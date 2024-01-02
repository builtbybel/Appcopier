using Appcopier;

namespace Conf
{
    public class DMouse : BackupBase
    {
        public string Key = @"HKEY_CURRENT_USER\Control Panel\Mouse";

        public DMouse()
        {
            Title = "Mouse";
            Info = "This will the backup Windows Mouse settigs.";
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