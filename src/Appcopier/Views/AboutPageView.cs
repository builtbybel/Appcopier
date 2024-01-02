using Appcopier;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Views
{
    public partial class AboutPageView : UserControl
    {
        private Stargazers github;

        public AboutPageView()
        {
            InitializeComponent();
            SetStyle();

            // Fetch Github Stargazers
            GetGitHubStargazers();
        }

        // Some UI nicety
        private void SetStyle()
        {
            // Segoe MDL2 Assets
            btnBack.Text = "\uE72B";
            // Some color styling
      
        }

        private void btnBack_Click(object sender, EventArgs e)
            => ViewHelper.SwitchView.SetMainFormAsView();

        private void GetGitHubStargazers()
        {
            github = new Stargazers();
            github.StargazersCountFetched += (sender, count) =>
            {
                if (count >= 0)
                    btnGithub.Text = $"{count}";
                else
                    lnkStargazers.Visible = true;
            };

            // Stargazers link Event listener
            lnkStargazers_LinkClicked(lnkStargazers, new LinkLabelLinkClickedEventArgs(lnkStargazers.Links[0]));
        }

        private async void lnkStargazers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //e.Link.Visited = true;
            await github.FetchStargazersAsync();
        }

        private void btnGithub_Click(object sender, EventArgs e)
            => Process.Start(DataHelper.Data.Uri.URL_GITREPO);

        private void linkURLIcon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => Process.Start(DataHelper.Data.Uri.URL_ICONATTRIBUTION);

        private void linkURLDev_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => Process.Start(DataHelper.Data.Uri.URL_BUILTBYBEL);
    }
}