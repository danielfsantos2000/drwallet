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
            this.logUsernameLab = new System.Windows.Forms.Label();
            this.logPassLab = new System.Windows.Forms.Label();
            this.logErrorLab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // logUserBox
            // 
            this.logUserBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.logUserBox.Location = new System.Drawing.Point(404, 351);
            this.logUserBox.Name = "logUserBox";
            this.logUserBox.Size = new System.Drawing.Size(172, 31);
            this.logUserBox.TabIndex = 1;
            this.logUserBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyReg);
            // 
            // logPassBox
            // 
            this.logPassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.logPassBox.Location = new System.Drawing.Point(404, 410);
            this.logPassBox.Name = "logPassBox";
            this.logPassBox.PasswordChar = '*';
            this.logPassBox.Size = new System.Drawing.Size(172, 31);
            this.logPassBox.TabIndex = 2;
            this.logPassBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyReg);
            // 
            // logLoginButton
            // 
            this.logLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(66)))));
            this.logLoginButton.FlatAppearance.BorderSize = 0;
            this.logLoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(25)))));
            this.logLoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(48)))));
            this.logLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.logLoginButton.Location = new System.Drawing.Point(217, 493);
            this.logLoginButton.Name = "logLoginButton";
            this.logLoginButton.Size = new System.Drawing.Size(150, 32);
            this.logLoginButton.TabIndex = 3;
            this.logLoginButton.Text = "Login";
            this.logLoginButton.UseVisualStyleBackColor = false;
            this.logLoginButton.Click += new System.EventHandler(this.LogLoginButton_Click);
            // 
            // regGotoButton
            // 
            this.regGotoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(66)))));
            this.regGotoButton.FlatAppearance.BorderSize = 0;
            this.regGotoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(25)))));
            this.regGotoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(48)))));
            this.regGotoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regGotoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.regGotoButton.Location = new System.Drawing.Point(426, 493);
            this.regGotoButton.Name = "regGotoButton";
            this.regGotoButton.Size = new System.Drawing.Size(150, 32);
            this.regGotoButton.TabIndex = 4;
            this.regGotoButton.Text = "Register";
            this.regGotoButton.UseVisualStyleBackColor = false;
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
            // logUsernameLab
            // 
            this.logUsernameLab.AutoSize = true;
            this.logUsernameLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.logUsernameLab.Location = new System.Drawing.Point(210, 343);
            this.logUsernameLab.Name = "logUsernameLab";
            this.logUsernameLab.Size = new System.Drawing.Size(188, 39);
            this.logUsernameLab.TabIndex = 12;
            this.logUsernameLab.Text = "Username:";
            // 
            // logPassLab
            // 
            this.logPassLab.AutoSize = true;
            this.logPassLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.logPassLab.Location = new System.Drawing.Point(218, 402);
            this.logPassLab.Name = "logPassLab";
            this.logPassLab.Size = new System.Drawing.Size(180, 39);
            this.logPassLab.TabIndex = 13;
            this.logPassLab.Text = "Password:";
            // 
            // logErrorLab
            // 
            this.logErrorLab.AutoSize = true;
            this.logErrorLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.logErrorLab.Location = new System.Drawing.Point(358, 287);
            this.logErrorLab.Name = "logErrorLab";
            this.logErrorLab.Size = new System.Drawing.Size(82, 36);
            this.logErrorLab.TabIndex = 14;
            this.logErrorLab.Text = "Error";
            this.logErrorLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logErrorLab.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(102)))));
            this.Controls.Add(this.logErrorLab);
            this.Controls.Add(this.logPassLab);
            this.Controls.Add(this.logUsernameLab);
            this.Controls.Add(this.regGotoButton);
            this.Controls.Add(this.logLoginButton);
            this.Controls.Add(this.logPassBox);
            this.Controls.Add(this.logUserBox);
            this.Controls.Add(this.logoImage);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(800, 600);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyReg);
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
        private System.Windows.Forms.Label logUsernameLab;
        private System.Windows.Forms.Label logPassLab;
        private System.Windows.Forms.Label logErrorLab;
    }
}
