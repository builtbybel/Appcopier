using Appcopier;
using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace DataHelper
{
    internal class Data
    {
        internal static string RoamingAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        internal static string LocalAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        internal static string ProgramData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
        internal static string WindowsFolder = Environment.GetFolderPath(Environment.SpecialFolder.Windows);

        public static string DataRootDir = Application.StartupPath +
                                            @"\app\";

        // Windows Terminal
        public static string ShellWT = LocalAppData +
                                        @"\Microsoft\WindowsApps\wt.exe";

        // Obtain current date and time
        internal static string Now = $"{DateTime.Now:G}";

        internal static string NowShort = $"{DateTime.Now:yyyy-MM-dd - HH.mm}";

        public static class Uri
        {
            public const string URL_BUILTBYBEL = "https://www.builtbybel.com";
            public const string URL_ASSEMBLY = "https://raw.githubusercontent.com/builtbybel/Appcopier/main/src/Appcopier/Properties/AssemblyInfo.cs";
            public const string URL_GITREPO = "https://github.com/builtbybel/Appcopier";
            public const string URL_ICONATTRIBUTION = "https://www.flaticon.com/free-icon/backup_10426480";
            public const string URL_GITLATEST = URL_GITREPO + "/releases/latest";
        }

        public static void CheckForUpdates()
        {
            if (IsInet() == true)
            {
                try
                {
                    string assemblyInfo = new WebClient().DownloadString(Data.Uri.URL_ASSEMBLY);

                    var readVersion = assemblyInfo.Split('\n');
                    var infoVersion = readVersion.Where(t => t.Contains("[assembly: AssemblyFileVersion"));
                    var latestVersion = "";
                    foreach (var item in infoVersion)
                    {
                        latestVersion = item.Substring(item.IndexOf('(') + 2, item.LastIndexOf(')') - item.IndexOf('(') - 3);
                    }

                    if (latestVersion ==
                        Program.GetCurrentVersionTostring())                      // Up-to-date
                    {
                        MessageBox.Show($"No new updates available.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    if (latestVersion !=                                        // Update available
                          Program.GetCurrentVersionTostring())

                    {
                        if (MessageBox.Show($"App version {latestVersion} available.\nDo you want to open the Download page?", "App update available", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            Process.Start(Data.Uri.URL_GITLATEST);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Checking for App updates failed.\n{ex.Message}");
                }
            }
            else if (IsInet() == false)
            {
                MessageBox.Show($"Problem on Internet connection: Checking for App updates failed");
            }
        }

        // Check Inet
        public static bool IsInet()
        {
            try
            {
                using (var CheckInternet = new WebClient())
                using (CheckInternet.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}