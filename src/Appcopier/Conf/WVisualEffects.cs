using Appcopier;

namespace Conf
{
    public class WVisualEffects : BackupBase
    {
        public string Key = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects";

        public WVisualEffects()
        {
            Title = "Visual Effects";
            Info = "This will export all Windows Visual Effects settings. These settings can be found in the GUI by Start menu or Run box 'SystemPropertiesPerformance'.";
            RequiresExplorerRestart = true;
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