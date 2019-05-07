namespace DRWallet
{
    partial class Dashboard
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
            this.dashUsernameLab = new System.Windows.Forms.Label();
            this.dashBalanceLab = new System.Windows.Forms.Label();
            this.dashSendButton = new System.Windows.Forms.Button();
            this.dashReceiveButton = new System.Windows.Forms.Button();
            this.dashDRCoinLab = new System.Windows.Forms.Label();
            this.dashValueLab = new System.Windows.Forms.Label();
            this.dashHistoryLab = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dashHistoryInfoLab = new System.Windows.Forms.Label();
            this.dashHistoryGrid = new System.Windows.Forms.DataGridView();
            this.Icon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oAccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dashNavBar = new DRWallet.NavBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashHistoryGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashUsernameLab
            // 
            this.dashUsernameLab.AutoSize = true;
            this.dashUsernameLab.Font = new System.Drawing.Font("Gill Sans MT", 58F);
            this.dashUsernameLab.Location = new System.Drawing.Point(156, 7);
            this.dashUsernameLab.Name = "dashUsernameLab";
            this.dashUsernameLab.Size = new System.Drawing.Size(351, 107);
            this.dashUsernameLab.TabIndex = 1;
            this.dashUsernameLab.Text = "username";
            // 
            // dashBalanceLab
            // 
            this.dashBalanceLab.AutoSize = true;
            this.dashBalanceLab.Font = new System.Drawing.Font("Gill Sans MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashBalanceLab.Location = new System.Drawing.Point(166, 156);
            this.dashBalanceLab.Name = "dashBalanceLab";
            this.dashBalanceLab.Size = new System.Drawing.Size(265, 48);
            this.dashBalanceLab.TabIndex = 2;
            this.dashBalanceLab.Text = "Balance: 0,00 DR";
            // 
            // dashSendButton
            // 
            this.dashSendButton.Location = new System.Drawing.Point(178, 223);
            this.dashSendButton.Name = "dashSendButton";
            this.dashSendButton.Size = new System.Drawing.Size(114, 38);
            this.dashSendButton.TabIndex = 3;
            this.dashSendButton.Text = "Send";
            this.dashSendButton.UseVisualStyleBackColor = true;
            // 
            // dashReceiveButton
            // 
            this.dashReceiveButton.Location = new System.Drawing.Point(313, 223);
            this.dashReceiveButton.Name = "dashReceiveButton";
            this.dashReceiveButton.Size = new System.Drawing.Size(114, 38);
            this.dashReceiveButton.TabIndex = 4;
            this.dashReceiveButton.Text = "Receive";
            this.dashReceiveButton.UseVisualStyleBackColor = true;
            // 
            // dashDRCoinLab
            // 
            this.dashDRCoinLab.AutoSize = true;
            this.dashDRCoinLab.Font = new System.Drawing.Font("Gill Sans MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashDRCoinLab.Location = new System.Drawing.Point(498, 156);
            this.dashDRCoinLab.Name = "dashDRCoinLab";
            this.dashDRCoinLab.Size = new System.Drawing.Size(244, 48);
            this.dashDRCoinLab.TabIndex = 5;
            this.dashDRCoinLab.Text = "DR Coin Value:";
            // 
            // dashValueLab
            // 
            this.dashValueLab.AutoSize = true;
            this.dashValueLab.Font = new System.Drawing.Font("Gill Sans MT", 26.25F);
            this.dashValueLab.Location = new System.Drawing.Point(554, 214);
            this.dashValueLab.Name = "dashValueLab";
            this.dashValueLab.Size = new System.Drawing.Size(103, 48);
            this.dashValueLab.TabIndex = 6;
            this.dashValueLab.Text = "0,00€";
            this.dashValueLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dashHistoryLab
            // 
            this.dashHistoryLab.AutoSize = true;
            this.dashHistoryLab.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashHistoryLab.Location = new System.Drawing.Point(168, 288);
            this.dashHistoryLab.Name = "dashHistoryLab";
            this.dashHistoryLab.Size = new System.Drawing.Size(94, 34);
            this.dashHistoryLab.TabIndex = 7;
            this.dashHistoryLab.Text = "History:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.dashHistoryInfoLab);
            this.panel1.Location = new System.Drawing.Point(156, 325);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 37);
            this.panel1.TabIndex = 8;
            // 
            // dashHistoryInfoLab
            // 
            this.dashHistoryInfoLab.AutoSize = true;
            this.dashHistoryInfoLab.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashHistoryInfoLab.Location = new System.Drawing.Point(38, 5);
            this.dashHistoryInfoLab.Name = "dashHistoryInfoLab";
            this.dashHistoryInfoLab.Size = new System.Drawing.Size(558, 27);
            this.dashHistoryInfoLab.TabIndex = 9;
            this.dashHistoryInfoLab.Text = "Your Account ID                Details               Account ID                Da" +
    "te";
            // 
            // dashHistoryGrid
            // 
            this.dashHistoryGrid.AllowUserToAddRows = false;
            this.dashHistoryGrid.AllowUserToDeleteRows = false;
            this.dashHistoryGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(79)))));
            this.dashHistoryGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dashHistoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dashHistoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Icon,
            this.accountID,
            this.details,
            this.oAccountID,
            this.date});
            this.dashHistoryGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashHistoryGrid.Location = new System.Drawing.Point(0, 0);
            this.dashHistoryGrid.Name = "dashHistoryGrid";
            this.dashHistoryGrid.ReadOnly = true;
            this.dashHistoryGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dashHistoryGrid.RowHeadersVisible = false;
            this.dashHistoryGrid.ShowCellErrors = false;
            this.dashHistoryGrid.ShowCellToolTips = false;
            this.dashHistoryGrid.ShowEditingIcon = false;
            this.dashHistoryGrid.ShowRowErrors = false;
            this.dashHistoryGrid.Size = new System.Drawing.Size(615, 229);
            this.dashHistoryGrid.TabIndex = 9;
            // 
            // Icon
            // 
            this.Icon.HeaderText = "";
            this.Icon.Name = "Icon";
            this.Icon.ReadOnly = true;
            // 
            // accountID
            // 
            this.accountID.HeaderText = "Your Account ID";
            this.accountID.Name = "accountID";
            this.accountID.ReadOnly = true;
            // 
            // details
            // 
            this.details.HeaderText = "Details";
            this.details.Name = "details";
            this.details.ReadOnly = true;
            // 
            // oAccountID
            // 
            this.oAccountID.HeaderText = "Account ID";
            this.oAccountID.Name = "oAccountID";
            this.oAccountID.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dashHistoryGrid);
            this.panel2.Location = new System.Drawing.Point(156, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 229);
            this.panel2.TabIndex = 10;
            // 
            // dashNavBar
            // 
            this.dashNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.dashNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashNavBar.Location = new System.Drawing.Point(0, 0);
            this.dashNavBar.Name = "dashNavBar";
            this.dashNavBar.Size = new System.Drawing.Size(150, 600);
            this.dashNavBar.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(102)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dashHistoryLab);
            this.Controls.Add(this.dashValueLab);
            this.Controls.Add(this.dashDRCoinLab);
            this.Controls.Add(this.dashReceiveButton);
            this.Controls.Add(this.dashSendButton);
            this.Controls.Add(this.dashBalanceLab);
            this.Controls.Add(this.dashUsernameLab);
            this.Controls.Add(this.dashNavBar);
            this.Controls.Add(this.panel2);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(800, 600);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashHistoryGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NavBar dashNavBar;
        private System.Windows.Forms.Label dashUsernameLab;
        private System.Windows.Forms.Label dashBalanceLab;
        private System.Windows.Forms.Button dashSendButton;
        private System.Windows.Forms.Button dashReceiveButton;
        private System.Windows.Forms.Label dashDRCoinLab;
        private System.Windows.Forms.Label dashValueLab;
        private System.Windows.Forms.Label dashHistoryLab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dashHistoryInfoLab;
        private System.Windows.Forms.DataGridView dashHistoryGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Icon;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn details;
        private System.Windows.Forms.DataGridViewTextBoxColumn oAccountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}
