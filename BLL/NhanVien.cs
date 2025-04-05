using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using DAL;
using System.Data;

namespace BLL
{
    public class NhanVien
    {
        DataAccess dataAccess = new DataAccess();
        public string LayMaNV(string username)
        {
            string query = "SELECT MANV FROM NHANVIEN WHERE TENDN = @username";
            SqlParameter[] parameters = {
                new SqlParameter("@username", username)
            };
            var result = dataAccess.ExecuteScalar(query, parameters);
            return result?.ToString();
        }
        public DataTable LoadBangLop(string ma)
        {
            string query = "SELECT * FROM LOP WHERE MANV = @ma";
            SqlParameter[] parameters = { new SqlParameter("@ma",ma ) };
            return dataAccess.ExecuteQuery(query,parameters);
        }
        public List<string> LayDanhSachLop(string manv)
        {
            string query = "SELECT MALOP FROM LOP WHERE MANV = @manv";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@manv", manv)
            };

            DataTable dataTable = dataAccess.ExecuteQuery(query, parameters);
            List<string> danhSachMaLop = new List<string>();

            foreach (DataRow row in dataTable.Rows)
            {
                danhSachMaLop.Add(row["MALOP"].ToString());
            }

            return danhSachMaLop;
        }

    }
}
