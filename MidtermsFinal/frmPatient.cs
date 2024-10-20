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
using System.Collections;

namespace MidtermsFinal
{
    public partial class frmPatient : Form
    {
        string query;

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
            // Disable all input fields
            txtPatientId.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtAddress.Enabled = false;
            txtAge.Enabled = false;
            cboDoctorLicense.Enabled = false;
            cboRoomNo.Enabled = false;


            conn = new MySqlConnection(connectionString);

            // populate combo box with doctor license
            string query = "SELECT licenseNo FROM Doctor";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            
            while(dr.Read())
            {
                cboDoctorLicense.Items.Add(dr["licenseNo"].ToString());
            }

            dr.Close();
            conn.Close();

            // populate combobox with room number
            query = ($"SELECT roomNo FROM Room WHERE roomType='Private'");
            conn.Open();
            cmd = new MySqlCommand(query, conn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cboRoomNo.Items.Add(dr["roomNo"].ToString());
            }
            conn.Close();

            // display all patient data in datatable
            selectAll();
            
        }


        void update()
        {
            if (string.IsNullOrEmpty(txtPatientId.Text) || string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtAge.Text))
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
                query = ($@"UPDATE Patient SET
                        firstName='{txtFirstName.Text}', lastName='{txtLastName.Text}', 
                        address='{txtAddress.Text}', age={int.Parse(txtAge.Text)}, 
                        doctorLicenseNo='{cboDoctorLicense.Text}', 
                        roomNo='{cboRoomNo.Text}' 
                        WHERE patientID='{txtPatientId.Text}'");
                conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                // Display patient data in datatable
                selectAll();
                clearInputFields();
            }
            
        }

        void selectAll()
        {
            // clear datatable and datagridview first
            dt.Clear();
            dtgPatient.DataSource = null;

            conn = new MySqlConnection(connectionString);

            // populate datatable with data of all patients
            query = ("SELECT * FROM Patient");
            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.Fill(dt);
            conn.Close();
            dtgPatient.DataSource = dt;

        }
        void delete()
        {
            if (string.IsNullOrEmpty(txtPatientId.Text))
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
                query = ($@"DELETE FROM Patient WHERE patientID='{txtPatientId.Text}'");
                conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                // Display patient data in datatable
                selectAll();
                clearInputFields();
            }


        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (cboCRUD.SelectedIndex == 0)
            {
                insert();
            }
            else if (cboCRUD.SelectedIndex == 1)
            {
                selectIndividual();
            }
            else if (cboCRUD.SelectedIndex == 2) 
            {
                update();
            }
            else if (cboCRUD.SelectedIndex == 3) 
            {
                delete();
            }

        }

        void clearInputFields()
        {
            txtPatientId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtAge.Clear();
            cboDoctorLicense.SelectedIndex = -1;
            cboRoomNo.SelectedIndex = -1;   
        }

        void insert()
        {
            if (string.IsNullOrEmpty(txtPatientId.Text) || string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtAge.Text))
            {
                MessageBox.Show("All input fields are required");
            }
            else
            {
                query = (@"INSERT INTO Patient(patientID, firstName, lastName, address, age, doctorLicenseNo, roomNo)
                            VALUES('" + txtPatientId.Text + "', '" + txtFirstName.Text + "','" + txtLastName.Text + "', '" + 
                            txtAddress.Text + "', '" + txtAge.Text + "', '" + cboDoctorLicense.SelectedItem.ToString() + 
                            "', '" + cboRoomNo.SelectedItem.ToString() + "')");
                conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Record Successfully Added!");
            }
            
        }

        void selectIndividual()
        {
            query = "SELECT * FROM Patient WHERE patientID ='" + txtPatientId.Text + "'";
            conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            cmd.ExecuteNonQuery();
            MySqlDataReader dr = cmd.ExecuteReader();

            dr.Read();

            lblPatientFirstName.Text = ($"First Name: {dr["firstName"].ToString()}");
            lblPatientLastName.Text = ($"Last Name: {dr["lastName"].ToString()}");
            lblAddress.Text = ($"Address: {dr["address"].ToString()}");
            lblAge.Text = ($"Age: {dr["age"].ToString()}");


            dr.Close();
            conn.Close();

            displayDoctorInformation();
            displayRoomInformation();
            
            
        }

        void displayDoctorInformation()
        {
            query = ($@"SELECT Doctor.* FROM Doctor INNER JOIN Patient 
                    ON Doctor.licenseNo = Patient.doctorLicenseNo 
                    WHERE Patient.patientID='{txtPatientId.Text}'");
            conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            dr.Read();
            lblLicenseNumber.Text = ($"License Number: {dr["licenseNo"].ToString()}");
            lblDoctorFirstName.Text = ($"First Name: {dr["firstName"].ToString()}");
            lblDoctorLastName.Text = ($"Last Name: {dr["lastName"].ToString()}");
            lblSpecialization.Text = ($"Specialization: {dr["specializationName"].ToString()}");
            dr.Close();
            conn.Close();
        }

        void displayRoomInformation()
        {
            query = ($@"SELECT Room.* FROM Room INNER JOIN Patient 
                    ON Room.roomNo = Patient.roomNo 
                    WHERE Patient.patientID = '{txtPatientId.Text}'");
            conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            dr.Read();
            lblRoomNumber.Text = ($"Room Number: {dr["roomNo"].ToString()}");
            lblRoomType.Text = ($"Type: {dr["roomType"].ToString()}");
            lblAvailabilityStatus.Text = ($"Availability status: {dr["roomAvailability"].ToString()}");

            dr.Close();
            conn.Close();

        }
    }
}
