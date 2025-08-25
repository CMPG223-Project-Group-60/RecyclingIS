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

namespace RecyclingIS
{
    public partial class frmStudentManagement : Form
    {
        private string placeholder = "Search students by number, name, or grade...";

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
            SetupDataGridView();
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

        }
    }
}
