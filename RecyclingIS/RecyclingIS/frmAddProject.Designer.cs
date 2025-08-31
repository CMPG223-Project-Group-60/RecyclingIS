
namespace RecyclingIS
{
    partial class frmAddProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProject));
            this.lblHeading = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtProjName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddProj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Stencil", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblHeading.Location = new System.Drawing.Point(14, 11);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(576, 72);
            this.lblHeading.TabIndex = 8;
            this.lblHeading.Text = "Add New Project";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 29);
            this.label5.TabIndex = 29;
            this.label5.Text = "Due date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.CausesValidation = false;
            this.txtDescription.Location = new System.Drawing.Point(25, 252);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(537, 40);
            this.txtDescription.TabIndex = 27;
            // 
            // txtProjName
            // 
            this.txtProjName.Location = new System.Drawing.Point(25, 148);
            this.txtProjName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProjName.Multiline = true;
            this.txtProjName.Name = "txtProjName";
            this.txtProjName.Size = new System.Drawing.Size(537, 40);
            this.txtProjName.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Project name";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 361);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 26);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGreen;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(225, 436);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(151, 69);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(414, 436);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 69);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddProj
            // 
            this.btnAddProj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProj.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProj.ForeColor = System.Drawing.Color.White;
            this.btnAddProj.Location = new System.Drawing.Point(25, 436);
            this.btnAddProj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddProj.Name = "btnAddProj";
            this.btnAddProj.Size = new System.Drawing.Size(163, 69);
            this.btnAddProj.TabIndex = 32;
            this.btnAddProj.Text = "Add Project";
            this.btnAddProj.UseVisualStyleBackColor = false;
            // 
            // frmAddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(603, 529);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddProj);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtProjName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHeading);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddProject";
            this.Text = "frmAddProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtProjName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddProj;
    }
}