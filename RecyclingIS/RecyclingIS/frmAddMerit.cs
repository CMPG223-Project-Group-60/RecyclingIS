using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RecyclingIS
{
    public partial class frmAddMerit: Form
    {
        string constr = @"Data Source=Rams\SQLEXPRESS;Initial Catalog=RecyclingIS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public frmAddMerit()
        {
            InitializeComponent();
        }

        private void frmAddMerit_Load(object sender, EventArgs e)
        {
            txtMeritType.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }

        
    }
}
