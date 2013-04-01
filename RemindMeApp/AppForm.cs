﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemindMeApp
{
  public partial class AppForm : Form
  {
    public AppForm()
    {
      InitializeComponent();
    }

    private void notifyTimer_Tick(object sender, EventArgs e)
    {
      string message = string.IsNullOrEmpty(this.txtNotificationMessage.Text) ? "RemindMe Notification!" : this.txtNotificationMessage.Text;
      notifyIcon.ShowBalloonTip(10000, "RemindMe", message, ToolTipIcon.Info);
    }

    private void AppForm_Load(object sender, EventArgs e)
    {
      this.cboNotifyInterval.SelectedIndex = 0;
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


  }

}