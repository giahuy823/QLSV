using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using DAL;

namespace BLL
{
    public class CheckLogin
    {
        DataAccess dataAccess = new DataAccess();

        public string CheckUserType(string username, string password)
        {
            string userType = null;

            string query = @"
            SELECT TOP 1 UserType FROM (
            SELECT 'SINHVIEN' AS UserType
            FROM SINHVIEN 
            WHERE TENDN = @username 
            AND MATKHAU = HASHBYTES('SHA1', @password)
            
            UNION
            
            SELECT 'NHANVIEN' AS UserType
            FROM NHANVIEN 
            WHERE TENDN = @username 
            AND MATKHAU = HASHBYTES('SHA1', @password)
        ) AS Combined";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password)
            };

            object result = dataAccess.ExecuteScalar(query, parameters);

            if (result != null && result != DBNull.Value)
            {
                userType = result.ToString();
            }

            return userType; 
        }

    }
}
