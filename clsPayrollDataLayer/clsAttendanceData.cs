using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsPayrollDataLayer
{
    public class clsAttendanceData
    {

        public static int AddNewAttendance(int EmployeeID, string FullName,
            DateTime Date,byte Persent,byte Absent,byte Excused)
        {
            int AttendanceID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsServerConnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_AddNewAttendance", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        SqlParameter paraEmployeeID = new SqlParameter("@EmployeeID", SqlDbType.Int);
                        paraEmployeeID.Value = EmployeeID;
                        command.Parameters.Add(paraEmployeeID);


                        SqlParameter paraFullName = new SqlParameter("@FullName", SqlDbType.NVarChar);
                        paraFullName.Value = FullName;
                        command.Parameters.Add(paraFullName);

                       

                        SqlParameter paraDate = new SqlParameter("@Date", SqlDbType.DateTime);
                        paraDate.Value = Date;
                        command.Parameters.Add(paraDate);

                        SqlParameter paraPersent = new SqlParameter("@Persent", SqlDbType.TinyInt);
                        paraPersent.Value = Persent;
                        command.Parameters.Add(paraPersent);

                        SqlParameter paraAbsent = new SqlParameter("@Absent", SqlDbType.TinyInt);
                        paraAbsent.Value = Absent;
                        command.Parameters.Add(paraAbsent);

                        SqlParameter paraExcused = new SqlParameter("@Excused", SqlDbType.TinyInt);
                        paraExcused.Value = Excused;
                        command.Parameters.Add(paraExcused);

                        SqlParameter resultAttendanceID = new SqlParameter("@NewAttendanceID", SqlDbType.Int);
                        resultAttendanceID.Direction = ParameterDirection.Output;
                        command.Parameters.Add(resultAttendanceID);

                        command.ExecuteNonQuery();
                        AttendanceID = Convert.ToInt32(resultAttendanceID.Value);
                    }
                }

            }
            catch (Exception ex)
            {
                //Event Log here.....
            }
            return AttendanceID;
        }

        public static bool DeleteAttendance(int AttendanceID)
        {
            bool isDelete = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsServerConnection.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_DeleteAttendance", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter paraAttendanceID = new SqlParameter("@AttendanceID", SqlDbType.Int);
                        paraAttendanceID.Value = AttendanceID;
                        command.Parameters.Add(paraAttendanceID);

                        SqlParameter resultIsDelete = new SqlParameter("@IsDelete", SqlDbType.Int);
                        resultIsDelete.Direction = ParameterDirection.Output;
                        command.Parameters.Add(resultIsDelete);

                        command.ExecuteNonQuery();

                        isDelete = Convert.ToBoolean(resultIsDelete.Value);

                    }

                }

            }
            catch (Exception ex)
            {
                ///Event Log Here....

                isDelete = false;
            }
            return isDelete;
        }

        public static bool GetAttendanceInfoByID(int AttendanceID,ref int EmployeeID, ref string FullName
            , ref DateTime Date,ref byte Persent,ref byte Absent,ref byte Excused)
        {

            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsServerConnection.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_FindAttendance", connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter paraAttendanceID = new SqlParameter("@AttendanceID", SqlDbType.Int);
                        paraAttendanceID.Value= AttendanceID;
                        command.Parameters.Add(paraAttendanceID);

                        SqlParameter resultEmployeeID = new SqlParameter("@EmployeeID", SqlDbType.Int);
                        resultEmployeeID.Direction = ParameterDirection.Output;
                        command.Parameters.Add(resultEmployeeID);

                        SqlParameter resultName = new SqlParameter("@FullName", SqlDbType.NVarChar, 350);
                        resultName.Direction = ParameterDirection.Output;
                        command.Parameters.Add(resultName);

                        SqlParameter resultDate = new SqlParameter("@Date", SqlDbType.DateTime);
                        resultDate.Direction = ParameterDirection.Output;
                        command.Parameters.Add(resultDate);

                        SqlParameter resultPersent = new SqlParameter("@Persent", SqlDbType.TinyInt);
                        resultPersent.Direction = ParameterDirection.Output;
                        command.Parameters.Add(resultPersent);

                        SqlParameter resultAbsent = new SqlParameter("@Absent", SqlDbType.TinyInt);
                        resultAbsent.Direction = ParameterDirection.Output;
                        command.Parameters.Add(resultAbsent);

                        SqlParameter resultExcused = new SqlParameter("@Excused", SqlDbType.TinyInt);
                        resultExcused.Direction = ParameterDirection.Output;
                        command.Parameters.Add(resultExcused);

                        command.ExecuteNonQuery();
                        FullName = Convert.ToString(resultName.Value);
                        EmployeeID = Convert.ToInt32(resultEmployeeID.Value);  
                        Date = Convert.ToDateTime(resultDate.Value);
                        Persent = Convert.ToByte(resultPersent.Value);
                        Absent = Convert.ToByte(resultAbsent.Value);
                        Excused = Convert.ToByte(resultExcused.Value);
                        IsFound = true;
                    }

                }

            }
            catch (Exception ex)
            {
                //Event Log....Here
                IsFound = false;
            }
            return IsFound;
        }

        public static DataTable GetAllAttendances()
        {
            DataTable dt = new DataTable();

            try
            {

                using (SqlConnection connection = new SqlConnection(clsServerConnection.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_GetAllAttendances", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                //Event Log Here!......
            }
            return dt;
        }

        public static DataTable GetAllAttendancesForEmployeeID(int EmployeeID,DateTime Date)
        {
            DataTable dt = new DataTable();

            try
            {

                using (SqlConnection connection = new SqlConnection(clsServerConnection.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_GetAllAttendancesForEmployeeID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter paraEmployeeID = new SqlParameter("@EmployeeID", SqlDbType.Int);
                        paraEmployeeID.Value = EmployeeID;
                        command.Parameters.Add(paraEmployeeID);

                        SqlParameter paraDate = new SqlParameter("@Date", SqlDbType.DateTime);
                        paraDate.Value = Date;
                        command.Parameters.Add(paraDate);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                //Event Log Here!......
            }
            return dt;
        }
    }
}
