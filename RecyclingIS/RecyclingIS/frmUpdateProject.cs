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
    public partial class frmUpdateProject : Form
    {
        private int projectID;
<<<<<<< HEAD
        private string connectionString = @"Data Source=34.29.210.64;Initial Catalog=RecyclingIS;Persist Security Info=True;User ID=sqlserver;Password=223Group60";
=======
        string connectionString = @"Data Source=Rams\SQLEXPRESS;Initial Catalog=RecyclingIS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

>>>>>>> ecb476944263b7f3de8b09977629dc607fad3b8e
        public frmUpdateProject(int projID, string name, string description, DateTime dueDate)
        {
            InitializeComponent();
            projectID = projID;

            LoadProjectNames();

            cbProjName.SelectedItem = name;
            txtProjDesc.Text = description;
            dateTimeProjDue.Value = dueDate;
        }

        private void LoadProjectNames()
        {
            cbProjName.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT DISTINCT Proj_Name FROM RECYCLEPROJECT";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbProjName.Items.Add(reader["Proj_Name"].ToString());
                        }
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmUpdateProject_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateProj_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE RECYCLEPROJECT SET Proj_Name = @Name, Proj_Description = @Description, Proj_Due = @Due_Date WHERE ProjID = @ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", cbProjName.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@Description", txtProjDesc.Text);
                    cmd.Parameters.AddWithValue("@Due_Date", dateTimeProjDue.Value);
                    cmd.Parameters.AddWithValue("@ID", projectID);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Project updated successfully!");
            this.DialogResult = DialogResult.OK;
                        this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProjDesc.Clear();
            dateTimeProjDue.Value = DateTime.Now;
        }
    }
}
