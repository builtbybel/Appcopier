using Appcopier;

namespace Conf
{
    public class WAPrivacy : BackupBase
    {
        public string Key = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore";

        public WAPrivacy()
        {
            Title = "Apps Privacy";
            Info = "This will export Application privacy settings. These settings can be found in the GUI by going to SETTINGS\\PRIVACY.";
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