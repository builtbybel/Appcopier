using Appcopier;

namespace Conf
{
    public class DTouchpad : BackupBase
    {
        public string Key = @"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\PrecisionTouchPad";

        public DTouchpad()
        {
            Title = "Touchpad";
            Info = "This will backup the Windows Touchpad settings.";
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