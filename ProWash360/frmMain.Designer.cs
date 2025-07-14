namespace ProWash360
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            pnlSideMenu = new Panel();
            btnSettings = new Button();
            btnLogs = new Button();
            btnPLCConfig = new Button();
            btnReports = new Button();
            btnLiveData = new Button();
            btnDashBoard = new Button();
            pnlLogo = new Panel();
            lblLogo = new Label();
            pnlTop = new Panel();
            lblTital = new Label();
            lblVersion = new Label();
            btnMinimize = new Button();
            btnClose = new Button();
            btnMaximize = new Button();
            pnlDesktopPane = new Panel();
            pnlSideMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideMenu
            // 
            pnlSideMenu.BackColor = Color.FromArgb(11, 7, 17);
            pnlSideMenu.Controls.Add(btnSettings);
            pnlSideMenu.Controls.Add(btnLogs);
            pnlSideMenu.Controls.Add(btnPLCConfig);
            pnlSideMenu.Controls.Add(btnReports);
            pnlSideMenu.Controls.Add(btnLiveData);
            pnlSideMenu.Controls.Add(btnDashBoard);
            pnlSideMenu.Controls.Add(pnlLogo);
            pnlSideMenu.Dock = DockStyle.Left;
            pnlSideMenu.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlSideMenu.Location = new Point(0, 0);
            pnlSideMenu.Margin = new Padding(4);
            pnlSideMenu.Name = "pnlSideMenu";
            pnlSideMenu.Size = new Size(160, 460);
            pnlSideMenu.TabIndex = 1;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.ForeColor = Color.Gainsboro;
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 315);
            btnSettings.Margin = new Padding(4);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(10, 0, 0, 0);
            btnSettings.Size = new Size(160, 43);
            btnSettings.TabIndex = 7;
            btnSettings.Text = "   Settings";
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnLogs
            // 
            btnLogs.Dock = DockStyle.Top;
            btnLogs.FlatAppearance.BorderSize = 0;
            btnLogs.FlatStyle = FlatStyle.Flat;
            btnLogs.ForeColor = Color.Gainsboro;
            btnLogs.Image = (Image)resources.GetObject("btnLogs.Image");
            btnLogs.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogs.Location = new Point(0, 272);
            btnLogs.Margin = new Padding(4);
            btnLogs.Name = "btnLogs";
            btnLogs.Padding = new Padding(10, 0, 0, 0);
            btnLogs.Size = new Size(160, 43);
            btnLogs.TabIndex = 6;
            btnLogs.Text = "   Logs";
            btnLogs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogs.UseVisualStyleBackColor = true;
            btnLogs.Click += btnLogs_Click;
            // 
            // btnPLCConfig
            // 
            btnPLCConfig.Dock = DockStyle.Top;
            btnPLCConfig.FlatAppearance.BorderSize = 0;
            btnPLCConfig.FlatStyle = FlatStyle.Flat;
            btnPLCConfig.ForeColor = Color.Gainsboro;
            btnPLCConfig.Image = (Image)resources.GetObject("btnPLCConfig.Image");
            btnPLCConfig.ImageAlign = ContentAlignment.MiddleLeft;
            btnPLCConfig.Location = new Point(0, 229);
            btnPLCConfig.Margin = new Padding(4);
            btnPLCConfig.Name = "btnPLCConfig";
            btnPLCConfig.Padding = new Padding(10, 0, 0, 0);
            btnPLCConfig.Size = new Size(160, 43);
            btnPLCConfig.TabIndex = 5;
            btnPLCConfig.Text = "   PLC Config";
            btnPLCConfig.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPLCConfig.UseVisualStyleBackColor = true;
            btnPLCConfig.Click += btnPLCConfig_Click;
            // 
            // btnReports
            // 
            btnReports.Dock = DockStyle.Top;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.ForeColor = Color.Gainsboro;
            btnReports.Image = (Image)resources.GetObject("btnReports.Image");
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(0, 186);
            btnReports.Margin = new Padding(4);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(10, 0, 0, 0);
            btnReports.Size = new Size(160, 43);
            btnReports.TabIndex = 4;
            btnReports.Text = "   Reports";
            btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnLiveData
            // 
            btnLiveData.Dock = DockStyle.Top;
            btnLiveData.FlatAppearance.BorderSize = 0;
            btnLiveData.FlatStyle = FlatStyle.Flat;
            btnLiveData.ForeColor = Color.Gainsboro;
            btnLiveData.Image = (Image)resources.GetObject("btnLiveData.Image");
            btnLiveData.ImageAlign = ContentAlignment.MiddleLeft;
            btnLiveData.Location = new Point(0, 143);
            btnLiveData.Margin = new Padding(4);
            btnLiveData.Name = "btnLiveData";
            btnLiveData.Padding = new Padding(10, 0, 0, 0);
            btnLiveData.Size = new Size(160, 43);
            btnLiveData.TabIndex = 3;
            btnLiveData.Text = "   Live Data";
            btnLiveData.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLiveData.UseVisualStyleBackColor = true;
            btnLiveData.Click += btnLiveData_Click;
            // 
            // btnDashBoard
            // 
            btnDashBoard.BackColor = Color.FromArgb(11, 7, 17);
            btnDashBoard.Dock = DockStyle.Top;
            btnDashBoard.FlatAppearance.BorderSize = 0;
            btnDashBoard.FlatStyle = FlatStyle.Flat;
            btnDashBoard.ForeColor = Color.Gainsboro;
            btnDashBoard.Image = (Image)resources.GetObject("btnDashBoard.Image");
            btnDashBoard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashBoard.Location = new Point(0, 100);
            btnDashBoard.Margin = new Padding(4);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Padding = new Padding(10, 0, 0, 0);
            btnDashBoard.Size = new Size(160, 43);
            btnDashBoard.TabIndex = 2;
            btnDashBoard.Text = "   Dash Board";
            btnDashBoard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashBoard.UseVisualStyleBackColor = false;
            btnDashBoard.Click += btnDashBoard_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.Controls.Add(lblLogo);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(160, 100);
            pnlLogo.TabIndex = 2;
            pnlLogo.MouseDown += pnlLogo_MouseDown;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.BackColor = Color.FromArgb(11, 7, 17);
            lblLogo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.Gold;
            lblLogo.Location = new Point(3, 38);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(150, 29);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "ProWash360";
            lblLogo.MouseDown += lblLogo_MouseDown;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(11, 7, 17);
            pnlTop.Controls.Add(lblTital);
            pnlTop.Controls.Add(lblVersion);
            pnlTop.Controls.Add(btnMinimize);
            pnlTop.Controls.Add(btnClose);
            pnlTop.Controls.Add(btnMaximize);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(160, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(620, 100);
            pnlTop.TabIndex = 2;
            pnlTop.MouseDown += pnlTop_MouseDown;
            // 
            // lblTital
            // 
            lblTital.Anchor = AnchorStyles.Left;
            lblTital.AutoSize = true;
            lblTital.BackColor = Color.FromArgb(11, 7, 17);
            lblTital.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTital.ForeColor = Color.White;
            lblTital.Location = new Point(-1, 61);
            lblTital.Name = "lblTital";
            lblTital.Size = new Size(184, 39);
            lblTital.TabIndex = 0;
            lblTital.Text = "Dashboard";
            lblTital.MouseDown += lblTital_MouseDown;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.FlatStyle = FlatStyle.Flat;
            lblVersion.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVersion.ForeColor = Color.White;
            lblVersion.Location = new Point(0, 0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(90, 16);
            lblVersion.TabIndex = 0;
            lblVersion.Text = "ProWash v1.0";
            lblVersion.MouseDown += lblVersion_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.FromArgb(11, 7, 17);
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(551, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(25, 25);
            btnMinimize.TabIndex = 0;
            btnMinimize.Text = "O";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(11, 7, 17);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(595, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 25);
            btnClose.TabIndex = 0;
            btnClose.Text = "O";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.FromArgb(11, 7, 17);
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaximize.ForeColor = Color.White;
            btnMaximize.Location = new Point(573, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(25, 25);
            btnMaximize.TabIndex = 0;
            btnMaximize.Text = "O";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // pnlDesktopPane
            // 
            pnlDesktopPane.Location = new Point(160, 100);
            pnlDesktopPane.Name = "pnlDesktopPane";
            pnlDesktopPane.Size = new Size(620, 360);
            pnlDesktopPane.TabIndex = 3;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 460);
            Controls.Add(pnlDesktopPane);
            Controls.Add(pnlTop);
            Controls.Add(pnlSideMenu);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(780, 460);
            Name = "frmMain";
            Text = "Form Main";
            pnlSideMenu.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSideMenu;
        private Panel pnlLogo;
        private Button btnDashBoard;
        private Button btnSettings;
        private Button btnLogs;
        private Button btnPLCConfig;
        private Button btnReports;
        private Button btnLiveData;
        private Label lblLogo;
        private Panel pnlTop;
        private Button btnClose;
        private Button btnMaximize;
        private Button btnMinimize;
        private Label lblVersion;
        private Panel pnlDesktopPane;
        private Label lblTital;
    }
}
