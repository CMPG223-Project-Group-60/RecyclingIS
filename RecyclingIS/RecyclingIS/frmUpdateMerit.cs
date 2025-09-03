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
    public partial class frmUpdateMerit : Form
    {
        string constr = @"Data Source=Rams\SQLEXPRESS;Initial Catalog=RecyclingIS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        // ✅ Keep properties to track the selected merit
        public int SelectedMeritID { get; private set; }

        public frmUpdateMerit()
        {
            InitializeComponent();
        }

        private void frmUpdateMerit_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();

                    string meritSQL = @"SELECT 
                                MeritID,
                                CASE Merit_Type
                                    WHEN 1 THEN 'Gold'
                                    WHEN 2 THEN 'Silver'
                                    WHEN 3 THEN 'Bronze'
                                END AS Merit_Type,
                                Points_Awarded
                              FROM MERIT 
                              ORDER BY Merit_Type";

                    SqlDataAdapter meritAdap = new SqlDataAdapter(meritSQL, conn);
                    DataTable meritTable = new DataTable();
                    meritAdap.Fill(meritTable);

                    cbxMeritType.SelectedIndexChanged -= CbxMeritType_SelectedIndexChanged;

                    cbxMeritType.DisplayMember = "Merit_Type";
                    cbxMeritType.ValueMember = "MeritID";
                    cbxMeritType.DataSource = meritTable;

                    cbxMeritType.SelectedIndexChanged += CbxMeritType_SelectedIndexChanged;

                    if (cbxMeritType.Items.Count > 0)
                    {
                        LoadPointsForSelectedMerit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading merit types: " + ex.Message, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxMeritType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPointsForSelectedMerit();
        }

        private void LoadPointsForSelectedMerit()
        {
            if (cbxMeritType.SelectedItem != null && cbxMeritType.SelectedItem is DataRowView)
            {
                DataRowView selectedRow = (DataRowView)cbxMeritType.SelectedItem;

                if (selectedRow["Points_Awarded"] != DBNull.Value)
                {
                    int currentPoints = Convert.ToInt32(selectedRow["Points_Awarded"]);
                    txtPointsAwarded.Text = currentPoints.ToString();
                    txtPointsAwarded.SelectAll();
                    txtPointsAwarded.Focus();
                }
            }
        }

        // ✅ UPDATED: Now performs the actual database update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // 1. Validate input
            if (cbxMeritType.SelectedItem == null)
            {
                MessageBox.Show("Please select a merit type to update.", "Selection Required",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxMeritType.Focus();
                return;
            }

            if (!int.TryParse(txtPointsAwarded.Text, out int points) || points <= 0)
            {
                MessageBox.Show("Please enter valid points (must be a positive number).", "Validation Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPointsAwarded.Focus();
                return;
            }

            // 2. Get selected values
            DataRowView selectedRow = (DataRowView)cbxMeritType.SelectedItem;
            int meritID = Convert.ToInt32(selectedRow["MeritID"]);
            string meritTypeName = selectedRow["Merit_Type"].ToString();

            // 3. Confirm update
            var result = MessageBox.Show($"Update {meritTypeName} merit to {points} points?",
                "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // ✅ PERFORM THE DATABASE UPDATE HERE
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();

                        string query = @"UPDATE MERIT 
                                      SET Points_Awarded = @Points 
                                      WHERE MeritID = @MeritID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Points", points);
                            cmd.Parameters.AddWithValue("@MeritID", meritID);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Merit updated successfully!", "Success",
                                               MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // ✅ Close the form with OK result
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("No records were updated.", "Warning",
                                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"Database error: {sqlEx.Message}", "Database Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating merit: {ex.Message}", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ✅ Cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        // ✅ Enter key functionality
        private void txtPointsAwarded_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUpdate.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
