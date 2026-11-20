using System;

namespace DVLVD_Project
{
    partial class frmTakeTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTakeTest));
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
            this.lblDateValue = new System.Windows.Forms.Label();
            this.lblFeesLabel = new System.Windows.Forms.Label();
            this.pbFees = new System.Windows.Forms.PictureBox();
            this.lblFeesValue = new System.Windows.Forms.Label();
            this.lblTestIDLabel = new System.Windows.Forms.Label();
            this.lblTestIDValue = new System.Windows.Forms.Label();
            this.lblResultLabel = new System.Windows.Forms.Label();
            this.rbPass = new System.Windows.Forms.RadioButton();
            this.rbFail = new System.Windows.Forms.RadioButton();
            this.lblNotesLabel = new System.Windows.Forms.Label();
            this.pbNotes = new System.Windows.Forms.PictureBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDLAppID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();

            // pbBanner
            this.pbBanner.BackColor = System.Drawing.Color.Transparent;
            this.pbBanner.Image = ((System.Drawing.Image)(resources.GetObject("pbBanner.Image")));
            this.pbBanner.Location = new System.Drawing.Point(195, 15);
            this.pbBanner.Size = new System.Drawing.Size(64, 64);
            this.pbBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBanner.TabStop = false;

            // lblHeader
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblHeader.Location = new System.Drawing.Point(85, 90);
            this.lblHeader.Text = "Scheduled Test";

            // pnlInfo
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(16, 29, 54);
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Location = new System.Drawing.Point(25, 130);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(400, 230);

            void AddRow(System.Windows.Forms.Control lbl, System.Windows.Forms.Control pb, System.Windows.Forms.Control val) {
                this.pnlInfo.Controls.Add(lbl);
                this.pnlInfo.Controls.Add(pb);
                this.pnlInfo.Controls.Add(val);
            }

            int row = 0;
            int rowH = 37;
            Action<System.Windows.Forms.Label, System.Windows.Forms.PictureBox, System.Windows.Forms.Label, string, string, System.Drawing.Image> setupRow =
                (labelCtrl, pbCtrl, valCtrl, labelText, valText, img) => {
                    int y = 10 + row * rowH;
                    labelCtrl.AutoSize = true;
                    labelCtrl.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
                    labelCtrl.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
                    labelCtrl.Location = new System.Drawing.Point(10, y);
                    labelCtrl.Text = labelText;
                    pbCtrl.BackColor = System.Drawing.Color.Transparent;
                    pbCtrl.Image = img;
                    pbCtrl.Location = new System.Drawing.Point(145, y - 2);
                    pbCtrl.Size = new System.Drawing.Size(20, 20);
                    pbCtrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    pbCtrl.TabStop = false;
                    valCtrl.AutoSize = true;
                    valCtrl.Font = new System.Drawing.Font("Segoe UI", 10F);
                    valCtrl.ForeColor = System.Drawing.Color.White;
                    valCtrl.Location = new System.Drawing.Point(170, y);
                    valCtrl.Text = valText;
                    this.pnlInfo.Controls.Add(labelCtrl);
                    this.pnlInfo.Controls.Add(pbCtrl);
                    this.pnlInfo.Controls.Add(valCtrl);
                    row++;
                };

            setupRow(lblDLAppIDLabel, pbDLAppID, lblDLAppIDValue, "D.L App ID:", "???",
                (System.Drawing.Image)resources.GetObject("pbDLAppID.Image"));
            setupRow(lblDClassLabel, pbDClass, lblDClassValue, "D. Class:", "???",
                (System.Drawing.Image)resources.GetObject("pbDClass.Image"));
            setupRow(lblNameLabel, pbName, lblNameValue, "Name:", "???",
                (System.Drawing.Image)resources.GetObject("pbName.Image"));
            setupRow(lblTrialLabel, pbTrial, lblTrialValue, "Trial:", "0",
                (System.Drawing.Image)resources.GetObject("pbTrial.Image"));
            setupRow(lblDateLabel, pbDate, lblDateValue, "Date:", "???",
                (System.Drawing.Image)resources.GetObject("pbDate.Image"));
            setupRow(lblFeesLabel, pbFees, lblFeesValue, "Fees:", "0",
                (System.Drawing.Image)resources.GetObject("pbFees.Image"));

            // Test ID
            this.lblTestIDLabel.AutoSize = true;
            this.lblTestIDLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTestIDLabel.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblTestIDLabel.Location = new System.Drawing.Point(10, 10 + row * rowH);
            this.lblTestIDLabel.Text = "Test ID:";
            this.lblTestIDValue.AutoSize = true;
            this.lblTestIDValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTestIDValue.ForeColor = System.Drawing.Color.White;
            this.lblTestIDValue.Location = new System.Drawing.Point(170, 10 + row * rowH);
            this.lblTestIDValue.Text = "Not Taken Yet";
            this.pnlInfo.Controls.Add(this.lblTestIDLabel);
            this.pnlInfo.Controls.Add(this.lblTestIDValue);

            // Result
            int resultY = 375;
            this.lblResultLabel.AutoSize = true;
            this.lblResultLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblResultLabel.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblResultLabel.Location = new System.Drawing.Point(25, resultY);
            this.lblResultLabel.Text = "Result:";

            this.rbPass.AutoSize = true;
            this.rbPass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbPass.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.rbPass.Location = new System.Drawing.Point(130, resultY - 2);
            this.rbPass.Text = "Pass";
            this.rbPass.TabIndex = 0;

            this.rbFail.AutoSize = true;
            this.rbFail.Checked = true;
            this.rbFail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbFail.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.rbFail.Location = new System.Drawing.Point(205, resultY - 2);
            this.rbFail.Text = "Fail";
            this.rbFail.TabIndex = 1;

            // Notes
            int notesY = resultY + 35;
            this.lblNotesLabel.AutoSize = true;
            this.lblNotesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblNotesLabel.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblNotesLabel.Location = new System.Drawing.Point(25, notesY);
            this.lblNotesLabel.Text = "Notes:";

            this.pbNotes.BackColor = System.Drawing.Color.Transparent;
            this.pbNotes.Image = ((System.Drawing.Image)(resources.GetObject("pbNotes.Image")));
            this.pbNotes.Location = new System.Drawing.Point(100, notesY - 2);
            this.pbNotes.Size = new System.Drawing.Size(20, 20);
            this.pbNotes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNotes.TabStop = false;

            this.txtNotes.BackColor = System.Drawing.Color.FromArgb(20, 35, 60);
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNotes.ForeColor = System.Drawing.Color.White;
            this.txtNotes.Location = new System.Drawing.Point(25, notesY + 25);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(400, 70);
            this.txtNotes.TabIndex = 2;
            this.txtNotes.Validating += new System.ComponentModel.CancelEventHandler(this.txtNotes_Validating);

            int btnsY = notesY + 110;

            // btnSave
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(24, 43, 73);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(40, 65, 105);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(310, btnsY);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 36);
            this.btnSave.TabIndex = 3;
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
            this.btnClose.Location = new System.Drawing.Point(185, btnsY);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 36);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "   Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // errorProvider
            this.errorProvider1.ContainerControl = this;

            // frmTakeTest
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(10, 22, 44);
            this.ClientSize = new System.Drawing.Size(450, btnsY + 55);
            this.Controls.Add(this.pbBanner);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.lblResultLabel);
            this.Controls.Add(this.rbPass);
            this.Controls.Add(this.rbFail);
            this.Controls.Add(this.lblNotesLabel);
            this.Controls.Add(this.pbNotes);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTakeTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Take Test";
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDLAppID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
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
        private System.Windows.Forms.Label lblDateValue;
        private System.Windows.Forms.Label lblFeesLabel;
        private System.Windows.Forms.PictureBox pbFees;
        private System.Windows.Forms.Label lblFeesValue;
        private System.Windows.Forms.Label lblTestIDLabel;
        private System.Windows.Forms.Label lblTestIDValue;
        private System.Windows.Forms.Label lblResultLabel;
        private System.Windows.Forms.RadioButton rbPass;
        private System.Windows.Forms.RadioButton rbFail;
        private System.Windows.Forms.Label lblNotesLabel;
        private System.Windows.Forms.PictureBox pbNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
