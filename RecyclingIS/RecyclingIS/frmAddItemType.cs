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
    public partial class frmAddItemType : Form
    {
        private string connectionString = @"";
        private SqlConnection con;
        private frmItemsManagement m_form;

        public frmAddItemType()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql;

            con.Open(); // Open database connection

            sql = "INSERT INTO ITEM VALUES(" + txtItemName.Text + ", " + cbxQty.SelectedItem.ToString() + ")";
            cmd = new SqlCommand(sql, con);

            try
            {
                adapter.UpdateCommand = cmd;
                adapter.UpdateCommand.ExecuteNonQuery();
            } catch (SqlException error)
            {
                MessageBox.Show("Item couldn't be added!");
                this.Close();
            }

            cmd.Dispose();
            con.Close(); // Close database connection

            MessageBox.Show("Item added succesfully!");
            m_form.refreshGridView();
        }

        private void frmAddItemType_Load(object sender, EventArgs e)
        {
            m_form = new frmItemsManagement();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtItemName.Text = "";
            cbxQty.SelectedIndex = -1;
        }
    }
}
