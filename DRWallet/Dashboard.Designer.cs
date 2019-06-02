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
            this.dashDRCoinLab = new System.Windows.Forms.Label();
            this.dashValueLab = new System.Windows.Forms.Label();
            this.dashHistoryLab = new System.Windows.Forms.Label();
            this.movHistoryGrid = new System.Windows.Forms.DataGridView();
            this.Icon = new System.Windows.Forms.DataGridViewImageColumn();
            this.accountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oAccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dashHistoryInfoLab_Date = new System.Windows.Forms.Label();
            this.dashHistoryInfoLab_AID = new System.Windows.Forms.Label();
            this.dashHistoryInfoLab_Details = new System.Windows.Forms.Label();
            this.dashHistoryInfoLab_YAID = new System.Windows.Forms.Label();
            this.dashNavBar = new DRWallet.NavBar();
            ((System.ComponentModel.ISupportInitialize)(this.movHistoryGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashUsernameLab
            // 
            this.dashUsernameLab.AutoSize = true;
            this.dashUsernameLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F);
            this.dashUsernameLab.Location = new System.Drawing.Point(156, 7);
            this.dashUsernameLab.Name = "dashUsernameLab";
            this.dashUsernameLab.Size = new System.Drawing.Size(277, 64);
            this.dashUsernameLab.TabIndex = 1;
            this.dashUsernameLab.Text = "username";
            // 
            // dashBalanceLab
            // 
            this.dashBalanceLab.AutoSize = true;
            this.dashBalanceLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashBalanceLab.Location = new System.Drawing.Point(166, 109);
            this.dashBalanceLab.Name = "dashBalanceLab";
            this.dashBalanceLab.Size = new System.Drawing.Size(287, 39);
            this.dashBalanceLab.TabIndex = 2;
            this.dashBalanceLab.Text = "Balance: 0,00 DR";
            // 
            // dashSendButton
            // 
            this.dashSendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(66)))));
            this.dashSendButton.FlatAppearance.BorderSize = 0;
            this.dashSendButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(25)))));
            this.dashSendButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(48)))));
            this.dashSendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashSendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.dashSendButton.Location = new System.Drawing.Point(249, 177);
            this.dashSendButton.Name = "dashSendButton";
            this.dashSendButton.Size = new System.Drawing.Size(114, 38);
            this.dashSendButton.TabIndex = 3;
            this.dashSendButton.Text = "Send";
            this.dashSendButton.UseVisualStyleBackColor = false;
            this.dashSendButton.Click += new System.EventHandler(this.DashSendButton_Click);
            // 
            // dashDRCoinLab
            // 
            this.dashDRCoinLab.AutoSize = true;
            this.dashDRCoinLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashDRCoinLab.Location = new System.Drawing.Point(498, 109);
            this.dashDRCoinLab.Name = "dashDRCoinLab";
            this.dashDRCoinLab.Size = new System.Drawing.Size(254, 39);
            this.dashDRCoinLab.TabIndex = 5;
            this.dashDRCoinLab.Text = "DR Coin Value:";
            // 
            // dashValueLab
            // 
            this.dashValueLab.AutoSize = true;
            this.dashValueLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.dashValueLab.Location = new System.Drawing.Point(547, 169);
            this.dashValueLab.Name = "dashValueLab";
            this.dashValueLab.Size = new System.Drawing.Size(103, 39);
            this.dashValueLab.TabIndex = 6;
            this.dashValueLab.Text = "0,00€";
            this.dashValueLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dashHistoryLab
            // 
            this.dashHistoryLab.AutoSize = true;
            this.dashHistoryLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.dashHistoryLab.Location = new System.Drawing.Point(160, 239);
            this.dashHistoryLab.Name = "dashHistoryLab";
            this.dashHistoryLab.Size = new System.Drawing.Size(137, 39);
            this.dashHistoryLab.TabIndex = 7;
            this.dashHistoryLab.Text = "History:";
            // 
            // movHistoryGrid
            // 
            this.movHistoryGrid.AllowUserToAddRows = false;
            this.movHistoryGrid.AllowUserToDeleteRows = false;
            this.movHistoryGrid.AllowUserToResizeColumns = false;
            this.movHistoryGrid.AllowUserToResizeRows = false;
            this.movHistoryGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(79)))));
            this.movHistoryGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.movHistoryGrid.ColumnHeadersHeight = 37;
            this.movHistoryGrid.ColumnHeadersVisible = false;
            this.movHistoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Icon,
            this.accountID,
            this.details,
            this.oAccountID,
            this.date});
            this.movHistoryGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movHistoryGrid.Location = new System.Drawing.Point(0, 0);
            this.movHistoryGrid.MultiSelect = false;
            this.movHistoryGrid.Name = "movHistoryGrid";
            this.movHistoryGrid.ReadOnly = true;
            this.movHistoryGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.movHistoryGrid.RowHeadersVisible = false;
            this.movHistoryGrid.RowTemplate.Height = 32;
            this.movHistoryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.movHistoryGrid.ShowCellErrors = false;
            this.movHistoryGrid.ShowCellToolTips = false;
            this.movHistoryGrid.ShowEditingIcon = false;
            this.movHistoryGrid.ShowRowErrors = false;
            this.movHistoryGrid.Size = new System.Drawing.Size(615, 234);
            this.movHistoryGrid.TabIndex = 9;
            // 
            // Icon
            // 
            this.Icon.DataPropertyName = "Image";
            this.Icon.HeaderText = "";
            this.Icon.Name = "Icon";
            this.Icon.ReadOnly = true;
            this.Icon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Icon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // accountID
            // 
            this.accountID.DataPropertyName = "MyAddress";
            this.accountID.HeaderText = "Your Account ID";
            this.accountID.Name = "accountID";
            this.accountID.ReadOnly = true;
            this.accountID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // details
            // 
            this.details.DataPropertyName = "Details";
            this.details.HeaderText = "Details";
            this.details.Name = "details";
            this.details.ReadOnly = true;
            this.details.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // oAccountID
            // 
            this.oAccountID.DataPropertyName = "OtherAddress";
            this.oAccountID.HeaderText = "Account ID";
            this.oAccountID.Name = "oAccountID";
            this.oAccountID.ReadOnly = true;
            this.oAccountID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // date
            // 
            this.date.DataPropertyName = "Date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.movHistoryGrid);
            this.panel2.Location = new System.Drawing.Point(156, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 234);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.dashHistoryInfoLab_Date);
            this.panel1.Controls.Add(this.dashHistoryInfoLab_AID);
            this.panel1.Controls.Add(this.dashHistoryInfoLab_Details);
            this.panel1.Controls.Add(this.dashHistoryInfoLab_YAID);
            this.panel1.Location = new System.Drawing.Point(156, 284);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 37);
            this.panel1.TabIndex = 11;
            // 
            // dashHistoryInfoLab_Date
            // 
            this.dashHistoryInfoLab_Date.AutoSize = true;
            this.dashHistoryInfoLab_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashHistoryInfoLab_Date.Location = new System.Drawing.Point(530, 5);
            this.dashHistoryInfoLab_Date.Name = "dashHistoryInfoLab_Date";
            this.dashHistoryInfoLab_Date.Size = new System.Drawing.Size(48, 24);
            this.dashHistoryInfoLab_Date.TabIndex = 12;
            this.dashHistoryInfoLab_Date.Text = "Date";
            this.dashHistoryInfoLab_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dashHistoryInfoLab_AID
            // 
            this.dashHistoryInfoLab_AID.AutoSize = true;
            this.dashHistoryInfoLab_AID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashHistoryInfoLab_AID.Location = new System.Drawing.Point(359, 5);
            this.dashHistoryInfoLab_AID.Name = "dashHistoryInfoLab_AID";
            this.dashHistoryInfoLab_AID.Size = new System.Drawing.Size(102, 24);
            this.dashHistoryInfoLab_AID.TabIndex = 11;
            this.dashHistoryInfoLab_AID.Text = "Account ID";
            this.dashHistoryInfoLab_AID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dashHistoryInfoLab_Details
            // 
            this.dashHistoryInfoLab_Details.AutoSize = true;
            this.dashHistoryInfoLab_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashHistoryInfoLab_Details.Location = new System.Drawing.Point(232, 5);
            this.dashHistoryInfoLab_Details.Name = "dashHistoryInfoLab_Details";
            this.dashHistoryInfoLab_Details.Size = new System.Drawing.Size(65, 24);
            this.dashHistoryInfoLab_Details.TabIndex = 10;
            this.dashHistoryInfoLab_Details.Text = "Details";
            this.dashHistoryInfoLab_Details.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dashHistoryInfoLab_YAID
            // 
            this.dashHistoryInfoLab_YAID.AutoSize = true;
            this.dashHistoryInfoLab_YAID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashHistoryInfoLab_YAID.Location = new System.Drawing.Point(39, 5);
            this.dashHistoryInfoLab_YAID.Name = "dashHistoryInfoLab_YAID";
            this.dashHistoryInfoLab_YAID.Size = new System.Drawing.Size(147, 24);
            this.dashHistoryInfoLab_YAID.TabIndex = 9;
            this.dashHistoryInfoLab_YAID.Text = "Your Account ID";
            this.dashHistoryInfoLab_YAID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Controls.Add(this.dashSendButton);
            this.Controls.Add(this.dashBalanceLab);
            this.Controls.Add(this.dashUsernameLab);
            this.Controls.Add(this.dashNavBar);
            this.Controls.Add(this.panel2);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.movHistoryGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NavBar dashNavBar;
        private System.Windows.Forms.Label dashUsernameLab;
        private System.Windows.Forms.Label dashBalanceLab;
        private System.Windows.Forms.Button dashSendButton;
        private System.Windows.Forms.Label dashDRCoinLab;
        private System.Windows.Forms.Label dashValueLab;
        private System.Windows.Forms.Label dashHistoryLab;
        private System.Windows.Forms.DataGridView movHistoryGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewImageColumn Icon;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn details;
        private System.Windows.Forms.DataGridViewTextBoxColumn oAccountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dashHistoryInfoLab_Date;
        private System.Windows.Forms.Label dashHistoryInfoLab_AID;
        private System.Windows.Forms.Label dashHistoryInfoLab_Details;
        private System.Windows.Forms.Label dashHistoryInfoLab_YAID;
    }
}
