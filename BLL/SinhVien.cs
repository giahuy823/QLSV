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
    public class SinhVien
    {
        DataAccess dataAccess = new DataAccess();
        public string LayMaSV(string tendn)
        {
            string query = "SELECT MASV FROM SINHVIEN WHERE TENDN = @ten";
            SqlParameter[] parameters = { new SqlParameter("@ten", tendn) };

            object result = dataAccess.ExecuteScalar(query, parameters);
            return result != null ? result.ToString() : null;
        }
        public string LayMaLop(string ma)
        {
            string query = "SELECT MALOP FROM SINHVIEN WHERE MASV = @ten";
            SqlParameter[] parameters = { new SqlParameter("@ten", ma) };

            object result = dataAccess.ExecuteScalar(query, parameters);
            return result != null ? result.ToString() : null;
        }
        public DataTable LoadBangLop(string ma)
        {
            string query = "SELECT * FROM LOP WHERE MALOP = @ma";
            SqlParameter[] parameters = { new SqlParameter("@ma", ma) };
            return dataAccess.ExecuteQuery(query, parameters);
        }
        public DataTable LoadBangSV(string ma)
        {
            string query = "SELECT MASV,HOTEN,DIACHI,NGAYSINH FROM SINHVIEN WHERE MALOP = @ma";
            SqlParameter[] parameters = { new SqlParameter("@ma", ma) };
            return dataAccess.ExecuteQuery(query, parameters);
        }
        public void CapNhapSv(string ma,string hoten,string ngaysinh,string diachi)
        {
            string query = "UPDATE SINHVIEN SET HOTEN = @hoten, NGAYSINH = @ngaysinh, DIACHI = @diachi WHERE MASV = @ma";
            SqlParameter[] parameters = {
                new SqlParameter("@hoten", hoten),
                new SqlParameter("@ngaysinh", DateTime.Parse(ngaysinh)),
                new SqlParameter("@diachi", diachi),
                new SqlParameter("@ma", ma)
    };

            dataAccess.ExecuteNonQuery(query, parameters);
        }


    }
}
