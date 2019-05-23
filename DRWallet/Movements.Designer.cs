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
            this.panel1 = new System.Windows.Forms.Panel();
            this.movHistoryInfoLab = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.movHistoryGrid = new System.Windows.Forms.DataGridView();
            this.Icon = new System.Windows.Forms.DataGridViewImageColumn();
            this.accountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oAccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movMovLab = new System.Windows.Forms.Label();
            this.movNavBar = new DRWallet.NavBar();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movHistoryGrid)).BeginInit();
            this.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(615, 452);
            this.panel2.TabIndex = 10;
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
            this.movHistoryGrid.Size = new System.Drawing.Size(615, 452);
            this.movHistoryGrid.TabIndex = 10;
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
            // movMovLab
            // 
            this.movMovLab.AutoSize = true;
            this.movMovLab.BackColor = System.Drawing.Color.Transparent;
            this.movMovLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F);
            this.movMovLab.Location = new System.Drawing.Point(155, 5);
            this.movMovLab.Name = "movMovLab";
            this.movMovLab.Size = new System.Drawing.Size(318, 64);
            this.movMovLab.TabIndex = 11;
            this.movMovLab.Text = "Movements";
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
        private System.Windows.Forms.Label movMovLab;
        private System.Windows.Forms.DataGridView movHistoryGrid;
        private System.Windows.Forms.DataGridViewImageColumn Icon;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn details;
        private System.Windows.Forms.DataGridViewTextBoxColumn oAccountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}
