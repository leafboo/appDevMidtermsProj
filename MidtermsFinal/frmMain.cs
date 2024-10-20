using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidtermsFinal
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPatientTable_Click(object sender, EventArgs e)
        {
            frmPatient patient = new frmPatient();
            patient.ShowDialog();
        }

        private void btnDoctorTable_Click(object sender, EventArgs e)
        {
            frmDoctor doctor = new frmDoctor();
            doctor.ShowDialog();
        }
    }
}
