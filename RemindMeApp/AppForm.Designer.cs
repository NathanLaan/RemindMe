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
      this.txtNotifyInterval = new System.Windows.Forms.TextBox();
      this.lblTime = new System.Windows.Forms.Label();
      this.cboNotifyInterval = new System.Windows.Forms.ComboBox();
      this.btnStart = new System.Windows.Forms.Button();
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
      this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
      this.notifyIcon.Text = "RemindMe";
      this.notifyIcon.Visible = true;
      // 
      // txtNotifyInterval
      // 
      this.txtNotifyInterval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtNotifyInterval.Location = new System.Drawing.Point(109, 12);
      this.txtNotifyInterval.Name = "txtNotifyInterval";
      this.txtNotifyInterval.Size = new System.Drawing.Size(183, 20);
      this.txtNotifyInterval.TabIndex = 0;
      this.txtNotifyInterval.Text = "15";
      // 
      // lblTime
      // 
      this.lblTime.AutoSize = true;
      this.lblTime.Location = new System.Drawing.Point(9, 15);
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
      this.cboNotifyInterval.Location = new System.Drawing.Point(299, 12);
      this.cboNotifyInterval.Name = "cboNotifyInterval";
      this.cboNotifyInterval.Size = new System.Drawing.Size(93, 21);
      this.cboNotifyInterval.TabIndex = 2;
      // 
      // btnStart
      // 
      this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnStart.Location = new System.Drawing.Point(12, 40);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(380, 23);
      this.btnStart.TabIndex = 3;
      this.btnStart.Text = "Start";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // AppForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(404, 181);
      this.Controls.Add(this.btnStart);
      this.Controls.Add(this.cboNotifyInterval);
      this.Controls.Add(this.lblTime);
      this.Controls.Add(this.txtNotifyInterval);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(320, 220);
      this.Name = "AppForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "RemindMe";
      this.Load += new System.EventHandler(this.AppForm_Load);
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
  }
}

