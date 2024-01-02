using Appcopier;

namespace Conf
{
    public class WAccessibility : BackupBase
    {
        public string Key = @"HKEY_CURRENT_USER\Control Panel\Accessibility";

        public WAccessibility()
        {
            Title = "Accessibility";
            Info = "This will backup settings related to accessibility resources for blind access, hearing, dexterity, mobility, focus, and more. ";
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