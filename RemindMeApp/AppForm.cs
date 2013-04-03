using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RemindMeApp
{
  public partial class AppForm : Form
  {

    private bool _applicationExit = false;
    private AppOptions appOptions;

    public AppForm()
    {
      InitializeComponent();
    }

    private void notifyTimer_Tick(object sender, EventArgs e)
    {
        this.Notify();
    }

    private void Notify()
    {
        string message = string.IsNullOrEmpty(this.txtNotificationMessage.Text) ? "RemindMe Notification!" : this.txtNotificationMessage.Text;
        notifyIcon.ShowBalloonTip(10000, "RemindMe", message, ToolTipIcon.Info);

        this.ShowToast();
    }

    private void ShowToast()
    {
      //
      // Size of desktop exluding the taskbar:
      //
      int w = SystemInformation.PrimaryMonitorMaximizedWindowSize.Width;
      int h = SystemInformation.PrimaryMonitorMaximizedWindowSize.Height;

      //MessageBox.Show(string.Format("w: {0} --- h: {1}", w, h));

      int spacer = 10;

      ToastForm toastForm = new ToastForm();
      toastForm.Left = w - toastForm.Width - spacer;
      toastForm.Top = h - toastForm.Height - spacer;
      toastForm.Message = this.appOptions.NotificationMessage;
      toastForm.TopMost = true;
      toastForm.ShowDialog(this);
    }

    private void AppForm_Load(object sender, EventArgs e)
    {
      this.cboNotifyInterval.SelectedIndex = 0;
      // load settings
      this.appOptions = new AppOptions();
      this.LoadSettings();
      this.tmrAnimIcon.Enabled = true;
      this.tmrAnimIcon.Start();
    }

    private void LoadSettings()
    {

      #region Load NotificationMessage
      string notificationMessage = this.appOptions.NotificationMessage;
      if (string.IsNullOrEmpty(notificationMessage))
      {
        MessageBox.Show("null");
        notificationMessage = "RemindMe Notification!";
        this.appOptions.NotificationMessage = notificationMessage;
      }
      this.txtNotificationMessage.Text = notificationMessage;
      #endregion



    }

    private void mnuTrayStart_Click(object sender, EventArgs e)
    {
      this.notifyTimer.Start();
    }

    private void mnuTrayStop_Click(object sender, EventArgs e)
    {
      this.notifyTimer.Stop();
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
      //
      // TODO: Set notification based on Minutes or Hours dropdown.
      //
      /*
      MessageBox.Show(this.cboNotifyInterval.SelectedText.ToString());
      if (this.cboNotifyInterval.SelectedValue == "Minutes")
      {
        this.notifyTimer.Interval = Int32.Parse(this.txtNotifyInterval.Text) * 60 * 1000;
      }
      else
      {
        this.notifyTimer.Interval = Int32.Parse(this.txtNotifyInterval.Text) * 60 * 60 * 1000;
      }
       * */
      this.notifyTimer.Interval = Int32.Parse(this.txtNotifyInterval.Text) * 60 * 1000;
      this.notifyTimer.Start();
    }

    private void txtNotificationMessage_TextChanged(object sender, EventArgs e)
    {
      //
      // TODO: Save settings on edit...
      //
      this.appOptions.NotificationMessage = this.txtNotificationMessage.Text;
    }

    private void txtNotifyInterval_TextChanged(object sender, EventArgs e)
    {
      //
      // TODO: Save settings on edit...
      //
    }

    private void cboNotifyInterval_SelectedIndexChanged(object sender, EventArgs e)
    {
      //
      // TODO: Save settings on edit...
      //
    }


    private void mnuTrayExit_Click(object sender, EventArgs e)
    {
      this.ApplicationExit();
    }

    private void ApplicationExit()
    {
      this._applicationExit = true;
      Application.Exit();
    }

    private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if (e.Button == System.Windows.Forms.MouseButtons.Left)
      {
        this.Visible = !this.Visible;
      }
    }

    private void AppForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (!this._applicationExit)
      {
        this.Visible = false;
        e.Cancel = true;
        this.ShowBalloonTip();
      }
    }

    private void ShowBalloonTip()
    {
      this.notifyIcon.ShowBalloonTip(5000, "RemindMe", "RemindMe is still running. Double-click the icon to show or hide RemindMe. Right-click the icon for additional options.", ToolTipIcon.Info);
    }

    private void btnTestNotification_Click(object sender, EventArgs e)
    {
        this.ShowToast();
    }

    private bool _animationEnabled = true;
    private int _frameCounter = 1;


    private void tmrAnimIcon_Tick(object sender, EventArgs e)
    {
      #region ANIMATION
      if (this._animationEnabled)
      {
        switch (this._frameCounter)
        {
          case 1:
            this.notifyIcon.Icon = NotifyIconList.AppIcon00;
            break;
          case 2:
            this.notifyIcon.Icon = NotifyIconList.AppIcon01;
            break;
          case 3:
            this.notifyIcon.Icon = NotifyIconList.AppIcon02;
            break;
          case 4:
            this.notifyIcon.Icon = NotifyIconList.AppIcon03;
            break;
          case 5:
            this.notifyIcon.Icon = NotifyIconList.AppIcon04;
            break;
          case 6:
            this.notifyIcon.Icon = NotifyIconList.AppIcon05;
            break;
          case 7:
            this.notifyIcon.Icon = NotifyIconList.AppIcon06;
            break;
          case 8:
            this.notifyIcon.Icon = NotifyIconList.AppIcon07;
            break;
        }
        if (_frameCounter < 8)
        {
          _frameCounter++;
        }
        else
        {
          _frameCounter = 1;
        }
      }
      else
      {
        // Set icon in case someone switches the property in the middle of an animation 
        // sequence. There are more efficient ways to do this but this is a simple way.
        this.notifyIcon.Icon = NotifyIconList.AppIcon00;
      }
      #endregion ANIMATION
    }


  }

}