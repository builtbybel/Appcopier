namespace Views
{
    partial class AboutPageView
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutPageView));
            this.btnBack = new System.Windows.Forms.Button();
            this.lnkStargazers = new System.Windows.Forms.LinkLabel();
            this.btnGithub = new System.Windows.Forms.Button();
            this.linkURLDev = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkURLIcon = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(14, 18);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(42, 38);
            this.btnBack.TabIndex = 225;
            this.btnBack.Text = "...";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lnkStargazers
            // 
            this.lnkStargazers.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkStargazers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lnkStargazers.AutoEllipsis = true;
            this.lnkStargazers.BackColor = System.Drawing.Color.Transparent;
            this.lnkStargazers.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkStargazers.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkStargazers.LinkColor = System.Drawing.Color.Black;
            this.lnkStargazers.Location = new System.Drawing.Point(515, 105);
            this.lnkStargazers.Name = "lnkStargazers";
            this.lnkStargazers.Size = new System.Drawing.Size(132, 17);
            this.lnkStargazers.TabIndex = 235;
            this.lnkStargazers.TabStop = true;
            this.lnkStargazers.Text = "Error fetching Github stargazers";
            this.lnkStargazers.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lnkStargazers.Visible = false;
            this.lnkStargazers.VisitedLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkStargazers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkStargazers_LinkClicked);
            // 
            // btnGithub
            // 
            this.btnGithub.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGithub.AutoEllipsis = true;
            this.btnGithub.BackColor = System.Drawing.Color.Transparent;
            this.btnGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGithub.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.btnGithub.FlatAppearance.BorderSize = 0;
            this.btnGithub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGithub.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 9.75F);
            this.btnGithub.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnGithub.Image = ((System.Drawing.Image)(resources.GetObject("btnGithub.Image")));
            this.btnGithub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGithub.Location = new System.Drawing.Point(416, 100);
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnGithub.Size = new System.Drawing.Size(106, 30);
            this.btnGithub.TabIndex = 236;
            this.btnGithub.TabStop = false;
            this.btnGithub.Text = "Github";
            this.btnGithub.UseVisualStyleBackColor = false;
            this.btnGithub.Click += new System.EventHandler(this.btnGithub_Click);
            // 
            // linkURLDev
            // 
            this.linkURLDev.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.linkURLDev.AutoSize = true;
            this.linkURLDev.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 9F);
            this.linkURLDev.LinkColor = System.Drawing.Color.Purple;
            this.linkURLDev.Location = new System.Drawing.Point(413, 706);
            this.linkURLDev.Name = "linkURLDev";
            this.linkURLDev.Size = new System.Drawing.Size(157, 16);
            this.linkURLDev.TabIndex = 237;
            this.linkURLDev.TabStop = true;
            this.linkURLDev.Text = "A Belim app creation (C) 2024.";
            this.linkURLDev.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkURLDev_LinkClicked);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.GhostWhite;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 9.25F);
            this.label2.Location = new System.Drawing.Point(166, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(654, 65);
            this.label2.TabIndex = 238;
            this.label2.Text = "Back up key things on your Windows PC, perform a reset or simply go back in time." +
    "";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(297, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 36);
            this.label1.TabIndex = 239;
            this.label1.Text = "About";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkURLIcon
            // 
            this.linkURLIcon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.linkURLIcon.AutoSize = true;
            this.linkURLIcon.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 9F);
            this.linkURLIcon.LinkColor = System.Drawing.Color.DimGray;
            this.linkURLIcon.Location = new System.Drawing.Point(365, 732);
            this.linkURLIcon.Name = "linkURLIcon";
            this.linkURLIcon.Size = new System.Drawing.Size(242, 16);
            this.linkURLIcon.TabIndex = 240;
            this.linkURLIcon.TabStop = true;
            this.linkURLIcon.Text = "Appcopier Icon created by Icon Hubs - Flaticon";
            this.linkURLIcon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkURLIcon_LinkClicked);
            // 
            // AboutPageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.Controls.Add(this.linkURLIcon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkURLDev);
            this.Controls.Add(this.btnGithub);
            this.Controls.Add(this.lnkStargazers);
            this.Controls.Add(this.btnBack);
            this.Name = "AboutPageView";
            this.Size = new System.Drawing.Size(942, 759);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.LinkLabel lnkStargazers;
        private System.Windows.Forms.Button btnGithub;
        private System.Windows.Forms.LinkLabel linkURLDev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkURLIcon;
    }
}
