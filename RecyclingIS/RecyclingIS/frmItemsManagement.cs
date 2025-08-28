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
        private string placeholder = "Search by name";

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
            
        }

        private void SetupDataGridView()
        {
            dgvDisplayItems.Columns.Clear();

            // Add text columns
            dgvDisplayItems.Columns.Add("Name", "Name");
            dgvDisplayItems.Columns.Add("QuantityOnHand", "QuantityOnHand");

           /* DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.HeaderText = "Delete";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            dgvDisplayItems.Columns.Add(btnDelete);*/
        }


       
        private void lblSubHeading_Click(object sender, EventArgs e)
        {

        }

        private void dgvDisplayItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmAddItemType add = new frmAddItemType();
            add.StartPosition = FormStartPosition.CenterParent;
            add.ShowDialog(this);
        }

        //BUTTON UPDATE ITEM TYPE
        private void button1_Click(object sender, EventArgs e)
        {
            frmUpdateItemType update = new frmUpdateItemType();
            update.StartPosition = FormStartPosition.CenterParent;
            update.ShowDialog(this);
        }

        //BUTTON DELETE ITEM TYPE
        private void button2_Click(object sender, EventArgs e)
        {
            frmDeleteItemType delete = new frmDeleteItemType();
            delete.StartPosition = FormStartPosition.CenterParent;
            delete.ShowDialog(this);
        }
    }
}
