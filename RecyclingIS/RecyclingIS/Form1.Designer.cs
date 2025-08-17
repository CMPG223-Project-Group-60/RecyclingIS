
namespace RecyclingIS
{
    partial class frmMain
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubheading = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnMerits = new System.Windows.Forms.Button();
            this.btnProjects = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.imgReport = new System.Windows.Forms.PictureBox();
            this.imgMerit = new System.Windows.Forms.PictureBox();
            this.imgProject = new System.Windows.Forms.PictureBox();
            this.imgRecord = new System.Windows.Forms.PictureBox();
            this.imgItems = new System.Windows.Forms.PictureBox();
            this.imgStudent = new System.Windows.Forms.PictureBox();
            this.imgDashboard = new System.Windows.Forms.PictureBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnlHeader.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMerit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblSubheading);
            this.pnlHeader.Controls.Add(this.imgLogo);
            this.pnlHeader.Controls.Add(this.lblHeading);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(1156, 80);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblSubheading
            // 
            this.lblSubheading.AutoSize = true;
            this.lblSubheading.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubheading.ForeColor = System.Drawing.Color.Gray;
            this.lblSubheading.Location = new System.Drawing.Point(91, 51);
            this.lblSubheading.Name = "lblSubheading";
            this.lblSubheading.Size = new System.Drawing.Size(192, 23);
            this.lblSubheading.TabIndex = 3;
            this.lblSubheading.Text = "Treasure hidden in waste";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblHeading.Location = new System.Drawing.Point(86, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(236, 51);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "EcoTrashure";
            this.lblHeading.Click += new System.EventHandler(this.lblHeading_Click);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.pnlSidebar.Controls.Add(this.imgReport);
            this.pnlSidebar.Controls.Add(this.imgMerit);
            this.pnlSidebar.Controls.Add(this.imgProject);
            this.pnlSidebar.Controls.Add(this.imgRecord);
            this.pnlSidebar.Controls.Add(this.imgItems);
            this.pnlSidebar.Controls.Add(this.imgStudent);
            this.pnlSidebar.Controls.Add(this.btnReports);
            this.pnlSidebar.Controls.Add(this.btnMerits);
            this.pnlSidebar.Controls.Add(this.btnProjects);
            this.pnlSidebar.Controls.Add(this.btnTransactions);
            this.pnlSidebar.Controls.Add(this.btnItems);
            this.pnlSidebar.Controls.Add(this.btnStudents);
            this.pnlSidebar.Controls.Add(this.imgDashboard);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 80);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(225, 389);
            this.pnlSidebar.TabIndex = 2;
            // 
            // btnReports
            // 
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(0, 300);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(225, 50);
            this.btnReports.TabIndex = 7;
            this.btnReports.Text = "Report";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnMerits
            // 
            this.btnMerits.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMerits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMerits.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMerits.ForeColor = System.Drawing.Color.White;
            this.btnMerits.Location = new System.Drawing.Point(0, 250);
            this.btnMerits.Name = "btnMerits";
            this.btnMerits.Size = new System.Drawing.Size(225, 50);
            this.btnMerits.TabIndex = 6;
            this.btnMerits.Text = "Merit System";
            this.btnMerits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMerits.UseVisualStyleBackColor = true;
            this.btnMerits.Click += new System.EventHandler(this.btnMerits_Click);
            // 
            // btnProjects
            // 
            this.btnProjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjects.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjects.ForeColor = System.Drawing.Color.White;
            this.btnProjects.Location = new System.Drawing.Point(0, 200);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(225, 50);
            this.btnProjects.TabIndex = 5;
            this.btnProjects.Text = "Project Management";
            this.btnProjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjects.UseVisualStyleBackColor = true;
            this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactions.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactions.ForeColor = System.Drawing.Color.White;
            this.btnTransactions.Location = new System.Drawing.Point(0, 150);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(225, 50);
            this.btnTransactions.TabIndex = 4;
            this.btnTransactions.Text = "Recycling Transactions";
            this.btnTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnItems
            // 
            this.btnItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItems.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItems.ForeColor = System.Drawing.Color.White;
            this.btnItems.Location = new System.Drawing.Point(0, 100);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(225, 50);
            this.btnItems.TabIndex = 3;
            this.btnItems.Text = "Items Catalogue";
            this.btnItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.ForeColor = System.Drawing.Color.White;
            this.btnStudents.Location = new System.Drawing.Point(0, 50);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(225, 50);
            this.btnStudents.TabIndex = 2;
            this.btnStudents.Text = "Student Management";
            this.btnStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(225, 50);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // imgReport
            // 
            this.imgReport.BackColor = System.Drawing.Color.White;
            this.imgReport.Image = global::RecyclingIS.Properties.Resources.reporticon;
            this.imgReport.Location = new System.Drawing.Point(95, 306);
            this.imgReport.Name = "imgReport";
            this.imgReport.Size = new System.Drawing.Size(24, 38);
            this.imgReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgReport.TabIndex = 12;
            this.imgReport.TabStop = false;
            // 
            // imgMerit
            // 
            this.imgMerit.BackColor = System.Drawing.Color.White;
            this.imgMerit.Image = global::RecyclingIS.Properties.Resources.medal_icon;
            this.imgMerit.Location = new System.Drawing.Point(149, 256);
            this.imgMerit.Name = "imgMerit";
            this.imgMerit.Size = new System.Drawing.Size(24, 38);
            this.imgMerit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMerit.TabIndex = 11;
            this.imgMerit.TabStop = false;
            this.imgMerit.Click += new System.EventHandler(this.imgMerit_Click);
            // 
            // imgProject
            // 
            this.imgProject.BackColor = System.Drawing.Color.White;
            this.imgProject.Image = global::RecyclingIS.Properties.Resources.projecticon;
            this.imgProject.Location = new System.Drawing.Point(186, 206);
            this.imgProject.Name = "imgProject";
            this.imgProject.Size = new System.Drawing.Size(24, 38);
            this.imgProject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProject.TabIndex = 3;
            this.imgProject.TabStop = false;
            // 
            // imgRecord
            // 
            this.imgRecord.BackColor = System.Drawing.Color.White;
            this.imgRecord.Image = global::RecyclingIS.Properties.Resources.recordicon;
            this.imgRecord.Location = new System.Drawing.Point(198, 156);
            this.imgRecord.Name = "imgRecord";
            this.imgRecord.Size = new System.Drawing.Size(24, 38);
            this.imgRecord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgRecord.TabIndex = 10;
            this.imgRecord.TabStop = false;
            // 
            // imgItems
            // 
            this.imgItems.BackColor = System.Drawing.Color.White;
            this.imgItems.Image = global::RecyclingIS.Properties.Resources.items_icon;
            this.imgItems.Location = new System.Drawing.Point(158, 106);
            this.imgItems.Name = "imgItems";
            this.imgItems.Size = new System.Drawing.Size(24, 38);
            this.imgItems.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgItems.TabIndex = 9;
            this.imgItems.TabStop = false;
            // 
            // imgStudent
            // 
            this.imgStudent.BackColor = System.Drawing.Color.White;
            this.imgStudent.Image = global::RecyclingIS.Properties.Resources.students_icon;
            this.imgStudent.Location = new System.Drawing.Point(198, 56);
            this.imgStudent.Name = "imgStudent";
            this.imgStudent.Size = new System.Drawing.Size(24, 38);
            this.imgStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgStudent.TabIndex = 8;
            this.imgStudent.TabStop = false;
            this.imgStudent.Click += new System.EventHandler(this.imgStudent_Click);
            // 
            // imgDashboard
            // 
            this.imgDashboard.BackColor = System.Drawing.Color.White;
            this.imgDashboard.Image = global::RecyclingIS.Properties.Resources.homeicon1;
            this.imgDashboard.Location = new System.Drawing.Point(116, 12);
            this.imgDashboard.Name = "imgDashboard";
            this.imgDashboard.Size = new System.Drawing.Size(24, 29);
            this.imgDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgDashboard.TabIndex = 1;
            this.imgDashboard.TabStop = false;
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.White;
            this.imgLogo.Image = global::RecyclingIS.Properties.Resources.logo;
            this.imgLogo.Location = new System.Drawing.Point(9, 3);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(71, 74);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 2;
            this.imgLogo.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1156, 469);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "EcoTrashure";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMerit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.PictureBox imgDashboard;
        private System.Windows.Forms.PictureBox imgStudent;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnMerits;
        private System.Windows.Forms.Button btnProjects;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.PictureBox imgItems;
        private System.Windows.Forms.PictureBox imgProject;
        private System.Windows.Forms.PictureBox imgRecord;
        private System.Windows.Forms.PictureBox imgMerit;
        private System.Windows.Forms.PictureBox imgReport;
        private System.Windows.Forms.Label lblSubheading;
        private System.Windows.Forms.PictureBox imgLogo;
    }
}

