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

      int spacer = 16;

      ToastForm toastForm = new ToastForm();
      toastForm.Left = w - toastForm.Width - spacer;
      toastForm.Top = h - toastForm.Height - spacer;
      toastForm.Message = this.appOptions.NotificationMessage;
      toastForm.ShowDialog(this);
    }

    private void AppForm_Load(object sender, EventArgs e)
    {
      this.cboNotifyInterval.SelectedIndex = 0;
      // load settings
      this.appOptions = new AppOptions();
      this.LoadSettings();
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


    private void SaveSettings()
    {
      try
      {
        Application.UserAppDataRegistry.SetValue("NotifyInterval", int.Parse(this.txtNotifyInterval.Text));
      }
      catch (Exception e)
      {
      }
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


  }

}