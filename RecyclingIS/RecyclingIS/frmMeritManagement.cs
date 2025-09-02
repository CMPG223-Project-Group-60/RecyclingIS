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
    public partial class frmMeritManagement : Form
    {
        //connection string
        string constr = @"Data Source=Rams\SQLEXPRESS;Initial Catalog=RecyclingIS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public frmMeritManagement()
        {
            InitializeComponent();
        }

        private void frmMeritManagement_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadMerits();
        }

        private void LoadMerits()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    string query = @"SELECT 
                        MeritID,
                        CASE Merit_Type
                            WHEN 1 THEN 'Gold'
                            WHEN 2 THEN 'Silver'
                            WHEN 3 THEN 'Bronze'
                        END AS Merit_Type,
                        Points_Awarded
                    FROM MERIT
                    ORDER BY Merit_Type";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable meritsTable = new DataTable();
                    adapter.Fill(meritsTable);

                    dgvDisplayMerits.DataSource = meritsTable;
                    dgvDisplayMerits.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading merits: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataGridView()
        {
            dgvDisplayMerits.Columns.Clear();

            // Add text columns
           // dgvDisplayMerits.Columns.Add("Merit Type", "Merit Type");
            //dgvDisplayMerits.Columns.Add("Points Awarded", "Points Awarded");
            


            /* DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
             btnDelete.HeaderText = "Delete";
             btnDelete.Text = "Delete";
             btnDelete.UseColumnTextForButtonValue = true;
             dgvDisplayItems.Columns.Add(btnDelete);*/
        }

        private void dgvDisplayMerits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnAddMerit_Click(object sender, EventArgs e)
        {
            frmAddMerit add = new frmAddMerit();
            add.StartPosition = FormStartPosition.CenterParent;
            add.ShowDialog(this);
            LoadMerits();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateMerit update = new frmUpdateMerit();
            update.StartPosition = FormStartPosition.CenterParent;
            update.ShowDialog(this);

            if (update.ShowDialog(this) == DialogResult.OK)
            {
                // ✅ REFRESH THE DATAGRIDVIEW AFTER UPDATE
                LoadMerits();
                MessageBox.Show("Merit updated successfully!", "Success",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDeleteMerit delete = new frmDeleteMerit();
            delete.StartPosition = FormStartPosition.CenterParent;
            delete.ShowDialog(this);

            LoadMerits();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
