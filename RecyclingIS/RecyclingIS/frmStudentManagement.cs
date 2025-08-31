using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;

namespace RecyclingIS
{
    public partial class frmStudentManagement : Form
    {
        private string placeholder = "Search students by Name";
        String ConStr = @"Data Source=Rams\SQLEXPRESS;Initial Catalog=RecyclingIS;Integrated Security=True;TrustServerCertificate=True";
        
        public frmStudentManagement()
        {
            InitializeComponent();

            //to fill the available space when the form opens and you click the student button
            /*this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;*/

            // Set initial placeholder
            txtSearch.Text = placeholder;
            txtSearch.ForeColor = Color.DarkGray;

            // Hook up events
            txtSearch.Enter += RemovePlaceholder;
            txtSearch.Leave += SetPlaceholder;
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

        private void frmStudentManagement_Load(object sender, EventArgs e)
        {
            //SetupDataGridView();
            LoadStudents();

        }
        private void SetupDataGridView()
        {
            dgvDisplayStudents.Columns.Clear();

            // Add text columns
            dgvDisplayStudents.Columns.Add("Last Name", "Last Name");
            dgvDisplayStudents.Columns.Add("First Name", "First Name");
            dgvDisplayStudents.Columns.Add("Grade", "Grade");
            dgvDisplayStudents.Columns.Add("Gender", "Gender");
            dgvDisplayStudents.Columns.Add("Date of Birth", "Date of Birth");

            /* DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
             btnDelete.HeaderText = "Delete";
             btnDelete.Text = "Delete";
             btnDelete.UseColumnTextForButtonValue = true;
             dgvDisplayItems.Columns.Add(btnDelete);*/
        }


        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmAddStudent student = new frmAddStudent();
            student.StartPosition = FormStartPosition.CenterParent;
            student.ShowDialog(this);



        }
        private void LoadStudents()
        {
            dgvDisplayStudents.DataSource = GetStudentsByName("");
        }

        private DataTable GetStudentsByName(string searchName)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(ConStr))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_GetStudentsByName", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@SearchName", searchName);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching students: " + ex.Message);
            }

            return dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateStudent update = new frmUpdateStudent();
            update.StartPosition = FormStartPosition.CenterParent;
            update.ShowDialog(this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDeleteStudent delete = new frmDeleteStudent();
            delete.StartPosition = FormStartPosition.CenterParent;
            delete.ShowDialog(this);
            
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Every time the user types, rebind the grid to the filtered data
            dgvDisplayStudents.DataSource = GetStudentsByName(txtSearch.Text);

        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void dgvDisplayStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
