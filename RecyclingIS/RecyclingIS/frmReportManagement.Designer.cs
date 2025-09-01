
namespace RecyclingIS
{
    partial class frmReportManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportManagement));
            this.lblSubHeading = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.dgvDisplayReport = new System.Windows.Forms.DataGridView();
            this.lblReport = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.cbxReport = new System.Windows.Forms.ComboBox();
            this.gbxReport = new System.Windows.Forms.GroupBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblEnd = new System.Windows.Forms.Label();
            this.gbxSort = new System.Windows.Forms.GroupBox();
            this.rdoStudentDesc = new System.Windows.Forms.RadioButton();
            this.rdoStudentAsc = new System.Windows.Forms.RadioButton();
            this.rdoProjectDesc = new System.Windows.Forms.RadioButton();
            this.rdoProjectAsc = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayReport)).BeginInit();
            this.gbxReport.SuspendLayout();
            this.gbxSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSubHeading
            // 
            this.lblSubHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblSubHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeading.ForeColor = System.Drawing.Color.White;
            this.lblSubHeading.Location = new System.Drawing.Point(0, 38);
            this.lblSubHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubHeading.Name = "lblSubHeading";
            this.lblSubHeading.Size = new System.Drawing.Size(467, 19);
            this.lblSubHeading.TabIndex = 3;
            this.lblSubHeading.Text = "Generate reports to get insight on top projects and students";
            // 
            // lblHeading
            // 
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Stencil", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblHeading.Location = new System.Drawing.Point(-4, -1);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(622, 47);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "Report Management";
            this.lblHeading.Click += new System.EventHandler(this.lblHeading_Click);
            // 
            // dgvDisplayReport
            // 
            this.dgvDisplayReport.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDisplayReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayReport.Location = new System.Drawing.Point(8, 282);
            this.dgvDisplayReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDisplayReport.Name = "dgvDisplayReport";
            this.dgvDisplayReport.RowHeadersWidth = 51;
            this.dgvDisplayReport.RowTemplate.Height = 24;
            this.dgvDisplayReport.Size = new System.Drawing.Size(535, 180);
            this.dgvDisplayReport.TabIndex = 5;
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblReport.ForeColor = System.Drawing.Color.White;
            this.lblReport.Location = new System.Drawing.Point(4, 24);
            this.lblReport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(77, 13);
            this.lblReport.TabIndex = 7;
            this.lblReport.Text = "Report type:";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblStart.ForeColor = System.Drawing.Color.White;
            this.lblStart.Location = new System.Drawing.Point(4, 63);
            this.lblStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(38, 13);
            this.lblStart.TabIndex = 8;
            this.lblStart.Text = "From:";
            this.lblStart.Click += new System.EventHandler(this.lblStart_Click);
            // 
            // cbxReport
            // 
            this.cbxReport.FormattingEnabled = true;
            this.cbxReport.Items.AddRange(new object[] {
            "Top 10 Recyclers",
            "Top 10 Projects "});
            this.cbxReport.Location = new System.Drawing.Point(82, 22);
            this.cbxReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxReport.Name = "cbxReport";
            this.cbxReport.Size = new System.Drawing.Size(195, 21);
            this.cbxReport.TabIndex = 9;
            this.cbxReport.SelectedIndexChanged += new System.EventHandler(this.cbxReport_SelectedIndexChanged);
            // 
            // gbxReport
            // 
            this.gbxReport.BackColor = System.Drawing.Color.Transparent;
            this.gbxReport.Controls.Add(this.dtpTo);
            this.gbxReport.Controls.Add(this.dtpFrom);
            this.gbxReport.Controls.Add(this.lblEnd);
            this.gbxReport.Controls.Add(this.lblReport);
            this.gbxReport.Controls.Add(this.lblStart);
            this.gbxReport.Controls.Add(this.cbxReport);
            this.gbxReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.gbxReport.ForeColor = System.Drawing.Color.White;
            this.gbxReport.Location = new System.Drawing.Point(8, 76);
            this.gbxReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxReport.Name = "gbxReport";
            this.gbxReport.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxReport.Size = new System.Drawing.Size(300, 126);
            this.gbxReport.TabIndex = 11;
            this.gbxReport.TabStop = false;
            this.gbxReport.Text = "Choose Report:";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(46, 92);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(232, 19);
            this.dtpTo.TabIndex = 14;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(46, 60);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(232, 19);
            this.dtpFrom.TabIndex = 13;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblEnd.ForeColor = System.Drawing.Color.White;
            this.lblEnd.Location = new System.Drawing.Point(17, 92);
            this.lblEnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(26, 13);
            this.lblEnd.TabIndex = 12;
            this.lblEnd.Text = "To:";
            // 
            // gbxSort
            // 
            this.gbxSort.BackColor = System.Drawing.Color.Transparent;
            this.gbxSort.Controls.Add(this.rdoStudentDesc);
            this.gbxSort.Controls.Add(this.rdoStudentAsc);
            this.gbxSort.Controls.Add(this.rdoProjectDesc);
            this.gbxSort.Controls.Add(this.rdoProjectAsc);
            this.gbxSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSort.ForeColor = System.Drawing.Color.White;
            this.gbxSort.Location = new System.Drawing.Point(391, 76);
            this.gbxSort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxSort.Name = "gbxSort";
            this.gbxSort.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxSort.Size = new System.Drawing.Size(152, 126);
            this.gbxSort.TabIndex = 12;
            this.gbxSort.TabStop = false;
            this.gbxSort.Text = "Sort Report By:";
            this.gbxSort.UseCompatibleTextRendering = true;
            this.gbxSort.Enter += new System.EventHandler(this.gbxSort_Enter);
            // 
            // rdoStudentDesc
            // 
            this.rdoStudentDesc.AutoSize = true;
            this.rdoStudentDesc.Location = new System.Drawing.Point(4, 106);
            this.rdoStudentDesc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoStudentDesc.Name = "rdoStudentDesc";
            this.rdoStudentDesc.Size = new System.Drawing.Size(144, 17);
            this.rdoStudentDesc.TabIndex = 12;
            this.rdoStudentDesc.TabStop = true;
            this.rdoStudentDesc.Text = "Student name (Desc)";
            this.rdoStudentDesc.UseVisualStyleBackColor = true;
            // 
            // rdoStudentAsc
            // 
            this.rdoStudentAsc.AutoSize = true;
            this.rdoStudentAsc.Location = new System.Drawing.Point(4, 76);
            this.rdoStudentAsc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoStudentAsc.Name = "rdoStudentAsc";
            this.rdoStudentAsc.Size = new System.Drawing.Size(136, 17);
            this.rdoStudentAsc.TabIndex = 11;
            this.rdoStudentAsc.TabStop = true;
            this.rdoStudentAsc.Text = "Student name (Asc)";
            this.rdoStudentAsc.UseVisualStyleBackColor = true;
            // 
            // rdoProjectDesc
            // 
            this.rdoProjectDesc.AutoSize = true;
            this.rdoProjectDesc.Location = new System.Drawing.Point(4, 47);
            this.rdoProjectDesc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoProjectDesc.Name = "rdoProjectDesc";
            this.rdoProjectDesc.Size = new System.Drawing.Size(140, 17);
            this.rdoProjectDesc.TabIndex = 10;
            this.rdoProjectDesc.TabStop = true;
            this.rdoProjectDesc.Text = "Project name (Desc)";
            this.rdoProjectDesc.UseVisualStyleBackColor = true;
            // 
            // rdoProjectAsc
            // 
            this.rdoProjectAsc.AutoSize = true;
            this.rdoProjectAsc.Location = new System.Drawing.Point(4, 17);
            this.rdoProjectAsc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoProjectAsc.Name = "rdoProjectAsc";
            this.rdoProjectAsc.Size = new System.Drawing.Size(132, 17);
            this.rdoProjectAsc.TabIndex = 9;
            this.rdoProjectAsc.TabStop = true;
            this.rdoProjectAsc.Text = "Project name (Asc)";
            this.rdoProjectAsc.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(5, 266);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(79, 13);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "xxxResultxxx";
            this.lblResult.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Location = new System.Drawing.Point(8, 212);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(128, 34);
            this.btnGenerateReport.TabIndex = 13;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(154, 212);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 34);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmReportManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(552, 465);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.gbxSort);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.gbxReport);
            this.Controls.Add(this.dgvDisplayReport);
            this.Controls.Add(this.lblSubHeading);
            this.Controls.Add(this.lblHeading);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmReportManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportManagement";
            this.Load += new System.EventHandler(this.frmReportManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayReport)).EndInit();
            this.gbxReport.ResumeLayout(false);
            this.gbxReport.PerformLayout();
            this.gbxSort.ResumeLayout(false);
            this.gbxSort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubHeading;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.DataGridView dgvDisplayReport;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.ComboBox cbxReport;
        private System.Windows.Forms.GroupBox gbxReport;
        private System.Windows.Forms.GroupBox gbxSort;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.RadioButton rdoProjectDesc;
        private System.Windows.Forms.RadioButton rdoProjectAsc;
        private System.Windows.Forms.RadioButton rdoStudentDesc;
        private System.Windows.Forms.RadioButton rdoStudentAsc;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
    }
}