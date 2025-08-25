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
    public partial class frmProjectManagement : Form
    {
        private string placeholder = "Search students by number, name, or grade...";
        public frmProjectManagement()
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

        private void SetupDataGridView()
        {
            dgvDisplayProjects.Columns.Clear();

            // Add text columns
            dgvDisplayProjects.Columns.Add("Last Name", "Last Name");
            dgvDisplayProjects.Columns.Add("First Name", "First Name");
            dgvDisplayProjects.Columns.Add("Grade", "Grade");
            dgvDisplayProjects.Columns.Add("Gender", "Gender");
            dgvDisplayProjects.Columns.Add("Date of Birth", "Date of Birth");

            /* DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
             btnDelete.HeaderText = "Delete";
             btnDelete.Text = "Delete";
             btnDelete.UseColumnTextForButtonValue = true;
             dgvDisplayItems.Columns.Add(btnDelete);*/
        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void frmProjectManagement_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            frmAddProject add = new frmAddProject();
            add.StartPosition = FormStartPosition.CenterParent;
            add.ShowDialog(this);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateProject update = new frmUpdateProject();
            update.StartPosition = FormStartPosition.CenterParent;
            update.ShowDialog(this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDeleteProject delete = new frmDeleteProject();
            delete.StartPosition = FormStartPosition.CenterParent;
            delete.ShowDialog(this);
        }

        private void btnStuProj_Click(object sender, EventArgs e)
        {
            frmAssignStudents assign = new frmAssignStudents();
            assign.StartPosition = FormStartPosition.CenterParent;
            assign.ShowDialog(this);
        }
    }
}
