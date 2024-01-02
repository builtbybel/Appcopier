using Appcopier;
using System;
using System.IO;
using Views;

namespace Conf
{
    public class AppStoreApps : BackupBase
    {
        private static readonly LogHelper logger = LogHelper.Instance;

        public AppStoreApps()
        {
            Title = "Remember installed apps";
            Info = "This will export all installed winget package identifiers as a .JSON file.\nThe import process allows you to restore specific apps themselves based on this file.";
        }

        public override void Backup(string path)
        {
            try
            {
                // Execute winget command to list installed apps
                string outputFilePath = Path.Combine(path, $"{Title}.json");
                Utils.RunWT($"winget export -o \"{outputFilePath}\"");
                logger.Log($"Backup successful. Installed apps exported to: {outputFilePath}");
            }
            catch (Exception ex)
            {
                logger.Log($"Backup failed. Exception: {ex.Message}");
            }
        }

        public override void Restore(string path)
        {
            /*
            try
            {
                string inputFilePath = Path.Combine(path, $"{Title}.json");

                await Utils.RunWT($"winget import -i \"{inputFilePath}\" --accept-source-agreements --accept-package-agreements");
                logger.Log($"Restore successful. Installed apps imported from: {inputFilePath}");
            }
            catch (Exception ex)
            {
                logger.Log($"Restore failed. Exception: {ex.Message}");
            } */

            // Switch to instance of RestoreAppsForm
            RestAppsForm restoreApps = new RestAppsForm();
            restoreApps.ShowDialog();
        }
    }
}