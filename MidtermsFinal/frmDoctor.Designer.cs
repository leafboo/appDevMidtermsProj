namespace MidtermsFinal
{
    partial class frmDoctor
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
            this.lblSpecialization = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLicenseNo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgDoctor = new System.Windows.Forms.DataGridView();
            this.btnApply = new System.Windows.Forms.Button();
            this.cboCRUD = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLicenseNumber = new System.Windows.Forms.TextBox();
            this.cboSpecialization = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgPatients = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSpecialization
            // 
            this.lblSpecialization.AutoSize = true;
            this.lblSpecialization.Location = new System.Drawing.Point(81, 565);
            this.lblSpecialization.Name = "lblSpecialization";
            this.lblSpecialization.Size = new System.Drawing.Size(111, 20);
            this.lblSpecialization.TabIndex = 54;
            this.lblSpecialization.Text = "Specialization:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(81, 531);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 20);
            this.lblLastName.TabIndex = 53;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(81, 493);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblFirstName.TabIndex = 52;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLicenseNo
            // 
            this.lblLicenseNo.AutoSize = true;
            this.lblLicenseNo.Location = new System.Drawing.Point(81, 459);
            this.lblLicenseNo.Name = "lblLicenseNo";
            this.lblLicenseNo.Size = new System.Drawing.Size(128, 20);
            this.lblLicenseNo.TabIndex = 51;
            this.lblLicenseNo.Text = "License Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "Doctor\'s info:";
            // 
            // dtgDoctor
            // 
            this.dtgDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDoctor.Location = new System.Drawing.Point(455, 87);
            this.dtgDoctor.Name = "dtgDoctor";
            this.dtgDoctor.RowHeadersWidth = 62;
            this.dtgDoctor.RowTemplate.Height = 28;
            this.dtgDoctor.Size = new System.Drawing.Size(577, 218);
            this.dtgDoctor.TabIndex = 44;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(684, 327);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(97, 37);
            this.btnApply.TabIndex = 43;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // cboCRUD
            // 
            this.cboCRUD.FormattingEnabled = true;
            this.cboCRUD.Items.AddRange(new object[] {
            "Insert",
            "Search",
            "Update",
            "Delete"});
            this.cboCRUD.Location = new System.Drawing.Point(455, 336);
            this.cboCRUD.Name = "cboCRUD";
            this.cboCRUD.Size = new System.Drawing.Size(191, 28);
            this.cboCRUD.TabIndex = 42;
            this.cboCRUD.SelectedIndexChanged += new System.EventHandler(this.cboCRUD_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Specialization";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "License Number";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(85, 218);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(264, 26);
            this.txtLastName.TabIndex = 34;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(85, 154);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(264, 26);
            this.txtFirstName.TabIndex = 33;
            // 
            // txtLicenseNumber
            // 
            this.txtLicenseNumber.Location = new System.Drawing.Point(85, 89);
            this.txtLicenseNumber.Name = "txtLicenseNumber";
            this.txtLicenseNumber.Size = new System.Drawing.Size(264, 26);
            this.txtLicenseNumber.TabIndex = 32;
            // 
            // cboSpecialization
            // 
            this.cboSpecialization.FormattingEnabled = true;
            this.cboSpecialization.Location = new System.Drawing.Point(84, 277);
            this.cboSpecialization.Name = "cboSpecialization";
            this.cboSpecialization.Size = new System.Drawing.Size(265, 28);
            this.cboSpecialization.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 60;
            this.label6.Text = "Doctor\'s Patients";
            // 
            // dtgPatients
            // 
            this.dtgPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPatients.Location = new System.Drawing.Point(455, 459);
            this.dtgPatients.Name = "dtgPatients";
            this.dtgPatients.RowHeadersWidth = 62;
            this.dtgPatients.RowTemplate.Height = 28;
            this.dtgPatients.Size = new System.Drawing.Size(577, 218);
            this.dtgPatients.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 67;
            this.label5.Text = "Doctors";
            // 
            // frmDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 771);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtgPatients);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboSpecialization);
            this.Controls.Add(this.lblSpecialization);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLicenseNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtgDoctor);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.cboCRUD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLicenseNumber);
            this.Name = "frmDoctor";
            this.Text = "frmDoctor";
            this.Load += new System.EventHandler(this.frmDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSpecialization;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLicenseNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtgDoctor;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ComboBox cboCRUD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLicenseNumber;
        private System.Windows.Forms.ComboBox cboSpecialization;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgPatients;
        private System.Windows.Forms.Label label5;
    }
}