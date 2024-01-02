using Appcopier;
using Conf;
using DataHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class ConfPageView : UserControl
    {
        private static readonly LogHelper logger = LogHelper.Instance;

        internal string CurrentBackupPath = Data.DataRootDir + Data.NowShort + "\\";
        internal string CurrentRestorePath = "";

        internal List<BackupBase> selectedConfigs = new List<BackupBase>();

        private bool isSelectAll = false;

        public ConfPageView()
        {
            InitializeComponent();
            InitializeConfigurations();
            SetStyle();
        }

        private void SetStyle()
        {
            // Segoe MDL2 Assets
            btnMenu.Text = "\uEA8A";
            btnMenuMore.Text = "\uE712";
            btnMenuRestore.Text = "\uE777";
            // Some color styling
            pnlNav.BackColor = Color.FromArgb(245, 241, 249);
            BackColor =
            rtbLog.BackColor = Color.FromArgb(250, 250, 250);
            // Dynamically set OS information
            rtbLog.Text = $"This app supports you in backing up, sharing, and restoring your key settings of your Windows 11 {OsHelper.GetVersion()} on this or another system.";
            // Log messages to target rtbLog
            logger.SetTarget(rtbLog);
        }

        private void InitializeConfigurations()
        {
            AddConfiguration(new WPersonalization(), "Settings");
            AddConfiguration(new WVisualEffects(), "Settings");
            AddConfiguration(new WTaskbar(), "Settings");
            AddConfiguration(new WPrivacy(), "Settings");
            AddConfiguration(new WAPrivacy(), "Settings");
            AddConfiguration(new WTelemetry(), "Settings");
            AddConfiguration(new WNetworkConf(), "Settings");
            AddConfiguration(new WUpdates(), "Settings");
            AddConfiguration(new WThemes(), "Settings");
            AddConfiguration(new WAccessibility(), "Settings");
            AddConfiguration(new WOther(), "Settings");
            AddConfiguration(new AppStoreApps(), "Apps");
            AddConfiguration(new APinnedApps(), "Apps");
            AddConfiguration(new BMozillaFirefox(), "Browser");
            AddConfiguration(new BMicrosoftEdge(), "Browser");
            AddConfiguration(new BGoogleChrome(), "Browser");
            AddConfiguration(new DPrinters(), "Devices");
            AddConfiguration(new DMouse(), "Devices");
            AddConfiguration(new DKeyboard(), "Devices");
            AddConfiguration(new DUSB(), "Devices");
            AddConfiguration(new DTouchpad(), "Devices");
            AddConfiguration(new GGaming(), "Gaming");
            AddConfiguration(new CWiFiConf(), "Credentials");

            // Add event handler for button click
            btnRestartExplorer.Click += btnRestartExplorer_Click;
        }

        private void AddConfiguration(BackupBase configuration, string parentNodeText)
        {
            TreeNode parentNode = FindOrCreateNode(parentNodeText);
            TreeNode childNode = new TreeNode(configuration.Title);
            childNode.Tag = configuration;
            parentNode.Nodes.Add(childNode);
        }

        private TreeNode FindOrCreateNode(string text)
        {
            TreeNode parentNode = treeConfigurations.Nodes.Cast<TreeNode>()
                .FirstOrDefault(node => node.Text == text);

            if (parentNode == null)
            {
                parentNode = new TreeNode(text);
                treeConfigurations.Nodes.Add(parentNode);
            }

            return parentNode;
        }

        private async void btnBackup_Click(object sender, EventArgs e)
        {
            btnBackup.Enabled = false;
            this.Enabled = false;

            selectedConfigs.Clear();

            bool isAtLeastOneChecked = treeConfigurations.Nodes
                .Cast<TreeNode>()
                .Any(parentNode => parentNode.Nodes.Cast<TreeNode>().Any(childNode => childNode.Checked));

            // At least one node is checked, then proceed!
            if (isAtLeastOneChecked)
            {
                if (!Directory.Exists(CurrentBackupPath))
                {
                    Directory.CreateDirectory(CurrentBackupPath);
                }

                foreach (TreeNode parentNode in treeConfigurations.Nodes)
                {
                    foreach (TreeNode childNode in parentNode.Nodes)
                    {
                        if (childNode.Checked)
                        {
                            BackupBase configuration = childNode.Tag as BackupBase;
                            if (configuration != null)
                            {
                                selectedConfigs.Add(configuration);
                            }
                        }
                    }
                }

                foreach (BackupBase a in selectedConfigs)
                {
                    linkSubHeader.Text = $"Backing up: {a.Title}";

                    // Use asynchronous BackupAsync method and await its completion
                    await a.BackupAsync(CurrentBackupPath);

                    linkSubHeader.Text = "Choose settings";
                }

                // Log backed-up elements
                LogBackedUpElements(CurrentBackupPath, selectedConfigs);

                logger.Log("Back up done.");
                MessageBox.Show("Back up done.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nothing has been selected for backup. Please choose your settings to be backed up beforehand.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.Enabled = true;
            btnBackup.Enabled = true;
        }

        // Write a backup_log.txt
        private void LogBackedUpElements(string backupFolderPath, List<BackupBase> configurations)
        {
            List<string> backedUpElements = new List<string>();

            foreach (BackupBase configuration in configurations)
            {
                backedUpElements.Add($"{configuration.Title} ({configuration.GetType().Name})");
            }

            string logFilePath = Path.Combine(backupFolderPath, "backup_log.txt");

            try
            {
                File.WriteAllLines(logFilePath, backedUpElements);
            }
            catch (Exception ex)
            {
                logger.Log($"Failed to create backup log file: {ex.Message}");
            }
        }

        // Restoration logic with selected configurations
        private async Task PerformRestoration(List<BackupBase> selectedConfigs)
        {
            if (CurrentRestorePath != "" && Directory.Exists(CurrentRestorePath))
            {
                foreach (BackupBase config in selectedConfigs)
                {
                    await config.RestoreAsync(CurrentRestorePath);
                }
            }
        }

        // Asynchronous method to handle restoration after the user selects restoration path
        public async Task HandleRestorationAfterSelection()
        {
            await PerformRestoration(selectedConfigs);

            // Check if any selected configuration requires a restart
            bool requiresRestart = selectedConfigs.Any(config => config.RequiresExplorerRestart);

            // Show or hide restart button based on requirement
            btnRestartExplorer.Visible = requiresRestart;

            logger.Log("Restore done.");
            MessageBox.Show("Restore done.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            bool isAtLeastOneChecked = treeConfigurations.Nodes
                   .Cast<TreeNode>()
                   .Any(parentNode => parentNode.Nodes.Cast<TreeNode>().Any(childNode => childNode.Checked));

            // At least one node is checked, then proceed!
            if (isAtLeastOneChecked)
            {
                // Clear selectedConfigs list before populating it
                selectedConfigs.Clear();

                foreach (TreeNode parentNode in treeConfigurations.Nodes)
                {
                    foreach (TreeNode childNode in parentNode.Nodes)
                    {
                        if (childNode.Checked)
                        {
                            BackupBase configuration = childNode.Tag as BackupBase;
                            if (configuration != null)
                            {
                                selectedConfigs.Add(configuration);
                            }
                        }
                    }
                }

                ViewHelper.SwitchView.SetView(new RestPageView(this));
            }
            else
            {
                MessageBox.Show("Please choose a configuration to restore beforehand.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SelectInstalled()
        {
            foreach (TreeNode parentNode in treeConfigurations.Nodes)
            {
                foreach (TreeNode childNode in parentNode.Nodes)
                {
                    BackupBase configuration = childNode.Tag as BackupBase;
                    if (configuration != null)
                    {
                        bool isConfigInstalled = configuration.IsInstalled();
                        childNode.Checked = isConfigInstalled;
                    }
                }
            }
        }

        private void SelectAll(bool flag)
        {
            foreach (TreeNode parentNode in treeConfigurations.Nodes)
            {
                foreach (TreeNode childNode in parentNode.Nodes)
                {
                    childNode.Checked = flag;
                }
            }
        }

        private void treeConfigurations_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeConfigurations.SelectedNode != null && treeConfigurations.SelectedNode.Tag is BackupBase selectedConfiguration)
            {
                // Display the warning message
                if (!string.IsNullOrEmpty(selectedConfiguration.WarningMessage))
                {
                    ShowWarningMessage(selectedConfiguration.WarningMessage);
                }

                logger.ClearLog();

                BackupBase selectedConfig = treeConfigurations.SelectedNode.Tag as BackupBase;
                if (selectedConfig != null)
                {
                    logger.Log((selectedConfig.Title + "\r\n\n" +
                        selectedConfig.Info + "\r\n" +
                        selectedConfig.Version));
                }
            }
        }

        private void ShowWarningMessage(string warningMessage)
        {
            MessageBox.Show(warningMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnMenuMore_Click(object sender, EventArgs e)
            => this.contextMenu.Show(Cursor.Position.X, Cursor.Position.Y);

        private void menuSelectInstalled_Click(object sender, EventArgs e)
        {
            SelectAll(false);
            SelectInstalled();
        }

        private void menuSelectAll_Click(object sender, EventArgs e)
        {
            isSelectAll = !isSelectAll;
            SelectAll(isSelectAll);
        }

        private void btnRestartExplorer_Click(object sender, EventArgs e)
        {
            Utils.RestartExplorer();
            btnRestartExplorer.Visible = false;
        }

        private void treeConfigurations_AfterCheck(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode child in e.Node.Nodes)
            {
                child.Checked = e.Node.Checked;
            }
        }

        private void menuOpenAppBackups_Click(object sender, EventArgs e)
        {
            RestAppsForm f = new RestAppsForm();
            f.ShowDialog();
        }

        private void menuOpenBackupFolder_Click(object sender, EventArgs e)

           => Process.Start(new ProcessStartInfo("explorer.exe", DataHelper.Data.DataRootDir) { UseShellExecute = true });
    }
}