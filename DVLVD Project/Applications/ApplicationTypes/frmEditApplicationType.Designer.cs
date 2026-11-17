namespace DVLVD_Project
{
    partial class frmEditApplicationType
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditApplicationType));
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblIDLabel = new System.Windows.Forms.Label();
            this.lblApplicationTypeID = new System.Windows.Forms.Label();
            this.lblTitleLabel = new System.Windows.Forms.Label();
            this.pbTitle = new System.Windows.Forms.PictureBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblFeesLabel = new System.Windows.Forms.Label();
            this.pbFees = new System.Windows.Forms.PictureBox();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblHeader.Location = new System.Drawing.Point(85, 25);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(335, 37);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Update Application Type";
            // 
            // lblIDLabel
            // 
            this.lblIDLabel.AutoSize = true;
            this.lblIDLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblIDLabel.Location = new System.Drawing.Point(40, 95);
            this.lblIDLabel.Name = "lblIDLabel";
            this.lblIDLabel.Size = new System.Drawing.Size(26, 19);
            this.lblIDLabel.TabIndex = 1;
            this.lblIDLabel.Text = "ID:";
            // 
            // lblApplicationTypeID
            // 
            this.lblApplicationTypeID.AutoSize = true;
            this.lblApplicationTypeID.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblApplicationTypeID.ForeColor = System.Drawing.Color.White;
            this.lblApplicationTypeID.Location = new System.Drawing.Point(130, 95);
            this.lblApplicationTypeID.Name = "lblApplicationTypeID";
            this.lblApplicationTypeID.Size = new System.Drawing.Size(33, 19);
            this.lblApplicationTypeID.TabIndex = 2;
            this.lblApplicationTypeID.Text = "???";
            // 
            // lblTitleLabel
            // 
            this.lblTitleLabel.AutoSize = true;
            this.lblTitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblTitleLabel.Location = new System.Drawing.Point(40, 140);
            this.lblTitleLabel.Name = "lblTitleLabel";
            this.lblTitleLabel.Size = new System.Drawing.Size(39, 19);
            this.lblTitleLabel.TabIndex = 3;
            this.lblTitleLabel.Text = "Title:";
            // 
            // pbTitle
            // 
            this.pbTitle.BackColor = System.Drawing.Color.Transparent;
            this.pbTitle.Image = ((System.Drawing.Image)(resources.GetObject("pbTitle.Image")));
            this.pbTitle.Location = new System.Drawing.Point(95, 138);
            this.pbTitle.Name = "pbTitle";
            this.pbTitle.Size = new System.Drawing.Size(24, 24);
            this.pbTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTitle.TabIndex = 9;
            this.pbTitle.TabStop = false;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(65)))));
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(130, 138);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(310, 25);
            this.txtTitle.TabIndex = 4;
            this.txtTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitle_Validating);
            // 
            // lblFeesLabel
            // 
            this.lblFeesLabel.AutoSize = true;
            this.lblFeesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblFeesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblFeesLabel.Location = new System.Drawing.Point(40, 185);
            this.lblFeesLabel.Name = "lblFeesLabel";
            this.lblFeesLabel.Size = new System.Drawing.Size(39, 19);
            this.lblFeesLabel.TabIndex = 5;
            this.lblFeesLabel.Text = "Fees:";
            // 
            // pbFees
            // 
            this.pbFees.BackColor = System.Drawing.Color.Transparent;
            this.pbFees.Image = ((System.Drawing.Image)(resources.GetObject("pbFees.Image")));
            this.pbFees.Location = new System.Drawing.Point(95, 183);
            this.pbFees.Name = "pbFees";
            this.pbFees.Size = new System.Drawing.Size(24, 24);
            this.pbFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFees.TabIndex = 10;
            this.pbFees.TabStop = false;
            // 
            // txtFees
            // 
            this.txtFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(65)))));
            this.txtFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFees.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFees.ForeColor = System.Drawing.Color.White;
            this.txtFees.Location = new System.Drawing.Point(130, 183);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(310, 25);
            this.txtFees.TabIndex = 6;
            this.txtFees.Validating += new System.ComponentModel.CancelEventHandler(this.txtFees_Validating);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(325, 235);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 36);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "   Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(200, 235);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 36);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "   Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmEditApplicationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(22)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(480, 295);
            this.Controls.Add(this.pbFees);
            this.Controls.Add(this.pbTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.lblFeesLabel);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitleLabel);
            this.Controls.Add(this.lblApplicationTypeID);
            this.Controls.Add(this.lblIDLabel);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditApplicationType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Application Type";
            this.Load += new System.EventHandler(this.frmEditApplicationType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblIDLabel;
        private System.Windows.Forms.Label lblApplicationTypeID;
        private System.Windows.Forms.Label lblTitleLabel;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblFeesLabel;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pbTitle;
        private System.Windows.Forms.PictureBox pbFees;
    }
}
