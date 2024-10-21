namespace Payroll_Project2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnfrmAttendance = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnfrmHome = new System.Windows.Forms.Button();
            this.btnfrmEmployees = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnfrmSalary = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctrlHome1 = new Payroll_Project2.ctrlHome();
            this.ctrlEmployees1 = new Payroll_Project2.ctrlEmployees();
            this.ctrlAttendances1 = new Payroll_Project2.ctrlAttendances();
            this.ctrlIssueSalary1 = new Payroll_Project2.ctrlIssueSalary();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnfrmAttendance
            // 
            this.btnfrmAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfrmAttendance.Location = new System.Drawing.Point(3, 370);
            this.btnfrmAttendance.Name = "btnfrmAttendance";
            this.btnfrmAttendance.Size = new System.Drawing.Size(171, 38);
            this.btnfrmAttendance.TabIndex = 5;
            this.btnfrmAttendance.Text = "Attendance";
            this.btnfrmAttendance.UseVisualStyleBackColor = true;
            this.btnfrmAttendance.Click += new System.EventHandler(this.btnfrmAttendance_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnfrmHome
            // 
            this.btnfrmHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfrmHome.Location = new System.Drawing.Point(3, 255);
            this.btnfrmHome.Name = "btnfrmHome";
            this.btnfrmHome.Size = new System.Drawing.Size(171, 38);
            this.btnfrmHome.TabIndex = 2;
            this.btnfrmHome.Text = "Home";
            this.btnfrmHome.UseVisualStyleBackColor = true;
            this.btnfrmHome.Click += new System.EventHandler(this.btnfrmHome_Click);
            // 
            // btnfrmEmployees
            // 
            this.btnfrmEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfrmEmployees.Location = new System.Drawing.Point(3, 309);
            this.btnfrmEmployees.Name = "btnfrmEmployees";
            this.btnfrmEmployees.Size = new System.Drawing.Size(171, 38);
            this.btnfrmEmployees.TabIndex = 1;
            this.btnfrmEmployees.Text = "Employees";
            this.btnfrmEmployees.UseVisualStyleBackColor = true;
            this.btnfrmEmployees.Click += new System.EventHandler(this.btnfrmEmployees_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.ctrlHome1);
            this.panel2.Controls.Add(this.ctrlEmployees1);
            this.panel2.Controls.Add(this.ctrlAttendances1);
            this.panel2.Controls.Add(this.ctrlIssueSalary1);
            this.panel2.Location = new System.Drawing.Point(189, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(976, 547);
            this.panel2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(3, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnfrmSalary
            // 
            this.btnfrmSalary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfrmSalary.Location = new System.Drawing.Point(3, 427);
            this.btnfrmSalary.Name = "btnfrmSalary";
            this.btnfrmSalary.Size = new System.Drawing.Size(171, 38);
            this.btnfrmSalary.TabIndex = 2;
            this.btnfrmSalary.Text = "Issue Salary";
            this.btnfrmSalary.UseVisualStyleBackColor = true;
            this.btnfrmSalary.Click += new System.EventHandler(this.btnfrmSalary_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel1.Controls.Add(this.btnfrmAttendance);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnfrmHome);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnfrmSalary);
            this.panel1.Controls.Add(this.btnfrmEmployees);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 547);
            this.panel1.TabIndex = 5;
            // 
            // ctrlHome1
            // 
            this.ctrlHome1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrlHome1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlHome1.Location = new System.Drawing.Point(1, 0);
            this.ctrlHome1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlHome1.Name = "ctrlHome1";
            this.ctrlHome1.Size = new System.Drawing.Size(976, 547);
            this.ctrlHome1.TabIndex = 3;
            // 
            // ctrlEmployees1
            // 
            this.ctrlEmployees1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrlEmployees1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlEmployees1.Location = new System.Drawing.Point(1, 0);
            this.ctrlEmployees1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlEmployees1.Name = "ctrlEmployees1";
            this.ctrlEmployees1.Size = new System.Drawing.Size(976, 547);
            this.ctrlEmployees1.TabIndex = 2;
            // 
            // ctrlAttendances1
            // 
            this.ctrlAttendances1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrlAttendances1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlAttendances1.Location = new System.Drawing.Point(1, 0);
            this.ctrlAttendances1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlAttendances1.Name = "ctrlAttendances1";
            this.ctrlAttendances1.Size = new System.Drawing.Size(976, 547);
            this.ctrlAttendances1.TabIndex = 1;
            // 
            // ctrlIssueSalary1
            // 
            this.ctrlIssueSalary1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrlIssueSalary1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlIssueSalary1.Location = new System.Drawing.Point(1, 0);
            this.ctrlIssueSalary1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlIssueSalary1.Name = "ctrlIssueSalary1";
            this.ctrlIssueSalary1.Size = new System.Drawing.Size(976, 547);
            this.ctrlIssueSalary1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1167, 555);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnfrmAttendance;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnfrmHome;
        private System.Windows.Forms.Button btnfrmEmployees;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnfrmSalary;
        private System.Windows.Forms.Panel panel1;
        private ctrlIssueSalary ctrlIssueSalary1;
        private ctrlHome ctrlHome1;
        private ctrlEmployees ctrlEmployees1;
        private ctrlAttendances ctrlAttendances1;
    }
}

