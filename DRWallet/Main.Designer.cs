namespace DRWallet
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.loginControl = new DRWallet.Login();
            this.registerControl = new DRWallet.Register();
            this.SuspendLayout();
            // 
            // loginControl
            // 
            this.loginControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(102)))));
            this.loginControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginControl.Location = new System.Drawing.Point(0, 0);
            this.loginControl.Name = "loginControl";
            this.loginControl.Size = new System.Drawing.Size(784, 561);
            this.loginControl.TabIndex = 1;
            // 
            // registerControl
            // 
            this.registerControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(102)))));
            this.registerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerControl.Location = new System.Drawing.Point(0, 0);
            this.registerControl.Name = "registerControl";
            this.registerControl.Size = new System.Drawing.Size(784, 561);
            this.registerControl.TabIndex = 2;
            this.registerControl.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.loginControl);
            this.Controls.Add(this.registerControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "DR Wallet";
            this.ResumeLayout(false);

        }

        #endregion

        private Login loginControl;
        private Register registerControl;
    }
}