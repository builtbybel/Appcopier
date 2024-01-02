namespace Views
{
    partial class RestPageView
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
            this.listRestoration = new System.Windows.Forms.ListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.linkSubHeader = new System.Windows.Forms.LinkLabel();
            this.linkOpenBackupsDirectory = new System.Windows.Forms.LinkLabel();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.linkISubHeader = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // listRestoration
            // 
            this.listRestoration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listRestoration.BackColor = System.Drawing.Color.White;
            this.listRestoration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listRestoration.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F);
            this.listRestoration.ForeColor = System.Drawing.Color.Black;
            this.listRestoration.FormattingEnabled = true;
            this.listRestoration.ItemHeight = 17;
            this.listRestoration.Location = new System.Drawing.Point(248, 104);
            this.listRestoration.Margin = new System.Windows.Forms.Padding(2);
            this.listRestoration.Name = "listRestoration";
            this.listRestoration.Size = new System.Drawing.Size(327, 612);
            this.listRestoration.TabIndex = 5;
            this.listRestoration.SelectedIndexChanged += new System.EventHandler(this.listRestoration_SelectedIndexChanged);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.AutoEllipsis = true;
            this.btnOK.BackColor = System.Drawing.Color.Black;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(611, 40);
            this.btnOK.Name = "btnOK";
            this.btnOK.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnOK.Size = new System.Drawing.Size(127, 34);
            this.btnOK.TabIndex = 182;
            this.btnOK.TabStop = false;
            this.btnOK.Text = "Restore";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(243, 30);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(280, 26);
            this.lblHeader.TabIndex = 223;
            this.lblHeader.Text = "Let\'s restore your PC";
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
            this.btnBack.TabIndex = 224;
            this.btnBack.Text = "...";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // linkSubHeader
            // 
            this.linkSubHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkSubHeader.AutoEllipsis = true;
            this.linkSubHeader.BackColor = System.Drawing.Color.Transparent;
            this.linkSubHeader.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.25F, System.Drawing.FontStyle.Bold);
            this.linkSubHeader.ForeColor = System.Drawing.Color.Black;
            this.linkSubHeader.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkSubHeader.LinkColor = System.Drawing.Color.Black;
            this.linkSubHeader.Location = new System.Drawing.Point(245, 84);
            this.linkSubHeader.Name = "linkSubHeader";
            this.linkSubHeader.Size = new System.Drawing.Size(231, 18);
            this.linkSubHeader.TabIndex = 231;
            this.linkSubHeader.TabStop = true;
            this.linkSubHeader.Text = "Found back ups";
            // 
            // linkOpenBackupsDirectory
            // 
            this.linkOpenBackupsDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkOpenBackupsDirectory.AutoEllipsis = true;
            this.linkOpenBackupsDirectory.BackColor = System.Drawing.Color.Transparent;
            this.linkOpenBackupsDirectory.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.25F, System.Drawing.FontStyle.Bold);
            this.linkOpenBackupsDirectory.ForeColor = System.Drawing.Color.Black;
            this.linkOpenBackupsDirectory.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkOpenBackupsDirectory.LinkColor = System.Drawing.Color.Blue;
            this.linkOpenBackupsDirectory.Location = new System.Drawing.Point(433, 84);
            this.linkOpenBackupsDirectory.Name = "linkOpenBackupsDirectory";
            this.linkOpenBackupsDirectory.Size = new System.Drawing.Size(142, 18);
            this.linkOpenBackupsDirectory.TabIndex = 232;
            this.linkOpenBackupsDirectory.TabStop = true;
            this.linkOpenBackupsDirectory.Text = "Open backups directory";
            this.linkOpenBackupsDirectory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkOpenBackupsDirectory_LinkClicked);
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.BackColor = System.Drawing.SystemColors.Control;
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbLog.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.75F);
            this.rtbLog.ForeColor = System.Drawing.Color.DimGray;
            this.rtbLog.HideSelection = false;
            this.rtbLog.Location = new System.Drawing.Point(611, 104);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(316, 612);
            this.rtbLog.TabIndex = 233;
            this.rtbLog.Text = "";
            // 
            // linkISubHeader
            // 
            this.linkISubHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkISubHeader.AutoEllipsis = true;
            this.linkISubHeader.BackColor = System.Drawing.Color.Transparent;
            this.linkISubHeader.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkISubHeader.ForeColor = System.Drawing.Color.Black;
            this.linkISubHeader.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkISubHeader.LinkColor = System.Drawing.Color.Black;
            this.linkISubHeader.Location = new System.Drawing.Point(608, 83);
            this.linkISubHeader.Name = "linkISubHeader";
            this.linkISubHeader.Size = new System.Drawing.Size(319, 18);
            this.linkISubHeader.TabIndex = 234;
            this.linkISubHeader.TabStop = true;
            this.linkISubHeader.Text = "Included in this back up:";
            this.linkISubHeader.Visible = false;
            // 
            // RestorationPageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.Controls.Add(this.linkISubHeader);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.linkOpenBackupsDirectory);
            this.Controls.Add(this.linkSubHeader);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.listRestoration);
            this.Name = "RestorationPageView";
            this.Size = new System.Drawing.Size(942, 759);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listRestoration;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.LinkLabel linkSubHeader;
        private System.Windows.Forms.LinkLabel linkOpenBackupsDirectory;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.LinkLabel linkISubHeader;
    }
}
