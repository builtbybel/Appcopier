using DataHelper;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Views
{
    public partial class RestPageView : UserControl
    {
        private ConfPageView configPage;

        public RestPageView(ConfPageView cp)
        {
            InitializeComponent();
            configPage = cp;

            LoadBackups();
            SetStyle();
        }

        // Some UI nicety
        private void SetStyle()
        {
            // Segoe MDL2 Assets
            btnBack.Text = "\uE72B";
            // Some color styling
            BackColor =
            rtbLog.BackColor =
                Color.FromArgb(245, 241, 249);
        }

        internal void LoadBackups()
        {
            listRestoration.Items.Clear();

            if (Directory.Exists(Data.DataRootDir))
            {
                string[] backups = Directory.GetDirectories(Data.DataRootDir);

                foreach (string backup in backups)
                {
                    listRestoration.Items.Add(Path.GetFileName(backup));
                }
            }
        }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            if (listRestoration.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please select exactly one backup folder for restore.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            configPage.CurrentRestorePath = Data.DataRootDir + listRestoration.SelectedItem.ToString() + "\\";

            ViewHelper.SwitchView.SetMainFormAsView();

            // Call restoration logic after setting path
            await configPage.HandleRestorationAfterSelection();
        }

        private void btnBack_Click(object sender, EventArgs e)
           => ViewHelper.SwitchView.SetMainFormAsView();

        private void linkOpenBackupsDirectory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
             => Process.Start(new ProcessStartInfo("explorer.exe", Data.DataRootDir) { UseShellExecute = true });

        private void listRestoration_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBackupPath = listRestoration.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedBackupPath))
            {
                string logFilePath = Path.Combine(Data.DataRootDir + selectedBackupPath, "backup_log.txt");

                if (File.Exists(logFilePath))
                {
                    linkISubHeader.Visible = true;
                    // Load and display log file content in rtbLog
                    rtbLog.Text = File.ReadAllText(logFilePath);
                }
                else
                {
                    rtbLog.Text = "No backup log available for this backup.";
                }
            }
        }
    }
}