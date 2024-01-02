using Appcopier;

namespace Conf
{
    public class WPrivacy : BackupBase
    {
        public string Key = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Privacy";

        public WPrivacy()
        {
            Title = "Privacy";
            Info = "This will export settings related to Privacy and Tailored experiences/Windows diagnostic which offers you personalized tips, ads, and recommendations to enhance Microsoft experiences.";
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