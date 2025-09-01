
namespace RecyclingIS
{
    partial class frmAddMerit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddMerit));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.cbxMerit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.txtPointsAwarded = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGreen;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(190, 315);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(148, 59);
            this.btnClear.TabIndex = 42;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(370, 315);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 59);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.Location = new System.Drawing.Point(25, 315);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(142, 59);
            this.btnAddStudent.TabIndex = 40;
            this.btnAddStudent.Text = "Add Merit";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            // 
            // cbxMerit
            // 
            this.cbxMerit.FormattingEnabled = true;
            this.cbxMerit.Location = new System.Drawing.Point(29, 164);
            this.cbxMerit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxMerit.Name = "cbxMerit";
            this.cbxMerit.Size = new System.Drawing.Size(271, 28);
            this.cbxMerit.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 29);
            this.label3.TabIndex = 38;
            this.label3.Text = "Points awarded";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 37;
            this.label1.Text = "Merit type";
            // 
            // lblHeading
            // 
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Stencil", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblHeading.Location = new System.Drawing.Point(14, 11);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(934, 72);
            this.lblHeading.TabIndex = 36;
            this.lblHeading.Text = "Add New Merit";
            // 
            // txtPointsAwarded
            // 
            this.txtPointsAwarded.Location = new System.Drawing.Point(25, 252);
            this.txtPointsAwarded.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPointsAwarded.Multiline = true;
            this.txtPointsAwarded.Name = "txtPointsAwarded";
            this.txtPointsAwarded.Size = new System.Drawing.Size(376, 32);
            this.txtPointsAwarded.TabIndex = 43;
            // 
            // frmAddMerit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(530, 395);
            this.Controls.Add(this.txtPointsAwarded);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.cbxMerit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHeading);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddMerit";
            this.Text = "frmAddMerit";
            this.Load += new System.EventHandler(this.frmAddMerit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.ComboBox cbxMerit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TextBox txtPointsAwarded;
    }
}