using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RecyclingIS
{
    public partial class frmAddStudent : Form
    {
        String ConStr = @"Data Source=Nthabeleng_P\SQLEXPRESS02;Initial Catalog=RecyclingIS;Integrated Security=True;TrustServerCertificate=true;";
        public frmAddStudent()
        {
            InitializeComponent();
            SetupForm();
        }
        private void SetupForm()
        {
            // Setup Grade ComboBox
            cbxGrade.Items.Clear();
            for (int i = 9; i <= 12; i++)
            {
                cbxGrade.Items.Add( i);
            }
            cbxGrade.SelectedIndex = 0; // Default to Grade 1

            // Setup Date of Birth - set to a reasonable default (e.g., 10 years ago)
            dateTimePicker1.Value = DateTime.Now.AddYears(-10);
            dateTimePicker1.MaxDate = DateTime.Now; // Can't select future dates
            dateTimePicker1.MinDate = DateTime.Now.AddYears(-25); // Reasonable minimum age

            // Set default gender selection
            rdoFemale.Checked = true;
        }
        private void rdoMale_AppearanceChanged(object sender, EventArgs e)
        {

        }

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        private void lblSubHeading_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxGrade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a first name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                MessageBox.Show("Please enter a last name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSurname.Focus();
                return;
            }

            if (cbxGrade.SelectedItem == null)
            {
                MessageBox.Show("Please select a grade.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxGrade.Focus();
                return;
            }

            // Get form data
            string firstName = txtName.Text.Trim();
            string lastName = txtSurname.Text.Trim();
            string grade = cbxGrade.SelectedItem.ToString();
            string gender = rdoFemale.Checked ? "Female" : "Male";
            DateTime dateOfBirth = dateTimePicker1.Value;

            // Add student to database
            if (AddStudentToDatabase(firstName, lastName, grade, gender, dateOfBirth))
            {
                MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }


        }
        private bool AddStudentToDatabase(string firstName, string lastName, string grade, string gender, DateTime dateOfBirth)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConStr))
                {
                    conn.Open();
                    string query = @"INSERT INTO Student (F_Name, L_Name, Grade, Gender, DOB) 
                                   VALUES (@FirstName, @LastName, @Grade, @Gender, @DateOfBirth)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Grade", grade);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth.Date);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding student: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void ClearForm()
        {
            txtName.Clear();
            txtSurname.Clear();
            cbxGrade.SelectedIndex = 0;
            rdoFemale.Checked = true;
            dateTimePicker1.Value = DateTime.Now.AddYears(-10);
            txtName.Focus();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
