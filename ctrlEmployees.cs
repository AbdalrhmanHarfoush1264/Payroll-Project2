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
using System.Xml.Linq;

namespace Payroll_Project2
{
    public partial class ctrlEmployees : UserControl
    {
        private DataTable _dtAllEmployess;
        private clsEmployee _Employee;
        public ctrlEmployees()
        {
            InitializeComponent();
        }

        private void LoadEmployeesTodgv()
        {
            _dtAllEmployess = clsEmployee.GetAllEmployees();

            dgvListEmployees.DataSource = _dtAllEmployess;


            if (dgvListEmployees.Rows.Count > 0)
            {
                dgvListEmployees.Columns[0].HeaderText = "Emp ID";
                dgvListEmployees.Columns[0].Width = 100;

                dgvListEmployees.Columns[1].HeaderText = "Full Name";
                dgvListEmployees.Columns[1].Width = 150;

                dgvListEmployees.Columns[2].HeaderText = "Phone";
                dgvListEmployees.Columns[2].Width = 100;

                dgvListEmployees.Columns[3].HeaderText = "Gender";
                dgvListEmployees.Columns[3].Width = 100;

                dgvListEmployees.Columns[4].HeaderText = "Address";
                dgvListEmployees.Columns[4].Width = 150;

                dgvListEmployees.Columns[5].HeaderText = "Department";
                dgvListEmployees.Columns[5].Width = 100;

                dgvListEmployees.Columns[6].HeaderText = "Base Salary";
                dgvListEmployees.Columns[6].Width = 100;

                dgvListEmployees.Columns[7].HeaderText = "Date Of Birth";
                dgvListEmployees.Columns[7].Width = 100;

                dgvListEmployees.Columns[8].HeaderText = "Join Date";
                dgvListEmployees.Columns[8].Width = 100;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtAddress.Text) ||
               string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtBaseSalary.Text))
            {
                MessageBox.Show("Some Boxes is Empty", "Not Vailed", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            _Employee = new clsEmployee();

            _Employee.FullName = txtFullName.Text;
            _Employee.Address=txtAddress.Text;
            _Employee.Phone = txtPhone.Text;
            _Employee.Department = cbxDepartment.SelectedItem.ToString();
            _Employee.BaseSalary = Convert.ToDouble(txtBaseSalary.Text);
            _Employee.Gender = cbxGender.SelectedItem.ToString();
            _Employee.DateOfBirth = dtpDOB.Value;
            _Employee.JoinDate = dtpJoinDate.Value;

            if(_Employee.Save())
            {
                MessageBox.Show("Employee Successfully Added", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ctrlEmployees_Load(null, null);
            }
            else
            {
                MessageBox.Show("Adding Employee failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ctrlEmployees_Load(object sender, EventArgs e)
        {
            LoadEmployeesTodgv();
            cbxGender.SelectedIndex = 0;
            cbxDepartment.SelectedIndex = 0;
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtAddress.Text) ||
            string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtBaseSalary.Text))
            {
                MessageBox.Show("Some Boxes is Empty", "Not Vailed", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (_Employee==null)
            {
                MessageBox.Show("Select The Employee To Be Update", "Not Vailed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFullName.Text = "";
                txtAddress.Text = "";
                txtPhone.Text = "";
                txtBaseSalary.Text = "";
                return;
            }
            
            _Employee.FullName = txtFullName.Text;
            _Employee.Address = txtAddress.Text;
            _Employee.Phone = txtPhone.Text;
            _Employee.Department = cbxDepartment.SelectedItem.ToString();
            _Employee.BaseSalary = Convert.ToDouble(txtBaseSalary.Text);
            _Employee.Gender = cbxGender.SelectedItem.ToString();
            _Employee.DateOfBirth = dtpDOB.Value;
            _Employee.JoinDate = dtpJoinDate.Value;

            if(_Employee.Save())
            {
                MessageBox.Show("Employee Successfully Updated", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ctrlEmployees_Load(null, null);
            }
            else
                MessageBox.Show("The update process failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtAddress.Text) ||
              string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtBaseSalary.Text))
            {
                MessageBox.Show("Some Boxes is Empty", "Not Vailed", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (_Employee == null)
            {
                MessageBox.Show("Select The Employee To Be Delete", "Not Vailed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFullName.Text = "";
                txtAddress.Text = "";
                txtPhone.Text = "";
                txtBaseSalary.Text = "";
                return;
            }

            if(_Employee.DeleteEmployee())
            {
                MessageBox.Show("Employee Successfully Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ctrlEmployees_Load(null, null);
            }
            else
            {
                MessageBox.Show("Employee Deleted failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvListEmployees_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            int EmployeeID = (int)dgvListEmployees.CurrentRow.Cells[0].Value;

            _Employee = clsEmployee.Find(EmployeeID);   
            if(_Employee != null)
            {
                txtFullName.Text = _Employee.FullName;
                txtAddress.Text = _Employee.Address;
                txtPhone.Text = _Employee.Phone;
                txtBaseSalary.Text = _Employee.BaseSalary.ToString();
                cbxDepartment.SelectedIndex = cbxDepartment.FindString(_Employee.Department);
                cbxGender.SelectedIndex = cbxGender.FindString(_Employee.Gender);
                dtpJoinDate.Value = _Employee.JoinDate;
                dtpDOB.Value = _Employee.DateOfBirth;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
