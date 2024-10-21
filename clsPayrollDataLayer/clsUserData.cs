using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsPayrollDataLayer
{
    public class clsUserData
    {
        public static bool CheckUsernameAndPassword(string username, string password)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsServerConnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_CheckUsernameAndPassword", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter usernamepara = new SqlParameter("@UserName", SqlDbType.NVarChar);
                        usernamepara.Value = username;
                        command.Parameters.Add(usernamepara);

                        SqlParameter passwordPara = new SqlParameter("@Password", SqlDbType.NVarChar);
                        passwordPara.Value = password;
                        command.Parameters.Add(passwordPara);


                        SqlParameter result = new SqlParameter("@IsFound", SqlDbType.Int);
                        result.Direction = ParameterDirection.Output;
                        command.Parameters.Add(result);


                        command.ExecuteNonQuery();
                        isFound = Convert.ToBoolean(result.Value);

                    }

                }
            }
            catch (Exception ex)
            {
                //Error Log
            }
            return (isFound);
        }
    }
}
