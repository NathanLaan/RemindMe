using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RemindMeApp
{
  static class App
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new AppForm());
    }
  }
}
