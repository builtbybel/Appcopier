using Appcopier;
using DataHelper;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conf
{
    public class BMozillaFirefox : BackupBase
    {
        public string Folder = Data.RoamingAppData + "\\Mozilla";

        public BMozillaFirefox()
        {
            Title = "Mozilla Firefox";
            Info = "This will back up the complete Mozilla Firefox profile.";
        }

        public override bool IsInstalled()
        {
            return Directory.Exists(Folder);
        }

        public override async Task BackupAsync(string path)
        {
            // Check if process is running
            if (Utils.IsProcessRunning("firefox"))
            {
                DialogResult result = MessageBox.Show("The Firefox process is currently running. Do you want to close it before backup?",
                                                      "Process Running",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Utils.CloseProcess("firefox");
                }
                else
                {
                    return;
                }
            }

            await Utils.CopyFolder(Folder, path + Title);
        }

        public override async Task RestoreAsync(string path)
        {
            await Utils.CopyFolder(path + Title, Folder);
        }
    }
}