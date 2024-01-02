using Appcopier;

namespace Conf
{
    public class DUSB : BackupBase
    {
        public string Key = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Shell\USB";

        public DUSB()
        {
            Title = "USB Devices";
            Info = "This will backup the Windows USB Devices settings.";
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