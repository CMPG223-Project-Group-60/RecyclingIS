
namespace RecyclingIS
{
    partial class frmUpdateStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateStudent));
            this.label5 = new System.Windows.Forms.Label();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxGrade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 29);
            this.label5.TabIndex = 38;
            this.label5.Text = "Date of Birth";
            // 
            // rdoMale
            // 
            this.rdoMale.BackColor = System.Drawing.Color.Transparent;
            this.rdoMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMale.ForeColor = System.Drawing.Color.White;
            this.rdoMale.Location = new System.Drawing.Point(145, 382);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(117, 51);
            this.rdoMale.TabIndex = 37;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = false;
            // 
            // rdoFemale
            // 
            this.rdoFemale.BackColor = System.Drawing.Color.Transparent;
            this.rdoFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFemale.ForeColor = System.Drawing.Color.White;
            this.rdoFemale.Location = new System.Drawing.Point(25, 389);
            this.rdoFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(114, 38);
            this.rdoFemale.TabIndex = 36;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 29);
            this.label4.TabIndex = 35;
            this.label4.Text = "Gender";
            // 
            // cbxGrade
            // 
            this.cbxGrade.FormattingEnabled = true;
            this.cbxGrade.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12"});
            this.cbxGrade.Location = new System.Drawing.Point(316, 396);
            this.cbxGrade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxGrade.Name = "cbxGrade";
            this.cbxGrade.Size = new System.Drawing.Size(130, 28);
            this.cbxGrade.TabIndex = 34;
            this.cbxGrade.SelectedIndexChanged += new System.EventHandler(this.cbxGrade_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(310, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 29);
            this.label3.TabIndex = 33;
            this.label3.Text = "Grade";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "First name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(26, 292);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSurname.Multiline = true;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(213, 33);
            this.txtSurname.TabIndex = 31;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Select student";
            // 
            // lblHeading
            // 
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Stencil", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblHeading.Location = new System.Drawing.Point(14, 11);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(934, 72);
            this.lblHeading.TabIndex = 25;
            this.lblHeading.Text = "Update Student ";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(369, 566);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(168, 54);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.Location = new System.Drawing.Point(26, 566);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(168, 54);
            this.btnAddStudent.TabIndex = 27;
            this.btnAddStudent.Text = "Update Student";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 189);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(331, 28);
            this.comboBox1.TabIndex = 40;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(316, 292);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 33);
            this.textBox1.TabIndex = 41;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(310, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 29);
            this.label6.TabIndex = 42;
            this.label6.Text = "Last name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 509);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 43;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // frmUpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(578, 622);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxGrade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddStudent);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUpdateStudent";
            this.Text = "frmUpdateStudent";
            this.Load += new System.EventHandler(this.frmUpdateStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxGrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}