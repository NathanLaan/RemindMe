using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace RemindMeApp
{
    public partial class ToastForm : Form
    {

      public string Message
      {
        get
        {
          return this.txtMessage.Text;
        }
        set
        {
          this.txtMessage.Text = value;
        }
      }

        public ToastForm()
        {
            InitializeComponent();
        }
    }
}
