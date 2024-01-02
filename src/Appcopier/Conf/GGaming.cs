using Appcopier;
using System.Collections.Generic;
using System.IO;

namespace Conf
{
    public class GGaming : BackupBase
    {
        public List<string> Keys = new List<string>();

        public GGaming()
        {
            Title = "Gaming settings";
            Info = "This will export settings related to Windows Game Bar DVR (Game Recorder).";

            LoadSettings();
        }

        private void LoadSettings()

        {
            Keys.Add(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\GameBar");
            Keys.Add(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\GameDVR");
        }

        public override bool IsInstalled()
        {
            bool b1 = false;

            foreach (string k in Keys)
            {
                if (Utils.KeyExists(k))
                {
                    b1 = true;
                    break;
                }
            }

            return b1;
        }

        public override void Backup(string path)
        {
            foreach (string k in Keys)
            {
                string outputFileName = Path.Combine(path, $"{Title}_{GetSafeFileName(k)}.reg");
                Utils.ExportImportRegistryKey(outputFileName, k, false);
            }
        }

        public override void Restore(string path)
        {
            foreach (string k in Keys)
            {
                string inputFileName = Path.Combine(path, $"{Title}_{GetSafeFileName(k)}.reg");
                Utils.ExportImportRegistryKey(inputFileName, k, true);
            }
        }

        // Helper method to create a safe file name from registry key
        private string GetSafeFileName(string registryKey)
        {
            return registryKey.Replace("\\", "_").Replace(":", "_").Replace("/", "_").Replace("*", "_").Replace("?", "_").Replace("\"", "_");
        }
    }
}