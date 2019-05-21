namespace DRWallet
{
    partial class Account
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
            this.accAccLab = new System.Windows.Forms.Label();
            this.accFNameLab = new System.Windows.Forms.Label();
            this.accFNameBox = new System.Windows.Forms.TextBox();
            this.accLNameLab = new System.Windows.Forms.Label();
            this.accLNameBox = new System.Windows.Forms.TextBox();
            this.accEmailLab = new System.Windows.Forms.Label();
            this.accEmailBox = new System.Windows.Forms.TextBox();
            this.accPasswordButton = new System.Windows.Forms.Button();
            this.accSaveBox = new System.Windows.Forms.Button();
            this.accLogoutBut = new System.Windows.Forms.Button();
            this.accNavBar = new DRWallet.NavBar();
            this.SuspendLayout();
            // 
            // accAccLab
            // 
            this.accAccLab.AutoSize = true;
            this.accAccLab.BackColor = System.Drawing.Color.Transparent;
            this.accAccLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F);
            this.accAccLab.Location = new System.Drawing.Point(155, 5);
            this.accAccLab.Name = "accAccLab";
            this.accAccLab.Size = new System.Drawing.Size(230, 64);
            this.accAccLab.TabIndex = 13;
            this.accAccLab.Text = "Account";
            // 
            // accFNameLab
            // 
            this.accFNameLab.AutoSize = true;
            this.accFNameLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accFNameLab.Location = new System.Drawing.Point(218, 117);
            this.accFNameLab.Name = "accFNameLab";
            this.accFNameLab.Size = new System.Drawing.Size(198, 39);
            this.accFNameLab.TabIndex = 14;
            this.accFNameLab.Text = "First Name:";
            // 
            // accFNameBox
            // 
            this.accFNameBox.BackColor = System.Drawing.SystemColors.Window;
            this.accFNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accFNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.accFNameBox.Location = new System.Drawing.Point(422, 125);
            this.accFNameBox.Name = "accFNameBox";
            this.accFNameBox.Size = new System.Drawing.Size(237, 31);
            this.accFNameBox.TabIndex = 15;
            this.accFNameBox.Text = "first name";
            // 
            // accLNameLab
            // 
            this.accLNameLab.AutoSize = true;
            this.accLNameLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accLNameLab.Location = new System.Drawing.Point(221, 178);
            this.accLNameLab.Name = "accLNameLab";
            this.accLNameLab.Size = new System.Drawing.Size(195, 39);
            this.accLNameLab.TabIndex = 16;
            this.accLNameLab.Text = "Last Name:";
            // 
            // accLNameBox
            // 
            this.accLNameBox.BackColor = System.Drawing.SystemColors.Window;
            this.accLNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accLNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.accLNameBox.Location = new System.Drawing.Point(422, 186);
            this.accLNameBox.Name = "accLNameBox";
            this.accLNameBox.Size = new System.Drawing.Size(237, 31);
            this.accLNameBox.TabIndex = 17;
            this.accLNameBox.Text = "last name";
            // 
            // accEmailLab
            // 
            this.accEmailLab.AutoSize = true;
            this.accEmailLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accEmailLab.Location = new System.Drawing.Point(301, 233);
            this.accEmailLab.Name = "accEmailLab";
            this.accEmailLab.Size = new System.Drawing.Size(115, 39);
            this.accEmailLab.TabIndex = 18;
            this.accEmailLab.Text = "Email:";
            // 
            // accEmailBox
            // 
            this.accEmailBox.BackColor = System.Drawing.SystemColors.Window;
            this.accEmailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accEmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.accEmailBox.Location = new System.Drawing.Point(422, 241);
            this.accEmailBox.Name = "accEmailBox";
            this.accEmailBox.Size = new System.Drawing.Size(354, 31);
            this.accEmailBox.TabIndex = 19;
            this.accEmailBox.Text = "your@email.com";
            // 
            // accPasswordButton
            // 
            this.accPasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(66)))));
            this.accPasswordButton.FlatAppearance.BorderSize = 0;
            this.accPasswordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(25)))));
            this.accPasswordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(48)))));
            this.accPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accPasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accPasswordButton.Location = new System.Drawing.Point(387, 315);
            this.accPasswordButton.Name = "accPasswordButton";
            this.accPasswordButton.Size = new System.Drawing.Size(150, 32);
            this.accPasswordButton.TabIndex = 20;
            this.accPasswordButton.Text = "Change Password";
            this.accPasswordButton.UseVisualStyleBackColor = false;
            this.accPasswordButton.Click += new System.EventHandler(this.accPasswordButton_Click);
            // 
            // accSaveBox
            // 
            this.accSaveBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(66)))));
            this.accSaveBox.FlatAppearance.BorderSize = 0;
            this.accSaveBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(25)))));
            this.accSaveBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(48)))));
            this.accSaveBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accSaveBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.accSaveBox.Location = new System.Drawing.Point(387, 486);
            this.accSaveBox.Name = "accSaveBox";
            this.accSaveBox.Size = new System.Drawing.Size(150, 50);
            this.accSaveBox.TabIndex = 21;
            this.accSaveBox.Text = "Save Changes";
            this.accSaveBox.UseVisualStyleBackColor = false;
            this.accSaveBox.Click += new System.EventHandler(this.AccSaveBox_Click);
            // 
            // accLogoutBut
            // 
            this.accLogoutBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(66)))));
            this.accLogoutBut.FlatAppearance.BorderSize = 0;
            this.accLogoutBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(25)))));
            this.accLogoutBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(48)))));
            this.accLogoutBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accLogoutBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accLogoutBut.Location = new System.Drawing.Point(581, 504);
            this.accLogoutBut.Name = "accLogoutBut";
            this.accLogoutBut.Size = new System.Drawing.Size(150, 32);
            this.accLogoutBut.TabIndex = 22;
            this.accLogoutBut.Text = "Logout";
            this.accLogoutBut.UseVisualStyleBackColor = false;
            this.accLogoutBut.Click += new System.EventHandler(this.Button1_Click);
            // 
            // accNavBar
            // 
            this.accNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.accNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.accNavBar.Location = new System.Drawing.Point(0, 0);
            this.accNavBar.Name = "accNavBar";
            this.accNavBar.Size = new System.Drawing.Size(150, 600);
            this.accNavBar.TabIndex = 0;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(102)))));
            this.Controls.Add(this.accLogoutBut);
            this.Controls.Add(this.accSaveBox);
            this.Controls.Add(this.accPasswordButton);
            this.Controls.Add(this.accEmailBox);
            this.Controls.Add(this.accEmailLab);
            this.Controls.Add(this.accLNameBox);
            this.Controls.Add(this.accLNameLab);
            this.Controls.Add(this.accFNameBox);
            this.Controls.Add(this.accFNameLab);
            this.Controls.Add(this.accAccLab);
            this.Controls.Add(this.accNavBar);
            this.Name = "Account";
            this.Size = new System.Drawing.Size(800, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NavBar accNavBar;
        private System.Windows.Forms.Label accAccLab;
        private System.Windows.Forms.Label accFNameLab;
        private System.Windows.Forms.TextBox accFNameBox;
        private System.Windows.Forms.Label accLNameLab;
        private System.Windows.Forms.TextBox accLNameBox;
        private System.Windows.Forms.Label accEmailLab;
        private System.Windows.Forms.TextBox accEmailBox;
        private System.Windows.Forms.Button accPasswordButton;
        private System.Windows.Forms.Button accSaveBox;
        private System.Windows.Forms.Button accLogoutBut;
    }
}
