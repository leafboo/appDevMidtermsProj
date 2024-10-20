namespace MidtermsFinal
{
    partial class frmPatient
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
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCRUD = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.dtgPatient = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPatientFirstName = new System.Windows.Forms.Label();
            this.lblPatientLastName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSpecialization = new System.Windows.Forms.Label();
            this.lblDoctorLastName = new System.Windows.Forms.Label();
            this.lblDoctorFirstName = new System.Windows.Forms.Label();
            this.lblLicenseNumber = new System.Windows.Forms.Label();
            this.lblAvailabilityStatus = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cboDoctorLicense = new System.Windows.Forms.ComboBox();
            this.cboRoomNo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPatientId
            // 
            this.txtPatientId.Location = new System.Drawing.Point(43, 60);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(264, 26);
            this.txtPatientId.TabIndex = 0;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(43, 125);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(264, 26);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(43, 189);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(264, 26);
            this.txtLastName.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(43, 248);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(264, 26);
            this.txtAddress.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(43, 311);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(264, 26);
            this.txtAge.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Patient ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Age";
            // 
            // cboCRUD
            // 
            this.cboCRUD.FormattingEnabled = true;
            this.cboCRUD.Items.AddRange(new object[] {
            "Insert",
            "Search",
            "Update",
            "Delete"});
            this.cboCRUD.Location = new System.Drawing.Point(376, 305);
            this.cboCRUD.Name = "cboCRUD";
            this.cboCRUD.Size = new System.Drawing.Size(191, 28);
            this.cboCRUD.TabIndex = 10;
            this.cboCRUD.SelectedIndexChanged += new System.EventHandler(this.cboCRUD_SelectedIndexChanged);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(605, 296);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(97, 37);
            this.btnApply.TabIndex = 11;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // dtgPatient
            // 
            this.dtgPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPatient.Location = new System.Drawing.Point(376, 56);
            this.dtgPatient.Name = "dtgPatient";
            this.dtgPatient.RowHeadersWidth = 62;
            this.dtgPatient.RowTemplate.Height = 28;
            this.dtgPatient.Size = new System.Drawing.Size(577, 218);
            this.dtgPatient.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 556);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Patient info";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(531, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Patient\'s doctor info:";
            // 
            // lblPatientFirstName
            // 
            this.lblPatientFirstName.AutoSize = true;
            this.lblPatientFirstName.Location = new System.Drawing.Point(48, 595);
            this.lblPatientFirstName.Name = "lblPatientFirstName";
            this.lblPatientFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblPatientFirstName.TabIndex = 16;
            this.lblPatientFirstName.Text = "First Name:";
            // 
            // lblPatientLastName
            // 
            this.lblPatientLastName.AutoSize = true;
            this.lblPatientLastName.Location = new System.Drawing.Point(48, 629);
            this.lblPatientLastName.Name = "lblPatientLastName";
            this.lblPatientLastName.Size = new System.Drawing.Size(90, 20);
            this.lblPatientLastName.TabIndex = 17;
            this.lblPatientLastName.Text = "Last Name:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(48, 701);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(42, 20);
            this.lblAge.TabIndex = 19;
            this.lblAge.Text = "Age:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(48, 667);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 20);
            this.lblAddress.TabIndex = 18;
            this.lblAddress.Text = "Address:";
            // 
            // lblSpecialization
            // 
            this.lblSpecialization.AutoSize = true;
            this.lblSpecialization.Location = new System.Drawing.Point(450, 590);
            this.lblSpecialization.Name = "lblSpecialization";
            this.lblSpecialization.Size = new System.Drawing.Size(111, 20);
            this.lblSpecialization.TabIndex = 23;
            this.lblSpecialization.Text = "Specialization:";
            // 
            // lblDoctorLastName
            // 
            this.lblDoctorLastName.AutoSize = true;
            this.lblDoctorLastName.Location = new System.Drawing.Point(450, 556);
            this.lblDoctorLastName.Name = "lblDoctorLastName";
            this.lblDoctorLastName.Size = new System.Drawing.Size(90, 20);
            this.lblDoctorLastName.TabIndex = 22;
            this.lblDoctorLastName.Text = "Last Name:";
            // 
            // lblDoctorFirstName
            // 
            this.lblDoctorFirstName.AutoSize = true;
            this.lblDoctorFirstName.Location = new System.Drawing.Point(450, 518);
            this.lblDoctorFirstName.Name = "lblDoctorFirstName";
            this.lblDoctorFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblDoctorFirstName.TabIndex = 21;
            this.lblDoctorFirstName.Text = "First Name:";
            // 
            // lblLicenseNumber
            // 
            this.lblLicenseNumber.AutoSize = true;
            this.lblLicenseNumber.Location = new System.Drawing.Point(450, 484);
            this.lblLicenseNumber.Name = "lblLicenseNumber";
            this.lblLicenseNumber.Size = new System.Drawing.Size(128, 20);
            this.lblLicenseNumber.TabIndex = 20;
            this.lblLicenseNumber.Text = "License Number:";
            // 
            // lblAvailabilityStatus
            // 
            this.lblAvailabilityStatus.AutoSize = true;
            this.lblAvailabilityStatus.Location = new System.Drawing.Point(453, 753);
            this.lblAvailabilityStatus.Name = "lblAvailabilityStatus";
            this.lblAvailabilityStatus.Size = new System.Drawing.Size(133, 20);
            this.lblAvailabilityStatus.TabIndex = 27;
            this.lblAvailabilityStatus.Text = "Availability status:";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(453, 715);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(47, 20);
            this.lblRoomType.TabIndex = 26;
            this.lblRoomType.Text = "Type:";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Location = new System.Drawing.Point(453, 681);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(116, 20);
            this.lblRoomNumber.TabIndex = 25;
            this.lblRoomNumber.Text = "Room Number:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(509, 640);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(144, 20);
            this.label20.TabIndex = 24;
            this.label20.Text = "Patient\'s room info:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(42, 363);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(147, 20);
            this.label16.TabIndex = 28;
            this.label16.Text = "Doctor\'s license no.";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(39, 430);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 20);
            this.label21.TabIndex = 29;
            this.label21.Text = "Room no.";
            // 
            // cboDoctorLicense
            // 
            this.cboDoctorLicense.FormattingEnabled = true;
            this.cboDoctorLicense.Location = new System.Drawing.Point(43, 386);
            this.cboDoctorLicense.Name = "cboDoctorLicense";
            this.cboDoctorLicense.Size = new System.Drawing.Size(264, 28);
            this.cboDoctorLicense.TabIndex = 30;
            // 
            // cboRoomNo
            // 
            this.cboRoomNo.FormattingEnabled = true;
            this.cboRoomNo.Location = new System.Drawing.Point(43, 453);
            this.cboRoomNo.Name = "cboRoomNo";
            this.cboRoomNo.Size = new System.Drawing.Size(264, 28);
            this.cboRoomNo.TabIndex = 31;
            // 
            // frmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 843);
            this.Controls.Add(this.cboRoomNo);
            this.Controls.Add(this.cboDoctorLicense);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblAvailabilityStatus);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblSpecialization);
            this.Controls.Add(this.lblDoctorLastName);
            this.Controls.Add(this.lblDoctorFirstName);
            this.Controls.Add(this.lblLicenseNumber);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPatientLastName);
            this.Controls.Add(this.lblPatientFirstName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtgPatient);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.cboCRUD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtPatientId);
            this.Name = "frmPatient";
            this.Text = "frmPatient";
            this.Load += new System.EventHandler(this.frmPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCRUD;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.DataGridView dtgPatient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPatientFirstName;
        private System.Windows.Forms.Label lblPatientLastName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSpecialization;
        private System.Windows.Forms.Label lblDoctorLastName;
        private System.Windows.Forms.Label lblDoctorFirstName;
        private System.Windows.Forms.Label lblLicenseNumber;
        private System.Windows.Forms.Label lblAvailabilityStatus;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cboDoctorLicense;
        private System.Windows.Forms.ComboBox cboRoomNo;
    }
}