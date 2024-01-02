using Appcopier;
using System;
using System.Diagnostics;
using System.IO;

namespace Conf
{
    public class CWiFiConf : BackupBase
    {
        private static readonly LogHelper logger = LogHelper.Instance;

        public CWiFiConf()
        {
            Title = "Wi-Fi networks & passwords";
            Info = "This will back up and restore credentials of Wi-Fi networks.";
        }

        public override void Backup(string path)
        {
            try
            {
                // Execute netsh command to export Wi-Fi profiles to a file
                ExecuteNetshCommand($"wlan export profile key=clear folder=\"{path.TrimEnd('\\')}\""); // remove trailing backslash from path

                // Check if the file was created
                if (Directory.Exists(path))
                {
                    logger.Log($"Wi-Fi Backup successful. File created: {path}");
                }
                else
                {
                    logger.Log("Wi-Fi Backup failed. File not created.");
                }
            }
            catch (Exception ex)
            {
                logger.Log($"Backup failed. Exception: {ex.Message}");
            }
        }

        public override void Restore(string path)
        {
            try
            {
                // Search for a file in the specified folder that starts with "wlan" and has an XML extension
                string[] xmlFiles = Directory.GetFiles(path, "WLAN*.xml");

                if (xmlFiles.Length > 0)
                {
                    // Import first found XML file
                    ExecuteNetshCommand($"wlan add profile filename=\"{xmlFiles[0]}\"");
                    logger.Log($"Wi-Fi Restore successful. File imported: {xmlFiles[0]}");
                }
                else
                {
                    logger.Log("Wi-Fi Restore failed. No matching XML file found.");
                }
            }
            catch (Exception ex)
            {
                logger.Log($"Restore failed. Exception: {ex.Message}");
            }
        }

        // Helper method to execute netsh commands
        private int ExecuteNetshCommand(string arguments)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "netsh",
                Arguments = arguments,
                RedirectStandardOutput = true,
                RedirectStandardError = true, // capture error output
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = new Process { StartInfo = psi })
            {
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                process.WaitForExit();

                logger.Log($"Wi-Fi Conf: {output}");
                logger.Log($"Wi-Fi Conf: {error}");

                return process.ExitCode;
            }
        }
    }
}