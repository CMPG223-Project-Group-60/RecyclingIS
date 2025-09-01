using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RecyclingIS
{
    public partial class frmUpdateStudent : Form
    {
        string conStr = @"Data Source=Rams\SQLEXPRESS;Initial Catalog=RecyclingIS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private DataTable studentsTable;
        private int selectedStudentID = -1;
        public frmUpdateStudent()
        {
            InitializeComponent();
            LoadStudents();
            SetupForm();

        }
        private void LoadStudents()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    conn.Open();
                    string query = "SELECT StudentID, F_Name, L_Name, Grade, Gender, DOB FROM STUDENT ORDER BY L_Name, F_Name";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        studentsTable = new DataTable();
                        adapter.Fill(studentsTable);

                        // Add display column manually using a loop (FIXED)
                        studentsTable.Columns.Add("Display", typeof(string));

                        foreach (DataRow row in studentsTable.Rows)
                        {
                            row["Display"] = row["L_Name"] + ", " + row["F_Name"] + " (Grade " + row["Grade"] + ")";
                        }

                        // Bind to ComboBox
                        comboBox1.DisplayMember = "Display";
                        comboBox1.ValueMember = "StudentID";
                        comboBox1.DataSource = studentsTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SetupForm()
        {
            // Setup Grade ComboBox
            cbxGrade.Items.Clear();
            for (int i = 9; i <= 12; i++)
            {
                cbxGrade.Items.Add(i);
            }
        }
       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateStudent_Load(object sender, EventArgs e)
        {

        }

        private void cbxGrade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null && comboBox1.SelectedValue is int)
            {
                selectedStudentID = (int)comboBox1.SelectedValue;
                LoadStudentDetails(selectedStudentID);
            }
        }
        private void LoadStudentDetails(int studentID)
        {
            DataRow[] rows = studentsTable.Select($"StudentID = {studentID}");
            if (rows.Length > 0)
            {
                DataRow row = rows[0];

                txtSurname.Text = row["F_Name"].ToString();
                textBox1.Text = row["L_Name"].ToString();
                cbxGrade.SelectedItem = Convert.ToInt32(row["Grade"]);

                int gender = Convert.ToInt32(row["Gender"]);
                rdoFemale.Checked = (gender == 0);
                rdoMale.Checked = (gender == 1);

                dateTimePicker1.Value = Convert.ToDateTime(row["DOB"]);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private bool UpdateStudent(int studentID, string firstName, string lastName, int grade, int gender, DateTime dateOfBirth)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_UpdateStudent", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@StudentID", studentID);
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Grade", grade);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth.Date);

                        SqlParameter returnParam = new SqlParameter("@ReturnValue", SqlDbType.Int);
                        returnParam.Direction = ParameterDirection.ReturnValue;
                        cmd.Parameters.Add(returnParam);

                        cmd.ExecuteNonQuery();

                        int returnValue = (int)returnParam.Value;
                        return returnValue == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void ClearForm()
        {
            txtSurname.Clear();
            textBox1.Clear();
            cbxGrade.SelectedIndex = -1;
            rdoFemale.Checked = true;
            dateTimePicker1.Value = DateTime.Now.AddYears(-10);
            selectedStudentID = -1;
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (selectedStudentID == -1)
            {
                MessageBox.Show("Please select a student to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate input
            if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                MessageBox.Show("Please enter a last name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSurname.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a first name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            if (cbxGrade.SelectedItem == null)
            {
                MessageBox.Show("Please select a grade.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxGrade.Focus();
                return;
            }

            // Get updated values - FIXED: Correct field mapping
            string lastName = txtSurname.Text.Trim();      // Surname field = Last Name
            string firstName = textBox1.Text.Trim();       // textBox1 = First Name
            int grade = (int)cbxGrade.SelectedItem;
            int gender = rdoFemale.Checked ? 0 : 1;
            DateTime dateOfBirth = dateTimePicker1.Value;

            // Update student
            if (UpdateStudent(selectedStudentID, firstName, lastName, grade, gender, dateOfBirth))
            {
                MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                LoadStudents(); // Refresh the list
                ClearForm();
                
            }
        }
    }   
}
