namespace DRWallet
{
    partial class Settings
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
            this.setSetLab = new System.Windows.Forms.Label();
            this.setLangLab = new System.Windows.Forms.Label();
            this.setLangBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.setThemeBox = new System.Windows.Forms.ComboBox();
            this.accSaveBox = new System.Windows.Forms.Button();
            this.setNavBar = new DRWallet.NavBar();
            this.SuspendLayout();
            // 
            // setSetLab
            // 
            this.setSetLab.AutoSize = true;
            this.setSetLab.BackColor = System.Drawing.Color.Transparent;
            this.setSetLab.Font = new System.Drawing.Font("Gill Sans MT", 58F);
            this.setSetLab.Location = new System.Drawing.Point(152, -8);
            this.setSetLab.Name = "setSetLab";
            this.setSetLab.Size = new System.Drawing.Size(289, 107);
            this.setSetLab.TabIndex = 14;
            this.setSetLab.Text = "Settings";
            // 
            // setLangLab
            // 
            this.setLangLab.AutoSize = true;
            this.setLangLab.Font = new System.Drawing.Font("Gill Sans MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setLangLab.Location = new System.Drawing.Point(173, 151);
            this.setLangLab.Name = "setLangLab";
            this.setLangLab.Size = new System.Drawing.Size(158, 48);
            this.setLangLab.TabIndex = 15;
            this.setLangLab.Text = "Language:";
            // 
            // setLangBox
            // 
            this.setLangBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setLangBox.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setLangBox.FormattingEnabled = true;
            this.setLangBox.Items.AddRange(new object[] {
            "English",
            "Portuguese"});
            this.setLangBox.Location = new System.Drawing.Point(337, 162);
            this.setLangBox.Name = "setLangBox";
            this.setLangBox.Size = new System.Drawing.Size(142, 38);
            this.setLangBox.TabIndex = 16;
            this.setLangBox.Text = "Language";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 48);
            this.label1.TabIndex = 17;
            this.label1.Text = "Theme:";
            // 
            // setThemeBox
            // 
            this.setThemeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setThemeBox.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setThemeBox.FormattingEnabled = true;
            this.setThemeBox.Items.AddRange(new object[] {
            "DRWallet",
            "Dark",
            "Light"});
            this.setThemeBox.Location = new System.Drawing.Point(337, 224);
            this.setThemeBox.Name = "setThemeBox";
            this.setThemeBox.Size = new System.Drawing.Size(142, 38);
            this.setThemeBox.TabIndex = 18;
            this.setThemeBox.Text = "Theme";
            // 
            // accSaveBox
            // 
            this.accSaveBox.Location = new System.Drawing.Point(401, 520);
            this.accSaveBox.Name = "accSaveBox";
            this.accSaveBox.Size = new System.Drawing.Size(116, 23);
            this.accSaveBox.TabIndex = 22;
            this.accSaveBox.Text = "Save Changes";
            this.accSaveBox.UseVisualStyleBackColor = true;
            this.accSaveBox.Click += new System.EventHandler(this.AccSaveBox_Click);
            // 
            // setNavBar
            // 
            this.setNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.setNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.setNavBar.Location = new System.Drawing.Point(0, 0);
            this.setNavBar.Name = "setNavBar";
            this.setNavBar.Size = new System.Drawing.Size(150, 600);
            this.setNavBar.TabIndex = 0;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(102)))));
            this.Controls.Add(this.accSaveBox);
            this.Controls.Add(this.setThemeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setLangBox);
            this.Controls.Add(this.setLangLab);
            this.Controls.Add(this.setSetLab);
            this.Controls.Add(this.setNavBar);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(800, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NavBar setNavBar;
        private System.Windows.Forms.Label setSetLab;
        private System.Windows.Forms.Label setLangLab;
        private System.Windows.Forms.ComboBox setLangBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox setThemeBox;
        private System.Windows.Forms.Button accSaveBox;
    }
}
