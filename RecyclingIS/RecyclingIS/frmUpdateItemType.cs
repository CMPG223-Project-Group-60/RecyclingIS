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
    public partial class frmUpdateItemType : Form
    {
        private string connectionString = @"Data Source=34.29.210.64;Initial Catalog=RecyclingIS;Persist Security Info=True;User ID=sqlserver;Password=223Group60;TrustServerCertificate=True";
        private SqlConnection con;
        private frmItemsManagement m_form;

        public frmUpdateItemType()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            txtItemName.Text = "";
            txtQty.Text = "";
        }

        private void frmUpdateItemType_Load(object sender, EventArgs e)
        {
            // Initialize management form
            m_form = new frmItemsManagement();

            // DB STuff
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
                comboBox1.Items.Add(reader.GetValue(0));
            }

            cmd.Dispose();
            con.Close(); // Close database connection
        }

        private void btnUpdateItemType_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql;
            bool completed = false;

            con.Open(); // Open database connection

            int id;
            if(int.TryParse(txtQty.Text, out id))
            {

            }
            else
            {
                MessageBox.Show("Please enter a proper ammount and try again!");
                this.Close();
            }

            sql = $"UPDATE ITEM SET Item_Name = '{txtItemName.Text}', Item_QtyOnHand = {id)} WHERE ItemID = {comboBox1.SelectedItem.ToString()}";
            cmd = new SqlCommand(sql, con);

            try
            {
                adapter.UpdateCommand = cmd;
                adapter.UpdateCommand.ExecuteNonQuery();
                completed = true;
            } catch (SqlException error)
            {
                MessageBox.Show("Couldn't update item!");
                System.Console.WriteLine(error.ToString());
                this.Close();
            }

            cmd.Dispose();
            con.Close(); // Close database connection
            if (completed)
            { 
                MessageBox.Show("Item updated succesfully!");
            }
            m_form.refreshGridView();

            this.Close();
        }
    }
}
