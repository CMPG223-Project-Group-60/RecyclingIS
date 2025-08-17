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


            //close existing instance of a form is its open to avoid duplication

            foreach (Form form in this.MdiChildren)
            {
                if (form is frmStudentManagement)
                {
                    form.Close();
                    break;
                }
            }


            frmStudentManagement studentform = new frmStudentManagement();
            studentform.MdiParent = this;
            studentform.Show();
            studentform.BringToFront();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            //close existing instance of a form is its open to avoid duplication

            foreach (Form form in this.MdiChildren)
            {
                if (form is frmItemsManagement)
                {
                    form.Close();
                    break;
                }
            }


           frmItemsManagement itemform = new frmItemsManagement();
           // itemform.MdiParent = this;
           itemform.Show();
           // itemform.BringToFront();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            //close existing instance of a form is its open to avoid duplication

            foreach (Form form in this.MdiChildren)
            {
                if (form is frmRecordManagement)
                {
                    form.Close();
                    break;
                }
            }


            frmRecordManagement recordform = new frmRecordManagement();
            recordform.MdiParent = this;
            recordform.Show();
            recordform.BringToFront();
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            //close existing instance of a form is its open to avoid duplication

            foreach (Form form in this.MdiChildren)
            {
                if (form is frmProjectManagement)
                {
                    form.Close();
                    break;
                }
            }


            frmProjectManagement projform = new frmProjectManagement();
            projform.MdiParent = this;
            projform.Show();
            projform.BringToFront();
        }

        private void imgMerit_Click(object sender, EventArgs e)
        {

        }

        private void btnMerits_Click(object sender, EventArgs e)
        {
            //close existing instance of a form is its open to avoid duplication

            foreach (Form form in this.MdiChildren)
            {
                if (form is frmMeritManagement)
                {
                    form.Close();
                    break;
                }
            }


            frmMeritManagement meritform = new frmMeritManagement();
            meritform.MdiParent = this;
            meritform.Show();
            meritform.BringToFront();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {

            foreach (Form form in this.MdiChildren)
            {
                if (form is frmReportManagement)
                {
                    form.Close();
                    break;
                }
            }


            frmReportManagement reportform = new frmReportManagement();
            reportform.MdiParent = this;
            reportform.Show();
            reportform.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmDashboardManagement)
                {
                    form.Close();
                    break;
                }
            }


            frmDashboardManagement dashboardform = new frmDashboardManagement();
            dashboardform.MdiParent = this;
            dashboardform.Show();
            dashboardform.BringToFront();
        }
    }
}
