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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addAddLab = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addListInfoLab_YAID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addListGrid = new System.Windows.Forms.DataGridView();
            this.accountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addCreateButton = new System.Windows.Forms.Button();
            this.addRemoveButton = new System.Windows.Forms.Button();
            this.addNavBar = new DRWallet.NavBar();
            this.addListInfoLab_Bal = new System.Windows.Forms.Label();
            this.addListInfoLab_Date = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addAddLab
            // 
            this.addAddLab.AutoSize = true;
            this.addAddLab.BackColor = System.Drawing.Color.Transparent;
            this.addAddLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F);
            this.addAddLab.Location = new System.Drawing.Point(155, 5);
            this.addAddLab.Name = "addAddLab";
            this.addAddLab.Size = new System.Drawing.Size(292, 64);
            this.addAddLab.TabIndex = 12;
            this.addAddLab.Text = "Addresses";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.addListInfoLab_Date);
            this.panel1.Controls.Add(this.addListInfoLab_Bal);
            this.panel1.Controls.Add(this.addListInfoLab_YAID);
            this.panel1.Location = new System.Drawing.Point(156, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 37);
            this.panel1.TabIndex = 13;
            // 
            // addListInfoLab_YAID
            // 
            this.addListInfoLab_YAID.AutoSize = true;
            this.addListInfoLab_YAID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addListInfoLab_YAID.Location = new System.Drawing.Point(27, 6);
            this.addListInfoLab_YAID.Name = "addListInfoLab_YAID";
            this.addListInfoLab_YAID.Size = new System.Drawing.Size(147, 24);
            this.addListInfoLab_YAID.TabIndex = 9;
            this.addListInfoLab_YAID.Text = "Your Account ID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addListGrid);
            this.panel2.Location = new System.Drawing.Point(156, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 404);
            this.panel2.TabIndex = 11;
            // 
            // addListGrid
            // 
            this.addListGrid.AllowUserToAddRows = false;
            this.addListGrid.AllowUserToDeleteRows = false;
            this.addListGrid.AllowUserToResizeColumns = false;
            this.addListGrid.AllowUserToResizeRows = false;
            this.addListGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(79)))));
            this.addListGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addListGrid.ColumnHeadersVisible = false;
            this.addListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountID,
            this.balance,
            this.date});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.addListGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.addListGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addListGrid.Location = new System.Drawing.Point(0, 0);
            this.addListGrid.MultiSelect = false;
            this.addListGrid.Name = "addListGrid";
            this.addListGrid.ReadOnly = true;
            this.addListGrid.RowHeadersVisible = false;
            this.addListGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.addListGrid.RowTemplate.Height = 32;
            this.addListGrid.RowTemplate.ReadOnly = true;
            this.addListGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.addListGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.addListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addListGrid.ShowCellErrors = false;
            this.addListGrid.ShowCellToolTips = false;
            this.addListGrid.ShowEditingIcon = false;
            this.addListGrid.ShowRowErrors = false;
            this.addListGrid.Size = new System.Drawing.Size(615, 404);
            this.addListGrid.TabIndex = 11;
            // 
            // accountID
            // 
            this.accountID.DataPropertyName = "addnum";
            this.accountID.HeaderText = "Your Account ID";
            this.accountID.Name = "accountID";
            this.accountID.ReadOnly = true;
            this.accountID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // balance
            // 
            this.balance.DataPropertyName = "addbal";
            this.balance.HeaderText = "Balance";
            this.balance.Name = "balance";
            this.balance.ReadOnly = true;
            this.balance.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // date
            // 
            this.date.DataPropertyName = "addcreated";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // addCreateButton
            // 
            this.addCreateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(66)))));
            this.addCreateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addCreateButton.FlatAppearance.BorderSize = 0;
            this.addCreateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(25)))));
            this.addCreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCreateButton.Location = new System.Drawing.Point(611, 524);
            this.addCreateButton.Name = "addCreateButton";
            this.addCreateButton.Size = new System.Drawing.Size(160, 23);
            this.addCreateButton.TabIndex = 14;
            this.addCreateButton.Text = "Create Address";
            this.addCreateButton.UseVisualStyleBackColor = false;
            this.addCreateButton.Click += new System.EventHandler(this.AddCreateButton_Click);
            // 
            // addRemoveButton
            // 
            this.addRemoveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(66)))));
            this.addRemoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addRemoveButton.FlatAppearance.BorderSize = 0;
            this.addRemoveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(25)))));
            this.addRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRemoveButton.Location = new System.Drawing.Point(445, 524);
            this.addRemoveButton.Name = "addRemoveButton";
            this.addRemoveButton.Size = new System.Drawing.Size(160, 23);
            this.addRemoveButton.TabIndex = 15;
            this.addRemoveButton.Text = "Remove Address";
            this.addRemoveButton.UseVisualStyleBackColor = false;
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
            // addListInfoLab_Bal
            // 
            this.addListInfoLab_Bal.AutoSize = true;
            this.addListInfoLab_Bal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addListInfoLab_Bal.Location = new System.Drawing.Point(278, 6);
            this.addListInfoLab_Bal.Name = "addListInfoLab_Bal";
            this.addListInfoLab_Bal.Size = new System.Drawing.Size(78, 24);
            this.addListInfoLab_Bal.TabIndex = 10;
            this.addListInfoLab_Bal.Text = "Balance";
            // 
            // addListInfoLab_Date
            // 
            this.addListInfoLab_Date.AutoSize = true;
            this.addListInfoLab_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addListInfoLab_Date.Location = new System.Drawing.Point(497, 6);
            this.addListInfoLab_Date.Name = "addListInfoLab_Date";
            this.addListInfoLab_Date.Size = new System.Drawing.Size(48, 24);
            this.addListInfoLab_Date.TabIndex = 11;
            this.addListInfoLab_Date.Text = "Date";
            // 
            // Addresses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(102)))));
            this.Controls.Add(this.addRemoveButton);
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
        private System.Windows.Forms.Label addListInfoLab_YAID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView addListGrid;
        private System.Windows.Forms.Button addCreateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.Button addRemoveButton;
        private System.Windows.Forms.Label addListInfoLab_Date;
        private System.Windows.Forms.Label addListInfoLab_Bal;
    }
}
