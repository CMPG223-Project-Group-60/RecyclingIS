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
    public partial class frmAssignStudents : Form
    {
        private DataTable assignmentsTable;
        private string placeholder = "Search student on projects by firstname, lastname, project name";
        //string connString = @"Data Source=34.29.210.64;Initial Catalog=RecyclingDB;Persist Security Info=True;User ID=sqlserver;Password=***********;Encrypt=True;TrustServerCertificate=True";
        public frmAssignStudents()
        {
            InitializeComponent();

            // Set initial placeholder
            txtSearch.Text = placeholder;
            txtSearch.ForeColor = Color.DarkGray;

            // Hook up events
            txtSearch.Enter += RemovePlaceholder;
            txtSearch.Leave += SetPlaceholder;
            txtSearch.TextChanged += txtSearch_TextChanged;
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

        private void btnAddStudentProj_Click(object sender, EventArgs e)
        {
            frmAddStudentProj add = new frmAddStudentProj();
            add.StartPosition = FormStartPosition.CenterParent;
            add.ShowDialog(this);
        }

        private void btnUpdateStudentProj_Click(object sender, EventArgs e)
        {
            frmUpdateStudentProj add = new frmUpdateStudentProj();
            add.StartPosition = FormStartPosition.CenterParent;
            add.ShowDialog(this);
        }

        private void btnDeleteStudentProj_Click(object sender, EventArgs e)
        {
            if (dgvDisplayAssign.CurrentRow == null)
            {
                MessageBox.Show("Please select a student assignment to delete.");
                return;
            }

            // Get values from the current row
            string firstName = dgvDisplayAssign.CurrentRow.Cells["F_Name"].Value.ToString();
            string lastName = dgvDisplayAssign.CurrentRow.Cells["L_Name"].Value.ToString();
            string projectName = dgvDisplayAssign.CurrentRow.Cells["Proj_Name"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to remove {firstName} {lastName} from project {projectName}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.No) return;

            string connectionString = @"Data Source=34.29.210.64;Initial Catalog=RecyclingIS;Persist Security Info=True;User ID=sqlserver;Password=223Group60";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Find StudentID and ProjID for the selected row
                string getIdsQuery = @"
                SELECT sp.StudentID, sp.ProjID
                FROM STUDENTONPROJECT sp
                INNER JOIN STUDENT s ON sp.StudentID = s.StudentID
                INNER JOIN RECYCLEPROJECT p ON sp.ProjID = p.ProjID
                WHERE s.F_Name = @fname AND s.L_Name = @lname AND p.Proj_Name = @pname";

                int studentId = 0;
                int projId = 0;

                using (SqlCommand cmd = new SqlCommand(getIdsQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@fname", firstName);
                    cmd.Parameters.AddWithValue("@lname", lastName);
                    cmd.Parameters.AddWithValue("@pname", projectName);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            studentId = reader.GetInt32(0);
                            projId = reader.GetInt32(1);
                        }
                        else
                        {
                            MessageBox.Show("Could not find the assignment in the database.");
                            return;
                        }
                    }
                }

                // Delete from STUDENTONPROJECT
                string deleteQuery = "DELETE FROM STUDENTONPROJECT WHERE StudentID = @sid AND ProjID = @pid";

                using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@sid", studentId);
                    cmd.Parameters.AddWithValue("@pid", projId);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Assignment deleted successfully.");
                        LoadAssignments(); // refresh DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete assignment.");
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAssignStudents_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadAssignments();
        }

        private void SetupDataGridView()
        {
            dgvDisplayAssign.Columns.Clear();
            dgvDisplayAssign.AutoGenerateColumns = false;

            dgvDisplayAssign.Columns.Add("F_Name", "Student Firstname");
            dgvDisplayAssign.Columns["F_Name"].DataPropertyName = "F_Name";

            dgvDisplayAssign.Columns.Add("L_Name", "Student Lastname");
            dgvDisplayAssign.Columns["L_Name"].DataPropertyName = "L_Name";

            dgvDisplayAssign.Columns.Add("Proj_Name", "Project name");
            dgvDisplayAssign.Columns["Proj_Name"].DataPropertyName = "Proj_Name";

            dgvDisplayAssign.Columns.Add("Proj_Due", "Project Due Date");
            dgvDisplayAssign.Columns["Proj_Due"].DataPropertyName = "Proj_Due";


        }

        private void LoadAssignments()
        {
            string connectionString = @"Data Source=34.29.210.64;Initial Catalog=RecyclingIS;Persist Security Info=True;User ID=sqlserver;Password=223Group60";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT s.F_Name, s.L_Name, p.Proj_Name, p.Proj_Due
                    FROM STUDENTONPROJECT sp
                    INNER JOIN STUDENT s ON sp.StudentID = s.StudentID
                    INNER JOIN RECYCLEPROJECT p ON sp.ProjID = p.ProjID";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                assignmentsTable = new DataTable();
                da.Fill(assignmentsTable);

                assignmentsTable.Columns.Add("Fullname", typeof(string), "F_Name + ' ' + L_Name");

                dgvDisplayAssign.DataSource = assignmentsTable;
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (assignmentsTable == null) return;

            if (txtSearch.Text == placeholder)
            {
                (dgvDisplayAssign.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                return;
            }

            string filterText = txtSearch.Text.Replace("'", "''");

            string filter = string.Format(
                "F_Name LIKE '%{0}%' OR L_Name LIKE '%{0}%' OR FullName LIKE'%{0}%' OR Proj_Name LIKE '%{0}%'",
                filterText);

            (dgvDisplayAssign.DataSource as DataTable).DefaultView.RowFilter = filter;
        }
    }
}
