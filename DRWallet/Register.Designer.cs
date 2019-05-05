namespace DRWallet
{
    partial class Register
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
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.regFNameBox = new System.Windows.Forms.TextBox();
            this.regLNameBox = new System.Windows.Forms.TextBox();
            this.regUserBox = new System.Windows.Forms.TextBox();
            this.regEmailBox = new System.Windows.Forms.TextBox();
            this.regPassBox = new System.Windows.Forms.TextBox();
            this.regConfPassBox = new System.Windows.Forms.TextBox();
            this.logRegisterBox = new System.Windows.Forms.Button();
            this.logBackButton = new System.Windows.Forms.Button();
            this.regErrorLab = new System.Windows.Forms.Label();
            this.regFNameLab = new System.Windows.Forms.Label();
            this.regLNameLab = new System.Windows.Forms.Label();
            this.regUserLab = new System.Windows.Forms.Label();
            this.regEmailLab = new System.Windows.Forms.Label();
            this.regPassLab = new System.Windows.Forms.Label();
            this.regConfPassLab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // logoImage
            // 
            this.logoImage.BackgroundImage = global::DRWallet.Properties.Resources.Icon_PNG_Prancheta_1;
            this.logoImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoImage.Location = new System.Drawing.Point(272, 12);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(256, 256);
            this.logoImage.TabIndex = 1;
            this.logoImage.TabStop = false;
            // 
            // regFNameBox
            // 
            this.regFNameBox.Location = new System.Drawing.Point(256, 354);
            this.regFNameBox.Name = "regFNameBox";
            this.regFNameBox.Size = new System.Drawing.Size(100, 20);
            this.regFNameBox.TabIndex = 2;
            // 
            // regLNameBox
            // 
            this.regLNameBox.Location = new System.Drawing.Point(456, 354);
            this.regLNameBox.Name = "regLNameBox";
            this.regLNameBox.Size = new System.Drawing.Size(100, 20);
            this.regLNameBox.TabIndex = 3;
            // 
            // regUserBox
            // 
            this.regUserBox.Location = new System.Drawing.Point(256, 410);
            this.regUserBox.Name = "regUserBox";
            this.regUserBox.Size = new System.Drawing.Size(100, 20);
            this.regUserBox.TabIndex = 4;
            // 
            // regEmailBox
            // 
            this.regEmailBox.Location = new System.Drawing.Point(456, 409);
            this.regEmailBox.Name = "regEmailBox";
            this.regEmailBox.Size = new System.Drawing.Size(100, 20);
            this.regEmailBox.TabIndex = 5;
            // 
            // regPassBox
            // 
            this.regPassBox.Location = new System.Drawing.Point(256, 462);
            this.regPassBox.Name = "regPassBox";
            this.regPassBox.PasswordChar = '*';
            this.regPassBox.Size = new System.Drawing.Size(100, 20);
            this.regPassBox.TabIndex = 6;
            // 
            // regConfPassBox
            // 
            this.regConfPassBox.Location = new System.Drawing.Point(456, 462);
            this.regConfPassBox.Name = "regConfPassBox";
            this.regConfPassBox.PasswordChar = '*';
            this.regConfPassBox.Size = new System.Drawing.Size(100, 20);
            this.regConfPassBox.TabIndex = 7;
            // 
            // logRegisterBox
            // 
            this.logRegisterBox.Location = new System.Drawing.Point(428, 528);
            this.logRegisterBox.Name = "logRegisterBox";
            this.logRegisterBox.Size = new System.Drawing.Size(75, 23);
            this.logRegisterBox.TabIndex = 8;
            this.logRegisterBox.Text = "Register";
            this.logRegisterBox.UseVisualStyleBackColor = true;
            this.logRegisterBox.Click += new System.EventHandler(this.LogRegisterBox_Click);
            // 
            // logBackButton
            // 
            this.logBackButton.Location = new System.Drawing.Point(297, 528);
            this.logBackButton.Name = "logBackButton";
            this.logBackButton.Size = new System.Drawing.Size(75, 23);
            this.logBackButton.TabIndex = 9;
            this.logBackButton.Text = "Cancel";
            this.logBackButton.UseVisualStyleBackColor = true;
            // 
            // regErrorLab
            // 
            this.regErrorLab.AutoSize = true;
            this.regErrorLab.Font = new System.Drawing.Font("Gill Sans MT", 22.25F);
            this.regErrorLab.Location = new System.Drawing.Point(358, 287);
            this.regErrorLab.Name = "regErrorLab";
            this.regErrorLab.Size = new System.Drawing.Size(86, 42);
            this.regErrorLab.TabIndex = 10;
            this.regErrorLab.Text = "Error";
            this.regErrorLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.regErrorLab.Visible = false;
            // 
            // regFNameLab
            // 
            this.regFNameLab.AutoSize = true;
            this.regFNameLab.Location = new System.Drawing.Point(190, 357);
            this.regFNameLab.Name = "regFNameLab";
            this.regFNameLab.Size = new System.Drawing.Size(60, 13);
            this.regFNameLab.TabIndex = 11;
            this.regFNameLab.Text = "First Name:";
            // 
            // regLNameLab
            // 
            this.regLNameLab.AutoSize = true;
            this.regLNameLab.Location = new System.Drawing.Point(389, 357);
            this.regLNameLab.Name = "regLNameLab";
            this.regLNameLab.Size = new System.Drawing.Size(61, 13);
            this.regLNameLab.TabIndex = 12;
            this.regLNameLab.Text = "Last Name:";
            // 
            // regUserLab
            // 
            this.regUserLab.AutoSize = true;
            this.regUserLab.Location = new System.Drawing.Point(192, 412);
            this.regUserLab.Name = "regUserLab";
            this.regUserLab.Size = new System.Drawing.Size(58, 13);
            this.regUserLab.TabIndex = 13;
            this.regUserLab.Text = "Username:";
            // 
            // regEmailLab
            // 
            this.regEmailLab.AutoSize = true;
            this.regEmailLab.Location = new System.Drawing.Point(415, 413);
            this.regEmailLab.Name = "regEmailLab";
            this.regEmailLab.Size = new System.Drawing.Size(35, 13);
            this.regEmailLab.TabIndex = 14;
            this.regEmailLab.Text = "Email:";
            // 
            // regPassLab
            // 
            this.regPassLab.AutoSize = true;
            this.regPassLab.Location = new System.Drawing.Point(194, 465);
            this.regPassLab.Name = "regPassLab";
            this.regPassLab.Size = new System.Drawing.Size(56, 13);
            this.regPassLab.TabIndex = 15;
            this.regPassLab.Text = "Password:";
            // 
            // regConfPassLab
            // 
            this.regConfPassLab.AutoSize = true;
            this.regConfPassLab.Location = new System.Drawing.Point(362, 465);
            this.regConfPassLab.Name = "regConfPassLab";
            this.regConfPassLab.Size = new System.Drawing.Size(91, 13);
            this.regConfPassLab.TabIndex = 16;
            this.regConfPassLab.Text = "ConfirmPassword:";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(102)))));
            this.Controls.Add(this.regConfPassLab);
            this.Controls.Add(this.regPassLab);
            this.Controls.Add(this.regEmailLab);
            this.Controls.Add(this.regUserLab);
            this.Controls.Add(this.regLNameLab);
            this.Controls.Add(this.regFNameLab);
            this.Controls.Add(this.regErrorLab);
            this.Controls.Add(this.logBackButton);
            this.Controls.Add(this.logRegisterBox);
            this.Controls.Add(this.regConfPassBox);
            this.Controls.Add(this.regPassBox);
            this.Controls.Add(this.regEmailBox);
            this.Controls.Add(this.regUserBox);
            this.Controls.Add(this.regLNameBox);
            this.Controls.Add(this.regFNameBox);
            this.Controls.Add(this.logoImage);
            this.Name = "Register";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoImage;
        private System.Windows.Forms.TextBox regFNameBox;
        private System.Windows.Forms.TextBox regLNameBox;
        private System.Windows.Forms.TextBox regUserBox;
        private System.Windows.Forms.TextBox regEmailBox;
        private System.Windows.Forms.TextBox regPassBox;
        private System.Windows.Forms.TextBox regConfPassBox;
        private System.Windows.Forms.Button logRegisterBox;
        private System.Windows.Forms.Button logBackButton;
        private System.Windows.Forms.Label regErrorLab;
        private System.Windows.Forms.Label regFNameLab;
        private System.Windows.Forms.Label regLNameLab;
        private System.Windows.Forms.Label regUserLab;
        private System.Windows.Forms.Label regEmailLab;
        private System.Windows.Forms.Label regPassLab;
        private System.Windows.Forms.Label regConfPassLab;
    }
}
