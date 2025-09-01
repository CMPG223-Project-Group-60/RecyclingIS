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
    public partial class frmReportManagement : Form
    {
        String conStr = @"Data Source=Nthabeleng_P\SQLEXPRESS02;Initial Catalog=RecyclingIS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public frmReportManagement()
        {
            InitializeComponent();
        }
       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gbxSort_Enter(object sender, EventArgs e)
        {

        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void frmReportManagement_Load(object sender, EventArgs e)
        {

        }

        private void lblStart_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validate Report Type selection
                if (cbxReport.SelectedItem == null)
                {
                    MessageBox.Show("Please select a report type", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbxReport.Focus();
                    return;
                }

                // 2. Validate Date Range
                if (dtpFrom.Value > dtpTo.Value)
                {
                    MessageBox.Show("Please select a valid date range.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpFrom.Focus();
                    return;
                }

                // 3. Validate Sorting Selection
                bool isSortingSelected = rdoStudentAsc.Checked || rdoStudentDesc.Checked ||
                                        rdoProjectAsc.Checked || rdoProjectDesc.Checked;

                if (!isSortingSelected)
                {
                    MessageBox.Show("Please select a sorting option", "Sorting Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string reportType = cbxReport.SelectedItem.ToString().Trim();
                DateTime fromDate = dtpFrom.Value.Date;
                DateTime toDate = dtpTo.Value.Date.AddDays(1).AddSeconds(-1);

                string query = "";
                string reportTitle = "";

                if (reportType.Equals("Top 10 Recyclers", StringComparison.OrdinalIgnoreCase))
                {
                    reportTitle = "Top 10 Recyclers Report";

                    query = @"SELECT TOP 10 
                    s.StudentID,
                    s.F_Name AS FirstName, 
                    s.L_Name AS LastName,
                    SUM(ri.NumBags_Received) AS TotalBagsRecycled
                 FROM RECORDEDITEM ri
                 JOIN STUDENT s ON ri.StudentID = s.StudentID
                 WHERE ri.Date_Received BETWEEN @fromDate AND @toDate
                 GROUP BY s.StudentID, s.F_Name, s.L_Name
                 ORDER BY TotalBagsRecycled DESC";
                }
                else if (reportType.Equals("Top 10 Projects", StringComparison.OrdinalIgnoreCase))
                {
                    reportTitle = "Top 10 Recycling Projects Report";

                    query = @"SELECT TOP 10 
                    rp.ProjID AS ProjectID,
                    rp.Proj_Name AS ProjectName, 
                    COUNT(sop.StudentID) AS NumberOfStudents
                 FROM RECYCLEPROJECT rp
                 LEFT JOIN STUDENTONPROJECT sop ON rp.ProjID = sop.ProjID
                 GROUP BY rp.ProjID, rp.Proj_Name
                 ORDER BY NumberOfStudents DESC";
                }
                else
                {
                    MessageBox.Show("Please choose either 'Top 10 Recyclers' or 'Top 10 Projects'.", "Invalid Report Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //s.F_Name + ' ' + s.L_Name AS StudentName,

            // Execute the query and get results
            DataTable dt = new DataTable();

                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Only add date parameters for Recyclers report (Projects report doesn't use dates)
                        if (reportType.Equals("Top 10 Recyclers", StringComparison.OrdinalIgnoreCase))
                        {
                            cmd.Parameters.AddWithValue("@fromDate", fromDate);
                            cmd.Parameters.AddWithValue("@toDate", toDate);
                        }

                        using (SqlDataAdapter adap = new SqlDataAdapter(cmd))
                        {
                            adap.Fill(dt);
                        }
                    }
                }

                // Check if data was returned
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No data found. Please try different dates.", "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblResult.Text = "No Data Available";
                    dgvDisplayReport.DataSource = null;
                    return;
                }

                // Apply sorting based on radio button selection
                if (rdoStudentAsc.Checked)
                {
                    if (reportType.Equals("Top 10 Recyclers", StringComparison.OrdinalIgnoreCase))
                        dt.DefaultView.Sort = "LastName ASC, FirstName ASC";
                    else
                        dt.DefaultView.Sort = "NumberOfStudents ASC";
                }
                else if (rdoStudentDesc.Checked)
                {
                    if (reportType.Equals("Top 10 Recyclers", StringComparison.OrdinalIgnoreCase))
                        dt.DefaultView.Sort = "LastName DESC, FirstName DESC";
                    else
                        dt.DefaultView.Sort = "NumberOfStudents DESC";
                }
                else if (rdoProjectAsc.Checked)
                {
                    dt.DefaultView.Sort = "ProjectName ASC";
                }
                else if (rdoProjectDesc.Checked)
                {
                    dt.DefaultView.Sort = "ProjectName DESC";
                }

                // Display the results
                dgvDisplayReport.DataSource = dt.DefaultView;

                // Update the heading label with sorting information
                string sortInfo = "";
                if (rdoStudentAsc.Checked) sortInfo = "Sorted by: Student Name (A-Z)";
                else if (rdoStudentDesc.Checked) sortInfo = "Sorted by: Student Name (Z-A)";
                else if (rdoProjectAsc.Checked) sortInfo = "Sorted by: Project Name (A-Z)";
                else if (rdoProjectDesc.Checked) sortInfo = "Sorted by: Project Name (Z-A)";

                lblResult.Text = $"{reportTitle} - {sortInfo}";
                lblResult.Visible = true;

                // Format the DataGridView
                dgvDisplayReport.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvDisplayReport.Refresh();

                MessageBox.Show("Report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
    catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rdoProjectAsc.Checked = false;
            rdoProjectDesc.Checked = false;
            rdoStudentAsc.Checked = false;
            rdoStudentDesc.Checked = false;

            cbxReport.SelectedIndex = -1;

            lblResult.Text = "";

            dtpFrom.Value = DateTime.Today;
            dtpTo.Value = DateTime.Today;

            dgvDisplayReport.DataSource = null;
            // dgvDisplayReport.Rows.Clear();
        }
    }

    
}
