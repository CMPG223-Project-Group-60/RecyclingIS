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
        string connectionString = @"Data Source=Rams\SQLEXPRESS;Initial Catalog=RecyclingIS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"; private SqlConnection con;
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
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd;
            string sql;
            bool complete = false;

            con.Open(); // Open database connection

            
            try
            {
                sql = $"INSERT INTO ITEM (Item_Name, Item_QtyOnHand) VALUES('{txtItemName.Text}', {int.Parse(txtQty.Text)})";
                cmd = new SqlCommand(sql, con);

                adapter.InsertCommand = cmd;
                adapter.InsertCommand.ExecuteNonQuery();
                    
                complete = true;
                cmd.Dispose();
            } catch (SqlException error)
            {
                MessageBox.Show("Item couldn't be added!");
                Console.WriteLine(error.ToString());
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Item couldn't be added!");
                this.Close();
            }

            con.Close(); // Close database connection

            if (complete)
            { 
                MessageBox.Show("Item added succesfully!");
                m_form.refreshGridView();
            }
            
            this.Close();
        }

        private void frmAddItemType_Load(object sender, EventArgs e)
        {
            m_form = new frmItemsManagement();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtItemName.Text = "";
            txtQty.Text = "";
        }
    }
}
