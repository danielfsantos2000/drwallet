namespace DRWallet
{
    partial class Send
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Send));
            this.sendHeaderLab = new System.Windows.Forms.Label();
            this.sendYALab = new System.Windows.Forms.Label();
            this.sendTABox = new System.Windows.Forms.TextBox();
            this.sendYACombo = new System.Windows.Forms.ComboBox();
            this.sendTALab = new System.Windows.Forms.Label();
            this.SendValLab = new System.Windows.Forms.Label();
            this.sendValBox = new System.Windows.Forms.TextBox();
            this.sendSubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sendHeaderLab
            // 
            this.sendHeaderLab.AutoSize = true;
            this.sendHeaderLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F);
            this.sendHeaderLab.Location = new System.Drawing.Point(183, 9);
            this.sendHeaderLab.Name = "sendHeaderLab";
            this.sendHeaderLab.Size = new System.Drawing.Size(123, 51);
            this.sendHeaderLab.TabIndex = 1;
            this.sendHeaderLab.Text = "Send";
            // 
            // sendYALab
            // 
            this.sendYALab.AutoSize = true;
            this.sendYALab.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.sendYALab.Location = new System.Drawing.Point(97, 94);
            this.sendYALab.Name = "sendYALab";
            this.sendYALab.Size = new System.Drawing.Size(151, 26);
            this.sendYALab.TabIndex = 2;
            this.sendYALab.Text = "Your Address:";
            // 
            // sendTABox
            // 
            this.sendTABox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.sendTABox.Location = new System.Drawing.Point(252, 141);
            this.sendTABox.Name = "sendTABox";
            this.sendTABox.Size = new System.Drawing.Size(199, 29);
            this.sendTABox.TabIndex = 5;
            this.sendTABox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SupressKeysNumb);
            this.sendTABox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SupressKeysNumb);
            // 
            // sendYACombo
            // 
            this.sendYACombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.sendYACombo.FormattingEnabled = true;
            this.sendYACombo.Location = new System.Drawing.Point(252, 93);
            this.sendYACombo.Name = "sendYACombo";
            this.sendYACombo.Size = new System.Drawing.Size(199, 32);
            this.sendYACombo.TabIndex = 6;
            this.sendYACombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SupressKeys);
            this.sendYACombo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SupressKeys);
            // 
            // sendTALab
            // 
            this.sendTALab.AutoSize = true;
            this.sendTALab.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.sendTALab.Location = new System.Drawing.Point(83, 142);
            this.sendTALab.Name = "sendTALab";
            this.sendTALab.Size = new System.Drawing.Size(165, 26);
            this.sendTALab.TabIndex = 7;
            this.sendTALab.Text = "Target Address:";
            // 
            // SendValLab
            // 
            this.SendValLab.AutoSize = true;
            this.SendValLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.SendValLab.Location = new System.Drawing.Point(172, 187);
            this.SendValLab.Name = "SendValLab";
            this.SendValLab.Size = new System.Drawing.Size(74, 26);
            this.SendValLab.TabIndex = 8;
            this.SendValLab.Text = "Value:";
            // 
            // sendValBox
            // 
            this.sendValBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.sendValBox.Location = new System.Drawing.Point(252, 186);
            this.sendValBox.Name = "sendValBox";
            this.sendValBox.Size = new System.Drawing.Size(199, 29);
            this.sendValBox.TabIndex = 9;
            this.sendValBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SupressKeysNumb);
            this.sendValBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SupressKeysNumb);
            // 
            // sendSubmitButton
            // 
            this.sendSubmitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(66)))));
            this.sendSubmitButton.FlatAppearance.BorderSize = 0;
            this.sendSubmitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(25)))));
            this.sendSubmitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(48)))));
            this.sendSubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendSubmitButton.Location = new System.Drawing.Point(185, 248);
            this.sendSubmitButton.Name = "sendSubmitButton";
            this.sendSubmitButton.Size = new System.Drawing.Size(117, 35);
            this.sendSubmitButton.TabIndex = 10;
            this.sendSubmitButton.Text = "Send";
            this.sendSubmitButton.UseVisualStyleBackColor = false;
            this.sendSubmitButton.Click += new System.EventHandler(this.SendSubmitButton_Click);
            // 
            // Send
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(487, 293);
            this.Controls.Add(this.sendSubmitButton);
            this.Controls.Add(this.sendValBox);
            this.Controls.Add(this.SendValLab);
            this.Controls.Add(this.sendTALab);
            this.Controls.Add(this.sendYACombo);
            this.Controls.Add(this.sendTABox);
            this.Controls.Add(this.sendYALab);
            this.Controls.Add(this.sendHeaderLab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Send";
            this.Text = "Send - DRWallet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sendHeaderLab;
        private System.Windows.Forms.Label sendYALab;
        private System.Windows.Forms.TextBox sendTABox;
        private System.Windows.Forms.ComboBox sendYACombo;
        private System.Windows.Forms.Label sendTALab;
        private System.Windows.Forms.Label SendValLab;
        private System.Windows.Forms.TextBox sendValBox;
        private System.Windows.Forms.Button sendSubmitButton;
    }
}