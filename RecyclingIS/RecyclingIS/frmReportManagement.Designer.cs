
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
            this.lblEnd = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.gbxSort = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
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
            this.lblSubHeading.Location = new System.Drawing.Point(0, 59);
            this.lblSubHeading.Name = "lblSubHeading";
            this.lblSubHeading.Size = new System.Drawing.Size(701, 29);
            this.lblSubHeading.TabIndex = 3;
            this.lblSubHeading.Text = "Generate reports to get insight on top projects and students";
            // 
            // lblHeading
            // 
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Stencil", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblHeading.Location = new System.Drawing.Point(-7, -1);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(934, 72);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "Report Management";
            this.lblHeading.Click += new System.EventHandler(this.lblHeading_Click);
            // 
            // dgvDisplayReport
            // 
            this.dgvDisplayReport.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDisplayReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayReport.Location = new System.Drawing.Point(12, 434);
            this.dgvDisplayReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDisplayReport.Name = "dgvDisplayReport";
            this.dgvDisplayReport.RowHeadersWidth = 51;
            this.dgvDisplayReport.RowTemplate.Height = 24;
            this.dgvDisplayReport.Size = new System.Drawing.Size(847, 250);
            this.dgvDisplayReport.TabIndex = 5;
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblReport.ForeColor = System.Drawing.Color.White;
            this.lblReport.Location = new System.Drawing.Point(7, 38);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(108, 20);
            this.lblReport.TabIndex = 7;
            this.lblReport.Text = "Report type:";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblStart.ForeColor = System.Drawing.Color.White;
            this.lblStart.Location = new System.Drawing.Point(7, 100);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(95, 20);
            this.lblStart.TabIndex = 8;
            this.lblStart.Text = "Start date:";
            // 
            // cbxReport
            // 
            this.cbxReport.FormattingEnabled = true;
            this.cbxReport.Items.AddRange(new object[] {
            "Top 10 Recyclers",
            "Top 10 Projects "});
            this.cbxReport.Location = new System.Drawing.Point(124, 34);
            this.cbxReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxReport.Name = "cbxReport";
            this.cbxReport.Size = new System.Drawing.Size(345, 28);
            this.cbxReport.TabIndex = 9;
            // 
            // gbxReport
            // 
            this.gbxReport.BackColor = System.Drawing.Color.Transparent;
            this.gbxReport.Controls.Add(this.lblEnd);
            this.gbxReport.Controls.Add(this.txtEnd);
            this.gbxReport.Controls.Add(this.txtStart);
            this.gbxReport.Controls.Add(this.lblReport);
            this.gbxReport.Controls.Add(this.lblStart);
            this.gbxReport.Controls.Add(this.cbxReport);
            this.gbxReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.gbxReport.ForeColor = System.Drawing.Color.White;
            this.gbxReport.Location = new System.Drawing.Point(12, 116);
            this.gbxReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxReport.Name = "gbxReport";
            this.gbxReport.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxReport.Size = new System.Drawing.Size(495, 155);
            this.gbxReport.TabIndex = 11;
            this.gbxReport.TabStop = false;
            this.gbxReport.Text = "Choose Report:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblEnd.ForeColor = System.Drawing.Color.White;
            this.lblEnd.Location = new System.Drawing.Point(279, 104);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(87, 20);
            this.lblEnd.TabIndex = 12;
            this.lblEnd.Text = "End date:";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(376, 100);
            this.txtEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(93, 25);
            this.txtEnd.TabIndex = 11;
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(124, 100);
            this.txtStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(112, 25);
            this.txtStart.TabIndex = 10;
            // 
            // gbxSort
            // 
            this.gbxSort.BackColor = System.Drawing.Color.Transparent;
            this.gbxSort.Controls.Add(this.radioButton2);
            this.gbxSort.Controls.Add(this.radioButton1);
            this.gbxSort.Controls.Add(this.rdoProjectDesc);
            this.gbxSort.Controls.Add(this.rdoProjectAsc);
            this.gbxSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSort.ForeColor = System.Drawing.Color.White;
            this.gbxSort.Location = new System.Drawing.Point(631, 92);
            this.gbxSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSort.Name = "gbxSort";
            this.gbxSort.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSort.Size = new System.Drawing.Size(228, 219);
            this.gbxSort.TabIndex = 12;
            this.gbxSort.TabStop = false;
            this.gbxSort.Text = "Sort Report By:";
            this.gbxSort.UseCompatibleTextRendering = true;
            this.gbxSort.Enter += new System.EventHandler(this.gbxSort_Enter);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 164);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(205, 24);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Student name (Desc)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 118);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(194, 24);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Student name (Asc)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdoProjectDesc
            // 
            this.rdoProjectDesc.AutoSize = true;
            this.rdoProjectDesc.Location = new System.Drawing.Point(7, 72);
            this.rdoProjectDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoProjectDesc.Name = "rdoProjectDesc";
            this.rdoProjectDesc.Size = new System.Drawing.Size(197, 24);
            this.rdoProjectDesc.TabIndex = 10;
            this.rdoProjectDesc.TabStop = true;
            this.rdoProjectDesc.Text = "Project name (Desc)";
            this.rdoProjectDesc.UseVisualStyleBackColor = true;
            // 
            // rdoProjectAsc
            // 
            this.rdoProjectAsc.AutoSize = true;
            this.rdoProjectAsc.Location = new System.Drawing.Point(7, 26);
            this.rdoProjectAsc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoProjectAsc.Name = "rdoProjectAsc";
            this.rdoProjectAsc.Size = new System.Drawing.Size(186, 24);
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
            this.lblResult.Location = new System.Drawing.Point(8, 410);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(109, 20);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "xxxResultxxx";
            this.lblResult.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Location = new System.Drawing.Point(12, 326);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(191, 52);
            this.btnGenerateReport.TabIndex = 13;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(338, 326);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(169, 52);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // frmReportManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 696);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.gbxSort);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.gbxReport);
            this.Controls.Add(this.dgvDisplayReport);
            this.Controls.Add(this.lblSubHeading);
            this.Controls.Add(this.lblHeading);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.RadioButton rdoProjectDesc;
        private System.Windows.Forms.RadioButton rdoProjectAsc;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnClear;
    }
}