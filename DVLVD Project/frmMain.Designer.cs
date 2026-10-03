namespace DVLVD_Project
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSittingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUserName = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(22)))), ((int)(((byte)(44)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peopleToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.applicationsToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.accountSittingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1611, 48);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 13.5F, System.Drawing.FontStyle.Bold);
            this.peopleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.peopleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("peopleToolStripMenuItem.Image")));
            this.peopleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(125, 44);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 13.5F, System.Drawing.FontStyle.Bold);
            this.usersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.usersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usersToolStripMenuItem.Image")));
            this.usersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(114, 44);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 13.5F, System.Drawing.FontStyle.Bold);
            this.applicationsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.applicationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("applicationsToolStripMenuItem.Image")));
            this.applicationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(171, 44);
            this.applicationsToolStripMenuItem.Text = "Applications";
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 13.5F, System.Drawing.FontStyle.Bold);
            this.driversToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.driversToolStripMenuItem.Image = global::DVLVD_Project.Properties.Resources.Drivers_32;
            this.driversToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(127, 44);
            this.driversToolStripMenuItem.Text = "Drivers";
            // 
            // accountSittingToolStripMenuItem
            // 
            this.accountSittingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 13.5F, System.Drawing.FontStyle.Bold);
            this.accountSittingToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.accountSittingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("accountSittingToolStripMenuItem.Image")));
            this.accountSittingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.accountSittingToolStripMenuItem.Name = "accountSittingToolStripMenuItem";
            this.accountSittingToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.accountSittingToolStripMenuItem.Size = new System.Drawing.Size(210, 44);
            this.accountSittingToolStripMenuItem.Text = "Account Settings";
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(22)))), ((int)(((byte)(44)))));
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(1377, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(126, 25);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Current User";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::DVLVD_Project.Properties.Resources.Pictuer;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1611, 904);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DVLD - Driving & Vehicle License Department";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSittingToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}