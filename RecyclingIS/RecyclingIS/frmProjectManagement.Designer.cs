
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjectManagement));
            this.lblSubHeading = new System.Windows.Forms.Label();
            this.dgvDisplayProjects = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStuProj = new System.Windows.Forms.Button();
            this.recyclingISDataSet = new RecyclingIS.RecyclingISDataSet();
            this.recyclingISDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projDueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECYCLEPROJECTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recyclingISDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.recyclingISDataSet1 = new RecyclingIS.RecyclingISDataSet1();
            this.recyclingISDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recyclingISDataSet11 = new RecyclingIS.RecyclingISDataSet1();
            this.recyclingISDataSet2 = new RecyclingIS.RecyclingISDataSet2();
            this.rECYCLEPROJECTTableAdapter = new RecyclingIS.RecyclingISDataSet1TableAdapters.RECYCLEPROJECTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayProjects)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recyclingISDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recyclingISDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECYCLEPROJECTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recyclingISDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recyclingISDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recyclingISDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recyclingISDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recyclingISDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubHeading
            // 
            this.lblSubHeading.AutoSize = true;
            this.lblSubHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblSubHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeading.ForeColor = System.Drawing.Color.White;
            this.lblSubHeading.Location = new System.Drawing.Point(14, 59);
            this.lblSubHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubHeading.Name = "lblSubHeading";
            this.lblSubHeading.Size = new System.Drawing.Size(201, 17);
            this.lblSubHeading.TabIndex = 3;
            this.lblSubHeading.Text = "Manage the list of projects";
            // 
            // dgvDisplayProjects
            // 
            this.dgvDisplayProjects.AllowUserToAddRows = false;
            this.dgvDisplayProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplayProjects.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDisplayProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayProjects.Location = new System.Drawing.Point(7, 151);
            this.dgvDisplayProjects.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDisplayProjects.Name = "dgvDisplayProjects";
            this.dgvDisplayProjects.RowHeadersWidth = 51;
            this.dgvDisplayProjects.RowTemplate.Height = 24;
            this.dgvDisplayProjects.Size = new System.Drawing.Size(620, 215);
            this.dgvDisplayProjects.TabIndex = 8;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 579);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 47);
            this.label1.TabIndex = 12;
            this.label1.Text = "Project Management";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(7, 108);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(621, 39);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.Location = new System.Drawing.Point(41, 3);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(572, 28);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TabStop = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(505, 398);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 45);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete Project";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(257, 398);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 45);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update Project";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddProject
            // 
            this.btnAddProject.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProject.ForeColor = System.Drawing.Color.White;
            this.btnAddProject.Location = new System.Drawing.Point(7, 398);
            this.btnAddProject.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(122, 45);
            this.btnAddProject.TabIndex = 13;
            this.btnAddProject.Text = "Add Project";
            this.btnAddProject.UseVisualStyleBackColor = false;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 479);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Student to Project Management";
            // 
            // btnStuProj
            // 
            this.btnStuProj.BackColor = System.Drawing.Color.ForestGreen;
            this.btnStuProj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStuProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStuProj.ForeColor = System.Drawing.Color.White;
            this.btnStuProj.Location = new System.Drawing.Point(9, 509);
            this.btnStuProj.Margin = new System.Windows.Forms.Padding(2);
            this.btnStuProj.Name = "btnStuProj";
            this.btnStuProj.Size = new System.Drawing.Size(214, 45);
            this.btnStuProj.TabIndex = 17;
            this.btnStuProj.Text = "Assign Student to Project";
            this.btnStuProj.UseVisualStyleBackColor = false;
            this.btnStuProj.Click += new System.EventHandler(this.btnStuProj_Click);
            // 
            // recyclingISDataSet
            // 
            this.recyclingISDataSet.DataSetName = "RecyclingISDataSet";
            this.recyclingISDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recyclingISDataSetBindingSource
            // 
            this.recyclingISDataSetBindingSource.DataSource = this.recyclingISDataSet;
            this.recyclingISDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projIDDataGridViewTextBoxColumn,
            this.projNameDataGridViewTextBoxColumn,
            this.projDescriptionDataGridViewTextBoxColumn,
            this.projDueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rECYCLEPROJECTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(620, 214);
            this.dataGridView1.TabIndex = 18;
            // 
            // projIDDataGridViewTextBoxColumn
            // 
            this.projIDDataGridViewTextBoxColumn.DataPropertyName = "ProjID";
            this.projIDDataGridViewTextBoxColumn.HeaderText = "Project ID";
            this.projIDDataGridViewTextBoxColumn.Name = "projIDDataGridViewTextBoxColumn";
            this.projIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // projNameDataGridViewTextBoxColumn
            // 
            this.projNameDataGridViewTextBoxColumn.DataPropertyName = "Proj_Name";
            this.projNameDataGridViewTextBoxColumn.HeaderText = "Proj_Name";
            this.projNameDataGridViewTextBoxColumn.Name = "projNameDataGridViewTextBoxColumn";
            // 
            // projDescriptionDataGridViewTextBoxColumn
            // 
            this.projDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Proj_Description";
            this.projDescriptionDataGridViewTextBoxColumn.HeaderText = "Proj_Description";
            this.projDescriptionDataGridViewTextBoxColumn.Name = "projDescriptionDataGridViewTextBoxColumn";
            // 
            // projDueDataGridViewTextBoxColumn
            // 
            this.projDueDataGridViewTextBoxColumn.DataPropertyName = "Proj_Due";
            this.projDueDataGridViewTextBoxColumn.HeaderText = "Proj_Due";
            this.projDueDataGridViewTextBoxColumn.Name = "projDueDataGridViewTextBoxColumn";
            // 
            // rECYCLEPROJECTBindingSource
            // 
            this.rECYCLEPROJECTBindingSource.DataMember = "RECYCLEPROJECT";
            this.rECYCLEPROJECTBindingSource.DataSource = this.recyclingISDataSet1BindingSource1;
            // 
            // recyclingISDataSet1BindingSource1
            // 
            this.recyclingISDataSet1BindingSource1.DataSource = this.recyclingISDataSet1;
            this.recyclingISDataSet1BindingSource1.Position = 0;
            // 
            // recyclingISDataSet1
            // 
            this.recyclingISDataSet1.DataSetName = "RecyclingISDataSet1";
            this.recyclingISDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recyclingISDataSet1BindingSource
            // 
            this.recyclingISDataSet1BindingSource.DataSource = this.recyclingISDataSet1;
            this.recyclingISDataSet1BindingSource.Position = 0;
            // 
            // recyclingISDataSet11
            // 
            this.recyclingISDataSet11.DataSetName = "RecyclingISDataSet1";
            this.recyclingISDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recyclingISDataSet2
            // 
            this.recyclingISDataSet2.DataSetName = "RecyclingISDataSet2";
            this.recyclingISDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rECYCLEPROJECTTableAdapter
            // 
            this.rECYCLEPROJECTTableAdapter.ClearBeforeFill = true;
            // 
            // frmProjectManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(729, 579);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnStuProj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.dgvDisplayProjects);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSubHeading);
            this.Controls.Add(this.splitter1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmProjectManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProjectManagement";
            this.Load += new System.EventHandler(this.frmProjectManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayProjects)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recyclingISDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recyclingISDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECYCLEPROJECTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recyclingISDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recyclingISDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recyclingISDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recyclingISDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recyclingISDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSubHeading;
        private System.Windows.Forms.DataGridView dgvDisplayProjects;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStuProj;
        private RecyclingISDataSet recyclingISDataSet;
        private System.Windows.Forms.BindingSource recyclingISDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource recyclingISDataSet1BindingSource;
        private RecyclingISDataSet1 recyclingISDataSet1;
        private System.Windows.Forms.BindingSource recyclingISDataSet1BindingSource1;
        private RecyclingISDataSet1 recyclingISDataSet11;
        private RecyclingISDataSet2 recyclingISDataSet2;
        private System.Windows.Forms.BindingSource rECYCLEPROJECTBindingSource;
        private RecyclingISDataSet1TableAdapters.RECYCLEPROJECTTableAdapter rECYCLEPROJECTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn projIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projDueDataGridViewTextBoxColumn;
    }
}