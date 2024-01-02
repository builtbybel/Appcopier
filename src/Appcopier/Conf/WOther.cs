using Appcopier;

namespace Conf
{
    public class WOther : BackupBase
    {
        public string Key = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System";

        public WOther()
        {
            Title = "Other Windows settings";
            Info = "This will backup User Account Control settings, remote restrictions and configuration.";
        }

        public override bool IsInstalled()
        {
            return Utils.KeyExists(Key);
        }

        public override void Backup(string path)
        {
            Utils.ExportImportRegistryKey(path + Title + ".reg", Key, false);
        }

        public override void Restore(string path)
        {
            Utils.ExportImportRegistryKey(path + Title + ".reg", Key, true);
        }
    }
}