
namespace RecyclingIS
{
    partial class frmMeritManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMeritManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubHeading = new System.Windows.Forms.Label();
            this.dgvDisplayMerits = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddMerit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayMerits)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(0, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(934, 72);
            this.label1.TabIndex = 16;
            this.label1.Text = "Merits Management";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSubHeading
            // 
            this.lblSubHeading.AutoSize = true;
            this.lblSubHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblSubHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeading.ForeColor = System.Drawing.Color.White;
            this.lblSubHeading.Location = new System.Drawing.Point(14, 84);
            this.lblSubHeading.Name = "lblSubHeading";
            this.lblSubHeading.Size = new System.Drawing.Size(252, 25);
            this.lblSubHeading.TabIndex = 15;
            this.lblSubHeading.Text = "Manage student merits";
            // 
            // dgvDisplayMerits
            // 
            this.dgvDisplayMerits.AllowUserToAddRows = false;
            this.dgvDisplayMerits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplayMerits.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDisplayMerits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayMerits.Location = new System.Drawing.Point(11, 124);
            this.dgvDisplayMerits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDisplayMerits.Name = "dgvDisplayMerits";
            this.dgvDisplayMerits.RowHeadersWidth = 51;
            this.dgvDisplayMerits.RowTemplate.Height = 24;
            this.dgvDisplayMerits.Size = new System.Drawing.Size(629, 226);
            this.dgvDisplayMerits.TabIndex = 17;
            this.dgvDisplayMerits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayMerits_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(458, 358);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(182, 69);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete Merit";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(236, 358);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(182, 69);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update Merit";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddMerit
            // 
            this.btnAddMerit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddMerit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMerit.ForeColor = System.Drawing.Color.White;
            this.btnAddMerit.Location = new System.Drawing.Point(11, 358);
            this.btnAddMerit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddMerit.Name = "btnAddMerit";
            this.btnAddMerit.Size = new System.Drawing.Size(182, 69);
            this.btnAddMerit.TabIndex = 18;
            this.btnAddMerit.Text = "Add Merit";
            this.btnAddMerit.UseVisualStyleBackColor = false;
            this.btnAddMerit.Click += new System.EventHandler(this.btnAddMerit_Click);
            // 
            // frmMeritManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 438);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddMerit);
            this.Controls.Add(this.dgvDisplayMerits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSubHeading);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMeritManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMeritManagement";
            this.Load += new System.EventHandler(this.frmMeritManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayMerits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSubHeading;
        private System.Windows.Forms.DataGridView dgvDisplayMerits;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddMerit;
    }
}