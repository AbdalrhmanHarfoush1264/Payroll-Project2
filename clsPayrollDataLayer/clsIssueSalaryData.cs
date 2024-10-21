using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace clsPayrollDataLayer
{
    public class clsIssueSalaryData
    {


        public static int AddNewIssueSalary(int EmployeeID,string FullName,double BaseSalary,
            DateTime Date,double Bouns,double Discount,double TotalSalary)
        {

            int IssueSalaryID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsServerConnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_AddNewIssueSalary", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;


                        SqlParameter paraEmployeeID = new SqlParameter("@EmployeeID", SqlDbType.Int);
                        paraEmployeeID.Value = EmployeeID;
                        command.Parameters.Add(paraEmployeeID);

                        SqlParameter paraName = new SqlParameter("@FullName", SqlDbType.NVarChar);
                        paraName.Value = FullName;
                        command.Parameters.Add(paraName);


                        SqlParameter paraBaseSalary = new SqlParameter("@BaseSalary", SqlDbType.Money);
                        paraBaseSalary.Value = BaseSalary;
                        command.Parameters.Add(paraBaseSalary);

                        SqlParameter paraDate = new SqlParameter("@Date", SqlDbType.DateTime);
                        paraDate.Value = Date;
                        command.Parameters.Add(paraDate);

                        SqlParameter paraTotalSalary = new SqlParameter("@TotalSalary", SqlDbType.Money);
                        paraTotalSalary.Value = TotalSalary;
                        command.Parameters.Add(paraTotalSalary);

                        SqlParameter paraBouns = new SqlParameter("@Bouns", SqlDbType.Money);
                        paraBouns.Value = Bouns;
                        command.Parameters.Add(paraBouns);

                        SqlParameter paraDiscount = new SqlParameter("@Discount", SqlDbType.Money);
                        paraDiscount.Value = Discount;
                        command.Parameters.Add(paraDiscount);
                                
                        SqlParameter resultID = new SqlParameter("@NewIssueSalaryID", SqlDbType.Int);
                        resultID.Direction = ParameterDirection.Output;
                        command.Parameters.Add(resultID);

                        command.ExecuteNonQuery();
                        IssueSalaryID = Convert.ToInt32(resultID.Value);
                    }
                }

            }
            catch (Exception ex)
            {
                //Event Log here.....
            }
            return IssueSalaryID;

        }


        public static bool DeleteIssueSalary(int IssueSalaryID)
        {
            bool isDelete = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsServerConnection.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_DeleteIssueSalary", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter paraIssueSalaryID = new SqlParameter("@IssueSalaryID", SqlDbType.Int);
                        paraIssueSalaryID.Value = IssueSalaryID;
                        command.Parameters.Add(paraIssueSalaryID);

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

        public static DataTable GetAllIssueSalaries()
        {
            DataTable dt = new DataTable();

            try
            {

                using (SqlConnection connection = new SqlConnection(clsServerConnection.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_GetAllIssueSalaries", connection))
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
    }
}
