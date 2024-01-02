using Appcopier;
using System;
using System.Diagnostics;
using System.IO;

namespace Conf
{
    public class WNetworkConf : BackupBase
    {
        private static readonly LogHelper logger = LogHelper.Instance;

        public WNetworkConf()
        {
            Title = "Network configuration";
            Info = "This will back up and restore TCP/IP network configuration.";
        }

        public override void Backup(string path)
        {
            try
            {
                // Execute netsh command to export TCP/IP configuration to a file
                string filePath = Path.Combine(path, $"{Title}.txt");
                int exitCode = ExecuteNetshCommand($"interface dump", filePath);

                // Check if the file was created
                if (exitCode == 0 && File.Exists(filePath))
                {
                    logger.Log($"Backup successful. File created: {filePath}");
                }
                else
                {
                    logger.Log($"Backup failed. netsh command exited with code {exitCode}");
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
                // Execute netsh command to import TCP/IP configuration from file
                string filePath = Path.Combine(path, $"{Title}.txt");
                int exitCode = ExecuteNetshCommand($"exec \"{filePath}\"", null);

                // Check if netsh command ran successfully
                if (exitCode == 0)
                {
                    logger.Log("Restore successful.");
                }
                else
                {
                    logger.Log($"Restore failed. netsh command exited with code {exitCode}");
                }
            }
            catch (Exception ex)
            {
                logger.Log($"Restore failed. Exception: {ex.Message}");
            }
        }

        // Helper method to execute netsh commands
        private int ExecuteNetshCommand(string arguments, string outputFilePath)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "netsh",
                Arguments = arguments,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = new Process { StartInfo = psi })
            {
                process.Start();

                //  handle redirection internally using StreamWriter to write command output to file
                using (StreamWriter outputFile = new StreamWriter(outputFilePath))
                {
                    while (!process.StandardOutput.EndOfStream)
                    {
                        string line = process.StandardOutput.ReadLine();
                        outputFile.WriteLine(line);
                        logger.Log(line);
                    }
                }

                process.WaitForExit();

                return process.ExitCode;
            }
        }
    }
}