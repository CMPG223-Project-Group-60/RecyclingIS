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
        public frmAssignStudents()
        {
            InitializeComponent();
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
            frmDeleteStudentProj add = new frmDeleteStudentProj();
            add.StartPosition = FormStartPosition.CenterParent;
            add.ShowDialog(this);
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
            dgvDisplayAssign.Columns.Add("Student firstname", "ProjectID");
            dgvDisplayAssign.Columns.Add("Project Name", "Project Name");
            dgvDisplayAssign.Columns.Add("Description", "Description");
            dgvDisplayAssign.Columns.Add("Due Date", "Due Date");

            
        }
    }
}
