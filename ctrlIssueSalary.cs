using clsPayrollBussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_Project2
{
    public partial class ctrlIssueSalary : UserControl
    {
        private DataTable _dtAllIssueSalaries;
        private DataTable _dtAllAttendanceForEmpID;
        private clsIssueSalary _IssueSalary;
        private int _EmployeeID;
        private int _IssueSalaryID = -1;
        public ctrlIssueSalary()
        {
            InitializeComponent();
        }

        private void PrepareDateTimePicker()
        {
            // Set DateTimePicker to show only Month and Year
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "MM/yyyy";
        }

        private void LoadIssueSalariesTodgv()
        {
            _dtAllIssueSalaries = clsIssueSalary.GetAllIssueSalaries();

            dgvListIssueSalary.DataSource = _dtAllIssueSalaries;


            if (dgvListIssueSalary.Rows.Count > 0)
            {
                dgvListIssueSalary.Columns[0].HeaderText = "Issue ID";
                dgvListIssueSalary.Columns[0].Width = 100;

                dgvListIssueSalary.Columns[1].HeaderText = "Employee ID";
                dgvListIssueSalary.Columns[1].Width = 100;

                dgvListIssueSalary.Columns[2].HeaderText = "Full Name";
                dgvListIssueSalary.Columns[2].Width = 150;

                dgvListIssueSalary.Columns[3].HeaderText = "Base Salary";
                dgvListIssueSalary.Columns[3].Width = 100;

                dgvListIssueSalary.Columns[4].HeaderText = "Issue Date";
                dgvListIssueSalary.Columns[4].Width = 150;

                dgvListIssueSalary.Columns[5].HeaderText = "Bouns";
                dgvListIssueSalary.Columns[5].Width = 100;

                dgvListIssueSalary.Columns[6].HeaderText = "Discount";
                dgvListIssueSalary.Columns[6].Width = 100;

                dgvListIssueSalary.Columns[7].HeaderText = "TotalSalary";
                dgvListIssueSalary.Columns[7].Width = 100;

                
            }
        }
        private void ctrlIssueSalary_Load(object sender, EventArgs e)
        {
            PrepareDateTimePicker();
            LoadIssueSalariesTodgv();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int PersentCount = 0;
            int AbsentCount = 0;
            int ExcusedCount = 0;
            
            if (string.IsNullOrEmpty(txtEmployeeID.Text))
            {
                MessageBox.Show("Enter Employee ID to Use Find Button !","Not Vailed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _EmployeeID = Convert.ToInt32(txtEmployeeID.Text);  
            _IssueSalary = new clsIssueSalary();

            _IssueSalary.FindEmployee(_EmployeeID);
            _IssueSalary.EmployeeID = _EmployeeID;

            if (_IssueSalary.Employee!=null)
            {
                txtName.Text = _IssueSalary.Employee.FullName;
                txtBaseSalary.Text = _IssueSalary.Employee.BaseSalary.ToString();
                txtTotalSalary.Text = _IssueSalary.Employee.BaseSalary.ToString();

                _IssueSalary.Date = dtpDate.Value.Date;
                _dtAllAttendanceForEmpID = _IssueSalary.GetAllAttendancesForEmployeeID();

                if(_dtAllAttendanceForEmpID.Rows.Count>0)
                {

                    PersentCount = Convert.ToInt32(_dtAllAttendanceForEmpID.Rows[0]["Persent_Count"]);
                    AbsentCount = Convert.ToInt32(_dtAllAttendanceForEmpID.Rows[0]["Absent_Count"]);
                    ExcusedCount = Convert.ToInt32(_dtAllAttendanceForEmpID.Rows[0]["Excused_Count"]);

                    txtAbsent.Text = AbsentCount.ToString();
                    txtPresent.Text = PersentCount.ToString();
                    txtExcused.Text = ExcusedCount.ToString();
                }
                else
                {
                    txtAbsent.Text = AbsentCount.ToString();
                    txtPresent.Text = PersentCount.ToString();
                    txtExcused.Text = ExcusedCount.ToString();
                }

            }
            else
            {
                MessageBox.Show("Employee ID is not Found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtEmployeeID.Text)||string.IsNullOrEmpty(txtBouns.Text)||
                string.IsNullOrEmpty(txtDiscount.Text))
            {
                MessageBox.Show("Some Boxes is Empty!", "Not Vailed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _IssueSalary.FullName = txtName.Text;
            _IssueSalary.BaseSalary = Convert.ToDouble(txtBaseSalary.Text);
            _IssueSalary.Date = dtpDate.Value;
            _IssueSalary.Bouns=Convert.ToDouble(txtBouns.Text);
            _IssueSalary.Discount = Convert.ToDouble(txtDiscount.Text);
            _IssueSalary.TotalSalary = Convert.ToDouble(txtTotalSalary.Text);

            if(_IssueSalary.AddNewIssueSalary())
            {
                MessageBox.Show("The operation was completed successfully.", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ctrlIssueSalary_Load(null, null);
                txtEmployeeID.Text = "";
                txtName.Text = "";
                txtBaseSalary.Text = 0.ToString();
                txtTotalSalary.Text = 0.ToString();
                txtBouns.Text = 0.ToString();
                txtDiscount.Text= 0.ToString();
                txtPresent.Text = 0.ToString();
                txtAbsent.Text = 0.ToString();
                txtExcused.Text = 0.ToString();
                dtpDate.Value = DateTime.Now;
                return;
            }else
            {
                MessageBox.Show("The operation failed.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtBouns_TextChanged(object sender, EventArgs e)
        {
            txtTotalSalary.Text = txtBaseSalary.Text;

            if (string.IsNullOrEmpty(txtBouns.Text))
            {
                return;
            }
            int Bouns=Convert.ToInt32(txtBouns.Text);
            int BaseSalary = Convert.ToInt32(txtBaseSalary.Text);
            int TotalSalary = Bouns + BaseSalary;

            if(Bouns>0&&BaseSalary>0)
            {
                txtTotalSalary.Text = TotalSalary.ToString();
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            txtTotalSalary.Text = txtBaseSalary.Text;

            if (string.IsNullOrEmpty(txtDiscount.Text))
            {
                return;
            }
            int Discount = Convert.ToInt32(txtDiscount.Text);
            int BaseSalary = Convert.ToInt32(txtBaseSalary.Text);
            int TotalSalary = BaseSalary - Discount;

            if (Discount > 0 && BaseSalary > 0)
            {
                txtTotalSalary.Text = TotalSalary.ToString();
            }
        }

        private void dgvListIssueSalary_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _IssueSalaryID = (int)dgvListIssueSalary.CurrentRow.Cells[0].Value;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_IssueSalaryID != -1)
            {
                if (MessageBox.Show($"Are you want delete this ID= {_IssueSalaryID} ?", "Message",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (clsIssueSalary.DeleteIssueSalary(_IssueSalaryID))
                    {
                        MessageBox.Show("Delete was Successfully", "Delete", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ctrlIssueSalary_Load(null, null);
                        return;
                    }
                    else
                        MessageBox.Show("Delete was Failed", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Select Issue Salary ID to Delete!", "Not Vailed", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void txtEmployeeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
