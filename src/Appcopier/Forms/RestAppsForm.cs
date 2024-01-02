using Appcopier;
using DataHelper;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class RestAppsForm : Form
    {
        private List<string> packageIdentifiers;
        private static readonly LogHelper logger = LogHelper.Instance;

        public RestAppsForm()
        {
            InitializeComponent();

            // Load back ups
            LoadBackups();

            // Add event handler to Load PackageIdentifiers from JSON file
            comboBackups.Click += comboBackups_SelectedIndexChanged;

            // Load styling
            SetStyle();
        }

        // Some UI nicety
        private void SetStyle()
        {
            // Some color styling
            BackColor =
            listApps.BackColor =
                Color.FromArgb(245, 241, 249);
        }

        internal void LoadBackups()
        {
            comboBackups.Items.Clear();

            if (Directory.Exists(Data.DataRootDir))
            {
                string[] backups = Directory.GetDirectories(Data.DataRootDir);

                foreach (string backup in backups)
                {
                    comboBackups.Items.Add(Path.GetFileName(backup));
                }

                if (comboBackups.Items.Count > 0)
                {
                    comboBackups.SelectedIndex = 0;
                }
            }
        }

        private void LoadPackageIdentifiers()
        {
            // Load JSON file from app data directory
            string selectedBackup = comboBackups.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedBackup))
            {
                return;
            }

            string inputFilePath = Path.Combine(Data.DataRootDir + "\\" + selectedBackup, "Remember installed apps.JSON");

            // Parse JSON file and extract PackageIdentifiers
            try
            {
                string jsonContent = File.ReadAllText(inputFilePath);
                var json = JObject.Parse(jsonContent);

                // Extract PackageIdentifiers from JSON structure
                packageIdentifiers = json["Sources"]?.FirstOrDefault()?["Packages"]
                    ?.Select(package => package.Value<string>("PackageIdentifier"))
                    .ToList();
            }
            catch (Exception ex)
            {
                logger.Log($"Error loading or parsing JSON file: {ex.Message}");
            }

            // Ensure the list is initialized even if an error occurs
            if (packageIdentifiers == null)
            {
                packageIdentifiers = new List<string>();
            }
        }

        private void comboBackups_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listApps.Items.Clear();
                // Load PackageIdentifiers from JSON file
                LoadPackageIdentifiers();
                // Add PackageIdentifiers to ListBox
                foreach (var packageIdentifier in packageIdentifiers)
                {
                    listApps.Items.Add(packageIdentifier);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading or parsing JSON file: {ex.Message}");
            }
        }

        private async void RestorePackages(List<string> packageIdentifiers)
        {
            try
            {
                // Get selected items from listApps
                var selectedPackages = listApps.CheckedItems.Cast<string>().ToList();

                foreach (string packageIdentifier in selectedPackages)
                {
                    // Use Utils.RunWT to run winget command for each selected packageIdentifier
                    string wingetCommand = $"winget install --id {packageIdentifier} --accept-source-agreements --accept-package-agreements";
                    await Task.Run(() => Utils.RunWT(wingetCommand));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Restoration failed. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            // Let us ensure backup is selected
            string selectedBackup = comboBackups.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedBackup))
            {
                MessageBox.Show("Please select a backup to restore.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Load JSON file from selected backup
                string inputFilePath = Path.Combine(Data.DataRootDir, selectedBackup, "Remember installed apps.json");

                // Parse JSON file and extract PackageIdentifiers
                string jsonContent = File.ReadAllText(inputFilePath);
                var json = JObject.Parse(jsonContent);

                // Extract PackageIdentifiers from JSON structure
                List<string> packageIdentifiers = json["Sources"]?.FirstOrDefault()?["Packages"]
                    ?.Select(package => package.Value<string>("PackageIdentifier"))
                    .ToList();

                // Perform restoration process using extracted packageIdentifiers
                RestorePackages(packageIdentifiers);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Restoration failed. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
           => this.Close();
    }
}