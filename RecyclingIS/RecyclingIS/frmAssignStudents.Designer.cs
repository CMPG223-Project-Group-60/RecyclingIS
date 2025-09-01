
namespace RecyclingIS
{
    partial class frmAssignStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssignStudents));
            this.btnDeleteStudentProj = new System.Windows.Forms.Button();
            this.btnUpdateStudentProj = new System.Windows.Forms.Button();
            this.btnAddStudentProj = new System.Windows.Forms.Button();
            this.dgvDisplayAssign = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubHeading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAssign)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteStudentProj
            // 
            this.btnDeleteStudentProj.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteStudentProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudentProj.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStudentProj.Location = new System.Drawing.Point(658, 473);
            this.btnDeleteStudentProj.Name = "btnDeleteStudentProj";
            this.btnDeleteStudentProj.Size = new System.Drawing.Size(178, 55);
            this.btnDeleteStudentProj.TabIndex = 22;
            this.btnDeleteStudentProj.Text = "Delete Student from Project";
            this.btnDeleteStudentProj.UseVisualStyleBackColor = false;
            this.btnDeleteStudentProj.Click += new System.EventHandler(this.btnDeleteStudentProj_Click);
            // 
            // btnUpdateStudentProj
            // 
            this.btnUpdateStudentProj.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdateStudentProj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdateStudentProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStudentProj.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStudentProj.Location = new System.Drawing.Point(333, 473);
            this.btnUpdateStudentProj.Name = "btnUpdateStudentProj";
            this.btnUpdateStudentProj.Size = new System.Drawing.Size(171, 55);
            this.btnUpdateStudentProj.TabIndex = 21;
            this.btnUpdateStudentProj.Text = "Update Student to Project";
            this.btnUpdateStudentProj.UseVisualStyleBackColor = false;
            this.btnUpdateStudentProj.Click += new System.EventHandler(this.btnUpdateStudentProj_Click);
            // 
            // btnAddStudentProj
            // 
            this.btnAddStudentProj.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddStudentProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudentProj.ForeColor = System.Drawing.Color.White;
            this.btnAddStudentProj.Location = new System.Drawing.Point(5, 473);
            this.btnAddStudentProj.Name = "btnAddStudentProj";
            this.btnAddStudentProj.Size = new System.Drawing.Size(165, 55);
            this.btnAddStudentProj.TabIndex = 20;
            this.btnAddStudentProj.Text = "Add Student to Project";
            this.btnAddStudentProj.UseVisualStyleBackColor = false;
            this.btnAddStudentProj.Click += new System.EventHandler(this.btnAddStudentProj_Click);
            // 
            // dgvDisplayAssign
            // 
            this.dgvDisplayAssign.AllowUserToAddRows = false;
            this.dgvDisplayAssign.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplayAssign.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDisplayAssign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayAssign.Location = new System.Drawing.Point(12, 177);
            this.dgvDisplayAssign.Name = "dgvDisplayAssign";
            this.dgvDisplayAssign.RowHeadersWidth = 51;
            this.dgvDisplayAssign.RowTemplate.Height = 24;
            this.dgvDisplayAssign.Size = new System.Drawing.Size(827, 265);
            this.dgvDisplayAssign.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 124);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(827, 47);
            this.panel1.TabIndex = 18;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.Location = new System.Drawing.Point(55, 4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(763, 35);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(939, 58);
            this.label1.TabIndex = 19;
            this.label1.Text = "Student To Project Management";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSubHeading
            // 
            this.lblSubHeading.AutoSize = true;
            this.lblSubHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblSubHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeading.ForeColor = System.Drawing.Color.White;
            this.lblSubHeading.Location = new System.Drawing.Point(14, 67);
            this.lblSubHeading.Name = "lblSubHeading";
            this.lblSubHeading.Size = new System.Drawing.Size(360, 20);
            this.lblSubHeading.TabIndex = 16;
            this.lblSubHeading.Text = "Manage the students on different projects";
            // 
            // frmAssignStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(926, 601);
            this.Controls.Add(this.btnDeleteStudentProj);
            this.Controls.Add(this.btnUpdateStudentProj);
            this.Controls.Add(this.btnAddStudentProj);
            this.Controls.Add(this.dgvDisplayAssign);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSubHeading);
            this.Name = "frmAssignStudents";
            this.Text = "frmAssignStudents";
            this.Load += new System.EventHandler(this.frmAssignStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAssign)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteStudentProj;
        private System.Windows.Forms.Button btnUpdateStudentProj;
        private System.Windows.Forms.Button btnAddStudentProj;
        private System.Windows.Forms.DataGridView dgvDisplayAssign;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSubHeading;
    }
}