using Appcopier;
using System.Collections.Generic;
using System.IO;

namespace Conf
{
    public class WTelemetry : BackupBase
    {
        public List<string> Keys = new List<string>();

        public WTelemetry()
        {
            Title = "Telemetry";
            Info = "This will export Diagnostic data settings and services.";

            LoadSettings();
        }

        private void LoadSettings()
        {
            Keys.Add(@"HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows\DataCollection");
            Keys.Add(@"HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\DiagTrack");
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