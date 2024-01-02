using Appcopier;
using DataHelper;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conf
{
    public class BMicrosoftEdge : BackupBase
    {
        public string Folder = Data.LocalAppData + "\\Microsoft\\Edge";

        public BMicrosoftEdge()
        {
            Title = "Microsoft Edge";
            Info = "This will back up the complete Microsoft Edge profile.";
        }

        public override bool IsInstalled()
        {
            return Directory.Exists(Folder);
        }

        public override async Task BackupAsync(string path)
        {
            // Check if process is running
            if (Utils.IsProcessRunning("msedge"))
            {
                DialogResult result = MessageBox.Show("The Edge process is currently running. Do you want to close it before backup?",
                                                      "Process Running",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Utils.CloseProcess("msedge");
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