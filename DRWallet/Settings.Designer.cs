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
            this.setThemeLab = new System.Windows.Forms.Label();
            this.setThemeBox = new System.Windows.Forms.ComboBox();
            this.setSaveBox = new System.Windows.Forms.Button();
            this.setNavBar = new DRWallet.NavBar();
            this.SuspendLayout();
            // 
            // setSetLab
            // 
            this.setSetLab.AutoSize = true;
            this.setSetLab.BackColor = System.Drawing.Color.Transparent;
            this.setSetLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F);
            this.setSetLab.Location = new System.Drawing.Point(155, 5);
            this.setSetLab.Name = "setSetLab";
            this.setSetLab.Size = new System.Drawing.Size(231, 64);
            this.setSetLab.TabIndex = 14;
            this.setSetLab.Text = "Settings";
            // 
            // setLangLab
            // 
            this.setLangLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setLangLab.AutoSize = true;
            this.setLangLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setLangLab.Location = new System.Drawing.Point(279, 164);
            this.setLangLab.Name = "setLangLab";
            this.setLangLab.Size = new System.Drawing.Size(179, 39);
            this.setLangLab.TabIndex = 15;
            this.setLangLab.Text = "Language:";
            this.setLangLab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // setLangBox
            // 
            this.setLangBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setLangBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.setLangBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setLangBox.FormattingEnabled = true;
            this.setLangBox.Items.AddRange(new object[] {
            "English",
            "Portuguese"});
            this.setLangBox.Location = new System.Drawing.Point(464, 192);
            this.setLangBox.Name = "setLangBox";
            this.setLangBox.Size = new System.Drawing.Size(142, 33);
            this.setLangBox.TabIndex = 16;
            this.setLangBox.Text = "Language";
            // 
            // setThemeLab
            // 
            this.setThemeLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setThemeLab.AutoSize = true;
            this.setThemeLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setThemeLab.Location = new System.Drawing.Point(323, 224);
            this.setThemeLab.Name = "setThemeLab";
            this.setThemeLab.Size = new System.Drawing.Size(135, 39);
            this.setThemeLab.TabIndex = 17;
            this.setThemeLab.Text = "Theme:";
            this.setThemeLab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // setThemeBox
            // 
            this.setThemeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setThemeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setThemeBox.FormattingEnabled = true;
            this.setThemeBox.Items.AddRange(new object[] {
            "DRWallet",
            "Dark",
            "Light"});
            this.setThemeBox.Location = new System.Drawing.Point(464, 250);
            this.setThemeBox.Name = "setThemeBox";
            this.setThemeBox.Size = new System.Drawing.Size(142, 33);
            this.setThemeBox.TabIndex = 18;
            this.setThemeBox.Text = "Theme";
            // 
            // setSaveBox
            // 
            this.setSaveBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(66)))));
            this.setSaveBox.FlatAppearance.BorderSize = 0;
            this.setSaveBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(25)))));
            this.setSaveBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(48)))));
            this.setSaveBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setSaveBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setSaveBox.Location = new System.Drawing.Point(387, 486);
            this.setSaveBox.Name = "setSaveBox";
            this.setSaveBox.Size = new System.Drawing.Size(150, 50);
            this.setSaveBox.TabIndex = 22;
            this.setSaveBox.Text = "Save Changes";
            this.setSaveBox.UseVisualStyleBackColor = false;
            this.setSaveBox.Click += new System.EventHandler(this.AccSaveBox_Click);
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
            this.Controls.Add(this.setSaveBox);
            this.Controls.Add(this.setThemeBox);
            this.Controls.Add(this.setThemeLab);
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
        private System.Windows.Forms.Label setThemeLab;
        private System.Windows.Forms.ComboBox setThemeBox;
        private System.Windows.Forms.Button setSaveBox;
    }
}
