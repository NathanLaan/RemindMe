namespace RemindMeApp
{
    partial class ToastForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToastForm));
      this.txtMessage = new System.Windows.Forms.TextBox();
      this.tmrAnimation = new System.Windows.Forms.Timer(this.components);
      this.txtTime = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // txtMessage
      // 
      this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtMessage.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtMessage.Location = new System.Drawing.Point(13, 13);
      this.txtMessage.Multiline = true;
      this.txtMessage.Name = "txtMessage";
      this.txtMessage.ReadOnly = true;
      this.txtMessage.Size = new System.Drawing.Size(189, 74);
      this.txtMessage.TabIndex = 0;
      this.txtMessage.TabStop = false;
      // 
      // tmrAnimation
      // 
      this.tmrAnimation.Tick += new System.EventHandler(this.tmrAnimation_Tick);
      // 
      // txtTime
      // 
      this.txtTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtTime.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTime.Location = new System.Drawing.Point(12, 93);
      this.txtTime.Multiline = true;
      this.txtTime.Name = "txtTime";
      this.txtTime.ReadOnly = true;
      this.txtTime.Size = new System.Drawing.Size(189, 20);
      this.txtTime.TabIndex = 1;
      this.txtTime.TabStop = false;
      this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // ToastForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.ClientSize = new System.Drawing.Size(214, 125);
      this.Controls.Add(this.txtTime);
      this.Controls.Add(this.txtMessage);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ToastForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.Text = "RemindMe!";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Timer tmrAnimation;
        private System.Windows.Forms.TextBox txtTime;
    }
}