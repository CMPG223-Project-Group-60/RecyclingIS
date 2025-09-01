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
    public partial class frmAddRecordedItem : Form
    {
        string constr = "Data Source=34.29.210.64;Initial Catalog=RecyclingIS;Persist Security Info=True;User ID=sqlserver;Password=223Group60";
        public frmAddRecordedItem()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmAddRecordedItem_Load(object sender, EventArgs e)
        {
            cbxStudent.SelectedIndex = -1;
            cbxItemType.SelectedIndex = -1;

            LoadComboBoxes();
            dtpDate.Value = DateTime.Today;
            dtpDate.Enabled = false; //the date is recorded in real time so no past/future dates can be used
            
            lblMeritPointsOutput.Text = "0 Merit Points";
        }


        private void LoadComboBoxes()
        {
            try
            {
               
               using (SqlConnection conn = new SqlConnection(constr))
               {

                    conn.Open();

                    string studentSQL = "SELECT StudentID, F_Name + ' ' + L_Name AS FullName FROM STUDENT ORDER BY FullName";

                    SqlDataAdapter adap = new SqlDataAdapter(studentSQL, conn);
                    DataTable studentTable = new DataTable();
                    adap.Fill(studentTable);

                    cbxStudent.DisplayMember = "FullName";
                    cbxStudent.ValueMember = "StudentID";
                    cbxStudent.DataSource = studentTable;

                    string itemSQL = "SELECT ItemID, Item_Name FROM ITEM ORDER BY Item_Name";

                    SqlDataAdapter itemAdap = new SqlDataAdapter(itemSQL, conn);

                    DataTable itemTable = new DataTable();
                    itemAdap.Fill(itemTable);

                    cbxItemType.DisplayMember = "Item_Name";
                    cbxItemType.ValueMember = "ItemID";
                    cbxItemType.DataSource = itemTable;

                }
           }
           catch (Exception ex)
           {
               MessageBox.Show("Error with loading data" + ex.Message);
           }
     
            
        }


        private void CalculateMeritPoints()
        {
            if (cbxItemType.SelectedValue != null && !string.IsNullOrEmpty(txtQuantity.Text) && int.TryParse(txtQuantity.Text, out int quantity))
            {
                int meritPoints = quantity * 5;
                lblMeritPointsOutput.Text = $"{meritPoints} Merit Points";
            }
            else
            {
                lblMeritPointsOutput.Text = "0 Merit Points";
            }
        }

        private void btnRecordItem_Click(object sender, EventArgs e)
        {
            if (cbxStudent.SelectedValue == null)
            {
                MessageBox.Show("Please select a student.");
                cbxStudent.Focus();
                return;
            }

            if (cbxItemType.SelectedValue == null)
            {
                MessageBox.Show("Please select an item type.");
                cbxItemType.Focus();
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity (greater than 0)");
                txtQuantity.Focus();
                txtQuantity.SelectAll();
                return;      
            }

            int studentId = (int)cbxStudent.SelectedValue;
            int itemId = (int)cbxItemType.SelectedValue;
            DateTime dateReceived = DateTime.Today;


            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();

                    string sql = @"INSERT INTO RECORDEDITEM (StudentID, ItemID, Date_Received, NumBags_Received) VALUES (@student, @item, @date, @qty)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@student", studentId);
                        cmd.Parameters.AddWithValue("@item", itemId);
                        cmd.Parameters.AddWithValue("@date", dateReceived);
                        cmd.Parameters.AddWithValue("@qty", quantity);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Recycling record added succesfully");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with adding record" + ex.Message);
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbxStudent.SelectedIndex = -1;
            cbxItemType.SelectedIndex = -1;
            txtQuantity.Clear();
            dtpDate.Value = DateTime.Today;
            lblMeritPointsOutput.Text = "0 Merit Points";
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            CalculateMeritPoints();
        }

        private void cbxItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateMeritPoints();
        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }
    }
}
