
namespace RecyclingIS
{
    partial class frmDeleteItemType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteItemType));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDeleteItemType = new System.Windows.Forms.Button();
            this.cbxItemType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(391, 176);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(171, 39);
            this.btnCancel.TabIndex = 49;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDeleteItemType
            // 
            this.btnDeleteItemType.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDeleteItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItemType.ForeColor = System.Drawing.Color.White;
            this.btnDeleteItemType.Location = new System.Drawing.Point(12, 176);
            this.btnDeleteItemType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteItemType.Name = "btnDeleteItemType";
            this.btnDeleteItemType.Size = new System.Drawing.Size(171, 39);
            this.btnDeleteItemType.TabIndex = 48;
            this.btnDeleteItemType.Text = "Delete Item Type";
            this.btnDeleteItemType.UseVisualStyleBackColor = false;
            this.btnDeleteItemType.Click += new System.EventHandler(this.btnDeleteItemType_Click);
            // 
            // cbxItemType
            // 
            this.cbxItemType.FormattingEnabled = true;
            this.cbxItemType.Location = new System.Drawing.Point(12, 123);
            this.cbxItemType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxItemType.Name = "cbxItemType";
            this.cbxItemType.Size = new System.Drawing.Size(276, 24);
            this.cbxItemType.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Select item type";
            // 
            // lblHeading
            // 
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Stencil", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblHeading.Location = new System.Drawing.Point(12, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(829, 58);
            this.lblHeading.TabIndex = 45;
            this.lblHeading.Text = "Delete Item Type ";
            // 
            // frmDeleteItemType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(589, 226);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteItemType);
            this.Controls.Add(this.cbxItemType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHeading);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDeleteItemType";
            this.Text = "frmDeleteItemType";
            this.Load += new System.EventHandler(this.frmDeleteItemType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDeleteItemType;
        private System.Windows.Forms.ComboBox cbxItemType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHeading;
    }
}