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
    public partial class frmAddProject : Form
    {
        public string NewprojectName { get; private set; }

        string connectionString = @"Data Source=Nthabeleng_P\SQLEXPRESS02;Initial Catalog=RecyclingIS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public frmAddProject()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddProject_Load(object sender, EventArgs e)
        {

        }

        private void btnAddProj_Click(object sender, EventArgs e)
        {
            string Proj_Name = txtProjName.Text;
            string Proj_Description = txtDescription.Text;
            DateTime Proj_Due = dateTimePicker1.Value;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO RECYCLEPROJECT (Proj_Name, Proj_Description, Proj_Due) VALUES (@Proj_Name, @Proj_Description, @Proj_Due)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Proj_Name", Proj_Name);
                    cmd.Parameters.AddWithValue("@Proj_Description", Proj_Description);
                    cmd.Parameters.AddWithValue("@Proj_Due", Proj_Due);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            NewprojectName = Proj_Name;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDescription.Clear();
            txtProjName.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
