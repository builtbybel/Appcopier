using Appcopier;

namespace Conf
{
    public class DKeyboard : BackupBase
    {
        public string Key = @"HKEY_CURRENT_USER\Control Panel\Keyboard";

        public DKeyboard()
        {
            Title = "Keyboard";
            Info = "This will backup the Windows Keyboard settigs.";
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