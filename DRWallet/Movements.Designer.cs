namespace DRWallet
{
    partial class Movements
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
            this.movNavBar = new DRWallet.NavBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.movHistoryInfoLab = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.movHistoryGrid = new System.Windows.Forms.DataGridView();
            this.Icon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oAccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movMovLab = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movHistoryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // movNavBar
            // 
            this.movNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.movNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.movNavBar.Location = new System.Drawing.Point(0, 0);
            this.movNavBar.Name = "movNavBar";
            this.movNavBar.Size = new System.Drawing.Size(150, 600);
            this.movNavBar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.movHistoryInfoLab);
            this.panel1.Location = new System.Drawing.Point(156, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 37);
            this.panel1.TabIndex = 9;
            // 
            // movHistoryInfoLab
            // 
            this.movHistoryInfoLab.AutoSize = true;
            this.movHistoryInfoLab.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movHistoryInfoLab.Location = new System.Drawing.Point(38, 5);
            this.movHistoryInfoLab.Name = "movHistoryInfoLab";
            this.movHistoryInfoLab.Size = new System.Drawing.Size(558, 27);
            this.movHistoryInfoLab.TabIndex = 9;
            this.movHistoryInfoLab.Text = "Your Account ID                Details               Account ID                Da" +
    "te";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.movHistoryGrid);
            this.panel2.Location = new System.Drawing.Point(156, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 496);
            this.panel2.TabIndex = 10;
            // 
            // movHistoryGrid
            // 
            this.movHistoryGrid.AllowUserToAddRows = false;
            this.movHistoryGrid.AllowUserToDeleteRows = false;
            this.movHistoryGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(79)))));
            this.movHistoryGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.movHistoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movHistoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Icon,
            this.accountID,
            this.details,
            this.oAccountID,
            this.date});
            this.movHistoryGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movHistoryGrid.Location = new System.Drawing.Point(0, 0);
            this.movHistoryGrid.Name = "movHistoryGrid";
            this.movHistoryGrid.ReadOnly = true;
            this.movHistoryGrid.ShowCellErrors = false;
            this.movHistoryGrid.ShowCellToolTips = false;
            this.movHistoryGrid.ShowEditingIcon = false;
            this.movHistoryGrid.ShowRowErrors = false;
            this.movHistoryGrid.Size = new System.Drawing.Size(615, 496);
            this.movHistoryGrid.TabIndex = 10;
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
            // movMovLab
            // 
            this.movMovLab.AutoSize = true;
            this.movMovLab.BackColor = System.Drawing.Color.Transparent;
            this.movMovLab.Font = new System.Drawing.Font("Gill Sans MT", 58F);
            this.movMovLab.Location = new System.Drawing.Point(152, -8);
            this.movMovLab.Name = "movMovLab";
            this.movMovLab.Size = new System.Drawing.Size(412, 107);
            this.movMovLab.TabIndex = 11;
            this.movMovLab.Text = "Movements";
            // 
            // Movements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(102)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.movNavBar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.movMovLab);
            this.Name = "Movements";
            this.Size = new System.Drawing.Size(800, 600);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.movHistoryGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NavBar movNavBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label movHistoryInfoLab;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView movHistoryGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Icon;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn details;
        private System.Windows.Forms.DataGridViewTextBoxColumn oAccountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.Label movMovLab;
    }
}
