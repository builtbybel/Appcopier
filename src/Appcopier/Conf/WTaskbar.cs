using Appcopier;

namespace Conf
{
    public class WTaskbar : BackupBase
    {
        public string Key = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced";

        public WTaskbar()
        {
            Title = "Taskbar";
            Info = "This will export settings related to Taskbar and behaviors (Taskbar alignment, size and layout, Widgets etc).";
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