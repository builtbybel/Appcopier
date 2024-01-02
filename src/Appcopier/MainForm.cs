using DataHelper;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Views;

namespace Appcopier
{
    public partial class MainForm : Form
    {
        private ConfPageView configPage;
        private System.Timers.Timer timer;
        private bool isMouseOverQRCode = false;

        public MainForm()
        {
            InitializeComponent();

            // Initialize ConfigurationPageView
            configPage = new ConfPageView();

            // Some Fancy intro crap, just like in the Windows Backup app
            string wallpaperPath = GetDesktopWallpaper();
            string pcName = Environment.MachineName;

            if (!string.IsNullOrEmpty(wallpaperPath))
            {
                try
                {
                    Image wallpaperImage = Image.FromFile(wallpaperPath);
                    pictureWallpaper.Image = wallpaperImage;
                    lblMachineName.Text = pcName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading Wallpaper: {ex.Message}");
                }
            }

            //Load Icons
            GetCodeIcons();
        }

        private async void MainForm_Shown(object sender, EventArgs e)
        {
            // DO NOT DO THIS! Here's an exception to show something fancy and wait
            await Task.Delay(500);
            // Refer to instance ConfigPageView
            pnlMain.Controls.Add(configPage);
            configPage.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
            configPage.Dock = DockStyle.Fill;
            // Refer Main and default NavPage
            ViewHelper.SwitchView.INavPage = pnlForm.Controls[0];
            ViewHelper.SwitchView.mainForm = this;
            // Get versioning
            checkVersion.Text = GetMinorVersion(Program.GetCurrentVersionTostring());
            // Get Disk space
            lblDiskSpace.Text = Utils.GetSystemPartitionDiskSpaceInfo();
            // Load styling
            this.SetStyle();
            // Hide fancy intro
            pictureWallpaper.Visible =
            lblMachineName.Visible = false;
        }

        private void SetStyle()
        {
            btnAbout.Text = "\uE946 About";
            // Some color styling
            BackColor = Color.FromArgb(243, 243, 243);
        }

        private void GetCodeIcons()
        {
            string imageQR = Path.Combine(Data.DataRootDir, "qr.png");
            string imageAppIcon = Path.Combine(Data.DataRootDir, "AppIcon.png");

            if (File.Exists(imageQR))
            {
                picQR.Visible =
                lblQRInfo.Visible = true;
                picQR.Image = Image.FromFile(imageQR);
            }
            else
            {
                picQR.Visible =
                lblQRInfo.Visible = false;
            }

            if (File.Exists(imageAppIcon))
            {
                picAppIcon.Visible = true;
                picAppIcon.Image = Image.FromFile(imageAppIcon);
            }
            else
            {
                picAppIcon.Visible = false;
            }

            // Set up QR code timer
            picQR.MouseEnter += picQR_MouseEnter;
            picQR.MouseLeave += picQR_MouseLeave;

            timer = new System.Timers.Timer();
            timer.Interval = 500;
            timer.Elapsed += QRTimerElapsed;
        }

        private void picQR_MouseEnter(object sender, EventArgs e)
        {
            isMouseOverQRCode = true;
            timer.Start();
        }

        private void picQR_MouseLeave(object sender, EventArgs e)
        {
            isMouseOverQRCode = false;
            timer.Stop();
        }

        private void QRTimerElapsed(object sender, ElapsedEventArgs e)
        {
            // This method will be called when timer elapses
            timer.Stop();

            if (isMouseOverQRCode)
            {
                DialogResult result = MessageBox.Show("Do you want to view the introduction directly in your Desktop Browser?", "Intro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Process.Start("https://github.com/builtbybel/Appcopier");
                }
            }
        }

        private string GetMinorVersion(string version)
        {
            // Display everything until the second dot without the dot
            int secondDotIndex = version.IndexOf('.', version.IndexOf('.') + 1);
            if (secondDotIndex != -1)
            {
                version = version.Substring(0, secondDotIndex);
            }
            return $"Version {version}";
        }

        private void checkVersion_CheckedChanged(object sender, EventArgs e)
        {
            // Get full version
            string fullVersion = Program.GetCurrentVersionTostring();

            // Display version based on the CheckBox state
            checkVersion.Text = checkVersion.Checked ? fullVersion : GetMinorVersion(fullVersion);

            // Optionally, check for updates when checked
            if (checkVersion.Checked)
            {
                Data.CheckForUpdates();
            }
        }

        public static string GetDesktopWallpaper()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop"))
                {
                    if (key != null)
                    {
                        object wallpaperPath = key.GetValue("Wallpaper");
                        if (wallpaperPath != null)
                        {
                            return wallpaperPath.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
   
                Console.WriteLine($"Error: {ex.Message}");
            }

            return string.Empty;
        }

        private void btnAbout_Click(object sender, EventArgs e)
           => ViewHelper.SwitchView.SetView(new AboutPageView());
    }
}