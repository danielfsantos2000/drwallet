namespace DRWallet
{
    partial class Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logUserBox = new System.Windows.Forms.TextBox();
            this.logPassBox = new System.Windows.Forms.TextBox();
            this.logLoginButton = new System.Windows.Forms.Button();
            this.regGotoButton = new System.Windows.Forms.Button();
            this.logoImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // logUserBox
            // 
            this.logUserBox.Location = new System.Drawing.Point(272, 354);
            this.logUserBox.Name = "logUserBox";
            this.logUserBox.Size = new System.Drawing.Size(100, 20);
            this.logUserBox.TabIndex = 1;
            this.logUserBox.Text = "Username";
            // 
            // logPassBox
            // 
            this.logPassBox.Location = new System.Drawing.Point(428, 354);
            this.logPassBox.Name = "logPassBox";
            this.logPassBox.PasswordChar = '*';
            this.logPassBox.Size = new System.Drawing.Size(100, 20);
            this.logPassBox.TabIndex = 2;
            this.logPassBox.Text = "Password";
            // 
            // logLoginButton
            // 
            this.logLoginButton.Location = new System.Drawing.Point(297, 380);
            this.logLoginButton.Name = "logLoginButton";
            this.logLoginButton.Size = new System.Drawing.Size(75, 23);
            this.logLoginButton.TabIndex = 3;
            this.logLoginButton.Text = "Login";
            this.logLoginButton.UseVisualStyleBackColor = true;
            this.logLoginButton.Click += new System.EventHandler(this.LogLoginButton_Click);
            // 
            // regGotoButton
            // 
            this.regGotoButton.Location = new System.Drawing.Point(428, 380);
            this.regGotoButton.Name = "regGotoButton";
            this.regGotoButton.Size = new System.Drawing.Size(75, 23);
            this.regGotoButton.TabIndex = 4;
            this.regGotoButton.Text = "Register";
            this.regGotoButton.UseVisualStyleBackColor = true;
            this.regGotoButton.Click += new System.EventHandler(this.RegGotoButton_Click);
            // 
            // logoImage
            // 
            this.logoImage.BackgroundImage = global::DRWallet.Properties.Resources.Icon_PNG_Prancheta_1;
            this.logoImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoImage.Location = new System.Drawing.Point(272, 12);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(256, 256);
            this.logoImage.TabIndex = 0;
            this.logoImage.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(102)))));
            this.Controls.Add(this.regGotoButton);
            this.Controls.Add(this.logLoginButton);
            this.Controls.Add(this.logPassBox);
            this.Controls.Add(this.logUserBox);
            this.Controls.Add(this.logoImage);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoImage;
        private System.Windows.Forms.TextBox logUserBox;
        private System.Windows.Forms.TextBox logPassBox;
        private System.Windows.Forms.Button logLoginButton;
        private System.Windows.Forms.Button regGotoButton;
    }
}
