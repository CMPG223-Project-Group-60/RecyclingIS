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
using static System.Net.Mime.MediaTypeNames;

namespace RecyclingIS
{ 
    public partial class frmProjectManagement : Form
    {
        private string connectionString = @"Data Source=34.29.210.64;Initial Catalog=RecyclingIS;Persist Security Info=True;User ID=sqlserver;Password=223Group60";

        private string placeholder = "Search projects by ID, name";
        private DataTable projectsTable;
        public frmProjectManagement()
        {
            InitializeComponent();

            // Set initial placeholder
            txtSearch.Text = placeholder;
            txtSearch.ForeColor = Color.DarkGray;

            // Hook up events
            txtSearch.Enter += RemovePlaceholder;
            txtSearch.Leave += SetPlaceholder;
            //txtSearch.TextChanged += TxtSearch_TextChanged;
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (txtSearch.Text == placeholder)
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = placeholder;
                txtSearch.ForeColor = Color.DarkGray;
            }
        }

        private void SetupDataGridView()
        {
            dgvDisplayProjects.Columns.Clear();

            // Add text columns
            dgvDisplayProjects.Columns.Add("Project ID", "ProjectID");
            dgvDisplayProjects.Columns.Add("Project Name", "Project Name");
            dgvDisplayProjects.Columns.Add("Project Description", "Description");
            dgvDisplayProjects.Columns.Add("Proj Due Date", "Due Date");
        }
        private void lblHeading_Click(object sender, EventArgs e)
        {

        }
        private void LoadProjects()
        {
            string connectionString = "Data Source=34.29.210.64;Initial Catalog=RecyclingIS;Persist Security Info=True;User ID=sqlserver;Password=223Group60";
            SetupDataGridView();

            string query = @"
            SELECT 
                ProjID   AS [Project ID], 
                Proj_Name AS [Project Name], 
                Proj_Description AS [Project Description], 
                Proj_Due  AS [Proj Due Date]
            FROM RECYCLEPROJECT";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
            {
                //SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dt;
            }
        }

        private void frmProjectManagement_Load(object sender, EventArgs e)
        {
            
            LoadProjects();

        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            using (frmAddProject add = new frmAddProject())
            { 
                add.StartPosition = FormStartPosition.CenterParent;
                if (add.ShowDialog(this) == DialogResult.OK)
                { 
                    LoadProjects();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int projID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Project ID"].Value);
                string name = dataGridView1.SelectedRows[0].Cells["Project Name"].Value.ToString();
                string desc = dataGridView1.SelectedRows[0].Cells["Project Description"].Value.ToString();
                DateTime due = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["Proj Due Date"].Value);

                using (frmUpdateProject update = new frmUpdateProject(projID, name, desc, due))
                {
                    update.StartPosition = FormStartPosition.CenterParent;
                    if (update.ShowDialog(this) == DialogResult.OK)
                    {
                        LoadProjects();
                    }
                }
            }
            else
            { 
                MessageBox.Show("Please select a project to update.");
            }
            /*frmUpdateProject update = new frmUpdateProject();
            update.StartPosition = FormStartPosition.CenterParent;
            update.ShowDialog(this);*/
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /*frmDeleteProject delete = new frmDeleteProject();
            delete.StartPosition = FormStartPosition.CenterParent;
            delete.ShowDialog(this);*/

            if (dataGridView1.SelectedRows.Count > 0)
            {    
                int projectID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Project ID"].Value);

                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to delete this project?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    //string connectionString = "Data Source=34.29.210.64;Initial Catalog=RecyclingIS;Persist Security Info=True;User ID=sqlserver;Password=223Group60\";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM RECYCLEPROJECT WHERE ProjID = @Proj_ID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Proj_ID", projectID);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                    frmProjectManagement_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Please select a project to delete.");
            }
        }

        private void btnStuProj_Click(object sender, EventArgs e)
        {
            frmAssignStudents assign = new frmAssignStudents();
            assign.StartPosition = FormStartPosition.CenterParent;
            assign.ShowDialog(this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
