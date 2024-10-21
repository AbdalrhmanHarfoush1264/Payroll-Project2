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
    public partial class ctrlAttendances : UserControl
    {
        private clsAttendance _Attendance;
        private DataTable _dtAllAttendances;
        private int _AttendanceID = -1;

        DataTable dtAttendances = new DataTable();
        private Dictionary<string, string> idNameDictionary = new Dictionary<string, string>();
        public ctrlAttendances()
        {
            InitializeComponent();
        }

        private void ctrlAttendances_Load(object sender, EventArgs e)
        {
            LoadDataToComboBox();
            FilldgvWithAttendances();
        }

        private void FilldgvWithAttendances()
        {
            _dtAllAttendances = clsAttendance.GetAllAttendances();
            dgvAttendanceList.DataSource = _dtAllAttendances;

            if(dgvAttendanceList.Rows.Count > 0 )
            {
                dgvAttendanceList.Columns[0].HeaderText = "Attendance ID";
                dgvAttendanceList.Columns[0].Width = 100;

                dgvAttendanceList.Columns[1].HeaderText = "Employee ID";
                dgvAttendanceList.Columns[1].Width = 100;

                dgvAttendanceList.Columns[2].HeaderText = "Full Name";
                dgvAttendanceList.Columns[2].Width = 200;

                dgvAttendanceList.Columns[3].HeaderText = "Date";
                dgvAttendanceList.Columns[3].Width = 100;

                dgvAttendanceList.Columns[4].HeaderText = "Present";
                dgvAttendanceList.Columns[4].Width = 100;

                dgvAttendanceList.Columns[5].HeaderText = "Absent";
                dgvAttendanceList.Columns[5].Width = 100;

                dgvAttendanceList.Columns[6].HeaderText = "Excused";
                dgvAttendanceList.Columns[6].Width = 100;
            }
        }
        private void LinkIDToName()
        {
            idNameDictionary = new Dictionary<string, string>();
            dtAttendances = clsEmployee.GetAllEmployees();

            foreach(DataRow row in dtAttendances.Rows)
            {
                string EmployeeID = row["EmployeeID"].ToString();
                string FullName = row["FullName"].ToString();

                idNameDictionary.Add(EmployeeID, FullName);

            }

        }
        private void FillComboBoxWithEmployeesIDToComboBox()
        {
            foreach (string id in idNameDictionary.Keys)
            {
                cbxEmployeeID.Items.Add(id); // إضافة الـ ID إلى ComboBox
            }

            if (cbxEmployeeID.Items.Count > 0)
                cbxEmployeeID.SelectedIndex = 0;
        }
        private void LoadDataToComboBox()
        {
            LinkIDToName();
            FillComboBoxWithEmployeesIDToComboBox();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Attendance = new clsAttendance();

            _Attendance.EmployeeID = Convert.ToInt32(cbxEmployeeID.SelectedItem.ToString());
            _Attendance.FullName = txtName.Text;
            _Attendance.Date = dtpDate.Value;

            if (rdpPersent.Checked)
                _Attendance.IsPersntChecked = 1;
            else
                _Attendance.IsPersntChecked=0;

            if(rdpAbsent.Checked)
                _Attendance.IsAbsentChecked = 1;
            else
                _Attendance.IsAbsentChecked=0;

            if (rdpExcused.Checked)
                _Attendance.ISExcusedChecked = 1;
            else
                _Attendance.ISExcusedChecked = 0;

            if(_Attendance.AddNewAttendance())
            {
                MessageBox.Show("Attendance Add Successfully", "Saved", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                cbxEmployeeID.SelectedIndex = 0;
                rdpPersent.Checked = true;
                dtpDate.Value = DateTime.Now;
                ctrlAttendances_Load(null, null);
                return;
            }else
            {
                MessageBox.Show("Attendance Was not Added", "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return;
            }
        }

        private void cbxEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedId = cbxEmployeeID.SelectedItem.ToString();

            if(idNameDictionary.ContainsKey(selectedId))
            {
                string selectedName = idNameDictionary[selectedId];
                txtName.Text = selectedName;
            }
            else
            {
                txtName.Text = "";
            }
        }

        private void dgvAttendanceList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _AttendanceID = (int)dgvAttendanceList.CurrentRow.Cells[0].Value;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_AttendanceID != -1)
            {
                if (MessageBox.Show($"Are you want delete this ID= {_AttendanceID} ?", "Message",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (clsAttendance.DeleteAttendance(_AttendanceID))
                    {
                        MessageBox.Show("Delete was Successfully", "Delete", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ctrlAttendances_Load(null, null);
                        return;
                    }
                    else
                        MessageBox.Show("Delete was Failed", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Select Attendance ID to Delete!", "Not Vailed", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
    }
}
