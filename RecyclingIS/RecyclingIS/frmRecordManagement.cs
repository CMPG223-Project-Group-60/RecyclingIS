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
    public partial class frmRecordManagement : Form
    {
        private string placeholder = "Search by student or item...";
        public frmRecordManagement()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSubHeading_Click(object sender, EventArgs e)
        {

        }

        private void frmRecordManagement_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dgvRecordedItem.Columns.Clear();

            // Add text columns
            dgvRecordedItem.Columns.Add("Date", "Date");
            dgvRecordedItem.Columns.Add("Student", "Student");
            dgvRecordedItem.Columns.Add("Item", "Item");
            dgvRecordedItem.Columns.Add("Quantity", "Quantity");
            dgvRecordedItem.Columns.Add("Merit Points", "Merit Points");
            dgvRecordedItem.Columns.Add("Status", "Status");


            /* DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
             btnDelete.HeaderText = "Delete";
             btnDelete.Text = "Delete";
             btnDelete.UseColumnTextForButtonValue = true;
             dgvDisplayItems.Columns.Add(btnDelete);*/
        }

        private void btnAddRecordedItem_Click(object sender, EventArgs e)
        {
            frmAddRecordedItem add = new frmAddRecordedItem();
            add.StartPosition = FormStartPosition.CenterParent;
            add.ShowDialog(this);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateRecordedItem update = new frmUpdateRecordedItem();
            update.StartPosition = FormStartPosition.CenterParent;
            update.ShowDialog(this);
        }

        private void btnDeleteRecordedItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvRecordedItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
