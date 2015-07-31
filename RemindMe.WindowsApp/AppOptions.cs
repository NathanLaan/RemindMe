using System;
using System.Windows.Forms;

namespace RemindMe.WindowsApp
{

    class AppOptions
    {


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


        private static readonly string NotificationMessageKey = "NotificationMessage";
        private static readonly string NotificationIntervalKey = "NotificationInterval";
        private static readonly string NotificationIntervalUnitKey = "NotificationIntervalUnit";

        public string NotificationMessage
        {
            get
            {
                try
                {
                    return Application.UserAppDataRegistry.GetValue(AppOptions.NotificationMessageKey).ToString();
                }
                catch (Exception e)
                {
                    return string.Empty;
                }
            }
            set
            {
                Application.UserAppDataRegistry.SetValue(AppOptions.NotificationMessageKey, value);
            }
        }

        public int NotificationInterval
        {
            get
            {
                try
                {
                    return int.Parse(Application.UserAppDataRegistry.GetValue(AppOptions.NotificationIntervalKey).ToString());
                }
                catch (Exception e)
                {
                    return 1;
                }
            }
            set
            {
                Application.UserAppDataRegistry.SetValue(AppOptions.NotificationIntervalKey, value);
            }
        }

        public string NotificationIntervalUnit
        {
            get
            {
                try
                {
                    return Application.UserAppDataRegistry.GetValue(AppOptions.NotificationIntervalUnitKey).ToString();
                }
                catch (Exception e)
                {
                    return string.Empty;
                }
            }
            set
            {
                Application.UserAppDataRegistry.SetValue(AppOptions.NotificationIntervalUnitKey, value);
            }
        }


    }

}