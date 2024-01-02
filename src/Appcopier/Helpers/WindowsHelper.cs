using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Appcopier
{
    public static class Utils
    {
        private static readonly LogHelper logger = LogHelper.Instance;

        internal static async Task CopyFolder(string source, string destination)
        {
            try
            {
                DirectoryInfo sourceDir = new DirectoryInfo(source);
                DirectoryInfo destinationDir = new DirectoryInfo(destination);

                if (!sourceDir.Exists)
                {
                    logger.Log($"Source directory does not exist: {source}");
                    return;
                }

                if (!destinationDir.Exists)
                {
                    destinationDir.Create();
                    logger.Log($"Destination directory created: {destination}");
                }

                foreach (FileInfo file in sourceDir.GetFiles())
                {
                    string destinationFilePath = Path.Combine(destinationDir.FullName, file.Name);

                    try
                    {
                        using (FileStream sourceStream = new FileStream(file.FullName, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize: 4096, useAsync: true))
                        using (FileStream destinationStream = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize: 4096, useAsync: true))
                        {
                            await sourceStream.CopyToAsync(destinationStream);
                        }

                        logger.Log($"Copied file: {file.FullName} to {destinationFilePath}");
                    }
                    catch (Exception ex)
                    {
                        logger.Log($"Error copying file {file.FullName}: {ex.Message}");
                    }
                }

                foreach (DirectoryInfo subDirectory in sourceDir.GetDirectories())
                {
                    string newDestinationPath = Path.Combine(destinationDir.FullName, subDirectory.Name);
                    await CopyFolder(subDirectory.FullName, newDestinationPath).ConfigureAwait(false);
                }
            }
            catch (Exception ex)
            {
                logger.Log($"Error copying folder {source} to {destination}: {ex.Message}");
            }
        }

        internal static void CopyFile(string source, string destination)
        {
            try
            {
                File.Copy(source, destination, true);
            }
            catch (Exception ex)
            {
                logger.Log(ex.Message);
            }
        }

        internal static void ExportImportRegistryKey(string filePath, string registryPath, bool import)
        {
            string path = $"\"{filePath}\"";
            string key = $"\"{registryPath}\"";

            using (Process proc = new Process())
            {
                try
                {
                    proc.StartInfo.FileName = "regedit.exe";
                    proc.StartInfo.UseShellExecute = false;
                    proc.StartInfo.Verb = "runas";

                    string arguments = import ? $"/s {path} {key}" : $"/e {path} {key}";

                    proc.StartInfo.Arguments = arguments;
                    proc.Start();

                    proc.WaitForExit();
                }
                catch (Exception ex)
                {
                    logger.Log(ex.Message);
                }
            }
        }

        // Reg operations
        public static bool KeyExists(string key)
        {
            // Registry.CurrentUser or Registry.LocalMachine
            return KeyExistsInRegistry(key, Registry.CurrentUser) || KeyExistsInRegistry(key, Registry.LocalMachine);
        }

        private static bool KeyExistsInRegistry(string key, RegistryKey baseKey)
        {
            // remove base keys name from full registry key path
            using (RegistryKey registryKey = baseKey.OpenSubKey(key.Replace($"{baseKey.Name}\\", string.Empty)))
            {
                return registryKey != null;
            }
        }

        // Restart explorer.exe if required for back up closure
        public static void RestartExplorer()
        {
            // Retrieve explorer.exe process
            Process[] explorerProcesses = Process.GetProcessesByName("explorer");

            foreach (Process explorerProcess in explorerProcesses)
            {
                try
                {
                    // Kill explorer process
                    explorerProcess.Kill();
                    explorerProcess.WaitForExit();

                    // Start new explorer process
                    Process.Start("explorer.exe");
                }
                catch (Exception ex)
                {
                    logger.Log($"Error restarting explorer.exe: {ex.Message}");
                }
            }
        }

        // Show disk space info on ConfPage
        public static string GetSystemPartitionDiskSpaceInfo()
        {
            try
            {
                string systemDrive = Path.GetPathRoot(Environment.SystemDirectory);
                DriveInfo driveInfo = new DriveInfo(systemDrive);

                long availableSpace = driveInfo.AvailableFreeSpace;
                long totalSpace = driveInfo.TotalSize;

                string info = $"Available Space: {FormatBytes(availableSpace)} | Total Space: {FormatBytes(totalSpace)}";
                return info;
            }
            catch (Exception ex)
            {
                return $"Error retrieving disk space information: {ex.Message}";
            }
        }

        private static string FormatBytes(long bytes)
        {
            string[] suffixes = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
            int suffixIndex = 0;

            while (bytes >= 1024 && suffixIndex < suffixes.Length - 1)
            {
                bytes /= 1024;
                suffixIndex++;
            }

            return $"{bytes} {suffixes[suffixIndex]}";
        }

        // Check for running processes in Confs
        public static bool IsProcessRunning(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            return processes.Length > 0;
        }

        // Close running processes in Confs
        public static void CloseProcess(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            foreach (Process process in processes)
            {
                process.Kill(); // Kill method to forcefully terminate process
            }
        }

        // Run Windows Terminal in Confs
        public static async void RunWT(string args)
        {
            var startInfo = new ProcessStartInfo()
            {
                FileName = DataHelper.Data.ShellWT,
                Arguments = args,
                WorkingDirectory = DataHelper.Data.DataRootDir,
                UseShellExecute = false,
                CreateNoWindow = false
            };

            await Task.Run(() =>
            {
                Process.Start(startInfo).WaitForExit();
            });
        }
    }
}