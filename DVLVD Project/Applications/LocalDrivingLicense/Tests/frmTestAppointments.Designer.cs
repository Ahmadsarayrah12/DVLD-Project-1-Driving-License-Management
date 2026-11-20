namespace DVLVD_Project
{
    partial class frmTestAppointments
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTestAppointments));
            System.Windows.Forms.DataGridViewCellStyle dgvHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbBanner = new System.Windows.Forms.PictureBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblTestTypeTag = new System.Windows.Forms.Label();
            this.pnlAppInfo = new System.Windows.Forms.Panel();
            this.lblDLAppIDLabel = new System.Windows.Forms.Label();
            this.lblDLAppIDValue = new System.Windows.Forms.Label();
            this.lblAppliedForLabel = new System.Windows.Forms.Label();
            this.pbLicense = new System.Windows.Forms.PictureBox();
            this.lblAppliedForValue = new System.Windows.Forms.Label();
            this.lblPassedTestsLabel = new System.Windows.Forms.Label();
            this.pbTest = new System.Windows.Forms.PictureBox();
            this.lblPassedTestsValue = new System.Windows.Forms.Label();
            this.pnlBasicInfo = new System.Windows.Forms.Panel();
            this.lblBasicInfoHeader = new System.Windows.Forms.Label();
            this.lblAppIDLabel = new System.Windows.Forms.Label();
            this.lblAppIDValue = new System.Windows.Forms.Label();
            this.lblDateLabel = new System.Windows.Forms.Label();
            this.lblDateValue = new System.Windows.Forms.Label();
            this.lblStatusLabel = new System.Windows.Forms.Label();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.lblStatusDateLabel = new System.Windows.Forms.Label();
            this.lblStatusDateValue = new System.Windows.Forms.Label();
            this.lblFeesLabel = new System.Windows.Forms.Label();
            this.lblFeesValue = new System.Windows.Forms.Label();
            this.lblCreatedByLabel = new System.Windows.Forms.Label();
            this.lblCreatedByValue = new System.Windows.Forms.Label();
            this.lblTypeLabel = new System.Windows.Forms.Label();
            this.lblTypeValue = new System.Windows.Forms.Label();
            this.lblApplicantLabel = new System.Windows.Forms.Label();
            this.lblApplicantValue = new System.Windows.Forms.Label();
            this.lblAppointmentsHeader = new System.Windows.Forms.Label();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.cmsAppointments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLicense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.cmsAppointments.SuspendLayout();
            this.pnlAppInfo.SuspendLayout();
            this.pnlBasicInfo.SuspendLayout();
            this.SuspendLayout();

            // pbBanner
            this.pbBanner.BackColor = System.Drawing.Color.Transparent;
            this.pbBanner.Image = ((System.Drawing.Image)(resources.GetObject("pbBanner.Image")));
            this.pbBanner.Location = new System.Drawing.Point(310, 15);
            this.pbBanner.Size = new System.Drawing.Size(64, 64);
            this.pbBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBanner.TabStop = false;

            // lblFormTitle
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblFormTitle.Location = new System.Drawing.Point(130, 90);
            this.lblFormTitle.Text = "Vision Test Appointments";

            // lblTestTypeTag
            this.lblTestTypeTag.AutoSize = true;
            this.lblTestTypeTag.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTestTypeTag.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.lblTestTypeTag.Location = new System.Drawing.Point(25, 10);
            this.lblTestTypeTag.Text = "Vision Test";

            // pnlAppInfo (Driving License Application Info section)
            this.pnlAppInfo.BackColor = System.Drawing.Color.FromArgb(16, 29, 54);
            this.pnlAppInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAppInfo.Location = new System.Drawing.Point(25, 130);
            this.pnlAppInfo.Name = "pnlAppInfo";
            this.pnlAppInfo.Size = new System.Drawing.Size(640, 80);

            this.lblDLAppIDLabel.AutoSize = true;
            this.lblDLAppIDLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDLAppIDLabel.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblDLAppIDLabel.Location = new System.Drawing.Point(10, 8);
            this.lblDLAppIDLabel.Text = "Driving License Application Info";

            this.lblDLAppIDValue.AutoSize = true;
            this.lblDLAppIDValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDLAppIDValue.ForeColor = System.Drawing.Color.White;
            this.lblDLAppIDValue.Location = new System.Drawing.Point(10, 30);
            this.lblDLAppIDValue.Text = "D.L App ID:";

            this.lblAppliedForLabel.AutoSize = true;
            this.lblAppliedForLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAppliedForLabel.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.lblAppliedForLabel.Location = new System.Drawing.Point(10, 50);
            this.lblAppliedForLabel.Text = "Applied For License:";

            this.pbLicense.BackColor = System.Drawing.Color.Transparent;
            this.pbLicense.Image = ((System.Drawing.Image)(resources.GetObject("pbLicense.Image")));
            this.pbLicense.Location = new System.Drawing.Point(145, 48);
            this.pbLicense.Size = new System.Drawing.Size(18, 18);
            this.pbLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLicense.TabStop = false;

            this.lblAppliedForValue.AutoSize = true;
            this.lblAppliedForValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAppliedForValue.ForeColor = System.Drawing.Color.White;
            this.lblAppliedForValue.Location = new System.Drawing.Point(170, 50);
            this.lblAppliedForValue.Text = "???";

            this.lblPassedTestsLabel.AutoSize = true;
            this.lblPassedTestsLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPassedTestsLabel.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.lblPassedTestsLabel.Location = new System.Drawing.Point(430, 50);
            this.lblPassedTestsLabel.Text = "Passed Tests:";

            this.pbTest.BackColor = System.Drawing.Color.Transparent;
            this.pbTest.Image = ((System.Drawing.Image)(resources.GetObject("pbTest.Image")));
            this.pbTest.Location = new System.Drawing.Point(530, 48);
            this.pbTest.Size = new System.Drawing.Size(18, 18);
            this.pbTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTest.TabStop = false;

            this.lblPassedTestsValue.AutoSize = true;
            this.lblPassedTestsValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPassedTestsValue.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblPassedTestsValue.Location = new System.Drawing.Point(555, 50);
            this.lblPassedTestsValue.Text = "0/3";

            this.pnlAppInfo.Controls.Add(this.lblDLAppIDLabel);
            this.pnlAppInfo.Controls.Add(this.lblDLAppIDValue);
            this.pnlAppInfo.Controls.Add(this.lblAppliedForLabel);
            this.pnlAppInfo.Controls.Add(this.pbLicense);
            this.pnlAppInfo.Controls.Add(this.lblAppliedForValue);
            this.pnlAppInfo.Controls.Add(this.lblPassedTestsLabel);
            this.pnlAppInfo.Controls.Add(this.pbTest);
            this.pnlAppInfo.Controls.Add(this.lblPassedTestsValue);
            this.pnlAppInfo.Controls.Add(this.lblTestTypeTag);

            // pnlBasicInfo (Application Basic Info)
            this.pnlBasicInfo.BackColor = System.Drawing.Color.FromArgb(16, 29, 54);
            this.pnlBasicInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBasicInfo.Location = new System.Drawing.Point(25, 220);
            this.pnlBasicInfo.Name = "pnlBasicInfo";
            this.pnlBasicInfo.Size = new System.Drawing.Size(640, 155);

            this.lblBasicInfoHeader.AutoSize = true;
            this.lblBasicInfoHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblBasicInfoHeader.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblBasicInfoHeader.Location = new System.Drawing.Point(10, 8);
            this.lblBasicInfoHeader.Text = "Application Basic Info";

            void AddBasicRow(System.Windows.Forms.Label lbl, System.Windows.Forms.Label val, int x, int y, string labelText)
            {
                lbl.AutoSize = true;
                lbl.Font = new System.Drawing.Font("Segoe UI", 9F);
                lbl.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
                lbl.Location = new System.Drawing.Point(x, y);
                lbl.Text = labelText;
                val.AutoSize = true;
                val.Font = new System.Drawing.Font("Segoe UI", 9F);
                val.ForeColor = System.Drawing.Color.White;
                val.Location = new System.Drawing.Point(x + 90, y);
                val.Text = "???";
                this.pnlBasicInfo.Controls.Add(lbl);
                this.pnlBasicInfo.Controls.Add(val);
            }

            AddBasicRow(lblAppIDLabel, lblAppIDValue, 10, 30, "ID:");
            AddBasicRow(lblDateLabel, lblDateValue, 340, 30, "Date:");
            AddBasicRow(lblStatusLabel, lblStatusValue, 10, 55, "Status:");
            AddBasicRow(lblStatusDateLabel, lblStatusDateValue, 340, 55, "Status Date:");
            AddBasicRow(lblFeesLabel, lblFeesValue, 10, 80, "Fees:");
            AddBasicRow(lblCreatedByLabel, lblCreatedByValue, 340, 80, "Created By:");
            AddBasicRow(lblTypeLabel, lblTypeValue, 10, 105, "Type:");
            AddBasicRow(lblApplicantLabel, lblApplicantValue, 10, 130, "Applicant:");

            this.pnlBasicInfo.Controls.Add(this.lblBasicInfoHeader);

            // Appointments section header
            this.lblAppointmentsHeader.AutoSize = true;
            this.lblAppointmentsHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblAppointmentsHeader.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblAppointmentsHeader.Location = new System.Drawing.Point(25, 385);
            this.lblAppointmentsHeader.Text = "Appointments:";

            // btnAddAppointment (the + button)
            this.btnAddAppointment.BackColor = System.Drawing.Color.FromArgb(24, 43, 73);
            this.btnAddAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAppointment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(40, 65, 105);
            this.btnAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAppointment.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAppointment.Image")));
            this.btnAddAppointment.Location = new System.Drawing.Point(610, 380);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(36, 36);
            this.btnAddAppointment.TabIndex = 0;
            this.btnAddAppointment.UseVisualStyleBackColor = false;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);

            // dgvAppointments
            dgvHeaderStyle.BackColor = System.Drawing.Color.FromArgb(24, 43, 73);
            dgvHeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            dgvHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            dgvHeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(24, 43, 73);
            dgvCellStyle.BackColor = System.Drawing.Color.FromArgb(20, 35, 60);
            dgvCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgvCellStyle.ForeColor = System.Drawing.Color.White;
            dgvCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(41, 128, 185);

            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AllowUserToResizeRows = false;
            this.dgvAppointments.BackgroundColor = System.Drawing.Color.FromArgb(16, 29, 54);
            this.dgvAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppointments.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            this.dgvAppointments.ColumnHeadersHeight = 32;
            this.dgvAppointments.DefaultCellStyle = dgvCellStyle;
            this.dgvAppointments.ContextMenuStrip = this.cmsAppointments;
            this.dgvAppointments.Location = new System.Drawing.Point(25, 420);
            this.dgvAppointments.MultiSelect = false;
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersVisible = true;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.Size = new System.Drawing.Size(640, 150);
            this.dgvAppointments.TabIndex = 1;
            this.dgvAppointments.DoubleClick += new System.EventHandler(this.dgvAppointments_DoubleClick);

            // cmsAppointments
            this.cmsAppointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.takeTestToolStripMenuItem });
            this.cmsAppointments.BackColor = System.Drawing.Color.FromArgb(16, 29, 54);
            this.cmsAppointments.ForeColor = System.Drawing.Color.White;

            this.takeTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("takeTestToolStripMenuItem.Image")));
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);

            // lblRecordsCount
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblRecordsCount.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblRecordsCount.Location = new System.Drawing.Point(25, 580);
            this.lblRecordsCount.Text = "# Records: 0";

            // btnClose
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(24, 43, 73);
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(40, 65, 105);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(530, 575);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 36);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "   Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // frmTestAppointments
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(10, 22, 44);
            this.ClientSize = new System.Drawing.Size(690, 630);
            this.Controls.Add(this.pbBanner);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.pnlAppInfo);
            this.Controls.Add(this.pnlBasicInfo);
            this.Controls.Add(this.lblAppointmentsHeader);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTestAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vision Test Appointments";
            this.Load += new System.EventHandler(this.frmTestAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLicense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.cmsAppointments.ResumeLayout(false);
            this.pnlAppInfo.ResumeLayout(false);
            this.pnlAppInfo.PerformLayout();
            this.pnlBasicInfo.ResumeLayout(false);
            this.pnlBasicInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pbBanner;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblTestTypeTag;
        private System.Windows.Forms.Panel pnlAppInfo;
        private System.Windows.Forms.Label lblDLAppIDLabel;
        private System.Windows.Forms.Label lblDLAppIDValue;
        private System.Windows.Forms.Label lblAppliedForLabel;
        private System.Windows.Forms.PictureBox pbLicense;
        private System.Windows.Forms.Label lblAppliedForValue;
        private System.Windows.Forms.Label lblPassedTestsLabel;
        private System.Windows.Forms.PictureBox pbTest;
        private System.Windows.Forms.Label lblPassedTestsValue;
        private System.Windows.Forms.Panel pnlBasicInfo;
        private System.Windows.Forms.Label lblBasicInfoHeader;
        private System.Windows.Forms.Label lblAppIDLabel;
        private System.Windows.Forms.Label lblAppIDValue;
        private System.Windows.Forms.Label lblDateLabel;
        private System.Windows.Forms.Label lblDateValue;
        private System.Windows.Forms.Label lblStatusLabel;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label lblStatusDateLabel;
        private System.Windows.Forms.Label lblStatusDateValue;
        private System.Windows.Forms.Label lblFeesLabel;
        private System.Windows.Forms.Label lblFeesValue;
        private System.Windows.Forms.Label lblCreatedByLabel;
        private System.Windows.Forms.Label lblCreatedByValue;
        private System.Windows.Forms.Label lblTypeLabel;
        private System.Windows.Forms.Label lblTypeValue;
        private System.Windows.Forms.Label lblApplicantLabel;
        private System.Windows.Forms.Label lblApplicantValue;
        private System.Windows.Forms.Label lblAppointmentsHeader;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.ContextMenuStrip cmsAppointments;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Button btnClose;
    }
}
