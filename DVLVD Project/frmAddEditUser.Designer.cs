namespace DVLVD_Project
{
    partial class frmAddEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditUser));
            this.btnExit = new System.Windows.Forms.Button();
            this.tcAddUpdateUser = new System.Windows.Forms.TabControl();
            this.tcPersonInfo = new System.Windows.Forms.TabPage();
            this.btnFind = new System.Windows.Forms.Button();
            this.ctrlPersonCardWithFilter1 = new DVLVD_Project.UserControls.ctrlPersonCardWithFilter();
            this.tcUserInfo = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tcAddUpdateUser.SuspendLayout();
            this.tcPersonInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(22)))), ((int)(((byte)(44)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(989, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 26;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tcAddUpdateUser
            // 
            this.tcAddUpdateUser.Controls.Add(this.tcPersonInfo);
            this.tcAddUpdateUser.Controls.Add(this.tcUserInfo);
            this.tcAddUpdateUser.Location = new System.Drawing.Point(58, 67);
            this.tcAddUpdateUser.Multiline = true;
            this.tcAddUpdateUser.Name = "tcAddUpdateUser";
            this.tcAddUpdateUser.SelectedIndex = 0;
            this.tcAddUpdateUser.Size = new System.Drawing.Size(860, 426);
            this.tcAddUpdateUser.TabIndex = 28;
            // 
            // tcPersonInfo
            // 
            this.tcPersonInfo.BackColor = System.Drawing.SystemColors.Window;
            this.tcPersonInfo.Controls.Add(this.btnFind);
            this.tcPersonInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tcPersonInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tcPersonInfo.Location = new System.Drawing.Point(4, 22);
            this.tcPersonInfo.Name = "tcPersonInfo";
            this.tcPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tcPersonInfo.Size = new System.Drawing.Size(852, 400);
            this.tcPersonInfo.TabIndex = 0;
            this.tcPersonInfo.Text = "Personal Info";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFind.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.Location = new System.Drawing.Point(691, 345);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(100, 36);
            this.btnFind.TabIndex = 30;
            this.btnFind.Text = "Next     ";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(22)))), ((int)(((byte)(44)))));
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(-4, 0);
            this.ctrlPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(6);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(894, 420);
            this.ctrlPersonCardWithFilter1.TabIndex = 27;
            this.ctrlPersonCardWithFilter1.Load += new System.EventHandler(this.ctrlPersonCardWithFilter1_Load);
            // 
            // tcUserInfo
            // 
            this.tcUserInfo.Location = new System.Drawing.Point(4, 22);
            this.tcUserInfo.Name = "tcUserInfo";
            this.tcUserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tcUserInfo.Size = new System.Drawing.Size(852, 400);
            this.tcUserInfo.TabIndex = 1;
            this.tcUserInfo.Text = "User Info";
            this.tcUserInfo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(435, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 33);
            this.label1.TabIndex = 29;
            this.label1.Text = "Add User";
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(22)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1034, 608);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tcAddUpdateUser);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditUser";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Save/Update Users Screen";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.frmAddEditUser_Load);
            this.tcAddUpdateUser.ResumeLayout(false);
            this.tcPersonInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private UserControls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.TabControl tcAddUpdateUser;
        private System.Windows.Forms.TabPage tcPersonInfo;
        private System.Windows.Forms.TabPage tcUserInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
    }
}