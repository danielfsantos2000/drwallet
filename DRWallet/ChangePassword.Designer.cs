namespace DRWallet
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.cpwdTitleLab = new System.Windows.Forms.Label();
            this.cpwdCurrLab = new System.Windows.Forms.Label();
            this.cpwdNPassLab = new System.Windows.Forms.Label();
            this.cpwdCNPassLab = new System.Windows.Forms.Label();
            this.cpwdCPassBox = new System.Windows.Forms.TextBox();
            this.cpwdNPassBox = new System.Windows.Forms.TextBox();
            this.cpwdCNPassBox = new System.Windows.Forms.TextBox();
            this.cpwdSubmitButton = new System.Windows.Forms.Button();
            this.cpwdErrorLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cpwdTitleLab
            // 
            this.cpwdTitleLab.AutoSize = true;
            this.cpwdTitleLab.Font = new System.Drawing.Font("Gill Sans MT", 32.25F);
            this.cpwdTitleLab.Location = new System.Drawing.Point(68, 9);
            this.cpwdTitleLab.Name = "cpwdTitleLab";
            this.cpwdTitleLab.Size = new System.Drawing.Size(336, 60);
            this.cpwdTitleLab.TabIndex = 0;
            this.cpwdTitleLab.Text = "Change password";
            // 
            // cpwdCurrLab
            // 
            this.cpwdCurrLab.AutoSize = true;
            this.cpwdCurrLab.Font = new System.Drawing.Font("Gill Sans MT", 16.25F);
            this.cpwdCurrLab.Location = new System.Drawing.Point(54, 113);
            this.cpwdCurrLab.Name = "cpwdCurrLab";
            this.cpwdCurrLab.Size = new System.Drawing.Size(183, 31);
            this.cpwdCurrLab.TabIndex = 1;
            this.cpwdCurrLab.Text = "Current Password:";
            // 
            // cpwdNPassLab
            // 
            this.cpwdNPassLab.AutoSize = true;
            this.cpwdNPassLab.Font = new System.Drawing.Font("Gill Sans MT", 16.25F);
            this.cpwdNPassLab.Location = new System.Drawing.Point(84, 158);
            this.cpwdNPassLab.Name = "cpwdNPassLab";
            this.cpwdNPassLab.Size = new System.Drawing.Size(153, 31);
            this.cpwdNPassLab.TabIndex = 2;
            this.cpwdNPassLab.Text = "New Password:";
            // 
            // cpwdCNPassLab
            // 
            this.cpwdCNPassLab.AutoSize = true;
            this.cpwdCNPassLab.Font = new System.Drawing.Font("Gill Sans MT", 16.25F);
            this.cpwdCNPassLab.Location = new System.Drawing.Point(52, 202);
            this.cpwdCNPassLab.Name = "cpwdCNPassLab";
            this.cpwdCNPassLab.Size = new System.Drawing.Size(185, 31);
            this.cpwdCNPassLab.TabIndex = 3;
            this.cpwdCNPassLab.Text = "Confirm Password:";
            // 
            // cpwdCPassBox
            // 
            this.cpwdCPassBox.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.cpwdCPassBox.Location = new System.Drawing.Point(243, 115);
            this.cpwdCPassBox.Name = "cpwdCPassBox";
            this.cpwdCPassBox.PasswordChar = '*';
            this.cpwdCPassBox.Size = new System.Drawing.Size(199, 29);
            this.cpwdCPassBox.TabIndex = 4;
            // 
            // cpwdNPassBox
            // 
            this.cpwdNPassBox.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.cpwdNPassBox.Location = new System.Drawing.Point(243, 160);
            this.cpwdNPassBox.Name = "cpwdNPassBox";
            this.cpwdNPassBox.PasswordChar = '*';
            this.cpwdNPassBox.Size = new System.Drawing.Size(199, 29);
            this.cpwdNPassBox.TabIndex = 5;
            // 
            // cpwdCNPassBox
            // 
            this.cpwdCNPassBox.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.cpwdCNPassBox.Location = new System.Drawing.Point(243, 204);
            this.cpwdCNPassBox.Name = "cpwdCNPassBox";
            this.cpwdCNPassBox.PasswordChar = '*';
            this.cpwdCNPassBox.Size = new System.Drawing.Size(199, 29);
            this.cpwdCNPassBox.TabIndex = 6;
            // 
            // cpwdSubmitButton
            // 
            this.cpwdSubmitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(66)))));
            this.cpwdSubmitButton.FlatAppearance.BorderSize = 0;
            this.cpwdSubmitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(25)))));
            this.cpwdSubmitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(48)))));
            this.cpwdSubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cpwdSubmitButton.Location = new System.Drawing.Point(185, 248);
            this.cpwdSubmitButton.Name = "cpwdSubmitButton";
            this.cpwdSubmitButton.Size = new System.Drawing.Size(117, 35);
            this.cpwdSubmitButton.TabIndex = 7;
            this.cpwdSubmitButton.Text = "Change Password";
            this.cpwdSubmitButton.UseVisualStyleBackColor = false;
            this.cpwdSubmitButton.Click += new System.EventHandler(this.CpwdSubmitButton_Click);
            // 
            // cpwdErrorLab
            // 
            this.cpwdErrorLab.AutoSize = true;
            this.cpwdErrorLab.Font = new System.Drawing.Font("Gill Sans MT", 16.25F);
            this.cpwdErrorLab.Location = new System.Drawing.Point(214, 77);
            this.cpwdErrorLab.Name = "cpwdErrorLab";
            this.cpwdErrorLab.Size = new System.Drawing.Size(64, 31);
            this.cpwdErrorLab.TabIndex = 8;
            this.cpwdErrorLab.Text = "Error";
            this.cpwdErrorLab.Visible = false;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(487, 293);
            this.Controls.Add(this.cpwdErrorLab);
            this.Controls.Add(this.cpwdSubmitButton);
            this.Controls.Add(this.cpwdCNPassBox);
            this.Controls.Add(this.cpwdNPassBox);
            this.Controls.Add(this.cpwdCPassBox);
            this.Controls.Add(this.cpwdCNPassLab);
            this.Controls.Add(this.cpwdNPassLab);
            this.Controls.Add(this.cpwdCurrLab);
            this.Controls.Add(this.cpwdTitleLab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePassword";
            this.Text = "Change password - DRWallet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cpwdTitleLab;
        private System.Windows.Forms.Label cpwdCurrLab;
        private System.Windows.Forms.Label cpwdNPassLab;
        private System.Windows.Forms.Label cpwdCNPassLab;
        private System.Windows.Forms.TextBox cpwdCPassBox;
        private System.Windows.Forms.TextBox cpwdNPassBox;
        private System.Windows.Forms.TextBox cpwdCNPassBox;
        private System.Windows.Forms.Button cpwdSubmitButton;
        private System.Windows.Forms.Label cpwdErrorLab;
    }
}