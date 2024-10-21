namespace Payroll_Project2
{
    partial class ctrlIssueSalary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBaseSalary = new System.Windows.Forms.TextBox();
            this.txtBouns = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPresent = new System.Windows.Forms.TextBox();
            this.txtAbsent = new System.Windows.Forms.TextBox();
            this.txtExcused = new System.Windows.Forms.TextBox();
            this.dgvListIssueSalary = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtTotalSalary = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListIssueSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(313, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 31);
            this.label2.TabIndex = 33;
            this.label2.Text = "Issue Salary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "EmployeeID:";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(423, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 26);
            this.txtName.TabIndex = 36;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "MM/YYYY";
            this.dtpDate.Location = new System.Drawing.Point(158, 103);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(172, 26);
            this.dtpDate.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Absent:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Present:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "DisCount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Bouns:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(578, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "Base Salary:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(99, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(357, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "Name:";
            // 
            // txtBaseSalary
            // 
            this.txtBaseSalary.Enabled = false;
            this.txtBaseSalary.Location = new System.Drawing.Point(694, 74);
            this.txtBaseSalary.Name = "txtBaseSalary";
            this.txtBaseSalary.Size = new System.Drawing.Size(149, 26);
            this.txtBaseSalary.TabIndex = 45;
            this.txtBaseSalary.Text = "0";
            // 
            // txtBouns
            // 
            this.txtBouns.Location = new System.Drawing.Point(423, 101);
            this.txtBouns.Name = "txtBouns";
            this.txtBouns.Size = new System.Drawing.Size(149, 26);
            this.txtBouns.TabIndex = 46;
            this.txtBouns.Text = "0";
            this.txtBouns.TextChanged += new System.EventHandler(this.txtBouns_TextChanged);
            this.txtBouns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeID_KeyPress);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(694, 103);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(149, 26);
            this.txtDiscount.TabIndex = 47;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeID_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(606, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 48;
            this.label10.Text = "Excused:";
            // 
            // txtPresent
            // 
            this.txtPresent.Enabled = false;
            this.txtPresent.Location = new System.Drawing.Point(158, 140);
            this.txtPresent.Name = "txtPresent";
            this.txtPresent.Size = new System.Drawing.Size(172, 26);
            this.txtPresent.TabIndex = 49;
            this.txtPresent.Text = "0";
            // 
            // txtAbsent
            // 
            this.txtAbsent.Enabled = false;
            this.txtAbsent.Location = new System.Drawing.Point(423, 137);
            this.txtAbsent.Name = "txtAbsent";
            this.txtAbsent.Size = new System.Drawing.Size(149, 26);
            this.txtAbsent.TabIndex = 50;
            this.txtAbsent.Text = "0";
            // 
            // txtExcused
            // 
            this.txtExcused.Enabled = false;
            this.txtExcused.Location = new System.Drawing.Point(694, 140);
            this.txtExcused.Name = "txtExcused";
            this.txtExcused.Size = new System.Drawing.Size(149, 26);
            this.txtExcused.TabIndex = 51;
            this.txtExcused.Text = "0";
            // 
            // dgvListIssueSalary
            // 
            this.dgvListIssueSalary.AllowUserToAddRows = false;
            this.dgvListIssueSalary.AllowUserToDeleteRows = false;
            this.dgvListIssueSalary.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvListIssueSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListIssueSalary.GridColor = System.Drawing.Color.Red;
            this.dgvListIssueSalary.Location = new System.Drawing.Point(3, 172);
            this.dgvListIssueSalary.Name = "dgvListIssueSalary";
            this.dgvListIssueSalary.ReadOnly = true;
            this.dgvListIssueSalary.Size = new System.Drawing.Size(968, 318);
            this.dgvListIssueSalary.TabIndex = 52;
            this.dgvListIssueSalary.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListIssueSalary_CellMouseDoubleClick);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.ForeColor = System.Drawing.Color.Yellow;
            this.btnSave.Location = new System.Drawing.Point(131, 496);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(214, 36);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Green;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.ForeColor = System.Drawing.Color.Yellow;
            this.btnDelete.Location = new System.Drawing.Point(582, 496);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(214, 36);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(158, 71);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(172, 26);
            this.txtEmployeeID.TabIndex = 55;
            this.txtEmployeeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeID_KeyPress);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Green;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFind.ForeColor = System.Drawing.Color.Yellow;
            this.btnFind.Location = new System.Drawing.Point(351, 496);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(214, 36);
            this.btnFind.TabIndex = 56;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtTotalSalary
            // 
            this.txtTotalSalary.Enabled = false;
            this.txtTotalSalary.Location = new System.Drawing.Point(849, 102);
            this.txtTotalSalary.Multiline = true;
            this.txtTotalSalary.Name = "txtTotalSalary";
            this.txtTotalSalary.Size = new System.Drawing.Size(122, 64);
            this.txtTotalSalary.TabIndex = 57;
            this.txtTotalSalary.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(860, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 20);
            this.label11.TabIndex = 58;
            this.label11.Text = "TotalSalary";
            // 
            // ctrlIssueSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTotalSalary);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvListIssueSalary);
            this.Controls.Add(this.txtExcused);
            this.Controls.Add(this.txtAbsent);
            this.Controls.Add(this.txtPresent);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtBouns);
            this.Controls.Add(this.txtBaseSalary);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctrlIssueSalary";
            this.Size = new System.Drawing.Size(976, 547);
            this.Load += new System.EventHandler(this.ctrlIssueSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListIssueSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBaseSalary;
        private System.Windows.Forms.TextBox txtBouns;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPresent;
        private System.Windows.Forms.TextBox txtAbsent;
        private System.Windows.Forms.TextBox txtExcused;
        private System.Windows.Forms.DataGridView dgvListIssueSalary;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtTotalSalary;
        private System.Windows.Forms.Label label11;
    }
}
