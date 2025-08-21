
namespace RecyclingIS
{
    partial class frmRecordManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecordManagement));
            this.dgvStudentRecycling = new System.Windows.Forms.DataGridView();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblSubHeading = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.imgSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRecordRecycling = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentRecycling)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudentRecycling
            // 
            this.dgvStudentRecycling.AllowUserToAddRows = false;
            this.dgvStudentRecycling.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentRecycling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentRecycling.Location = new System.Drawing.Point(9, 253);
            this.dgvStudentRecycling.Name = "dgvStudentRecycling";
            this.dgvStudentRecycling.RowHeadersWidth = 51;
            this.dgvStudentRecycling.RowTemplate.Height = 24;
            this.dgvStudentRecycling.Size = new System.Drawing.Size(976, 265);
            this.dgvStudentRecycling.TabIndex = 9;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(12, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(372, 40);
            this.lblHeading.TabIndex = 10;
            this.lblHeading.Text = "Recycle Projects List";
            // 
            // lblSubHeading
            // 
            this.lblSubHeading.AutoSize = true;
            this.lblSubHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblSubHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeading.ForeColor = System.Drawing.Color.LightGray;
            this.lblSubHeading.Location = new System.Drawing.Point(15, 49);
            this.lblSubHeading.Name = "lblSubHeading";
            this.lblSubHeading.Size = new System.Drawing.Size(362, 20);
            this.lblSubHeading.TabIndex = 11;
            this.lblSubHeading.Text = "Manage the master list of recyclable item types";
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSearch.Controls.Add(this.imgSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Location = new System.Drawing.Point(9, 141);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(1);
            this.pnlSearch.Size = new System.Drawing.Size(976, 47);
            this.pnlSearch.TabIndex = 12;
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
            // btnRecordRecycling
            // 
            this.btnRecordRecycling.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRecordRecycling.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordRecycling.ForeColor = System.Drawing.Color.White;
            this.btnRecordRecycling.Location = new System.Drawing.Point(734, 33);
            this.btnRecordRecycling.Name = "btnRecordRecycling";
            this.btnRecordRecycling.Size = new System.Drawing.Size(251, 55);
            this.btnRecordRecycling.TabIndex = 13;
            this.btnRecordRecycling.Text = "Record Student Recycling Data";
            this.btnRecordRecycling.UseVisualStyleBackColor = false;
            // 
            // frmRecordManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 530);
            this.Controls.Add(this.btnRecordRecycling);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.lblSubHeading);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.dgvStudentRecycling);
            this.Name = "frmRecordManagement";
            this.Text = "frmRecordManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentRecycling)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudentRecycling;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblSubHeading;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.PictureBox imgSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRecordRecycling;
    }
}