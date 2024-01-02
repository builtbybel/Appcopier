using Appcopier;
using DataHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Conf
{
    public class WThemes : BackupBase
    {
        private static readonly LogHelper logger = LogHelper.Instance;

        public List<string> Folders = new List<string>();
        public List<string> Keys = new List<string>();

        public WThemes()
        {
            Title = "Themes";
            Info = "This will backup custom theme settings, default Windows wallpapers and a copy of your current Desktop background image.";
            // Version = "This is compatible with all versions of Windows.";
            RequiresExplorerRestart = true;

            LoadSettings();
        }

        private void LoadSettings()
        {
            Folders.Add(Data.WindowsFolder + "\\Web\\Wallpaper");
            Folders.Add(Data.RoamingAppData + "\\Microsoft\\Windows\\Themes");

            Keys.Add(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes");
        }

        public override bool IsInstalled()
        {
            bool b1 = false;
            bool b2 = false;

            foreach (string f in Folders)
            {
                if (Directory.Exists(f))
                {
                    b1 = true;
                    break;
                }
            }

            foreach (string k in Keys)
            {
                if (Utils.KeyExists(k))
                {
                    b2 = true;
                    break;
                }
            }

            return b1 || b2;
        }

        public override async Task BackupAsync(string path)
        {
            foreach (string folder in Folders)
            {
                string folderName = Path.GetFileName(folder);
                string backupFolderPath = Path.Combine(path, $"{Title}_{GetSafeFileName(folderName)}");

                try
                {
                    await Utils.CopyFolder(folder, backupFolderPath).ConfigureAwait(true);
                }
                catch (Exception ex)
                {
                    logger.Log($"Failed to backup folder '{folder}': {ex.Message}");
                }
            }

            foreach (string k in Keys)
            {
                Utils.ExportImportRegistryKey(path + Title + ".reg", k, false);
            }
        }

        public override async Task RestoreAsync(string path)
        {
            foreach (string folder in Folders)
            {
                string folderName = Path.GetFileName(folder);
                string backupFolderPath = Path.Combine(path, $"{Title}_{GetSafeFileName(folderName)}");
                await Utils.CopyFolder(backupFolderPath, folder).ConfigureAwait(true);
            }

            foreach (string k in Keys)
            {
                Utils.ExportImportRegistryKey(path + Title + ".reg", k, true);
            }
        }

        // Helper method to create a safe folder name from folder path
        private string GetSafeFileName(string folderPath)
        {
            return folderPath.Replace(":", "_").Replace("\\", "_").Replace("/", "_").Replace("*", "_").Replace("?", "_").Replace("\"", "_");
        }
    }
}