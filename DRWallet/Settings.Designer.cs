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
            this.accNavBar = new DRWallet.NavBar();
            this.setSetLab = new System.Windows.Forms.Label();
            this.setLangLab = new System.Windows.Forms.Label();
            this.setLangCBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.setThemeCBox = new System.Windows.Forms.ComboBox();
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
            // setLangCBox
            // 
            this.setLangCBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setLangCBox.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setLangCBox.FormattingEnabled = true;
            this.setLangCBox.Items.AddRange(new object[] {
            "English",
            "Portuguese"});
            this.setLangCBox.Location = new System.Drawing.Point(337, 162);
            this.setLangCBox.Name = "setLangCBox";
            this.setLangCBox.Size = new System.Drawing.Size(142, 38);
            this.setLangCBox.TabIndex = 16;
            this.setLangCBox.Text = "Language";
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
            // setThemeCBox
            // 
            this.setThemeCBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setThemeCBox.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setThemeCBox.FormattingEnabled = true;
            this.setThemeCBox.Items.AddRange(new object[] {
            "DRWallet",
            "Dark",
            "Light"});
            this.setThemeCBox.Location = new System.Drawing.Point(337, 224);
            this.setThemeCBox.Name = "setThemeCBox";
            this.setThemeCBox.Size = new System.Drawing.Size(142, 38);
            this.setThemeCBox.TabIndex = 18;
            this.setThemeCBox.Text = "Theme";
            // 
            // accSaveBox
            // 
            this.accSaveBox.Location = new System.Drawing.Point(401, 520);
            this.accSaveBox.Name = "accSaveBox";
            this.accSaveBox.Size = new System.Drawing.Size(116, 23);
            this.accSaveBox.TabIndex = 22;
            this.accSaveBox.Text = "Save Changes";
            this.accSaveBox.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(102)))));
            this.Controls.Add(this.accSaveBox);
            this.Controls.Add(this.setThemeCBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setLangCBox);
            this.Controls.Add(this.setLangLab);
            this.Controls.Add(this.setSetLab);
            this.Controls.Add(this.accNavBar);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(800, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NavBar accNavBar;
        private System.Windows.Forms.Label setSetLab;
        private System.Windows.Forms.Label setLangLab;
        private System.Windows.Forms.ComboBox setLangCBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox setThemeCBox;
        private System.Windows.Forms.Button accSaveBox;
    }
}
