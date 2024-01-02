using Appcopier;
using System.Collections.Generic;
using System.IO;

namespace Conf
{
    public class DPrinters : BackupBase
    {
        public List<string> Keys = new List<string>();

        public DPrinters()
        {
            Title = "Printers";
            Info = "This will backup the Windows Printers configuration.";
            IsWarning();
            LoadSettings();
        }

        private void IsWarning()
        {
            WarningMessage = "The restoration of this backup could affect your printer configurations. Proceed with caution.";
        }

        private void LoadSettings()
        {
            Keys.Add(@"HKEY_CURRENT_USER\Printers");
            Keys.Add(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Print\Printers");
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