using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace RemindMe.WindowsApp
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

        public string Time
        {
            set
            {
                this.txtTime.Text = value;
            }
        }

        public ToastForm()
        {
            InitializeComponent();
            this.tmrAnimation.Start();
        }

        private Boolean up = true;

        private double amount = 0.05;

        private void tmrAnimation_Tick(object sender, EventArgs e)
        {
            if (up)
            {
                if (this.Opacity >= 0.95)
                {
                    this.up = false;
                    this.Opacity -= amount;
                }
                else
                {
                    this.Opacity += amount;
                }
            }
            else
            {
                if (this.Opacity <= 0.6)
                {
                    this.up = true;
                    this.Opacity += amount;
                }
                else
                {
                    this.Opacity -= amount;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
