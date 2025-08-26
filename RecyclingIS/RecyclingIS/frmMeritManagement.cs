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
    public partial class frmMeritManagement : Form
    {
        public frmMeritManagement()
        {
            InitializeComponent();
        }

        private void frmMeritManagement_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dgvDisplayMerits.Columns.Clear();

            // Add text columns
            dgvDisplayMerits.Columns.Add("Merit Type", "Merit Type");
            dgvDisplayMerits.Columns.Add("Points Awarded", "Points Awarded");
            


            /* DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
             btnDelete.HeaderText = "Delete";
             btnDelete.Text = "Delete";
             btnDelete.UseColumnTextForButtonValue = true;
             dgvDisplayItems.Columns.Add(btnDelete);*/
        }

        private void dgvDisplayMerits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddMerit_Click(object sender, EventArgs e)
        {
            frmAddMerit add = new frmAddMerit();
            add.StartPosition = FormStartPosition.CenterParent;
            add.ShowDialog(this);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdate_Merit update = new frmUpdate_Merit();
            update.StartPosition = FormStartPosition.CenterParent;
            update.ShowDialog(this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDeleteMerit delete = new frmDeleteMerit();
            delete.StartPosition = FormStartPosition.CenterParent;
            delete.ShowDialog(this);
        }
    }
}
