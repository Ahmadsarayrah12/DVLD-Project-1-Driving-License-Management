namespace DVLVD_Project
{
    partial class frmAddUpdateLocalDrivingLicesnseApplication
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateLocalDrivingLicesnseApplication));
            this.lblHeader = new System.Windows.Forms.Label();
            this.tcApplicationInfo = new System.Windows.Forms.TabControl();
            this.tpPersonalInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlPersonCardWithFilter1 = new DVLVD_Project.UserControls.ctrlPersonCardWithFilter();
            this.tpApplicationInfo = new System.Windows.Forms.TabPage();
            this.lblCreatedByUser = new System.Windows.Forms.Label();
            this.pbCreatedBy = new System.Windows.Forms.PictureBox();
            this.lblCreatedByTitle = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.pbAppFees = new System.Windows.Forms.PictureBox();
            this.lblAppFeesTitle = new System.Windows.Forms.Label();
            this.cbLicenseClasses = new System.Windows.Forms.ComboBox();
            this.pbLicenseClass = new System.Windows.Forms.PictureBox();
            this.lblLicenseClassTitle = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.pbAppDate = new System.Windows.Forms.PictureBox();
            this.lblAppDateTitle = new System.Windows.Forms.Label();
            this.lblLocalDrivingLicenseApplicationID = new System.Windows.Forms.Label();
            this.pbDLAppID = new System.Windows.Forms.PictureBox();
            this.lblDLAppIDTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tcApplicationInfo.SuspendLayout();
            this.tpPersonalInfo.SuspendLayout();
            this.tpApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCreatedBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLicenseClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDLAppID)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblHeader.Location = new System.Drawing.Point(180, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(556, 41);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "New Local Driving License Application";
            // 
            // tcApplicationInfo
            // 
            this.tcApplicationInfo.Controls.Add(this.tpPersonalInfo);
            this.tcApplicationInfo.Controls.Add(this.tpApplicationInfo);
            this.tcApplicationInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.tcApplicationInfo.Location = new System.Drawing.Point(20, 65);
            this.tcApplicationInfo.Name = "tcApplicationInfo";
            this.tcApplicationInfo.SelectedIndex = 0;
            this.tcApplicationInfo.Size = new System.Drawing.Size(1177, 582);
            this.tcApplicationInfo.TabIndex = 1;
            // 
            // tpPersonalInfo
            // 
            this.tpPersonalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.tpPersonalInfo.Controls.Add(this.btnNext);
            this.tpPersonalInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tpPersonalInfo.ForeColor = System.Drawing.Color.White;
            this.tpPersonalInfo.Location = new System.Drawing.Point(4, 26);
            this.tpPersonalInfo.Name = "tpPersonalInfo";
            this.tpPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonalInfo.Size = new System.Drawing.Size(1169, 552);
            this.tpPersonalInfo.TabIndex = 0;
            this.tpPersonalInfo.Text = "Personal Info";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(920, 468);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(125, 36);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next   ";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(10, 5);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(1141, 525);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            this.ctrlPersonCardWithFilter1.OnPersonSelected += new System.Action<int>(this.ctrlPersonCardWithFilter1_OnPersonSelected);
            // 
            // tpApplicationInfo
            // 
            this.tpApplicationInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.tpApplicationInfo.Controls.Add(this.lblCreatedByUser);
            this.tpApplicationInfo.Controls.Add(this.pbCreatedBy);
            this.tpApplicationInfo.Controls.Add(this.lblCreatedByTitle);
            this.tpApplicationInfo.Controls.Add(this.lblApplicationFees);
            this.tpApplicationInfo.Controls.Add(this.pbAppFees);
            this.tpApplicationInfo.Controls.Add(this.lblAppFeesTitle);
            this.tpApplicationInfo.Controls.Add(this.cbLicenseClasses);
            this.tpApplicationInfo.Controls.Add(this.pbLicenseClass);
            this.tpApplicationInfo.Controls.Add(this.lblLicenseClassTitle);
            this.tpApplicationInfo.Controls.Add(this.lblApplicationDate);
            this.tpApplicationInfo.Controls.Add(this.pbAppDate);
            this.tpApplicationInfo.Controls.Add(this.lblAppDateTitle);
            this.tpApplicationInfo.Controls.Add(this.lblLocalDrivingLicenseApplicationID);
            this.tpApplicationInfo.Controls.Add(this.pbDLAppID);
            this.tpApplicationInfo.Controls.Add(this.lblDLAppIDTitle);
            this.tpApplicationInfo.ForeColor = System.Drawing.Color.White;
            this.tpApplicationInfo.Location = new System.Drawing.Point(4, 26);
            this.tpApplicationInfo.Name = "tpApplicationInfo";
            this.tpApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpApplicationInfo.Size = new System.Drawing.Size(1169, 552);
            this.tpApplicationInfo.TabIndex = 1;
            this.tpApplicationInfo.Text = "Application Info.";
            // 
            // lblCreatedByUser
            // 
            this.lblCreatedByUser.AutoSize = true;
            this.lblCreatedByUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCreatedByUser.ForeColor = System.Drawing.Color.White;
            this.lblCreatedByUser.Location = new System.Drawing.Point(280, 260);
            this.lblCreatedByUser.Name = "lblCreatedByUser";
            this.lblCreatedByUser.Size = new System.Drawing.Size(56, 20);
            this.lblCreatedByUser.TabIndex = 14;
            this.lblCreatedByUser.Text = "Admin";
            // 
            // pbCreatedBy
            // 
            this.pbCreatedBy.BackColor = System.Drawing.Color.Transparent;
            this.pbCreatedBy.Image = ((System.Drawing.Image)(resources.GetObject("pbCreatedBy.Image")));
            this.pbCreatedBy.Location = new System.Drawing.Point(235, 258);
            this.pbCreatedBy.Name = "pbCreatedBy";
            this.pbCreatedBy.Size = new System.Drawing.Size(39, 33);
            this.pbCreatedBy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCreatedBy.TabIndex = 13;
            this.pbCreatedBy.TabStop = false;
            // 
            // lblCreatedByTitle
            // 
            this.lblCreatedByTitle.AutoSize = true;
            this.lblCreatedByTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblCreatedByTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblCreatedByTitle.Location = new System.Drawing.Point(45, 260);
            this.lblCreatedByTitle.Name = "lblCreatedByTitle";
            this.lblCreatedByTitle.Size = new System.Drawing.Size(87, 20);
            this.lblCreatedByTitle.TabIndex = 12;
            this.lblCreatedByTitle.Text = "Created By:";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblApplicationFees.ForeColor = System.Drawing.Color.White;
            this.lblApplicationFees.Location = new System.Drawing.Point(280, 205);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(27, 20);
            this.lblApplicationFees.TabIndex = 11;
            this.lblApplicationFees.Text = "15";
            // 
            // pbAppFees
            // 
            this.pbAppFees.BackColor = System.Drawing.Color.Transparent;
            this.pbAppFees.Image = ((System.Drawing.Image)(resources.GetObject("pbAppFees.Image")));
            this.pbAppFees.Location = new System.Drawing.Point(235, 203);
            this.pbAppFees.Name = "pbAppFees";
            this.pbAppFees.Size = new System.Drawing.Size(39, 33);
            this.pbAppFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAppFees.TabIndex = 10;
            this.pbAppFees.TabStop = false;
            // 
            // lblAppFeesTitle
            // 
            this.lblAppFeesTitle.AutoSize = true;
            this.lblAppFeesTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblAppFeesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblAppFeesTitle.Location = new System.Drawing.Point(45, 205);
            this.lblAppFeesTitle.Name = "lblAppFeesTitle";
            this.lblAppFeesTitle.Size = new System.Drawing.Size(125, 20);
            this.lblAppFeesTitle.TabIndex = 9;
            this.lblAppFeesTitle.Text = "Application Fees:";
            // 
            // cbLicenseClasses
            // 
            this.cbLicenseClasses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(65)))));
            this.cbLicenseClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLicenseClasses.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLicenseClasses.ForeColor = System.Drawing.Color.White;
            this.cbLicenseClasses.FormattingEnabled = true;
            this.cbLicenseClasses.Location = new System.Drawing.Point(280, 150);
            this.cbLicenseClasses.Name = "cbLicenseClasses";
            this.cbLicenseClasses.Size = new System.Drawing.Size(335, 25);
            this.cbLicenseClasses.TabIndex = 8;
            // 
            // pbLicenseClass
            // 
            this.pbLicenseClass.BackColor = System.Drawing.Color.Transparent;
            this.pbLicenseClass.Image = ((System.Drawing.Image)(resources.GetObject("pbLicenseClass.Image")));
            this.pbLicenseClass.Location = new System.Drawing.Point(235, 150);
            this.pbLicenseClass.Name = "pbLicenseClass";
            this.pbLicenseClass.Size = new System.Drawing.Size(39, 33);
            this.pbLicenseClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLicenseClass.TabIndex = 7;
            this.pbLicenseClass.TabStop = false;
            // 
            // lblLicenseClassTitle
            // 
            this.lblLicenseClassTitle.AutoSize = true;
            this.lblLicenseClassTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblLicenseClassTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblLicenseClassTitle.Location = new System.Drawing.Point(45, 150);
            this.lblLicenseClassTitle.Name = "lblLicenseClassTitle";
            this.lblLicenseClassTitle.Size = new System.Drawing.Size(99, 20);
            this.lblLicenseClassTitle.TabIndex = 6;
            this.lblLicenseClassTitle.Text = "License Class:";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblApplicationDate.ForeColor = System.Drawing.Color.White;
            this.lblApplicationDate.Location = new System.Drawing.Point(280, 95);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(95, 20);
            this.lblApplicationDate.TabIndex = 5;
            this.lblApplicationDate.Text = "10/09/2023";
            // 
            // pbAppDate
            // 
            this.pbAppDate.BackColor = System.Drawing.Color.Transparent;
            this.pbAppDate.Image = ((System.Drawing.Image)(resources.GetObject("pbAppDate.Image")));
            this.pbAppDate.Location = new System.Drawing.Point(235, 93);
            this.pbAppDate.Name = "pbAppDate";
            this.pbAppDate.Size = new System.Drawing.Size(39, 33);
            this.pbAppDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAppDate.TabIndex = 4;
            this.pbAppDate.TabStop = false;
            // 
            // lblAppDateTitle
            // 
            this.lblAppDateTitle.AutoSize = true;
            this.lblAppDateTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblAppDateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblAppDateTitle.Location = new System.Drawing.Point(45, 95);
            this.lblAppDateTitle.Name = "lblAppDateTitle";
            this.lblAppDateTitle.Size = new System.Drawing.Size(127, 20);
            this.lblAppDateTitle.TabIndex = 3;
            this.lblAppDateTitle.Text = "Application Date:";
            // 
            // lblLocalDrivingLicenseApplicationID
            // 
            this.lblLocalDrivingLicenseApplicationID.AutoSize = true;
            this.lblLocalDrivingLicenseApplicationID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblLocalDrivingLicenseApplicationID.ForeColor = System.Drawing.Color.White;
            this.lblLocalDrivingLicenseApplicationID.Location = new System.Drawing.Point(280, 40);
            this.lblLocalDrivingLicenseApplicationID.Name = "lblLocalDrivingLicenseApplicationID";
            this.lblLocalDrivingLicenseApplicationID.Size = new System.Drawing.Size(42, 20);
            this.lblLocalDrivingLicenseApplicationID.TabIndex = 2;
            this.lblLocalDrivingLicenseApplicationID.Text = "[???]";
            // 
            // pbDLAppID
            // 
            this.pbDLAppID.BackColor = System.Drawing.Color.Transparent;
            this.pbDLAppID.Image = ((System.Drawing.Image)(resources.GetObject("pbDLAppID.Image")));
            this.pbDLAppID.Location = new System.Drawing.Point(235, 38);
            this.pbDLAppID.Name = "pbDLAppID";
            this.pbDLAppID.Size = new System.Drawing.Size(39, 33);
            this.pbDLAppID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDLAppID.TabIndex = 1;
            this.pbDLAppID.TabStop = false;
            // 
            // lblDLAppIDTitle
            // 
            this.lblDLAppIDTitle.AutoSize = true;
            this.lblDLAppIDTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblDLAppIDTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblDLAppIDTitle.Location = new System.Drawing.Point(45, 40);
            this.lblDLAppIDTitle.Name = "lblDLAppIDTitle";
            this.lblDLAppIDTitle.Size = new System.Drawing.Size(135, 20);
            this.lblDLAppIDTitle.TabIndex = 0;
            this.lblDLAppIDTitle.Text = "D.L.Application ID:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(900, 674);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 38);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "   Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1031, 674);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 38);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "   Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddUpdateLocalDrivingLicesnseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(22)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1235, 740);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcApplicationInfo);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddUpdateLocalDrivingLicesnseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Local Driving License Application";
            this.Load += new System.EventHandler(this.frmAddUpdateLocalDrivingLicesnseApplication_Load);
            this.tcApplicationInfo.ResumeLayout(false);
            this.tpPersonalInfo.ResumeLayout(false);
            this.tpApplicationInfo.ResumeLayout(false);
            this.tpApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCreatedBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLicenseClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDLAppID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TabControl tcApplicationInfo;
        private System.Windows.Forms.TabPage tpPersonalInfo;
        private System.Windows.Forms.TabPage tpApplicationInfo;
        private System.Windows.Forms.Button btnNext;
        private DVLVD_Project.UserControls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.Label lblDLAppIDTitle;
        private System.Windows.Forms.PictureBox pbDLAppID;
        private System.Windows.Forms.Label lblLocalDrivingLicenseApplicationID;
        private System.Windows.Forms.Label lblAppDateTitle;
        private System.Windows.Forms.PictureBox pbAppDate;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label lblLicenseClassTitle;
        private System.Windows.Forms.PictureBox pbLicenseClass;
        private System.Windows.Forms.ComboBox cbLicenseClasses;
        private System.Windows.Forms.Label lblAppFeesTitle;
        private System.Windows.Forms.PictureBox pbAppFees;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label lblCreatedByTitle;
        private System.Windows.Forms.PictureBox pbCreatedBy;
        private System.Windows.Forms.Label lblCreatedByUser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}
