using Appcopier;
using DataHelper;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conf
{
    public class BGoogleChrome : BackupBase
    {
        public string Folder = Data.LocalAppData + "\\Google\\Chrome";

        public BGoogleChrome()
        {
            Title = "Google Chrome";
            Info = "This will back up the complete Google Chrome profile.";
        }

        public override bool IsInstalled()
        {
            return Directory.Exists(Folder);
        }

        public override async Task BackupAsync(string path)
        {
            // Check if process is running
            if (Utils.IsProcessRunning("chrome"))
            {
                DialogResult result = MessageBox.Show("The Chrome process is currently running. Do you want to close it before backup?",
                                                      "Process Running",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Utils.CloseProcess("chrome");
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