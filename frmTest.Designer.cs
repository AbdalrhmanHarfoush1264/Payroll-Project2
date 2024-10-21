namespace Payroll_Project2
{
    partial class frmTest
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
            this.ctrlIssueSalary1 = new Payroll_Project2.ctrlIssueSalary();
            this.SuspendLayout();
            // 
            // ctrlIssueSalary1
            // 
            this.ctrlIssueSalary1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrlIssueSalary1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlIssueSalary1.Location = new System.Drawing.Point(4, 14);
            this.ctrlIssueSalary1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlIssueSalary1.Name = "ctrlIssueSalary1";
            this.ctrlIssueSalary1.Size = new System.Drawing.Size(979, 547);
            this.ctrlIssueSalary1.TabIndex = 0;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 582);
            this.Controls.Add(this.ctrlIssueSalary1);
            this.Name = "frmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTest";
            this.Load += new System.EventHandler(this.frmTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlIssueSalary ctrlIssueSalary1;
    }
}