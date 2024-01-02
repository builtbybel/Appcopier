using System.Diagnostics;
using System.Threading.Tasks;

namespace Appcopier
{
    public abstract class BackupBase
    {
        // Property to indicate whether a restart is required
        public virtual bool RequiresExplorerRestart { get; protected set; } = false;

        // Property to display Hints
        public virtual string WarningMessage { get; protected set; } = "";

        // Property to display Info
        public string Title { get; set; }

        public string Info { get; set; }
        public string Version { get; set; }

        public virtual bool IsInstalled()
        { return false; }

        public virtual void Backup(string path)
        { }

        public virtual void Restore(string path)
        { }

        public virtual async Task BackupAsync(string path)
        {
            await Task.Run(() =>
            {
                Backup(path);
            }).ConfigureAwait(true);
        }

        public virtual async Task RestoreAsync(string path)
        {
            await Task.Run(() =>
            {
                Restore(path);
            }).ConfigureAwait(true);
        }

    }
}