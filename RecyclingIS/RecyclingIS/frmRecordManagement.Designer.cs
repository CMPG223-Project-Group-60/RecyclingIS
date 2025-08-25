
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvRecordedItem = new System.Windows.Forms.DataGridView();
            this.btnDeleteRecordedItem = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddRecordedItem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecordedItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(-2, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(830, 58);
            this.label1.TabIndex = 14;
            this.label1.Text = "Recorded Items Management";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSubHeading
            // 
            this.lblSubHeading.AutoSize = true;
            this.lblSubHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblSubHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeading.ForeColor = System.Drawing.Color.White;
            this.lblSubHeading.Location = new System.Drawing.Point(4, 54);
            this.lblSubHeading.Name = "lblSubHeading";
            this.lblSubHeading.Size = new System.Drawing.Size(409, 20);
            this.lblSubHeading.TabIndex = 13;
            this.lblSubHeading.Text = "Manage the master list of recyclable item types";
            this.lblSubHeading.Click += new System.EventHandler(this.lblSubHeading_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(8, 119);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(801, 47);
            this.panel1.TabIndex = 15;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.Location = new System.Drawing.Point(55, 4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(738, 35);
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
            // dgvRecordedItem
            // 
            this.dgvRecordedItem.AllowUserToAddRows = false;
            this.dgvRecordedItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecordedItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecordedItem.Location = new System.Drawing.Point(8, 216);
            this.dgvRecordedItem.Name = "dgvRecordedItem";
            this.dgvRecordedItem.RowHeadersWidth = 51;
            this.dgvRecordedItem.RowTemplate.Height = 24;
            this.dgvRecordedItem.Size = new System.Drawing.Size(801, 265);
            this.dgvRecordedItem.TabIndex = 9;
            // 
            // btnDeleteRecordedItem
            // 
            this.btnDeleteRecordedItem.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteRecordedItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRecordedItem.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRecordedItem.Location = new System.Drawing.Point(617, 508);
            this.btnDeleteRecordedItem.Name = "btnDeleteRecordedItem";
            this.btnDeleteRecordedItem.Size = new System.Drawing.Size(192, 55);
            this.btnDeleteRecordedItem.TabIndex = 18;
            this.btnDeleteRecordedItem.Text = "Delete Recorded Item";
            this.btnDeleteRecordedItem.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(303, 508);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(202, 55);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update Recorded Item";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAddRecordedItem
            // 
            this.btnAddRecordedItem.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddRecordedItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRecordedItem.ForeColor = System.Drawing.Color.White;
            this.btnAddRecordedItem.Location = new System.Drawing.Point(14, 508);
            this.btnAddRecordedItem.Name = "btnAddRecordedItem";
            this.btnAddRecordedItem.Size = new System.Drawing.Size(162, 55);
            this.btnAddRecordedItem.TabIndex = 16;
            this.btnAddRecordedItem.Text = "Add Recorded Items";
            this.btnAddRecordedItem.UseVisualStyleBackColor = false;
            // 
            // frmRecordManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 574);
            this.Controls.Add(this.btnDeleteRecordedItem);
            this.Controls.Add(this.dgvRecordedItem);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddRecordedItem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSubHeading);
            this.Name = "frmRecordManagement";
            this.Text = "frmRecordManagement";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecordedItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSubHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvRecordedItem;
        private System.Windows.Forms.Button btnDeleteRecordedItem;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddRecordedItem;
    }
}