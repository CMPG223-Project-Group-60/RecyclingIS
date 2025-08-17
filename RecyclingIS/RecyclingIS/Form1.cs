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
            frmStudentManagement studentform = new frmStudentManagement();
            studentform.MdiParent = this;
            studentform.Show();
        }
    }
}
