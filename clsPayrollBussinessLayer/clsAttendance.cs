using clsPayrollDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsPayrollBussinessLayer
{
    public class clsAttendance
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int AttendanceID { get; set; }
        public int EmployeeID { get; set; }
        public string FullName { get; set; }    
        public DateTime Date {  get; set; }
        public byte IsPersntChecked { get; set; }
        public byte IsAbsentChecked { get; set; }
        public byte ISExcusedChecked {  get; set; }

        public clsAttendance()
        {
            this.AttendanceID = -1;
            this.EmployeeID = -1;
            this.FullName = "";
            this.Date = DateTime.Now;
            this.IsPersntChecked = 0;
            this.IsAbsentChecked = 0;
            this.ISExcusedChecked = 0;

            Mode = enMode.AddNew;
        }

        public clsAttendance(int AttendanceID,int EmployeeID,string FullName,
           DateTime Date,byte IsPersntCheck,byte IsAbsentCheck,byte IsExcusedCheck)
        {
            this.AttendanceID = AttendanceID;
            this.EmployeeID = EmployeeID;
            this.FullName = FullName;
            this.Date = Date;
            this.IsPersntChecked=IsPersntCheck;
            this.IsAbsentChecked=IsAbsentCheck;
            this.ISExcusedChecked=IsExcusedCheck;

            Mode = enMode.Update;
        }

        public bool AddNewAttendance()
        {
            this.AttendanceID = clsAttendanceData.AddNewAttendance(this.EmployeeID,this.FullName,
                this.Date,this.IsPersntChecked,this.IsAbsentChecked,this.ISExcusedChecked);

            return (this.AttendanceID != -1);
        }

        public static bool DeleteAttendance(int AttendanceID)
        {
            return clsAttendanceData.DeleteAttendance(AttendanceID);
        }

        public static DataTable GetAllAttendances()
        {
            return clsAttendanceData.GetAllAttendances();
        }

        public static DataTable GetAllAttendancesForEmployeeID(int EmployeeID,DateTime Date)
        {
            return clsAttendanceData.GetAllAttendancesForEmployeeID(EmployeeID, Date);
        }
    }
}
