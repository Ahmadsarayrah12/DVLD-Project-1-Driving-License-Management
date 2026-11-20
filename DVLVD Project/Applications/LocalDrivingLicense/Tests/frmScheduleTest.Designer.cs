namespace DVLVD_Project
{
    partial class frmScheduleTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScheduleTest));
            this.pbBanner = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblDLAppIDLabel = new System.Windows.Forms.Label();
            this.pbDLAppID = new System.Windows.Forms.PictureBox();
            this.lblDLAppIDValue = new System.Windows.Forms.Label();
            this.lblDClassLabel = new System.Windows.Forms.Label();
            this.pbDClass = new System.Windows.Forms.PictureBox();
            this.lblDClassValue = new System.Windows.Forms.Label();
            this.lblNameLabel = new System.Windows.Forms.Label();
            this.pbName = new System.Windows.Forms.PictureBox();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.lblTrialLabel = new System.Windows.Forms.Label();
            this.pbTrial = new System.Windows.Forms.PictureBox();
            this.lblTrialValue = new System.Windows.Forms.Label();
            this.lblDateLabel = new System.Windows.Forms.Label();
            this.pbDate = new System.Windows.Forms.PictureBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblFeesLabel = new System.Windows.Forms.Label();
            this.pbFees = new System.Windows.Forms.PictureBox();
            this.lblFeesValue = new System.Windows.Forms.Label();
            this.pnlRetake = new System.Windows.Forms.Panel();
            this.lblRetakeInfo = new System.Windows.Forms.Label();
            this.lblRetakeFeesLabel = new System.Windows.Forms.Label();
            this.pbRetakeFees = new System.Windows.Forms.PictureBox();
            this.lblRetakeFees = new System.Windows.Forms.Label();
            this.lblTotalFeesLabel = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblRetakeAppIDLabel = new System.Windows.Forms.Label();
            this.lblRetakeAppID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDLAppID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetakeFees)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.pnlRetake.SuspendLayout();
            this.SuspendLayout();

            // pbBanner
            this.pbBanner.BackColor = System.Drawing.Color.Transparent;
            this.pbBanner.Image = ((System.Drawing.Image)(resources.GetObject("pbBanner.Image")));
            this.pbBanner.Location = new System.Drawing.Point(195, 15);
            this.pbBanner.Name = "pbBanner";
            this.pbBanner.Size = new System.Drawing.Size(64, 64);
            this.pbBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBanner.TabIndex = 0;
            this.pbBanner.TabStop = false;

            // lblHeader
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblHeader.Location = new System.Drawing.Point(85, 90);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Text = "Schedule Test";

            // pnlInfo
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(16, 29, 54);
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Location = new System.Drawing.Point(25, 130);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(400, 230);

            // --- D.L App ID ---
            this.lblDLAppIDLabel.AutoSize = true;
            this.lblDLAppIDLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDLAppIDLabel.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblDLAppIDLabel.Location = new System.Drawing.Point(10, 15);
            this.lblDLAppIDLabel.Text = "D.L App ID:";

            this.pbDLAppID.BackColor = System.Drawing.Color.Transparent;
            this.pbDLAppID.Image = ((System.Drawing.Image)(resources.GetObject("pbDLAppID.Image")));
            this.pbDLAppID.Location = new System.Drawing.Point(145, 12);
            this.pbDLAppID.Size = new System.Drawing.Size(20, 20);
            this.pbDLAppID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDLAppID.TabStop = false;

            this.lblDLAppIDValue.AutoSize = true;
            this.lblDLAppIDValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDLAppIDValue.ForeColor = System.Drawing.Color.White;
            this.lblDLAppIDValue.Location = new System.Drawing.Point(170, 15);
            this.lblDLAppIDValue.Text = "???";

            // --- D. Class ---
            this.lblDClassLabel.AutoSize = true;
            this.lblDClassLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDClassLabel.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblDClassLabel.Location = new System.Drawing.Point(10, 50);
            this.lblDClassLabel.Text = "D. Class:";

            this.pbDClass.BackColor = System.Drawing.Color.Transparent;
            this.pbDClass.Image = ((System.Drawing.Image)(resources.GetObject("pbDClass.Image")));
            this.pbDClass.Location = new System.Drawing.Point(145, 47);
            this.pbDClass.Size = new System.Drawing.Size(20, 20);
            this.pbDClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDClass.TabStop = false;

            this.lblDClassValue.AutoSize = true;
            this.lblDClassValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDClassValue.ForeColor = System.Drawing.Color.White;
            this.lblDClassValue.Location = new System.Drawing.Point(170, 50);
            this.lblDClassValue.Text = "???";

            // --- Name ---
            this.lblNameLabel.AutoSize = true;
            this.lblNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblNameLabel.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblNameLabel.Location = new System.Drawing.Point(10, 85);
            this.lblNameLabel.Text = "Name:";

            this.pbName.BackColor = System.Drawing.Color.Transparent;
            this.pbName.Image = ((System.Drawing.Image)(resources.GetObject("pbName.Image")));
            this.pbName.Location = new System.Drawing.Point(145, 82);
            this.pbName.Size = new System.Drawing.Size(20, 20);
            this.pbName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbName.TabStop = false;

            this.lblNameValue.AutoSize = true;
            this.lblNameValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNameValue.ForeColor = System.Drawing.Color.White;
            this.lblNameValue.Location = new System.Drawing.Point(170, 85);
            this.lblNameValue.Text = "???";

            // --- Trial ---
            this.lblTrialLabel.AutoSize = true;
            this.lblTrialLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTrialLabel.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblTrialLabel.Location = new System.Drawing.Point(10, 120);
            this.lblTrialLabel.Text = "Trial:";

            this.pbTrial.BackColor = System.Drawing.Color.Transparent;
            this.pbTrial.Image = ((System.Drawing.Image)(resources.GetObject("pbTrial.Image")));
            this.pbTrial.Location = new System.Drawing.Point(145, 117);
            this.pbTrial.Size = new System.Drawing.Size(20, 20);
            this.pbTrial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTrial.TabStop = false;

            this.lblTrialValue.AutoSize = true;
            this.lblTrialValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTrialValue.ForeColor = System.Drawing.Color.White;
            this.lblTrialValue.Location = new System.Drawing.Point(170, 120);
            this.lblTrialValue.Text = "0";

            // --- Date ---
            this.lblDateLabel.AutoSize = true;
            this.lblDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDateLabel.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblDateLabel.Location = new System.Drawing.Point(10, 155);
            this.lblDateLabel.Text = "Date:";

            this.pbDate.BackColor = System.Drawing.Color.Transparent;
            this.pbDate.Image = ((System.Drawing.Image)(resources.GetObject("pbDate.Image")));
            this.pbDate.Location = new System.Drawing.Point(145, 152);
            this.pbDate.Size = new System.Drawing.Size(20, 20);
            this.pbDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDate.TabStop = false;

            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(170, 150);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 0;

            // --- Fees ---
            this.lblFeesLabel.AutoSize = true;
            this.lblFeesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblFeesLabel.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblFeesLabel.Location = new System.Drawing.Point(10, 190);
            this.lblFeesLabel.Text = "Fees:";

            this.pbFees.BackColor = System.Drawing.Color.Transparent;
            this.pbFees.Image = ((System.Drawing.Image)(resources.GetObject("pbFees.Image")));
            this.pbFees.Location = new System.Drawing.Point(145, 187);
            this.pbFees.Size = new System.Drawing.Size(20, 20);
            this.pbFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFees.TabStop = false;

            this.lblFeesValue.AutoSize = true;
            this.lblFeesValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFeesValue.ForeColor = System.Drawing.Color.White;
            this.lblFeesValue.Location = new System.Drawing.Point(170, 190);
            this.lblFeesValue.Text = "0";

            // pnlRetake
            this.pnlRetake.BackColor = System.Drawing.Color.FromArgb(16, 29, 54);
            this.pnlRetake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRetake.Location = new System.Drawing.Point(25, 375);
            this.pnlRetake.Name = "pnlRetake";
            this.pnlRetake.Size = new System.Drawing.Size(400, 90);

            this.lblRetakeInfo.AutoSize = true;
            this.lblRetakeInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblRetakeInfo.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblRetakeInfo.Location = new System.Drawing.Point(5, 5);
            this.lblRetakeInfo.Text = "Retake Test Info";

            this.lblRetakeFeesLabel.AutoSize = true;
            this.lblRetakeFeesLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRetakeFeesLabel.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.lblRetakeFeesLabel.Location = new System.Drawing.Point(10, 28);
            this.lblRetakeFeesLabel.Text = "R App. Fees:";

            this.pbRetakeFees.BackColor = System.Drawing.Color.Transparent;
            this.pbRetakeFees.Image = ((System.Drawing.Image)(resources.GetObject("pbRetakeFees.Image")));
            this.pbRetakeFees.Location = new System.Drawing.Point(135, 25);
            this.pbRetakeFees.Size = new System.Drawing.Size(18, 18);
            this.pbRetakeFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRetakeFees.TabStop = false;

            this.lblRetakeFees.AutoSize = true;
            this.lblRetakeFees.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRetakeFees.ForeColor = System.Drawing.Color.White;
            this.lblRetakeFees.Location = new System.Drawing.Point(158, 28);
            this.lblRetakeFees.Text = "0";

            this.lblTotalFeesLabel.AutoSize = true;
            this.lblTotalFeesLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTotalFeesLabel.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.lblTotalFeesLabel.Location = new System.Drawing.Point(220, 28);
            this.lblTotalFeesLabel.Text = "Total Fees:";

            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTotalFees.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblTotalFees.Location = new System.Drawing.Point(310, 28);
            this.lblTotalFees.Text = "0";

            this.lblRetakeAppIDLabel.AutoSize = true;
            this.lblRetakeAppIDLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRetakeAppIDLabel.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.lblRetakeAppIDLabel.Location = new System.Drawing.Point(10, 58);
            this.lblRetakeAppIDLabel.Text = "R Test App ID:";

            this.lblRetakeAppID.AutoSize = true;
            this.lblRetakeAppID.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRetakeAppID.ForeColor = System.Drawing.Color.White;
            this.lblRetakeAppID.Location = new System.Drawing.Point(135, 58);
            this.lblRetakeAppID.Text = "N/A";

            // Add controls to pnlInfo
            this.pnlInfo.Controls.Add(this.lblDLAppIDLabel);
            this.pnlInfo.Controls.Add(this.pbDLAppID);
            this.pnlInfo.Controls.Add(this.lblDLAppIDValue);
            this.pnlInfo.Controls.Add(this.lblDClassLabel);
            this.pnlInfo.Controls.Add(this.pbDClass);
            this.pnlInfo.Controls.Add(this.lblDClassValue);
            this.pnlInfo.Controls.Add(this.lblNameLabel);
            this.pnlInfo.Controls.Add(this.pbName);
            this.pnlInfo.Controls.Add(this.lblNameValue);
            this.pnlInfo.Controls.Add(this.lblTrialLabel);
            this.pnlInfo.Controls.Add(this.pbTrial);
            this.pnlInfo.Controls.Add(this.lblTrialValue);
            this.pnlInfo.Controls.Add(this.lblDateLabel);
            this.pnlInfo.Controls.Add(this.pbDate);
            this.pnlInfo.Controls.Add(this.dtpDate);
            this.pnlInfo.Controls.Add(this.lblFeesLabel);
            this.pnlInfo.Controls.Add(this.pbFees);
            this.pnlInfo.Controls.Add(this.lblFeesValue);

            // Add controls to pnlRetake
            this.pnlRetake.Controls.Add(this.lblRetakeInfo);
            this.pnlRetake.Controls.Add(this.lblRetakeFeesLabel);
            this.pnlRetake.Controls.Add(this.pbRetakeFees);
            this.pnlRetake.Controls.Add(this.lblRetakeFees);
            this.pnlRetake.Controls.Add(this.lblTotalFeesLabel);
            this.pnlRetake.Controls.Add(this.lblTotalFees);
            this.pnlRetake.Controls.Add(this.lblRetakeAppIDLabel);
            this.pnlRetake.Controls.Add(this.lblRetakeAppID);

            // btnSave
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(24, 43, 73);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(40, 65, 105);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(310, 480);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 36);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "   Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnClose
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(24, 43, 73);
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(40, 65, 105);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(185, 480);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 36);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "   Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // frmScheduleTest
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(10, 22, 44);
            this.ClientSize = new System.Drawing.Size(450, 535);
            this.Controls.Add(this.pbBanner);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlRetake);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScheduleTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Schedule Test";
            this.Load += new System.EventHandler(this.frmScheduleTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDLAppID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetakeFees)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlRetake.ResumeLayout(false);
            this.pnlRetake.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pbBanner;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblDLAppIDLabel;
        private System.Windows.Forms.PictureBox pbDLAppID;
        private System.Windows.Forms.Label lblDLAppIDValue;
        private System.Windows.Forms.Label lblDClassLabel;
        private System.Windows.Forms.PictureBox pbDClass;
        private System.Windows.Forms.Label lblDClassValue;
        private System.Windows.Forms.Label lblNameLabel;
        private System.Windows.Forms.PictureBox pbName;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label lblTrialLabel;
        private System.Windows.Forms.PictureBox pbTrial;
        private System.Windows.Forms.Label lblTrialValue;
        private System.Windows.Forms.Label lblDateLabel;
        private System.Windows.Forms.PictureBox pbDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblFeesLabel;
        private System.Windows.Forms.PictureBox pbFees;
        private System.Windows.Forms.Label lblFeesValue;
        private System.Windows.Forms.Panel pnlRetake;
        private System.Windows.Forms.Label lblRetakeInfo;
        private System.Windows.Forms.Label lblRetakeFeesLabel;
        private System.Windows.Forms.PictureBox pbRetakeFees;
        private System.Windows.Forms.Label lblRetakeFees;
        private System.Windows.Forms.Label lblTotalFeesLabel;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblRetakeAppIDLabel;
        private System.Windows.Forms.Label lblRetakeAppID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}
