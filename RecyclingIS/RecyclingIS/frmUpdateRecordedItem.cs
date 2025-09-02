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
    public partial class frmUpdateRecordedItem : Form
    {
        string constr = @"Data Source=Rams\SQLEXPRESS;Initial Catalog=RecyclingIS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private int originalStudentId;
        private int originalItemId;
        private DateTime originalDateReceived;
        private int originalQuantity;

        public int RecordedItemId { get; set; }

        public frmUpdateRecordedItem()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbxStudent.SelectedValue == null)
            {
                MessageBox.Show("Please select a student.");
                cbxStudent.Focus();
                return;
            }

            if (cbxItemType.SelectedValue == null)
            {
                MessageBox.Show("Please select a item type.");
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

            int updatedStudentId = (int)cbxStudent.SelectedValue;
            int updatedItemId = (int)cbxItemType.SelectedValue;
            DateTime updatedDateReceived = dtpDate.Value;

            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();

                    string query = @"UPDATE RECORDEDITEM 
                                     SET StudentID = @StudentID, 
                                         ItemID = @ItemID, 
                                         Date_Received = @DateReceived, 
                                         NumBags_Received = @Quantity
                                     WHERE RecordedItemID = @RecordedItemID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", updatedStudentId);
                        cmd.Parameters.AddWithValue("@ItemID", updatedItemId);
                        cmd.Parameters.AddWithValue("@DateReceived", updatedDateReceived);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@RecordedItemID", RecordedItemId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated succesfully!");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with loading  record data" + ex.Message);
            }
        }

        private void frmUpdateRecordedItem_Load(object sender, EventArgs e)
        {
            cbxStudent.SelectedIndex = -1;
            cbxItemType.SelectedIndex = -1;
            txtQuantity.Clear();
            dtpDate.Value = DateTime.Today;

            if (RecordedItemId > 0)
            {
                LoadComboBoxes();
                LoadRecordData();

            }
            else
            {
                MessageBox.Show("No record selected for editing");
                this.Close();
            }
        }

        private void LoadRecordData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();

                    string sql = @"SELECT StudentID, ItemID, Date_Received, NumBags_Received FROM RECORDEDITEM WHERE RecordedItemId = @recorded";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@recorded", RecordedItemId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                originalStudentId = reader.GetInt32(0);
                                originalItemId = reader.GetInt32(1);
                                originalDateReceived = reader.GetDateTime(2);
                                originalQuantity = reader.GetInt32(3);

                                cbxStudent.SelectedValue = originalStudentId;
                                cbxItemType.SelectedValue = originalItemId;
                                dtpDate.Value = originalDateReceived;
                                dtpDate.Enabled = false; 
                                txtQuantity.Text = originalQuantity.ToString();
                                CalculateMeritPoints();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with loading  record data" + ex.Message);
            }
        }

        private void LoadComboBoxes()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();

                    string studentsql = "SELECT StudentID, F_Name + ' ' + L_Name AS FullName FROM STUDENT ORDER BY FullName";

                    SqlDataAdapter studentAdap = new SqlDataAdapter(studentsql, conn);

                    DataTable studentTable = new DataTable();
                    studentAdap.Fill(studentTable);

                    cbxStudent.DisplayMember = "FullName";
                    cbxStudent.ValueMember = "StudentID";
                    cbxStudent.DataSource = studentTable;

                    string itemsql = "SELECT ItemID, Item_Name FROM ITEM ORDER BY Item_Name";

                    SqlDataAdapter itemAdap = new SqlDataAdapter(itemsql, conn);

                    DataTable itemTable = new DataTable();
                    itemAdap.Fill(itemTable);

                    cbxItemType.DisplayMember = "Item_Name";
                    cbxItemType.ValueMember = "ItemID";
                    cbxItemType.DataSource = itemTable;


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with loading dropdown data" + ex.Message);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbxStudent.SelectedValue = originalStudentId;
            cbxItemType.SelectedValue = originalItemId;
            dtpDate.Value = originalDateReceived;
            txtQuantity.Text = originalQuantity.ToString();
            CalculateMeritPoints();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            CalculateMeritPoints();
        }

        private void cbxItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateMeritPoints();
        }
    }
}

