using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;

namespace MidtermsFinal
{
    public partial class frmPatient : Form
    {
        DataTable dt = new DataTable();
        string connectionString = ("server=localhost; database=hospitaldb; pwd=1234; uid=root; port=3306");
        MySqlConnection conn;

        public frmPatient()
        {
            InitializeComponent();
        }

        private void cboCRUD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCRUD.SelectedIndex == 0) // Insert
            {
                txtPatientId.Enabled = false;
                txtFirstName.Enabled = true;
                txtLastName.Enabled = true;
                txtAddress.Enabled = true;
                txtAge.Enabled = true;
                cboDoctorLicense.Enabled = true;
                cboRoomNo.Enabled = true;
            } 
            else if (cboCRUD.SelectedIndex == 1) // Select
            {
                txtPatientId.Enabled = true;
                txtFirstName.Enabled = false;
                txtLastName.Enabled = false;
                txtAddress.Enabled = false;
                txtAge.Enabled = false;
                cboDoctorLicense.Enabled = false;
                cboRoomNo.Enabled = false;
            }
            else if (cboCRUD.SelectedIndex == 2) // Update
            {
                txtPatientId.Enabled = true;
                txtFirstName.Enabled = true;
                txtLastName.Enabled = true;
                txtAddress.Enabled = true;
                txtAge.Enabled = true;
                cboDoctorLicense.Enabled = true;
                cboRoomNo.Enabled = true;
            }
            else if (cboCRUD.SelectedIndex == 3) // Delete
            {
                txtPatientId.Enabled = true;
                txtFirstName.Enabled = false;
                txtLastName.Enabled = false;
                txtAddress.Enabled = false;
                txtAge.Enabled = false;
                cboDoctorLicense.Enabled = false;
                cboRoomNo.Enabled = false;
            }
        }

        private void frmPatient_Load(object sender, EventArgs e)
        {
            string query = ("SELECT * FROM Patient");
            conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.Fill(dt);
            conn.Close();

            dtgPatient.DataSource = dt;
            
        }


        private void label21_Click(object sender, EventArgs e)
        {

        }

        void update()
        {
            if (string.IsNullOrEmpty(txtPatientId.Text) || string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtAge.Text))
            {
                MessageBox.Show("All fields are required");
            }
            else
            {

            }
            string query = ($@"UPDATE Patient SET
                            firstName='{txtFirstName.Text}, lastName='{txtLastName.Text},
                            address='{txtAddress.Text}', age={int.Parse(txtAge.Text)},
                            doctorLicenseNo='{cboDoctorLicense.Text}', 
                            roomNo='{cboRoomNo.Text}'");
            conn = new MySqlConnection(connectionString);
            conn.Open();    
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();   


        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (cboCRUD.SelectedIndex == 2)
            {
                update();
            }
        }
    }
}
