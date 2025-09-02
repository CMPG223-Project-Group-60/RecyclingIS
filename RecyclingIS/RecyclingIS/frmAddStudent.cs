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
        string ConStr = @"Data Source=Nthabeleng_P\SQLEXPRESS02;Initial Catalog=RecyclingIS;Integrated Security=True;Encrypt=True;Trust
ServerCertificate=True"; 
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

            // Convert gender to INT (0 for Female, 1 for Male)
            int genderValue = rdoFemale.Checked ? 0 : 1;

            DateTime dateOfBirth = dateTimePicker1.Value;

            // Add student to database using stored procedure
            int newStudentId = AddStudentToDatabase(firstName, lastName, grade, genderValue, dateOfBirth);

            if (newStudentId > 0)
            {
                MessageBox.Show($"Student added successfully! Student ID: {newStudentId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }


        }

        private int AddStudentToDatabase(string firstName, string lastName, string grade, int gender, DateTime dateOfBirth)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConStr))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_AddStudent", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add input parameters
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Grade", Convert.ToInt32(grade));
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth.Date);

                        // Add output parameter for StudentID
                        SqlParameter studentIdParam = new SqlParameter("@StudentID", SqlDbType.Int);
                        studentIdParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(studentIdParam);

                        // Add return value parameter
                        SqlParameter returnParam = new SqlParameter("@ReturnValue", SqlDbType.Int);
                        returnParam.Direction = ParameterDirection.ReturnValue;
                        cmd.Parameters.Add(returnParam);

                        // Execute the stored procedure
                        cmd.ExecuteNonQuery();

                        // Get the return value
                        int returnValue = (int)returnParam.Value;

                        if (returnValue == 1) // Success
                        {
                            // Return the newly created StudentID
                            return (int)studentIdParam.Value;
                        }
                        else
                        {
                            MessageBox.Show("Failed to add student. Database returned error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return -1;
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error adding student: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
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
