namespace DRWallet
{
    partial class RemoveAddress
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
            this.cpwdTitleLab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.remAddBox = new System.Windows.Forms.ComboBox();
            this.remAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cpwdTitleLab
            // 
            this.cpwdTitleLab.AutoSize = true;
            this.cpwdTitleLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F);
            this.cpwdTitleLab.Location = new System.Drawing.Point(68, 9);
            this.cpwdTitleLab.Name = "cpwdTitleLab";
            this.cpwdTitleLab.Size = new System.Drawing.Size(353, 51);
            this.cpwdTitleLab.TabIndex = 1;
            this.cpwdTitleLab.Text = "Remove Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose your address:";
            // 
            // remAddBox
            // 
            this.remAddBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.remAddBox.FormatString = "N2";
            this.remAddBox.FormattingEnabled = true;
            this.remAddBox.Location = new System.Drawing.Point(156, 150);
            this.remAddBox.Name = "remAddBox";
            this.remAddBox.Size = new System.Drawing.Size(179, 33);
            this.remAddBox.TabIndex = 3;
            // 
            // remAddButton
            // 
            this.remAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(66)))));
            this.remAddButton.FlatAppearance.BorderSize = 0;
            this.remAddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(25)))));
            this.remAddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(48)))));
            this.remAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remAddButton.Location = new System.Drawing.Point(185, 219);
            this.remAddButton.Name = "remAddButton";
            this.remAddButton.Size = new System.Drawing.Size(117, 35);
            this.remAddButton.TabIndex = 8;
            this.remAddButton.Text = "Remove Address";
            this.remAddButton.UseVisualStyleBackColor = false;
            this.remAddButton.Click += new System.EventHandler(this.RemAddButton_Click);
            // 
            // RemoveAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(487, 293);
            this.Controls.Add(this.remAddButton);
            this.Controls.Add(this.remAddBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cpwdTitleLab);
            this.Name = "RemoveAddress";
            this.Text = "RemoveAddress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cpwdTitleLab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox remAddBox;
        private System.Windows.Forms.Button remAddButton;
    }
}