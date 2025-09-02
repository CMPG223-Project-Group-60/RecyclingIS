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

namespace RecyclingIS
{
    public partial class frmAddStudentProj : Form
    {
        public frmAddStudentProj()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbxFirstname.SelectedItem = null;
            cbxProjname.SelectedItem = null;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnAddProj_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            string connectionString = @"Data Source=34.29.210.64;Initial Catalog=RecyclingIS;Persist Security Info=True;User ID=sqlserver;Password=223Group60";
=======
            string connectionString = @"Data Source=Nthabeleng_P\SQLEXPRESS02;Initial Catalog=RecyclingIS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
>>>>>>> ecb476944263b7f3de8b09977629dc607fad3b8e

            if (cbxFirstname.SelectedItem == null || cbxProjname.SelectedItem == null)
            {
                MessageBox.Show("Please select a student and a project before assigning.");
                return;
            }

            int studentID = Convert.ToInt32(cbxFirstname.SelectedValue);
            int projID = Convert.ToInt32(cbxProjname.SelectedValue);

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT (*) FROM STUDENTONPROJECT WHERE StudentID = @SID AND ProjID = @PID";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@SID", studentID);
                        checkCmd.Parameters.AddWithValue("@PID", projID);
                        int exists = (int)checkCmd.ExecuteScalar();
                        if (exists > 0)
                        {
                            MessageBox.Show("This student is already assigned to the selected project");
                        }
                    }

                    string insertQuery = "INSERT INTO STUDENTONPROJECT (StudentID, ProjID) VALUES (@SID, @PID)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@SID", studentID);
                        cmd.Parameters.AddWithValue("@PID", projID);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Student successfully assigned to project!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error assigning student to project: " + ex.Message);
            }
        }

        private void frmAddStudentProj_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=34.29.210.64;Initial Catalog=RecyclingIS;Persist Security Info=True;User ID=sqlserver;Password=223Group60";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Fetch all student first names
                    string query = "SELECT StudentID, (F_Name + ' ' + L_Name) AS FullName FROM STUDENT ORDER BY F_Name, L_Name";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        cbxFirstname.DataSource = dt;
                        cbxFirstname.DisplayMember = "FullName";   // what user sees
                        cbxFirstname.ValueMember = "StudentID"; // the hidden key
                    }

                    string projectQuery = "SELECT ProjID, Proj_Name, Proj_Due FROM RECYCLEPROJECT ORDER BY Proj_Name";
                    using (SqlCommand cmd = new SqlCommand(projectQuery, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                            DataTable dt = new DataTable();
                            dt.Load(reader);

                            cbxProjname.DataSource = dt;
                            cbxProjname.DisplayMember = "Proj_Name";   // what user sees
                            cbxProjname.ValueMember = "ProjID"; // the hidden key
                    }
                }
                cbxFirstname.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbxFirstname.AutoCompleteSource = AutoCompleteSource.ListItems;

                cbxProjname.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbxProjname.AutoCompleteSource = AutoCompleteSource.ListItems;

                cbxProjname.SelectedIndexChanged += cbxProjname_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student names: " + ex.Message);
            }


        }
        private void cbxProjname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxProjname.SelectedItem == null) return;
            DataRowView drv = cbxProjname.SelectedItem as DataRowView;
            if(drv != null && drv["Proj_Due"] != DBNull.Value)
            {
                dateTimePicker1.Value = Convert.ToDateTime(drv["Proj_Due"]);
            }
            else
            {
                dateTimePicker1.Value = DateTime.Now;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
