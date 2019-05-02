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
            this.regFNameBox.Location = new System.Drawing.Point(272, 354);
            this.regFNameBox.Name = "regFNameBox";
            this.regFNameBox.Size = new System.Drawing.Size(100, 20);
            this.regFNameBox.TabIndex = 2;
            this.regFNameBox.Text = "First Name";
            // 
            // regLNameBox
            // 
            this.regLNameBox.Location = new System.Drawing.Point(428, 354);
            this.regLNameBox.Name = "regLNameBox";
            this.regLNameBox.Size = new System.Drawing.Size(100, 20);
            this.regLNameBox.TabIndex = 3;
            this.regLNameBox.Text = "Last Name";
            // 
            // regUserBox
            // 
            this.regUserBox.Location = new System.Drawing.Point(272, 410);
            this.regUserBox.Name = "regUserBox";
            this.regUserBox.Size = new System.Drawing.Size(100, 20);
            this.regUserBox.TabIndex = 4;
            this.regUserBox.Text = "Username";
            // 
            // regEmailBox
            // 
            this.regEmailBox.Location = new System.Drawing.Point(428, 409);
            this.regEmailBox.Name = "regEmailBox";
            this.regEmailBox.Size = new System.Drawing.Size(100, 20);
            this.regEmailBox.TabIndex = 5;
            this.regEmailBox.Text = "Email";
            // 
            // regPassBox
            // 
            this.regPassBox.Location = new System.Drawing.Point(272, 462);
            this.regPassBox.Name = "regPassBox";
            this.regPassBox.PasswordChar = '*';
            this.regPassBox.Size = new System.Drawing.Size(100, 20);
            this.regPassBox.TabIndex = 6;
            this.regPassBox.Text = "Password";
            // 
            // regConfPassBox
            // 
            this.regConfPassBox.Location = new System.Drawing.Point(428, 462);
            this.regConfPassBox.Name = "regConfPassBox";
            this.regConfPassBox.PasswordChar = '*';
            this.regConfPassBox.Size = new System.Drawing.Size(100, 20);
            this.regConfPassBox.TabIndex = 7;
            this.regConfPassBox.Text = "Confirm Password";
            // 
            // logRegisterBox
            // 
            this.logRegisterBox.Location = new System.Drawing.Point(428, 528);
            this.logRegisterBox.Name = "logRegisterBox";
            this.logRegisterBox.Size = new System.Drawing.Size(75, 23);
            this.logRegisterBox.TabIndex = 8;
            this.logRegisterBox.Text = "Register";
            this.logRegisterBox.UseVisualStyleBackColor = true;
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
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(102)))));
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
    }
}
