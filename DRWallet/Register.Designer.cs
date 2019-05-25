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
            this.regFNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.regFNameBox.Location = new System.Drawing.Point(206, 339);
            this.regFNameBox.Name = "regFNameBox";
            this.regFNameBox.Size = new System.Drawing.Size(143, 29);
            this.regFNameBox.TabIndex = 2;
            this.regFNameBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Register_KeyUp);
            // 
            // regLNameBox
            // 
            this.regLNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.regLNameBox.Location = new System.Drawing.Point(577, 339);
            this.regLNameBox.Name = "regLNameBox";
            this.regLNameBox.Size = new System.Drawing.Size(149, 29);
            this.regLNameBox.TabIndex = 3;
            this.regLNameBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Register_KeyUp);
            // 
            // regUserBox
            // 
            this.regUserBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.regUserBox.Location = new System.Drawing.Point(206, 390);
            this.regUserBox.Name = "regUserBox";
            this.regUserBox.Size = new System.Drawing.Size(143, 29);
            this.regUserBox.TabIndex = 4;
            this.regUserBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Register_KeyUp);
            // 
            // regEmailBox
            // 
            this.regEmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.regEmailBox.Location = new System.Drawing.Point(577, 390);
            this.regEmailBox.Name = "regEmailBox";
            this.regEmailBox.Size = new System.Drawing.Size(149, 29);
            this.regEmailBox.TabIndex = 5;
            this.regEmailBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Register_KeyUp);
            // 
            // regPassBox
            // 
            this.regPassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.regPassBox.Location = new System.Drawing.Point(205, 445);
            this.regPassBox.Name = "regPassBox";
            this.regPassBox.PasswordChar = '*';
            this.regPassBox.Size = new System.Drawing.Size(143, 29);
            this.regPassBox.TabIndex = 6;
            this.regPassBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Register_KeyUp);
            // 
            // regConfPassBox
            // 
            this.regConfPassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.regConfPassBox.Location = new System.Drawing.Point(578, 445);
            this.regConfPassBox.Name = "regConfPassBox";
            this.regConfPassBox.PasswordChar = '*';
            this.regConfPassBox.Size = new System.Drawing.Size(149, 29);
            this.regConfPassBox.TabIndex = 7;
            this.regConfPassBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Register_KeyUp);
            // 
            // logRegisterBox
            // 
            this.logRegisterBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(66)))));
            this.logRegisterBox.FlatAppearance.BorderSize = 0;
            this.logRegisterBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(25)))));
            this.logRegisterBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(48)))));
            this.logRegisterBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logRegisterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.logRegisterBox.Location = new System.Drawing.Point(426, 493);
            this.logRegisterBox.Name = "logRegisterBox";
            this.logRegisterBox.Size = new System.Drawing.Size(150, 32);
            this.logRegisterBox.TabIndex = 8;
            this.logRegisterBox.Text = "Register";
            this.logRegisterBox.UseVisualStyleBackColor = false;
            this.logRegisterBox.Click += new System.EventHandler(this.LogRegisterBox_Click);
            // 
            // logBackButton
            // 
            this.logBackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(66)))));
            this.logBackButton.FlatAppearance.BorderSize = 0;
            this.logBackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(25)))));
            this.logBackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(48)))));
            this.logBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.logBackButton.Location = new System.Drawing.Point(217, 493);
            this.logBackButton.Name = "logBackButton";
            this.logBackButton.Size = new System.Drawing.Size(150, 32);
            this.logBackButton.TabIndex = 9;
            this.logBackButton.Text = "Go Back";
            this.logBackButton.UseVisualStyleBackColor = false;
            this.logBackButton.Click += new System.EventHandler(this.LogBackButton_Click);
            // 
            // regErrorLab
            // 
            this.regErrorLab.AutoSize = true;
            this.regErrorLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.regErrorLab.Location = new System.Drawing.Point(358, 287);
            this.regErrorLab.Name = "regErrorLab";
            this.regErrorLab.Size = new System.Drawing.Size(82, 36);
            this.regErrorLab.TabIndex = 10;
            this.regErrorLab.Text = "Error";
            this.regErrorLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.regErrorLab.Visible = false;
            // 
            // regFNameLab
            // 
            this.regFNameLab.AutoSize = true;
            this.regFNameLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regFNameLab.Location = new System.Drawing.Point(63, 335);
            this.regFNameLab.Name = "regFNameLab";
            this.regFNameLab.Size = new System.Drawing.Size(137, 29);
            this.regFNameLab.TabIndex = 11;
            this.regFNameLab.Text = "First Name:";
            // 
            // regLNameLab
            // 
            this.regLNameLab.AutoSize = true;
            this.regLNameLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.regLNameLab.Location = new System.Drawing.Point(437, 335);
            this.regLNameLab.Name = "regLNameLab";
            this.regLNameLab.Size = new System.Drawing.Size(134, 29);
            this.regLNameLab.TabIndex = 12;
            this.regLNameLab.Text = "Last Name:";
            // 
            // regUserLab
            // 
            this.regUserLab.AutoSize = true;
            this.regUserLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.regUserLab.Location = new System.Drawing.Point(70, 389);
            this.regUserLab.Name = "regUserLab";
            this.regUserLab.Size = new System.Drawing.Size(130, 29);
            this.regUserLab.TabIndex = 13;
            this.regUserLab.Text = "Username:";
            // 
            // regEmailLab
            // 
            this.regEmailLab.AutoSize = true;
            this.regEmailLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.regEmailLab.Location = new System.Drawing.Point(491, 389);
            this.regEmailLab.Name = "regEmailLab";
            this.regEmailLab.Size = new System.Drawing.Size(80, 29);
            this.regEmailLab.TabIndex = 14;
            this.regEmailLab.Text = "Email:";
            // 
            // regPassLab
            // 
            this.regPassLab.AutoSize = true;
            this.regPassLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.regPassLab.Location = new System.Drawing.Point(73, 441);
            this.regPassLab.Name = "regPassLab";
            this.regPassLab.Size = new System.Drawing.Size(126, 29);
            this.regPassLab.TabIndex = 15;
            this.regPassLab.Text = "Password:";
            // 
            // regConfPassLab
            // 
            this.regConfPassLab.AutoSize = true;
            this.regConfPassLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.regConfPassLab.Location = new System.Drawing.Point(356, 444);
            this.regConfPassLab.Name = "regConfPassLab";
            this.regConfPassLab.Size = new System.Drawing.Size(216, 29);
            this.regConfPassLab.TabIndex = 16;
            this.regConfPassLab.Text = "Confirm Password:";
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
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Register_KeyUp);
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
