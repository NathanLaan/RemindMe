namespace RemindMeApp
{
  partial class AppForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.notifyTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.mnuTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuTrayStart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTrayStop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTraySeparator01 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTrayExit = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNotifyInterval = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.cboNotifyInterval = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblNotificationMessage = new System.Windows.Forms.Label();
            this.txtNotificationMessage = new System.Windows.Forms.TextBox();
            this.btnTestNotification = new System.Windows.Forms.Button();
            this.notifyIconImageList = new System.Windows.Forms.ImageList(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.tmrAnimIcon = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.mnu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTray.SuspendLayout();
            this.mnu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyTimer
            // 
            this.notifyTimer.Interval = 900000;
            this.notifyTimer.Tick += new System.EventHandler(this.notifyTimer_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "RemindMe!";
            this.notifyIcon.ContextMenuStrip = this.mnuTray;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "RemindMe";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // mnuTray
            // 
            this.mnuTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTrayStart,
            this.mnuTrayStop,
            this.mnuTraySeparator01,
            this.mnuTrayExit});
            this.mnuTray.Name = "systemTrayMenu";
            this.mnuTray.Size = new System.Drawing.Size(99, 76);
            // 
            // mnuTrayStart
            // 
            this.mnuTrayStart.Name = "mnuTrayStart";
            this.mnuTrayStart.Size = new System.Drawing.Size(98, 22);
            this.mnuTrayStart.Text = "&Start";
            this.mnuTrayStart.Click += new System.EventHandler(this.mnuTrayStart_Click);
            // 
            // mnuTrayStop
            // 
            this.mnuTrayStop.Name = "mnuTrayStop";
            this.mnuTrayStop.Size = new System.Drawing.Size(98, 22);
            this.mnuTrayStop.Text = "S&top";
            this.mnuTrayStop.Click += new System.EventHandler(this.mnuTrayStop_Click);
            // 
            // mnuTraySeparator01
            // 
            this.mnuTraySeparator01.Name = "mnuTraySeparator01";
            this.mnuTraySeparator01.Size = new System.Drawing.Size(95, 6);
            // 
            // mnuTrayExit
            // 
            this.mnuTrayExit.Name = "mnuTrayExit";
            this.mnuTrayExit.Size = new System.Drawing.Size(98, 22);
            this.mnuTrayExit.Text = "&Exit";
            this.mnuTrayExit.Click += new System.EventHandler(this.mnuTrayExit_Click);
            // 
            // txtNotifyInterval
            // 
            this.txtNotifyInterval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotifyInterval.Location = new System.Drawing.Point(114, 35);
            this.txtNotifyInterval.Name = "txtNotifyInterval";
            this.txtNotifyInterval.Size = new System.Drawing.Size(192, 20);
            this.txtNotifyInterval.TabIndex = 0;
            this.txtNotifyInterval.Text = "15";
            this.txtNotifyInterval.TextChanged += new System.EventHandler(this.txtNotifyInterval_TextChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(9, 38);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(91, 13);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Remind Me Every";
            // 
            // cboNotifyInterval
            // 
            this.cboNotifyInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNotifyInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNotifyInterval.Enabled = false;
            this.cboNotifyInterval.FormattingEnabled = true;
            this.cboNotifyInterval.Items.AddRange(new object[] {
            "Minutes",
            "Hours"});
            this.cboNotifyInterval.Location = new System.Drawing.Point(312, 35);
            this.cboNotifyInterval.Name = "cboNotifyInterval";
            this.cboNotifyInterval.Size = new System.Drawing.Size(93, 21);
            this.cboNotifyInterval.TabIndex = 2;
            this.cboNotifyInterval.SelectedIndexChanged += new System.EventHandler(this.cboNotifyInterval_SelectedIndexChanged);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(312, 198);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(93, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblNotificationMessage
            // 
            this.lblNotificationMessage.AutoSize = true;
            this.lblNotificationMessage.Location = new System.Drawing.Point(9, 65);
            this.lblNotificationMessage.Name = "lblNotificationMessage";
            this.lblNotificationMessage.Size = new System.Drawing.Size(87, 13);
            this.lblNotificationMessage.TabIndex = 5;
            this.lblNotificationMessage.Text = "Display Message";
            // 
            // txtNotificationMessage
            // 
            this.txtNotificationMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotificationMessage.Location = new System.Drawing.Point(114, 62);
            this.txtNotificationMessage.Multiline = true;
            this.txtNotificationMessage.Name = "txtNotificationMessage";
            this.txtNotificationMessage.Size = new System.Drawing.Size(291, 130);
            this.txtNotificationMessage.TabIndex = 4;
            this.txtNotificationMessage.Text = "RemindMe Notification!";
            this.txtNotificationMessage.TextChanged += new System.EventHandler(this.txtNotificationMessage_TextChanged);
            // 
            // btnTestNotification
            // 
            this.btnTestNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestNotification.Location = new System.Drawing.Point(114, 198);
            this.btnTestNotification.Name = "btnTestNotification";
            this.btnTestNotification.Size = new System.Drawing.Size(93, 23);
            this.btnTestNotification.TabIndex = 6;
            this.btnTestNotification.Text = "Test";
            this.btnTestNotification.UseVisualStyleBackColor = true;
            this.btnTestNotification.Click += new System.EventHandler(this.btnTestNotification_Click);
            // 
            // notifyIconImageList
            // 
            this.notifyIconImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("notifyIconImageList.ImageStream")));
            this.notifyIconImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.notifyIconImageList.Images.SetKeyName(0, "AppIcon00.ico");
            this.notifyIconImageList.Images.SetKeyName(1, "AppIcon01.ico");
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStop.Location = new System.Drawing.Point(213, 198);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(93, 23);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tmrAnimIcon
            // 
            this.tmrAnimIcon.Interval = 2000;
            this.tmrAnimIcon.Tick += new System.EventHandler(this.tmrAnimIcon_Tick);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(15, 198);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mnu
            // 
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuHelp});
            this.mnu.Location = new System.Drawing.Point(0, 0);
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(417, 24);
            this.mnu.TabIndex = 9;
            this.mnu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(35, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(152, 22);
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(40, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(152, 22);
            this.mnuHelpAbout.Text = "&About";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // AppForm
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnStop;
            this.ClientSize = new System.Drawing.Size(417, 233);
            this.Controls.Add(this.mnu);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnTestNotification);
            this.Controls.Add(this.lblNotificationMessage);
            this.Controls.Add(this.txtNotificationMessage);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cboNotifyInterval);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtNotifyInterval);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnu;
            this.MinimumSize = new System.Drawing.Size(320, 260);
            this.Name = "AppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemindMe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppForm_FormClosing);
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.mnuTray.ResumeLayout(false);
            this.mnu.ResumeLayout(false);
            this.mnu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Timer notifyTimer;
    private System.Windows.Forms.NotifyIcon notifyIcon;
    private System.Windows.Forms.TextBox txtNotifyInterval;
    private System.Windows.Forms.Label lblTime;
    private System.Windows.Forms.ComboBox cboNotifyInterval;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Label lblNotificationMessage;
    private System.Windows.Forms.TextBox txtNotificationMessage;
    private System.Windows.Forms.ContextMenuStrip mnuTray;
    private System.Windows.Forms.ToolStripMenuItem mnuTrayStart;
    private System.Windows.Forms.ToolStripMenuItem mnuTrayStop;
    private System.Windows.Forms.ToolStripSeparator mnuTraySeparator01;
    private System.Windows.Forms.ToolStripMenuItem mnuTrayExit;
    private System.Windows.Forms.Button btnTestNotification;
    private System.Windows.Forms.ImageList notifyIconImageList;
    private System.Windows.Forms.Button btnStop;
    private System.Windows.Forms.Timer tmrAnimIcon;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.MenuStrip mnu;
    private System.Windows.Forms.ToolStripMenuItem mnuFile;
    private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
    private System.Windows.Forms.ToolStripMenuItem mnuHelp;
    private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
  }
}

