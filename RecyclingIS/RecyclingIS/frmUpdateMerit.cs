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

        // ✅ Add these properties to pass data back to main form
        public int SelectedMeritID { get; private set; }
        public int NewPoints { get; private set; }

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

                    // ✅ Load Merit Types (Gold, Silver, Bronze) from database
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

                    // ✅ Bind to ComboBox for merit types
                    cbxMeritType.DisplayMember = "Merit_Type";  // Shows "Gold", "Silver", "Bronze"
                    cbxMeritType.ValueMember = "MeritID";       // Stores the numeric ID (1, 2, 3)
                    cbxMeritType.DataSource = meritTable;

                    cbxMeritType.SelectedIndexChanged += CbxMeritType_SelectedIndexChanged;

                    // ✅ Load points for the first item initially
                    if (cbxMeritType.Items.Count > 0)
                    {
                        LoadPointsForSelectedMerit();
                    }

                    // ✅ Optional: Also load Points_Awarded if you need to display it
                    // You can add another combobox or display the points when merit type is selected
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading merit types: " + ex.Message, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // ✅ Event handler when merit type selection changes
            
        }

        private void CbxMeritType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPointsForSelectedMerit();
        }

        private void LoadPointsForSelectedMerit()
        {
            if (cbxMeritType.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)cbxMeritType.SelectedItem;
                int currentPoints = Convert.ToInt32(selectedRow["Points_Awarded"]);
                txtPointsAwarded.Text = currentPoints.ToString();

                // Optional: Select all text for easy editing
                txtPointsAwarded.SelectAll();
                txtPointsAwarded.Focus();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
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
                SelectedMeritID = Convert.ToInt32(selectedRow["MeritID"]);
                NewPoints = points;

                // 3. Confirm update
                string meritTypeName = selectedRow["Merit_Type"].ToString();
                var result = MessageBox.Show($"Update {meritTypeName} merit to {points} points?",
                    "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
