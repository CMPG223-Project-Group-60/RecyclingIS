using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecyclingIS
{
    public partial class frmAssignStudents : Form
    {
        private string placeholder = "Search student on projects by firstname, lastname, project name";

        public frmAssignStudents()
        {
            InitializeComponent();

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
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAssignStudents_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dgvDisplayAssign.Columns.Clear();

            // Add text columns
            dgvDisplayAssign.Columns.Add("Student firstname", "Student firstname");
            dgvDisplayAssign.Columns.Add("Student lastname", "Student lastname");
            dgvDisplayAssign.Columns.Add("Project name", "Project name");
            dgvDisplayAssign.Columns.Add("Project Due Date", "Project Due Date");

            
        }
    }
}
