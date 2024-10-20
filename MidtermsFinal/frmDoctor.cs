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
    public partial class frmDoctor : Form
    {
        string licenseNo, firstName, lastName, specialization;

        string query;

        // Note on the relationship of datatable and datagrid: the are linked through databinding
        DataTable dt = new DataTable();
        DataTable dtPatients = new DataTable();

        string connectionString = ("server=localhost; database=hospitaldb; pwd=1234; uid=root; port=3306");
        MySqlConnection conn;

        public frmDoctor()
        {
            InitializeComponent();
        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {
            disableAllInputFields();

            selectAll();

            // populate combobox with specialization
            query = "SELECT specializationName FROM Specialization";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader(); // required to keep the connection open

            while (dr.Read()) // This goes through the rows and stops once dr.Read() returns false. Once it returns false, it stays as false unless dr is re-initialized.
            {
                cboSpecialization.Items.Add(dr["specializationName"].ToString());
            }
            conn.Close(); // close it only after the loop is over

        }

        private void cboCRUD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCRUD.SelectedIndex == 0) // Create
            {
                enableAllInputFields();
            }
            else if (cboCRUD.SelectedIndex == 1) // Read
            {
                enablePrimaryKeyInputFieldOnly();
            }
            else if (cboCRUD.SelectedIndex == 2) // Update
            {
                enableAllInputFields();
            }
            else if (cboCRUD.SelectedIndex == 3) // Delete
            {
                enablePrimaryKeyInputFieldOnly();
            }
        }

        void enableAllInputFields()
        {
            txtLicenseNumber.Enabled = true;
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            cboSpecialization.Enabled = true;
        }

        void enablePrimaryKeyInputFieldOnly()
        {
            txtLicenseNumber.Enabled = true;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            cboSpecialization.Enabled = false;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (cboCRUD.SelectedIndex == 0) // Create
            {
                insert();
            }
            else if (cboCRUD.SelectedIndex == 1) // Read
            {
                selectIndividual();
            }
            else if (cboCRUD.SelectedIndex == 2) // Update
            {
                update();
            }
            else if (cboCRUD.SelectedIndex == 3) // Delete
            {
                delete();
            }
        }

        void selectAll()
        {
            dt.Clear();
            dtgDoctor.DataSource = null;

            query = "SELECT * FROM Doctor";
            conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.Fill(dt);
            conn.Close();
            dtgDoctor.DataSource = dt;
        }

        void insert()
        {
            query = ($@"INSERT INTO Doctor(licenseNo, firstName, lastName, specializationName) 
                    VALUES('{txtLicenseNumber.Text}', '{txtFirstName.Text}', '{txtLastName.Text}', 
                    '{cboSpecialization.Text}')");
            conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            selectAll();
            disableAllInputFields();
            clearAllInputFields();
        }

        void selectIndividual()
        {
            query = ($"SELECT * FROM Doctor WHERE licenseNo='{txtLicenseNumber.Text}'");
            conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            // Initialize the variables to be put in the label
            dr.Read(); // Read the first row of the result returned by the query(doctor)
            licenseNo = dr["licenseNo"].ToString();
            firstName = dr["firstName"].ToString();
            lastName = dr["lastName"].ToString();
            specialization = dr["specializationName"].ToString();

            dr.Close();
            conn.Close();

            lblLicenseNo.Text = ($"License Number: {licenseNo}");
            lblFirstName.Text = ($"First Name: {firstName}");
            lblLastName.Text = ($"Last Name: {lastName}");
            lblSpecialization.Text = ($"Specialization: {specialization}");

            // Get the patients data
            getPatientsData();
            disableAllInputFields();
            clearAllInputFields();

        }
        void update()
        {
            query = ($@"UPDATE Doctor SET firstName='{txtFirstName.Text}', lastName='{txtLastName.Text}', 
            specializationName='{cboSpecialization.Text}' 
            WHERE licenseNo='{txtLicenseNumber.Text}'");
            conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            selectAll();
            disableAllInputFields();
            clearAllInputFields();
        }
        void delete()
        {
            query = ($@"DELETE FROM Doctor WHERE Doctor.licenseNo='{txtLicenseNumber.Text}' 
                    AND Doctor.LicenseNo NOT IN (SELECT Patient.doctorLicenseNo FROM Patient)");
            conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            // execute the query and get the number of rows affected 
            int affectedRows = cmd.ExecuteNonQuery();

            // Get the rows returned by the query
            conn.Close();

            if (affectedRows == 0)
            {
                MessageBox.Show("Deletion failed because it is referenced in another table");
            }

            selectAll();
            disableAllInputFields();
            clearAllInputFields();
        }

        void disableAllInputFields()
        {
            txtLicenseNumber.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            cboSpecialization.Enabled = false;
        }

        void getPatientsData()
        {
            dtPatients.Clear(); // Clear contents of datatable first

            query = ($"SELECT * FROM Patient WHERE doctorLicenseNo='{txtLicenseNumber.Text}'");
            conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.Fill(dtPatients);
            conn.Close();
            dtgPatients.DataSource = dtPatients;

        }

        void clearAllInputFields()
        {
            txtLicenseNumber.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            cboSpecialization.SelectedIndex = -1;
            cboCRUD.SelectedIndex = -1;
        }
    }
}
