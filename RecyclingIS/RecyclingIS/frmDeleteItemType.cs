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
    public partial class frmDeleteItemType : Form
    {
        private string connectionString = @"Data Source=34.29.210.64;Initial Catalog=RecyclingIS;Persist Security Info=True;User ID=sqlserver;Password=223Group60;TrustServerCertificate=True";
        private SqlConnection con;
        private frmItemsManagement m_form;

        public frmDeleteItemType()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDeleteItemType_Load(object sender, EventArgs e)
        {
            // Initialize management form
            m_form = new frmItemsManagement();

            // DB Stuff
            con = new SqlConnection(connectionString);
            SqlCommand cmd;
            SqlDataReader reader;
            string sql;

            con.Open(); // Open database connection

            sql = "SELECT ItemID FROM ITEM";
            cmd = new SqlCommand(sql, con);
            reader = cmd.ExecuteReader();

            while (reader.Read()) // loops through results and gets the item type to populate the combo box
            {
                cbxItemType.Items.Add(reader.GetValue(0));
            }

            cmd.Dispose();
            con.Close(); // Close database connection
        }

        private void btnDeleteItemType_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql;

            con.Open(); // Open database connection

            sql = "DELETE FROM ITEM WHERE ItemID = " + cbxItemType.SelectedItem.ToString();
            cmd = new SqlCommand(sql, con);

            try
            {
                adapter.DeleteCommand = cmd;
                adapter.DeleteCommand.ExecuteNonQuery();
            } catch (SqlException error)
            {
                MessageBox.Show("Couldn't remove item!");
                this.Close();
            }

            cmd.Dispose();
            con.Close(); // Close database connection

            MessageBox.Show("Item removed succesfully!");
            m_form.refreshGridView();

            this.Close();
        }
    }
}
