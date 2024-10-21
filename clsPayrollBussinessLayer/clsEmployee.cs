using clsPayrollDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsPayrollBussinessLayer
{
    public class clsEmployee
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int EmployeeID {  get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public double BaseSalary { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime JoinDate { get; set; }

        public clsEmployee()
        {
            this.EmployeeID = -1;
            this.FullName = "";
            this.Phone = "";
            this.Gender = "";
            this.Address = "";
            this.Department = "";
            this.BaseSalary = 0;
            this.DateOfBirth = DateTime.Now;
            this.JoinDate = DateTime.Now;

            Mode = enMode.AddNew;
        }
        public clsEmployee(int EmployeeID, string FullName, string Phone, string Gender, string Address, string Department,
            double BaseSalary, DateTime DateOfBirth, DateTime JoinDate)
        {
            this.EmployeeID = EmployeeID;
            this.FullName = FullName;
            this.Phone = Phone;
            this.Gender = Gender;
            this.Address = Address;
            this.Department = Department;
            this.BaseSalary = BaseSalary;
            this.DateOfBirth = DateOfBirth;
            this.JoinDate = JoinDate;

            Mode = enMode.Update;
        }

        public static DataTable GetAllEmployees()
        {
            return clsEmployeesData.GetAllEmployees();
        }

        private bool _AddNewEmployee()
        {
            this.EmployeeID = clsEmployeesData.AddNewEmployee(this.FullName, this.Phone,
                this.Gender, this.Address, this.Department, this.BaseSalary, this.DateOfBirth, this.JoinDate);

            return (this.EmployeeID != -1);
        }

        private bool _UpdateEmployee()
        {
            return clsEmployeesData.UpdateEmployee(this.EmployeeID, this.FullName, this.Phone,
                this.Gender, this.Address, this.Department, this.BaseSalary, this.DateOfBirth, this.JoinDate);
        }

        public bool DeleteEmployee()
        {
            return clsEmployeesData.DeleteEmployee(this.EmployeeID);
        }

        public static clsEmployee Find(int EmployeeID)
        {
            string FullName = "", Phone = "", Gender = "", Address = "", Department = "";
            double BaseSalary = 0;
            DateTime DateOfBirth = DateTime.Now, JoinDate = DateTime.Now;

            if (clsEmployeesData.GetEmployeeInfoByID(EmployeeID, ref FullName, ref Phone, ref Gender, ref Address,
                ref Department, ref BaseSalary, ref DateOfBirth, ref JoinDate))
            {
                return new clsEmployee(EmployeeID, FullName, Phone, Gender, Address, Department,
                    BaseSalary, DateOfBirth, JoinDate);
            }
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewEmployee())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case enMode.Update:
                    return _UpdateEmployee();
            }
            return false;
        }
    }
}
