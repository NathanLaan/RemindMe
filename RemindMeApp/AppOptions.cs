using System;
using System.Windows.Forms;

namespace RemindMeApp
{

  class AppOptions
  {

    public string NotificationMessage { get; set; }
    public int NotificationInterval { get; set; }
    public string NotificationIntervalUnit { get; set; }

    public sealed class Unit
    {
      public static readonly Unit Minutes = new Unit("Minutes");
      public static readonly Unit Hours = new Unit("Hours");
      private string value;
      public Unit(string value)
      {
        this.value = value;
      }
      public override string ToString()
      {
        return value;
      }
    }


    public void SaveSettings()
    {
      try
      {
        Application.UserAppDataRegistry.SetValue("NotifyInterval", this.NotificationInterval);
      }
      catch (Exception e)
      {
      }
    }

    private void SaveNotificationMessage()
    {
    }

    private void SaveNotificationInterval()
    {
    }

    private void SaveNotificationIntervalUnit()
    {
    }

  }

}