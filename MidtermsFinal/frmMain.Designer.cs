namespace MidtermsFinal
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
            this.btnPatientTable = new System.Windows.Forms.Button();
            this.btnDoctorTable = new System.Windows.Forms.Button();
            this.btnRoomTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPatientTable
            // 
            this.btnPatientTable.Location = new System.Drawing.Point(199, 82);
            this.btnPatientTable.Name = "btnPatientTable";
            this.btnPatientTable.Size = new System.Drawing.Size(152, 36);
            this.btnPatientTable.TabIndex = 1;
            this.btnPatientTable.Text = "Patient table";
            this.btnPatientTable.UseVisualStyleBackColor = true;
            this.btnPatientTable.Click += new System.EventHandler(this.btnPatientTable_Click);
            // 
            // btnDoctorTable
            // 
            this.btnDoctorTable.Location = new System.Drawing.Point(199, 135);
            this.btnDoctorTable.Name = "btnDoctorTable";
            this.btnDoctorTable.Size = new System.Drawing.Size(152, 36);
            this.btnDoctorTable.TabIndex = 2;
            this.btnDoctorTable.Text = "Doctor Table";
            this.btnDoctorTable.UseVisualStyleBackColor = true;
            // 
            // btnRoomTable
            // 
            this.btnRoomTable.Location = new System.Drawing.Point(199, 186);
            this.btnRoomTable.Name = "btnRoomTable";
            this.btnRoomTable.Size = new System.Drawing.Size(152, 36);
            this.btnRoomTable.TabIndex = 3;
            this.btnRoomTable.Text = "Room table";
            this.btnRoomTable.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 338);
            this.Controls.Add(this.btnRoomTable);
            this.Controls.Add(this.btnDoctorTable);
            this.Controls.Add(this.btnPatientTable);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPatientTable;
        private System.Windows.Forms.Button btnDoctorTable;
        private System.Windows.Forms.Button btnRoomTable;
    }
}

