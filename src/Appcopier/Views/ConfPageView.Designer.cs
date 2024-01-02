namespace Views
{
    partial class ConfPageView
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
            this.components = new System.ComponentModel.Container();
            this.btnMenuRestore = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.linkSubHeader = new System.Windows.Forms.LinkLabel();
            this.btnMenuMore = new System.Windows.Forms.Button();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuSelectInstalled = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.textHeaderApp = new System.Windows.Forms.ToolStripTextBox();
            this.menuOpenBackupFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenAppBackups = new System.Windows.Forms.ToolStripMenuItem();
            this.treeConfigurations = new System.Windows.Forms.TreeView();
            this.btnRestartExplorer = new System.Windows.Forms.Button();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMenuRestore
            // 
            this.btnMenuRestore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMenuRestore.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuRestore.FlatAppearance.BorderSize = 0;
            this.btnMenuRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.btnMenuRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuRestore.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.25F, System.Drawing.FontStyle.Bold);
            this.btnMenuRestore.ForeColor = System.Drawing.Color.DimGray;
            this.btnMenuRestore.Location = new System.Drawing.Point(381, 17);
            this.btnMenuRestore.Name = "btnMenuRestore";
            this.btnMenuRestore.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnMenuRestore.Size = new System.Drawing.Size(43, 39);
            this.btnMenuRestore.TabIndex = 180;
            this.btnMenuRestore.TabStop = false;
            this.btnMenuRestore.Text = "Restore";
            this.tt.SetToolTip(this.btnMenuRestore, "Restore your back ups");
            this.btnMenuRestore.UseVisualStyleBackColor = false;
            this.btnMenuRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackup.AutoEllipsis = true;
            this.btnBackup.BackColor = System.Drawing.Color.Black;
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Location = new System.Drawing.Point(559, 40);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(127, 34);
            this.btnBackup.TabIndex = 179;
            this.btnBackup.TabStop = false;
            this.btnBackup.Text = "Back up";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(56, 805);
            this.pnlNav.TabIndex = 210;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16.25F, System.Drawing.FontStyle.Bold);
            this.btnMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMenu.Location = new System.Drawing.Point(299, 17);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(43, 39);
            this.btnMenu.TabIndex = 221;
            this.btnMenu.Text = "Home";
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.BackColor = System.Drawing.SystemColors.Control;
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbLog.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.75F);
            this.rtbLog.ForeColor = System.Drawing.Color.DimGray;
            this.rtbLog.HideSelection = false;
            this.rtbLog.Location = new System.Drawing.Point(248, 72);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.rtbLog.Size = new System.Drawing.Size(215, 139);
            this.rtbLog.TabIndex = 211;
            this.rtbLog.Text = "This app supports you in backing up, sharing, and restoring your key settings of " +
    "your Windows 11 build on this or another system.";
            // 
            // tt
            // 
            this.tt.IsBalloon = true;
            this.tt.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // linkSubHeader
            // 
            this.linkSubHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkSubHeader.AutoEllipsis = true;
            this.linkSubHeader.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.25F, System.Drawing.FontStyle.Bold);
            this.linkSubHeader.ForeColor = System.Drawing.Color.Black;
            this.linkSubHeader.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkSubHeader.LinkColor = System.Drawing.Color.Black;
            this.linkSubHeader.Location = new System.Drawing.Point(244, 223);
            this.linkSubHeader.Name = "linkSubHeader";
            this.linkSubHeader.Size = new System.Drawing.Size(177, 18);
            this.linkSubHeader.TabIndex = 222;
            this.linkSubHeader.TabStop = true;
            this.linkSubHeader.Text = "Choose settings";
            // 
            // btnMenuMore
            // 
            this.btnMenuMore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenuMore.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuMore.FlatAppearance.BorderSize = 0;
            this.btnMenuMore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.btnMenuMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuMore.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnMenuMore.ForeColor = System.Drawing.Color.Black;
            this.btnMenuMore.Location = new System.Drawing.Point(438, 217);
            this.btnMenuMore.Name = "btnMenuMore";
            this.btnMenuMore.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnMenuMore.Size = new System.Drawing.Size(32, 24);
            this.btnMenuMore.TabIndex = 223;
            this.btnMenuMore.TabStop = false;
            this.btnMenuMore.Text = "...";
            this.btnMenuMore.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnMenuMore.UseVisualStyleBackColor = false;
            this.btnMenuMore.Click += new System.EventHandler(this.btnMenuMore_Click);
            // 
            // contextMenu
            // 
            this.contextMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contextMenu.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSelectInstalled,
            this.menuSelectAll,
            this.toolStripSeparator1,
            this.textHeaderApp,
            this.menuOpenBackupFolder,
            this.menuOpenAppBackups});
            this.contextMenu.Name = "menuMain";
            this.contextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenu.Size = new System.Drawing.Size(204, 148);
            // 
            // menuSelectInstalled
            // 
            this.menuSelectInstalled.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.menuSelectInstalled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuSelectInstalled.Name = "menuSelectInstalled";
            this.menuSelectInstalled.Size = new System.Drawing.Size(203, 24);
            this.menuSelectInstalled.Text = "Select available";
            this.menuSelectInstalled.Click += new System.EventHandler(this.menuSelectInstalled_Click);
            // 
            // menuSelectAll
            // 
            this.menuSelectAll.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            this.menuSelectAll.Name = "menuSelectAll";
            this.menuSelectAll.Size = new System.Drawing.Size(203, 24);
            this.menuSelectAll.Text = "Select all";
            this.menuSelectAll.Click += new System.EventHandler(this.menuSelectAll_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // textHeaderApp
            // 
            this.textHeaderApp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textHeaderApp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textHeaderApp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHeaderApp.ForeColor = System.Drawing.Color.Gray;
            this.textHeaderApp.Margin = new System.Windows.Forms.Padding(1, 1, 1, 3);
            this.textHeaderApp.Name = "textHeaderApp";
            this.textHeaderApp.Size = new System.Drawing.Size(100, 16);
            this.textHeaderApp.Text = "Settings";
            // 
            // menuOpenBackupFolder
            // 
            this.menuOpenBackupFolder.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuOpenBackupFolder.Name = "menuOpenBackupFolder";
            this.menuOpenBackupFolder.Size = new System.Drawing.Size(203, 24);
            this.menuOpenBackupFolder.Text = "Open backups folder";
            this.menuOpenBackupFolder.Click += new System.EventHandler(this.menuOpenBackupFolder_Click);
            // 
            // menuOpenAppBackups
            // 
            this.menuOpenAppBackups.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F);
            this.menuOpenAppBackups.Name = "menuOpenAppBackups";
            this.menuOpenAppBackups.Size = new System.Drawing.Size(203, 24);
            this.menuOpenAppBackups.Text = "Open app backups";
            this.menuOpenAppBackups.Click += new System.EventHandler(this.menuOpenAppBackups_Click);
            // 
            // treeConfigurations
            // 
            this.treeConfigurations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeConfigurations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeConfigurations.CheckBoxes = true;
            this.treeConfigurations.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeConfigurations.FullRowSelect = true;
            this.treeConfigurations.ItemHeight = 30;
            this.treeConfigurations.LineColor = System.Drawing.Color.Orchid;
            this.treeConfigurations.Location = new System.Drawing.Point(247, 244);
            this.treeConfigurations.Name = "treeConfigurations";
            this.treeConfigurations.Size = new System.Drawing.Size(216, 461);
            this.treeConfigurations.TabIndex = 225;
            this.treeConfigurations.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeConfigurations_AfterCheck);
            this.treeConfigurations.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeConfigurations_AfterSelect);
            // 
            // btnRestartExplorer
            // 
            this.btnRestartExplorer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestartExplorer.BackColor = System.Drawing.Color.HotPink;
            this.btnRestartExplorer.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartExplorer.Location = new System.Drawing.Point(62, -5);
            this.btnRestartExplorer.Name = "btnRestartExplorer";
            this.btnRestartExplorer.Size = new System.Drawing.Size(625, 28);
            this.btnRestartExplorer.TabIndex = 226;
            this.btnRestartExplorer.Text = "To apply some changes, the explorer.exe needs to be restarted. Click here to fini" +
    "sh.";
            this.btnRestartExplorer.UseVisualStyleBackColor = false;
            this.btnRestartExplorer.Visible = false;
            // 
            // ConfPageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(500, 100);
            this.Controls.Add(this.btnRestartExplorer);
            this.Controls.Add(this.treeConfigurations);
            this.Controls.Add(this.btnMenuMore);
            this.Controls.Add(this.linkSubHeader);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.btnMenuRestore);
            this.Controls.Add(this.btnBackup);
            this.Name = "ConfPageView";
            this.Size = new System.Drawing.Size(824, 759);
            this.contextMenu.ResumeLayout(false);
            this.contextMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMenuRestore;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.LinkLabel linkSubHeader;
        private System.Windows.Forms.Button btnMenuMore;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripTextBox textHeaderApp;
        private System.Windows.Forms.ToolStripMenuItem menuSelectInstalled;
        private System.Windows.Forms.ToolStripMenuItem menuSelectAll;
        private System.Windows.Forms.TreeView treeConfigurations;
        private System.Windows.Forms.Button btnRestartExplorer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuOpenBackupFolder;
        private System.Windows.Forms.ToolStripMenuItem menuOpenAppBackups;
    }
}
