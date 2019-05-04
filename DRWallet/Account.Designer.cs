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
            this.accNavBar = new DRWallet.NavBar();
            this.accAccLab = new System.Windows.Forms.Label();
            this.accFNameLab = new System.Windows.Forms.Label();
            this.accFNameBox = new System.Windows.Forms.TextBox();
            this.accLNameLab = new System.Windows.Forms.Label();
            this.accLNameBox = new System.Windows.Forms.TextBox();
            this.accEmailLab = new System.Windows.Forms.Label();
            this.accEmailBox = new System.Windows.Forms.TextBox();
            this.assPasswordButton = new System.Windows.Forms.Button();
            this.accSaveBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // accAccLab
            // 
            this.accAccLab.AutoSize = true;
            this.accAccLab.BackColor = System.Drawing.Color.Transparent;
            this.accAccLab.Font = new System.Drawing.Font("Gill Sans MT", 58F);
            this.accAccLab.Location = new System.Drawing.Point(152, -8);
            this.accAccLab.Name = "accAccLab";
            this.accAccLab.Size = new System.Drawing.Size(312, 107);
            this.accAccLab.TabIndex = 13;
            this.accAccLab.Text = "Account";
            // 
            // accFNameLab
            // 
            this.accFNameLab.AutoSize = true;
            this.accFNameLab.Font = new System.Drawing.Font("Gill Sans MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accFNameLab.Location = new System.Drawing.Point(173, 151);
            this.accFNameLab.Name = "accFNameLab";
            this.accFNameLab.Size = new System.Drawing.Size(187, 48);
            this.accFNameLab.TabIndex = 14;
            this.accFNameLab.Text = "First Name:";
            // 
            // accFNameBox
            // 
            this.accFNameBox.BackColor = System.Drawing.SystemColors.Window;
            this.accFNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accFNameBox.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accFNameBox.Location = new System.Drawing.Point(360, 160);
            this.accFNameBox.Name = "accFNameBox";
            this.accFNameBox.Size = new System.Drawing.Size(237, 35);
            this.accFNameBox.TabIndex = 15;
            this.accFNameBox.Text = "first name";
            // 
            // accLNameLab
            // 
            this.accLNameLab.AutoSize = true;
            this.accLNameLab.Font = new System.Drawing.Font("Gill Sans MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accLNameLab.Location = new System.Drawing.Point(173, 212);
            this.accLNameLab.Name = "accLNameLab";
            this.accLNameLab.Size = new System.Drawing.Size(181, 48);
            this.accLNameLab.TabIndex = 16;
            this.accLNameLab.Text = "Last Name:";
            // 
            // accLNameBox
            // 
            this.accLNameBox.BackColor = System.Drawing.SystemColors.Window;
            this.accLNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accLNameBox.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accLNameBox.Location = new System.Drawing.Point(360, 225);
            this.accLNameBox.Name = "accLNameBox";
            this.accLNameBox.Size = new System.Drawing.Size(237, 35);
            this.accLNameBox.TabIndex = 17;
            this.accLNameBox.Text = "last name";
            // 
            // accEmailLab
            // 
            this.accEmailLab.AutoSize = true;
            this.accEmailLab.Font = new System.Drawing.Font("Gill Sans MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accEmailLab.Location = new System.Drawing.Point(173, 275);
            this.accEmailLab.Name = "accEmailLab";
            this.accEmailLab.Size = new System.Drawing.Size(104, 48);
            this.accEmailLab.TabIndex = 18;
            this.accEmailLab.Text = "Email:";
            // 
            // accEmailBox
            // 
            this.accEmailBox.BackColor = System.Drawing.SystemColors.Window;
            this.accEmailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accEmailBox.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accEmailBox.Location = new System.Drawing.Point(283, 284);
            this.accEmailBox.Name = "accEmailBox";
            this.accEmailBox.Size = new System.Drawing.Size(314, 35);
            this.accEmailBox.TabIndex = 19;
            this.accEmailBox.Text = "your@email.com";
            // 
            // assPasswordButton
            // 
            this.assPasswordButton.Location = new System.Drawing.Point(319, 351);
            this.assPasswordButton.Name = "assPasswordButton";
            this.assPasswordButton.Size = new System.Drawing.Size(116, 23);
            this.assPasswordButton.TabIndex = 20;
            this.assPasswordButton.Text = "Change Password";
            this.assPasswordButton.UseVisualStyleBackColor = true;
            // 
            // accSaveBox
            // 
            this.accSaveBox.Location = new System.Drawing.Point(401, 520);
            this.accSaveBox.Name = "accSaveBox";
            this.accSaveBox.Size = new System.Drawing.Size(116, 23);
            this.accSaveBox.TabIndex = 21;
            this.accSaveBox.Text = "Save Changes";
            this.accSaveBox.UseVisualStyleBackColor = true;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(102)))));
            this.Controls.Add(this.accSaveBox);
            this.Controls.Add(this.assPasswordButton);
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
        private System.Windows.Forms.Button assPasswordButton;
        private System.Windows.Forms.Button accSaveBox;
    }
}
