using clsPayrollDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsPayrollBussinessLayer
{
    public class clsIssueSalary:clsEmployee
    {
        public clsEmployee Employee { get; set; }
        public int EmployeeID { get; set; }
        public int IssueSalaryID { get; set; }
        public DateTime Date { get; set; }
        public double Bouns {  get; set; }
        public double Discount { get; set; }
        public double TotalSalary { get; set; }
        public clsIssueSalary()
        {

        }

        public void FindEmployee(int EmployeeID)
        {
            Employee = Find(EmployeeID);
        }

        public bool AddNewIssueSalary()
        {
            this.IssueSalaryID = clsIssueSalaryData.AddNewIssueSalary(this.EmployeeID, this.FullName, this.BaseSalary,
                this.Date, this.Bouns, this.Discount, this.TotalSalary);

            return (this.IssueSalaryID != -1);
        }
        public DataTable GetAllAttendancesForEmployeeID()
        {
            return clsAttendance.GetAllAttendancesForEmployeeID(this.EmployeeID, this.Date);
        }

        public static bool DeleteIssueSalary(int IssueSalaryID)
        {
            return clsIssueSalaryData.DeleteIssueSalary(IssueSalaryID);
        }

        public static DataTable GetAllIssueSalaries()
        {
            return clsIssueSalaryData.GetAllIssueSalaries();
        }

    }
}
