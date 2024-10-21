using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace clsPayrollDataLayer
{
    public class clsEmployeesData
    {
        public static int AddNewEmployee(string FullName, string Phone,string Gender ,string Address, string Department,
            double BaseSalary,DateTime DateOfBirth,DateTime JoinDate)
        {
            int CustomerID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsServerConnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_AddNewEmployee", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        SqlParameter paraName = new SqlParameter("@FullName", SqlDbType.NVarChar);
                        paraName.Value = FullName;
                        command.Parameters.Add(paraName);


                        SqlParameter paraPhone = new SqlParameter("@Phone", SqlDbType.NVarChar);
                        paraPhone.Value = Phone;
                        command.Parameters.Add(paraPhone);

                        SqlParameter paraGender = new SqlParameter("@Gender", SqlDbType.NVarChar);
                        paraGender.Value = Gender;
                        command.Parameters.Add(paraGender);

                        SqlParameter paraAddress = new SqlParameter("@Address", SqlDbType.NVarChar);
                        paraAddress.Value = Address;
                        command.Parameters.Add(paraAddress);

                        SqlParameter paraDepartment = new SqlParameter("@Department", SqlDbType.NVarChar);
                        paraDepartment.Value = Department;
                        command.Parameters.Add(paraDepartment);

                        SqlParameter paraBaseSalary = new SqlParameter("@BaseSalary", SqlDbType.Money);
                        paraBaseSalary.Value = BaseSalary;
                        command.Parameters.Add(paraBaseSalary);

                        SqlParameter paraDateOfBirth = new SqlParameter("@DateOfBirth", SqlDbType.DateTime);
                        paraDateOfBirth.Value = DateOfBirth;
                        command.Parameters.Add(paraDateOfBirth);

                        SqlParameter paraJoinDate = new SqlParameter("@JoinDate", SqlDbType.DateTime);
                        paraJoinDate.Value = JoinDate;
                        command.Parameters.Add(paraJoinDate);

                        SqlParameter resultID = new SqlParameter("@NewEmployeeID", SqlDbType.Int);
                        resultID.Direction = ParameterDirection.Output;
                        command.Parameters.Add(resultID);

                        command.ExecuteNonQuery();
                        CustomerID = Convert.ToInt32(resultID.Value);
                    }
                }

            }
            catch (Exception ex)
            {
                //Event Log here.....
            }
            return CustomerID;
        }
        public static bool UpdateEmployee(int EmployeeID,string FullName, string Phone, string Gender, string Address, string Department,
            double BaseSalary, DateTime DateOfBirth, DateTime JoinDate)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsServerConnection.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_UpdateEmployee", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter paraEmployeeID = new SqlParameter("@EmployeeID", SqlDbType.Int);
                        paraEmployeeID.Value = EmployeeID;
                        command.Parameters.Add(paraEmployeeID);

                        SqlParameter paraName = new SqlParameter("@FullName", SqlDbType.NVarChar);
                        paraName.Value = FullName;
                        command.Parameters.Add(paraName);


                        SqlParameter paraPhone = new SqlParameter("@Phone", SqlDbType.NVarChar);
                        paraPhone.Value = Phone;
                        command.Parameters.Add(paraPhone);

                        SqlParameter paraGender = new SqlParameter("@Gender", SqlDbType.NVarChar);
                        paraGender.Value = Gender;
                        command.Parameters.Add(paraGender);

                        SqlParameter paraAddress = new SqlParameter("@Address", SqlDbType.NVarChar);
                        paraAddress.Value = Address;
                        command.Parameters.Add(paraAddress);

                        SqlParameter paraDepartment = new SqlParameter("@Department", SqlDbType.NVarChar);
                        paraDepartment.Value = Department;
                        command.Parameters.Add(paraDepartment);

                        SqlParameter paraBaseSalary = new SqlParameter("@BaseSalary", SqlDbType.Money);
                        paraBaseSalary.Value = BaseSalary;
                        command.Parameters.Add(paraBaseSalary);

                        SqlParameter paraDateOfBirth = new SqlParameter("@DateOfBirth", SqlDbType.DateTime);
                        paraDateOfBirth.Value = DateOfBirth;
                        command.Parameters.Add(paraDateOfBirth);

                        SqlParameter paraJoinDate = new SqlParameter("@JoinDate", SqlDbType.DateTime);
                        paraJoinDate.Value = JoinDate;
                        command.Parameters.Add(paraJoinDate);


                        command.ExecuteNonQuery();
                        IsFound = true;
                    }
                }
            }
            catch (Exception ex)
            {
                //Event Log....
                IsFound = false;
            }
            return IsFound;
        }
        public static bool DeleteEmployee(int EmployeeID)
        {
            bool isDelete = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsServerConnection.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_DeleteEmployee", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter paraID = new SqlParameter("@EmployeeID", SqlDbType.Int);
                        paraID.Value = EmployeeID;
                        command.Parameters.Add(paraID);

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
        public static DataTable GetAllEmployees()
        {
            DataTable dt = new DataTable();

            try
            {

                using (SqlConnection connection = new SqlConnection(clsServerConnection.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_GetAllEmployees", connection))
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

        public static bool GetEmployeeInfoByID(int EmployeeID,ref string FullName,ref string Phone,ref string Gender,ref string Address,ref string Department,
          ref double BaseSalary,ref DateTime DateOfBirth,ref DateTime JoinDate)
        {

            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsServerConnection.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_FindEmployee", connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;


                        SqlParameter paraEmployeeID = new SqlParameter("@EmployeeID", SqlDbType.Int);
                        paraEmployeeID.Value = EmployeeID;
                        command.Parameters.Add(paraEmployeeID);

                        SqlParameter resultName = new SqlParameter("@FullName", SqlDbType.NVarChar, 350);
                        resultName.Direction = ParameterDirection.Output;
                        command.Parameters.Add(resultName);

                        SqlParameter resultAddress = new SqlParameter("@Address", SqlDbType.NVarChar, 350);
                        resultAddress.Direction = ParameterDirection.Output;
                        command.Parameters.Add(resultAddress);

                        SqlParameter resultPhone = new SqlParameter("@Phone", SqlDbType.NVarChar, 20);
                        resultPhone.Direction = ParameterDirection.Output;
                        command.Parameters.Add(resultPhone);

                        SqlParameter resultGender = new SqlParameter("@Gender", SqlDbType.NVarChar,30);
                        resultGender.Direction = ParameterDirection.Output;
                        command.Parameters.Add(resultGender);

                        SqlParameter resultDepartment = new SqlParameter("@Department", SqlDbType.NVarChar, 30);
                        resultDepartment.Direction = ParameterDirection.Output;
                        command.Parameters.Add(resultDepartment);

                        SqlParameter resultBaseSalary = new SqlParameter("@BaseSalary", SqlDbType.Money);
                        resultBaseSalary.Direction = ParameterDirection.Output;
                        command.Parameters.Add(resultBaseSalary);

                        SqlParameter resultDateOfBirth = new SqlParameter("@DateOfBirth", SqlDbType.DateTime);
                        resultDateOfBirth.Direction = ParameterDirection.Output;
                        command.Parameters.Add(resultDateOfBirth);

                        SqlParameter resultJoinDate = new SqlParameter("@JoinDate", SqlDbType.DateTime);
                        resultJoinDate.Direction = ParameterDirection.Output;
                        command.Parameters.Add(resultJoinDate);

                        


                        command.ExecuteNonQuery();
                        FullName = Convert.ToString(resultName.Value);
                        Address = Convert.ToString(resultAddress.Value);
                        Phone = Convert.ToString(resultPhone.Value);
                        Gender = Convert.ToString(resultGender.Value);
                        Department = Convert.ToString(resultDepartment.Value);
                        BaseSalary = Convert.ToDouble(resultBaseSalary.Value);
                        DateOfBirth = Convert.ToDateTime(resultDateOfBirth.Value);
                        JoinDate = Convert.ToDateTime(resultJoinDate.Value);
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
    }
}
