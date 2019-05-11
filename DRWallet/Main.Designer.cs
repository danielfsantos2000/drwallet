namespace DRWallet
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.loginPage = new DRWallet.Login();
            this.registerPage = new DRWallet.Register();
            this.dashboardPage = new DRWallet.Dashboard();
            this.movementsPage = new DRWallet.Movements();
            this.accountPage = new DRWallet.Account();
            this.addressesPage = new DRWallet.Addresses();
            this.settingsPage = new DRWallet.Settings();
            this.SuspendLayout();
            // 
            // loginPage
            // 
            this.loginPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(102)))));
            this.loginPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPage.Location = new System.Drawing.Point(0, 0);
            this.loginPage.Name = "loginPage";
            this.loginPage.Size = new System.Drawing.Size(784, 561);
            this.loginPage.TabIndex = 4;
            // 
            // registerPage
            // 
            this.registerPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(102)))));
            this.registerPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerPage.Location = new System.Drawing.Point(0, 0);
            this.registerPage.Name = "registerPage";
            this.registerPage.Size = new System.Drawing.Size(784, 561);
            this.registerPage.TabIndex = 5;
            this.registerPage.Visible = false;
            // 
            // dashboardPage
            // 
            this.dashboardPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(102)))));
            this.dashboardPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardPage.Location = new System.Drawing.Point(0, 0);
            this.dashboardPage.Name = "dashboardPage";
            this.dashboardPage.Size = new System.Drawing.Size(784, 561);
            this.dashboardPage.TabIndex = 7;
            this.dashboardPage.Visible = false;
            // 
            // movementsPage
            // 
            this.movementsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(102)))));
            this.movementsPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movementsPage.Location = new System.Drawing.Point(0, 0);
            this.movementsPage.Name = "movementsPage";
            this.movementsPage.Size = new System.Drawing.Size(784, 561);
            this.movementsPage.TabIndex = 9;
            this.movementsPage.Visible = false;
            // 
            // accountPage
            // 
            this.accountPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(102)))));
            this.accountPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountPage.Location = new System.Drawing.Point(0, 0);
            this.accountPage.Name = "accountPage";
            this.accountPage.Size = new System.Drawing.Size(784, 561);
            this.accountPage.TabIndex = 10;
            this.accountPage.Visible = false;
            // 
            // addressesPage
            // 
            this.addressesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(102)))));
            this.addressesPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressesPage.Location = new System.Drawing.Point(0, 0);
            this.addressesPage.Name = "addressesPage";
            this.addressesPage.Size = new System.Drawing.Size(784, 561);
            this.addressesPage.TabIndex = 11;
            this.addressesPage.Visible = false;
            // 
            // settingsPage
            // 
            this.settingsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(102)))));
            this.settingsPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPage.Location = new System.Drawing.Point(0, 0);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Size = new System.Drawing.Size(784, 561);
            this.settingsPage.TabIndex = 12;
            this.settingsPage.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.loginPage);
            this.Controls.Add(this.registerPage);
            this.Controls.Add(this.dashboardPage);
            this.Controls.Add(this.movementsPage);
            this.Controls.Add(this.accountPage);
            this.Controls.Add(this.addressesPage);
            this.Controls.Add(this.settingsPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "DR Wallet";
            this.ResumeLayout(false);

        }

        #endregion

        private Login loginPage;
        private Register registerPage;
        private Dashboard dashboardPage;
        private Movements movementsPage;
        private Account accountPage;
        private Addresses addressesPage;
        private Settings settingsPage;
    }
}