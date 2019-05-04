namespace DRWallet
{
    partial class Addresses
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
            this.addNavBar = new DRWallet.NavBar();
            this.addAddLab = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addListInfoLab = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addListGrid = new System.Windows.Forms.DataGridView();
            this.accountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addCreateButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addNavBar
            // 
            this.addNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.addNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.addNavBar.Location = new System.Drawing.Point(0, 0);
            this.addNavBar.Name = "addNavBar";
            this.addNavBar.Size = new System.Drawing.Size(150, 600);
            this.addNavBar.TabIndex = 0;
            // 
            // addAddLab
            // 
            this.addAddLab.AutoSize = true;
            this.addAddLab.BackColor = System.Drawing.Color.Transparent;
            this.addAddLab.Font = new System.Drawing.Font("Gill Sans MT", 58F);
            this.addAddLab.Location = new System.Drawing.Point(152, -8);
            this.addAddLab.Name = "addAddLab";
            this.addAddLab.Size = new System.Drawing.Size(372, 107);
            this.addAddLab.TabIndex = 12;
            this.addAddLab.Text = "Addresses";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.addListInfoLab);
            this.panel1.Location = new System.Drawing.Point(156, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 37);
            this.panel1.TabIndex = 13;
            // 
            // addListInfoLab
            // 
            this.addListInfoLab.AutoSize = true;
            this.addListInfoLab.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addListInfoLab.Location = new System.Drawing.Point(25, 5);
            this.addListInfoLab.Name = "addListInfoLab";
            this.addListInfoLab.Size = new System.Drawing.Size(579, 27);
            this.addListInfoLab.TabIndex = 9;
            this.addListInfoLab.Text = "Your Account ID                  Balance                   Date                  " +
    " Settings";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addListGrid);
            this.panel2.Location = new System.Drawing.Point(156, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 429);
            this.panel2.TabIndex = 11;
            // 
            // addListGrid
            // 
            this.addListGrid.AllowUserToAddRows = false;
            this.addListGrid.AllowUserToDeleteRows = false;
            this.addListGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(79)))));
            this.addListGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountID,
            this.balance,
            this.date,
            this.settings});
            this.addListGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addListGrid.Location = new System.Drawing.Point(0, 0);
            this.addListGrid.Name = "addListGrid";
            this.addListGrid.ReadOnly = true;
            this.addListGrid.ShowCellErrors = false;
            this.addListGrid.ShowCellToolTips = false;
            this.addListGrid.ShowEditingIcon = false;
            this.addListGrid.ShowRowErrors = false;
            this.addListGrid.Size = new System.Drawing.Size(615, 429);
            this.addListGrid.TabIndex = 11;
            // 
            // accountID
            // 
            this.accountID.HeaderText = "Your Account ID";
            this.accountID.Name = "accountID";
            this.accountID.ReadOnly = true;
            // 
            // balance
            // 
            this.balance.HeaderText = "Balance";
            this.balance.Name = "balance";
            this.balance.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // settings
            // 
            this.settings.HeaderText = "Settings";
            this.settings.Name = "settings";
            this.settings.ReadOnly = true;
            // 
            // addCreateButton
            // 
            this.addCreateButton.Location = new System.Drawing.Point(611, 524);
            this.addCreateButton.Name = "addCreateButton";
            this.addCreateButton.Size = new System.Drawing.Size(160, 23);
            this.addCreateButton.TabIndex = 14;
            this.addCreateButton.Text = "Create Address";
            this.addCreateButton.UseVisualStyleBackColor = true;
            // 
            // Addresses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(102)))));
            this.Controls.Add(this.addCreateButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addAddLab);
            this.Controls.Add(this.addNavBar);
            this.Controls.Add(this.panel2);
            this.Name = "Addresses";
            this.Size = new System.Drawing.Size(800, 600);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addListGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NavBar addNavBar;
        private System.Windows.Forms.Label addAddLab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label addListInfoLab;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView addListGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn settings;
        private System.Windows.Forms.Button addCreateButton;
    }
}
