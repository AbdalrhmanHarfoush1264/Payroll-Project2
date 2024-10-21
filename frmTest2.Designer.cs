namespace Payroll_Project2
{
    partial class frmTest2
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
            this.ctrlAttendances1 = new Payroll_Project2.ctrlAttendances();
            this.SuspendLayout();
            // 
            // ctrlAttendances1
            // 
            this.ctrlAttendances1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrlAttendances1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlAttendances1.Location = new System.Drawing.Point(46, 4);
            this.ctrlAttendances1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlAttendances1.Name = "ctrlAttendances1";
            this.ctrlAttendances1.Size = new System.Drawing.Size(855, 547);
            this.ctrlAttendances1.TabIndex = 0;
            // 
            // frmTest2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1013, 557);
            this.Controls.Add(this.ctrlAttendances1);
            this.Name = "frmTest2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTest2";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlAttendances ctrlAttendances1;
    }
}