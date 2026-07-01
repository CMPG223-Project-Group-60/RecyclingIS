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
    public partial class frmItemsManagement : Form
    {
        private string placeholder = "Search by name or description...";

        public frmItemsManagement()
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


        private void frmItemsManagement_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            PopulateCatalog();
            dgvDisplayItems.CellContentClick += dgvCatalog_CellContentClick;
        }

        private void SetupDataGridView()
        {
            dgvDisplayItems.Columns.Clear();

            // Add text columns
            dgvDisplayItems.Columns.Add("Name", "Name");
            dgvDisplayItems.Columns.Add("Quantity", "Quantity");
            dgvDisplayItems.Columns.Add("Description", "Description");

            // Add button columns
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            btnUpdate.HeaderText = "Update";
            btnUpdate.Text = "Update";
            btnUpdate.UseColumnTextForButtonValue = true;
            dgvDisplayItems.Columns.Add(btnUpdate);

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.HeaderText = "Delete";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            dgvDisplayItems.Columns.Add(btnDelete);
        }

        private void PopulateCatalog()
        {
            dgvDisplayItems.Rows.Clear();
            dgvDisplayItems.Rows.Add("Plastic Bottle", 100, "Clean plastic bottles (PET)");
            dgvDisplayItems.Rows.Add("Aluminum Can", 447, "Aluminum beverage cans");
            dgvDisplayItems.Rows.Add("Paper Waste", 33, "Clean paper and cardboard");
        }

        private void dgvCatalog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignore header row

            // Update button clicked
            if (dgvDisplayItems.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                string name = dgvDisplayItems.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                int quantity = 0;
                int.TryParse(dgvDisplayItems.Rows[e.RowIndex].Cells["Quantity"].Value.ToString(), out quantity);
                string description = dgvDisplayItems.Rows[e.RowIndex].Cells["Description"].Value.ToString();

                // Open update popup
                frmUpdateItem updateForm = new frmUpdateItem(name, quantity, description);
                if (updateForm.ShowDialog() == DialogResult.OK)
                {
                    // Update the row with new values
                    dgvDisplayItems.Rows[e.RowIndex].Cells["Name"].Value = updateForm.ItemName;
                    dgvDisplayItems.Rows[e.RowIndex].Cells["Quantity"].Value = updateForm.ItemQty;
                    dgvDisplayItems.Rows[e.RowIndex].Cells["Description"].Value = updateForm.ItemDescription;
                }
            }

            // Delete button clicked
            if (dgvDisplayItems.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this item?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                if (result == DialogResult.Yes)
                {
                    dgvDisplayItems.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void lblSubHeading_Click(object sender, EventArgs e)
        {

        }
    }
}
