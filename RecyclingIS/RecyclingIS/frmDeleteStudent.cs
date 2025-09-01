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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace RecyclingIS
{
    public partial class frmDeleteStudent : Form
    {
        String conStr = @"Data Source=Nthabeleng_P\SQLEXPRESS02;Initial Catalog=RecyclingIS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        
        public frmDeleteStudent()
        {
            InitializeComponent();
            
        }
   
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Please select a student.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int studentID = Convert.ToInt32(comboBox1.SelectedValue);
            string studentName = comboBox1.Text;

            // Confirm before deleting
            DialogResult result = MessageBox.Show($"Are you sure you want to delete {studentName}?",
                                                  "Confirm Delete",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(conStr))
                    {
                        SqlCommand cmd = new SqlCommand("sp_DeleteStudent", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@StudentID", studentID);

                        // Add parameter to capture RETURN value from stored procedure
                        SqlParameter returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                        returnParameter.Direction = ParameterDirection.ReturnValue;

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        int resultCode = (int)returnParameter.Value;

                        if (resultCode == 1) // Success
                        {
                            MessageBox.Show("Student deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadStudents(); // Refresh list
                        }
                        else if (resultCode == -1) // Error
                        {
                            MessageBox.Show("Error occurred while deleting the student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("No student deleted. Please try again.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    
        private void frmDeleteStudent_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }
        private void LoadStudents()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    string query = "SELECT StudentID, (F_Name + ' ' + L_Name + ' - Grade ' + CAST(Grade AS VARCHAR)) AS StudentInfo FROM STUDENT";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "StudentInfo";  // What user sees
                    comboBox1.ValueMember = "StudentID";      // The ID
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }
        private void ClearForm()
        {
           
        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
    }
}
