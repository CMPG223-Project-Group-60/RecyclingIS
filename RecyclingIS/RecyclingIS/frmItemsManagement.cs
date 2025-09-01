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
    public partial class frmItemsManagement : Form
    {
        private string placeholder = "Search by name";
        string connectionString = @"Data Source=Rams\SQLEXPRESS;Initial Catalog=RecyclingIS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private SqlConnection con;

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
            refreshGridView();
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

        public void refreshGridView()
        {
            con = new SqlConnection(connectionString);
            SqlCommand cmd;
            SqlDataAdapter adapter;
            DataSet ds;
            string sql;

            con.Open(); // Open database connection

            sql = "SELECT * FROM ITEM";
            cmd = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter();
            ds = new DataSet();

            adapter.SelectCommand = cmd;
            adapter.Fill(ds, "ITEM");

            dgvDisplayItems.DataSource = ds;
            dgvDisplayItems.DataMember = "ITEM";

            cmd.Dispose();
            con.Close(); // Close database connection
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select * FROM ITEM WHERE ItemID LIKE '%" + txtSearch.Text + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connectionString);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "ITEM");

            dgvDisplayItems.DataSource = ds;
            dgvDisplayItems.DataMember = "ITEM";
        }
    }
}
