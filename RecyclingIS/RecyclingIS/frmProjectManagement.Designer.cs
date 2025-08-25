
namespace RecyclingIS
{
    partial class frmProjectManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjectManagement));
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblSubHeading = new System.Windows.Forms.Label();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.dgvDisplayProjects = new System.Windows.Forms.DataGridView();
            this.imgSearch = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.gpbProjects = new System.Windows.Forms.GroupBox();
            this.gpbStudentOnProj = new System.Windows.Forms.GroupBox();
            this.btnAddStudentonProj = new System.Windows.Forms.Button();
            this.pnlSearch1 = new System.Windows.Forms.Panel();
            this.imgSearch2 = new System.Windows.Forms.PictureBox();
            this.txtSearch2 = new System.Windows.Forms.TextBox();
            this.dgvDisplayStudentOnProj = new System.Windows.Forms.DataGridView();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearch)).BeginInit();
            this.gpbProjects.SuspendLayout();
            this.gpbStudentOnProj.SuspendLayout();
            this.pnlSearch1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearch2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayStudentOnProj)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(2, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(372, 40);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "Recycle Projects List";
            this.lblHeading.Click += new System.EventHandler(this.lblHeading_Click);
            // 
            // lblSubHeading
            // 
            this.lblSubHeading.AutoSize = true;
            this.lblSubHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblSubHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeading.ForeColor = System.Drawing.Color.LightGray;
            this.lblSubHeading.Location = new System.Drawing.Point(5, 50);
            this.lblSubHeading.Name = "lblSubHeading";
            this.lblSubHeading.Size = new System.Drawing.Size(362, 20);
            this.lblSubHeading.TabIndex = 3;
            this.lblSubHeading.Text = "Manage the master list of recyclable item types";
            // 
            // btnAddProject
            // 
            this.btnAddProject.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProject.ForeColor = System.Drawing.Color.White;
            this.btnAddProject.Location = new System.Drawing.Point(956, 10);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(162, 55);
            this.btnAddProject.TabIndex = 5;
            this.btnAddProject.Text = "Add New Project";
            this.btnAddProject.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.Location = new System.Drawing.Point(55, 4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(952, 35);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TabStop = false;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSearch.Controls.Add(this.imgSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Location = new System.Drawing.Point(6, 71);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(1);
            this.pnlSearch.Size = new System.Drawing.Size(1015, 47);
            this.pnlSearch.TabIndex = 7;
            // 
            // dgvDisplayProjects
            // 
            this.dgvDisplayProjects.AllowUserToAddRows = false;
            this.dgvDisplayProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplayProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayProjects.Location = new System.Drawing.Point(12, 151);
            this.dgvDisplayProjects.Name = "dgvDisplayProjects";
            this.dgvDisplayProjects.RowHeadersWidth = 51;
            this.dgvDisplayProjects.RowTemplate.Height = 24;
            this.dgvDisplayProjects.Size = new System.Drawing.Size(1015, 265);
            this.dgvDisplayProjects.TabIndex = 8;
            // 
            // imgSearch
            // 
            this.imgSearch.Image = ((System.Drawing.Image)(resources.GetObject("imgSearch.Image")));
            this.imgSearch.Location = new System.Drawing.Point(4, 4);
            this.imgSearch.Name = "imgSearch";
            this.imgSearch.Size = new System.Drawing.Size(45, 35);
            this.imgSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSearch.TabIndex = 0;
            this.imgSearch.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 1055);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // gpbProjects
            // 
            this.gpbProjects.Controls.Add(this.btnAddProject);
            this.gpbProjects.Controls.Add(this.pnlSearch);
            this.gpbProjects.Controls.Add(this.dgvDisplayProjects);
            this.gpbProjects.Location = new System.Drawing.Point(12, 86);
            this.gpbProjects.Name = "gpbProjects";
            this.gpbProjects.Size = new System.Drawing.Size(1118, 422);
            this.gpbProjects.TabIndex = 10;
            this.gpbProjects.TabStop = false;
            this.gpbProjects.Text = "Manage Projects";
            // 
            // gpbStudentOnProj
            // 
            this.gpbStudentOnProj.Controls.Add(this.btnAddStudentonProj);
            this.gpbStudentOnProj.Controls.Add(this.pnlSearch1);
            this.gpbStudentOnProj.Controls.Add(this.dgvDisplayStudentOnProj);
            this.gpbStudentOnProj.Location = new System.Drawing.Point(18, 567);
            this.gpbStudentOnProj.Name = "gpbStudentOnProj";
            this.gpbStudentOnProj.Size = new System.Drawing.Size(1118, 466);
            this.gpbStudentOnProj.TabIndex = 11;
            this.gpbStudentOnProj.TabStop = false;
            this.gpbStudentOnProj.Text = "Manage Students on Projects";
            // 
            // btnAddStudentonProj
            // 
            this.btnAddStudentonProj.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddStudentonProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudentonProj.ForeColor = System.Drawing.Color.White;
            this.btnAddStudentonProj.Location = new System.Drawing.Point(915, 10);
            this.btnAddStudentonProj.Name = "btnAddStudentonProj";
            this.btnAddStudentonProj.Size = new System.Drawing.Size(203, 55);
            this.btnAddStudentonProj.TabIndex = 5;
            this.btnAddStudentonProj.Text = "Add Student To Project";
            this.btnAddStudentonProj.UseVisualStyleBackColor = false;
            // 
            // pnlSearch1
            // 
            this.pnlSearch1.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearch1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSearch1.Controls.Add(this.imgSearch2);
            this.pnlSearch1.Controls.Add(this.txtSearch2);
            this.pnlSearch1.Location = new System.Drawing.Point(12, 82);
            this.pnlSearch1.Name = "pnlSearch1";
            this.pnlSearch1.Padding = new System.Windows.Forms.Padding(1);
            this.pnlSearch1.Size = new System.Drawing.Size(1015, 47);
            this.pnlSearch1.TabIndex = 7;
            // 
            // imgSearch2
            // 
            this.imgSearch2.Image = ((System.Drawing.Image)(resources.GetObject("imgSearch2.Image")));
            this.imgSearch2.Location = new System.Drawing.Point(4, 4);
            this.imgSearch2.Name = "imgSearch2";
            this.imgSearch2.Size = new System.Drawing.Size(45, 35);
            this.imgSearch2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSearch2.TabIndex = 0;
            this.imgSearch2.TabStop = false;
            // 
            // txtSearch2
            // 
            this.txtSearch2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch2.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch2.Location = new System.Drawing.Point(49, 4);
            this.txtSearch2.Multiline = true;
            this.txtSearch2.Name = "txtSearch2";
            this.txtSearch2.Size = new System.Drawing.Size(952, 35);
            this.txtSearch2.TabIndex = 1;
            this.txtSearch2.TabStop = false;
            // 
            // dgvDisplayStudentOnProj
            // 
            this.dgvDisplayStudentOnProj.AllowUserToAddRows = false;
            this.dgvDisplayStudentOnProj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplayStudentOnProj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayStudentOnProj.Location = new System.Drawing.Point(12, 181);
            this.dgvDisplayStudentOnProj.Name = "dgvDisplayStudentOnProj";
            this.dgvDisplayStudentOnProj.RowHeadersWidth = 51;
            this.dgvDisplayStudentOnProj.RowTemplate.Height = 24;
            this.dgvDisplayStudentOnProj.Size = new System.Drawing.Size(1015, 265);
            this.dgvDisplayStudentOnProj.TabIndex = 8;
            // 
            // frmProjectManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 1055);
            this.Controls.Add(this.gpbStudentOnProj);
            this.Controls.Add(this.gpbProjects);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.lblSubHeading);
            this.Controls.Add(this.lblHeading);
            this.Name = "frmProjectManagement";
            this.Text = "frmProjectManagement";
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearch)).EndInit();
            this.gpbProjects.ResumeLayout(false);
            this.gpbStudentOnProj.ResumeLayout(false);
            this.pnlSearch1.ResumeLayout(false);
            this.pnlSearch1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearch2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayStudentOnProj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblSubHeading;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.PictureBox imgSearch;
        private System.Windows.Forms.DataGridView dgvDisplayProjects;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox gpbProjects;
        private System.Windows.Forms.GroupBox gpbStudentOnProj;
        private System.Windows.Forms.Button btnAddStudentonProj;
        private System.Windows.Forms.Panel pnlSearch1;
        private System.Windows.Forms.PictureBox imgSearch2;
        private System.Windows.Forms.TextBox txtSearch2;
        private System.Windows.Forms.DataGridView dgvDisplayStudentOnProj;
    }
}