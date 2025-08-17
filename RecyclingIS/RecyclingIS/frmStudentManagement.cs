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
    public partial class frmStudentManagement : Form
    {
        public frmStudentManagement()
        {
            InitializeComponent();

            //to fill the available space when the form opens and you click the student button
            /*this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;*/
        }

        private void frmStudentManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
