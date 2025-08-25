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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.BackColor = Color.FromArgb(240, 245, 240);

            SetMdiClientBackColor(); //overrides default mdi color (grey to green)
        }

        private void SetMdiClientBackColor()
        {
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    control.BackColor = Color.FromArgb(240, 245, 240);

                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void imgStudent_Click(object sender, EventArgs e)
        {

        }

        private void btnStudents_Click(object sender, EventArgs e)
        {

           /* frmStudentManagement students= new frmStudentManagement();
            students.StartPosition = FormStartPosition.CenterParent;
            students.ShowDialog(this);*/

            OpenChildForm(new frmStudentManagement());
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
           /* frmItemsManagement items = new frmItemsManagement();
            items.StartPosition = FormStartPosition.CenterParent;
            items.ShowDialog(this);*/

            OpenChildForm(new frmItemsManagement());

        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            /*frmRecordManagement transactions = new frmRecordManagement();
            transactions.StartPosition = FormStartPosition.CenterParent;
            transactions.ShowDialog(this);*/

            OpenChildForm(new frmRecordManagement());
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            /*frmProjectManagement projects = new frmProjectManagement();
            projects.StartPosition = FormStartPosition.CenterParent;
            projects.ShowDialog(this);*/

            OpenChildForm(new frmProjectManagement());
        }

        private void imgMerit_Click(object sender, EventArgs e)
        {

        }

        private void btnMerits_Click(object sender, EventArgs e)
        {
           /* frmMeritManagement merits = new frmMeritManagement();
            merits.StartPosition = FormStartPosition.CenterParent;
            merits.ShowDialog(this);*/

            OpenChildForm(new frmMeritManagement());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            /*frmReportManagement reports = new frmReportManagement();
            reports.StartPosition = FormStartPosition.CenterParent;
            reports.ShowDialog(this);*/

            OpenChildForm(new frmReportManagement());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDashboardManagement());
        }

        //this method will close any open mdi child form and open the current selected
        private void OpenChildForm(Form childform)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }


            childform.Dock = DockStyle.Fill;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.TopLevel = false;
            childform.MdiParent = this;
            childform.BringToFront();
            childform.Show();

            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
