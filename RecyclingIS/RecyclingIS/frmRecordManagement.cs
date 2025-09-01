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
    public partial class frmRecordManagement : Form
    {
        //connection string
        string constr = @"Data Source=Rams\SQLEXPRESS;Initial Catalog=RecyclingIS;Integrated Security=True";

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
            txtSearch.TextChanged += txtSearch_TextChanged;

            
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
            //SetupDataGridView();
            RefreshDataGridView();
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

        private void RefreshDataGridView()
        {
            try
            {
                string searchTerm = txtSearch.Text.Trim();
                string whereClause = "";

                if (!string.IsNullOrEmpty(searchTerm) && searchTerm != placeholder)
                {
                    whereClause = $@"WHERE (s.F_Name + ' ' + s.L_Name LIKE '%{searchTerm}%' 
                               OR i.Item_Name LIKE '%{searchTerm}%'
                               OR CONVERT(VARCHAR, ri.Date_Received, 120) LIKE '%{searchTerm}%'
                               OR CONVERT(VARCHAR, ri.NumBags_Received) LIKE '%{searchTerm}%')";
                }
            

                using (SqlConnection conn = new SqlConnection(constr))
                {
                    string query = $@"SELECT ri.RecordedItemID,
                                             s.StudentID, 
                                             s.F_Name + ' ' + s.L_Name AS StudentName,
                                             i.ItemID,
                                             i.Item_Name,
                                             ri.Date_Received,
                                             ri.NumBags_Received,
                                             --Calculate merit points based on item type (e.g 5 points per bag)
                                             (ri.NumBags_Received * 5) AS MeritPoints
                                             FROM RECORDEDITEM ri
                                             INNER JOIN STUDENT s ON ri.StudentID = s.StudentID
                                             INNER JOIN ITEM i ON ri.ItemID = i.ItemID
                                             {whereClause}
                                             ORDER BY ri.Date_Received DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvRecordedItem.DataSource = dataTable;

                    //hide the id columns
                    dgvRecordedItem.Columns["RecordedItemID"].Visible = false;
                    dgvRecordedItem.Columns["StudentID"].Visible = false;
                    dgvRecordedItem.Columns["ItemID"].Visible = false;

                    //headings
                    dgvRecordedItem.Columns["Date_Received"].HeaderText = "Date Received";
                    dgvRecordedItem.Columns["NumBags_Received"].HeaderText = "Number of Bags";
                    dgvRecordedItem.Columns["Item_Name"].HeaderText = "Item Type";
                    dgvRecordedItem.Columns["MeritPoints"].HeaderText = "Merit Points";

                    dgvRecordedItem.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with loading data" + ex.Message);
            }
        }

        private void txtSearch_TextChanged(Object sender, EventArgs e)
        {
            if (txtSearch.Text != placeholder && txtSearch.ForeColor != Color.DarkGray)
            {
                RefreshDataGridView();
            }
        }

        private void btnAddRecordedItem_Click(object sender, EventArgs e)
        {
            frmAddRecordedItem addform = new frmAddRecordedItem();
            addform.StartPosition = FormStartPosition.CenterParent;

            if (addform.ShowDialog() == DialogResult.OK)
            {
                RefreshDataGridView();
                MessageBox.Show("Recycling recorded item added successfully!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            /*frmUpdateRecordedItem update = new frmUpdateRecordedItem();
            update.StartPosition = FormStartPosition.CenterParent;
            update.ShowDialog(this);*/

            if (dgvRecordedItem.CurrentRow == null || dgvRecordedItem.CurrentRow.Index < 0)
            {
                MessageBox.Show("Please select a record to update.");
                return;
            }

            try
            {
                //DataGridViewRow selectedRow = dgvRecordedItem.CurrentRow;

                int recordedItemId = Convert.ToInt32(dgvRecordedItem.CurrentRow.Cells["RecordedItemID"].Value);
                

                frmUpdateRecordedItem update = new frmUpdateRecordedItem();
                update.RecordedItemId = recordedItemId;
                update.StartPosition = FormStartPosition.CenterParent;

                if (update.ShowDialog() == DialogResult.OK)
                {
                    RefreshDataGridView();
                    MessageBox.Show("Record updated successfully!");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with loading data" + ex.Message);
            }
        }

        private void btnDeleteRecordedItem_Click(object sender, EventArgs e)
        {
            if (dgvRecordedItem.CurrentRow == null)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            try
            {
                DataGridViewRow selectedRow = dgvRecordedItem.CurrentRow;

                int recordedItemId = Convert.ToInt32(selectedRow.Cells["RecordedItemID"].Value);
                string studentName = selectedRow.Cells["StudentName"].Value.ToString();
                string itemName = selectedRow.Cells["Item_Name"].Value.ToString();
                DateTime dateReceived = Convert.ToDateTime(selectedRow.Cells["Date_Received"].Value);
                int numBags = Convert.ToInt32(selectedRow.Cells["Numbags_Received"].Value);

                DialogResult result = MessageBox.Show($"Are you sure want to delete this recycling record?\n\n"
                                                     + $"Student: {studentName}\n"
                                                     + $"Item: {itemName}\n"
                                                     + $"Date: {dateReceived:yyyy-MM-dd}\n"
                                                     + $"Bags: {numBags}", " Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteRecord(recordedItemId);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with loading data" + ex.Message);
            }
        }


        private void DeleteRecord(int recordedItemId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();

                    string sql = "DELETE FROM RECORDEDITEM WHERE RecordedItemID = @delete";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@delete", recordedItemId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.");
                            RefreshDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Record not found or already deleted.");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with loading data" + ex.Message);
            }

        }

        private void dgvRecordedItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
