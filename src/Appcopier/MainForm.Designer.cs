namespace Appcopier
{
    partial class MainForm
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlForm = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblDiskSpace = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.checkVersion = new System.Windows.Forms.CheckBox();
            this.picAppIcon = new System.Windows.Forms.PictureBox();
            this.lblQRInfo = new System.Windows.Forms.Label();
            this.picQR = new System.Windows.Forms.PictureBox();
            this.pictureWallpaper = new System.Windows.Forms.PictureBox();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.pnlForm.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAppIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWallpaper)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.pnlMain);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(878, 758);
            this.pnlForm.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.AutoScrollMargin = new System.Drawing.Size(500, 550);
            this.pnlMain.Controls.Add(this.lblMachineName);
            this.pnlMain.Controls.Add(this.pictureWallpaper);
            this.pnlMain.Controls.Add(this.lblDiskSpace);
            this.pnlMain.Controls.Add(this.btnAbout);
            this.pnlMain.Controls.Add(this.checkVersion);
            this.pnlMain.Controls.Add(this.picAppIcon);
            this.pnlMain.Controls.Add(this.lblQRInfo);
            this.pnlMain.Controls.Add(this.picQR);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(878, 758);
            this.pnlMain.TabIndex = 0;
            // 
            // lblDiskSpace
            // 
            this.lblDiskSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDiskSpace.AutoSize = true;
            this.lblDiskSpace.BackColor = System.Drawing.Color.GhostWhite;
            this.lblDiskSpace.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiskSpace.ForeColor = System.Drawing.Color.DimGray;
            this.lblDiskSpace.Location = new System.Drawing.Point(3, 743);
            this.lblDiskSpace.Name = "lblDiskSpace";
            this.lblDiskSpace.Size = new System.Drawing.Size(83, 15);
            this.lblDiskSpace.TabIndex = 231;
            this.lblDiskSpace.Text = "Storage estimate";
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.BackColor = System.Drawing.Color.GhostWhite;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F);
            this.btnAbout.ForeColor = System.Drawing.Color.DimGray;
            this.btnAbout.Location = new System.Drawing.Point(762, 716);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(85, 30);
            this.btnAbout.TabIndex = 230;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // checkVersion
            // 
            this.checkVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkVersion.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkVersion.AutoSize = true;
            this.checkVersion.BackColor = System.Drawing.Color.GhostWhite;
            this.checkVersion.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkVersion.FlatAppearance.BorderSize = 0;
            this.checkVersion.FlatAppearance.CheckedBackColor = System.Drawing.Color.GhostWhite;
            this.checkVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkVersion.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 9.75F);
            this.checkVersion.ForeColor = System.Drawing.Color.Black;
            this.checkVersion.Location = new System.Drawing.Point(800, 3);
            this.checkVersion.Name = "checkVersion";
            this.checkVersion.Size = new System.Drawing.Size(57, 27);
            this.checkVersion.TabIndex = 229;
            this.checkVersion.Text = "loading";
            this.checkVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkVersion.UseVisualStyleBackColor = false;
            this.checkVersion.CheckedChanged += new System.EventHandler(this.checkVersion_CheckedChanged);
            // 
            // picAppIcon
            // 
            this.picAppIcon.Location = new System.Drawing.Point(9, 22);
            this.picAppIcon.Name = "picAppIcon";
            this.picAppIcon.Size = new System.Drawing.Size(48, 42);
            this.picAppIcon.TabIndex = 228;
            this.picAppIcon.TabStop = false;
            // 
            // lblQRInfo
            // 
            this.lblQRInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQRInfo.AutoSize = true;
            this.lblQRInfo.BackColor = System.Drawing.Color.GhostWhite;
            this.lblQRInfo.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQRInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQRInfo.Location = new System.Drawing.Point(704, 529);
            this.lblQRInfo.Name = "lblQRInfo";
            this.lblQRInfo.Size = new System.Drawing.Size(135, 17);
            this.lblQRInfo.TabIndex = 227;
            this.lblQRInfo.Text = "First steps with the app";
            this.lblQRInfo.Visible = false;
            // 
            // picQR
            // 
            this.picQR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picQR.Location = new System.Drawing.Point(704, 548);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(143, 146);
            this.picQR.TabIndex = 226;
            this.picQR.TabStop = false;
            this.picQR.Visible = false;
            this.picQR.MouseEnter += new System.EventHandler(this.picQR_MouseEnter);
            this.picQR.MouseLeave += new System.EventHandler(this.picQR_MouseLeave);
            // 
            // pictureWallpaper
            // 
            this.pictureWallpaper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureWallpaper.Location = new System.Drawing.Point(123, 75);
            this.pictureWallpaper.Name = "pictureWallpaper";
            this.pictureWallpaper.Size = new System.Drawing.Size(573, 451);
            this.pictureWallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureWallpaper.TabIndex = 232;
            this.pictureWallpaper.TabStop = false;
            // 
            // lblMachineName
            // 
            this.lblMachineName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMachineName.AutoSize = true;
            this.lblMachineName.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachineName.Location = new System.Drawing.Point(355, 36);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(118, 28);
            this.lblMachineName.TabIndex = 233;
            this.lblMachineName.Text = "Builtbybel ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(878, 758);
            this.Controls.Add(this.pnlForm);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appcopier";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.pnlForm.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAppIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWallpaper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblQRInfo;
        private System.Windows.Forms.PictureBox picQR;
        private System.Windows.Forms.PictureBox picAppIcon;
        private System.Windows.Forms.CheckBox checkVersion;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblDiskSpace;
        private System.Windows.Forms.PictureBox pictureWallpaper;
        private System.Windows.Forms.Label lblMachineName;
    }
}

