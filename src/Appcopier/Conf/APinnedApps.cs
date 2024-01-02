using Appcopier;
using DataHelper;
using System.IO;
using System.Threading.Tasks;

namespace Conf
{
    public class APinnedApps : BackupBase
    {
        public string Folder = Data.LocalAppData + "\\Packages\\Microsoft.Windows.StartMenuExperienceHost_cw5n1h2txyewy\\LocalState";

        public APinnedApps()
        {
            Title = "Remember pinned app preferences";
            Info = "The Start menu is comprised of three sections: Pinned, All apps, and Recommended.\nThis will back up pinned items on the Start menu and restore the pinned items to the Start menu.";
            IsWarning();
        }


        private void IsWarning()
        {
            WarningMessage = "This is reserved for Windows 11.";
        }

        public override bool IsInstalled()
        {
            return Directory.Exists(Folder);
        }

        public override async Task BackupAsync(string path)
        {
            await Utils.CopyFolder(Folder, path + Title);
        }

        public override async Task RestoreAsync(string path)
        {
            await Utils.CopyFolder(path + Title, Folder);
        }
    }
}