using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class khachhangDAO
    {
        ketnoi kn = new ketnoi();
        SqlCommand cmd;
        SqlDataAdapter apt;
        public DataTable allkhachhang()
        {
            DataTable dt = new DataTable();
            string sql = "select * from khachhang";
            cmd = new SqlCommand(sql, kn.getketnoi());
            apt = new SqlDataAdapter(cmd);
            apt.Fill(dt);
            return dt;
        }
        public DataTable allsanpham()
        {
            DataTable dt = new DataTable();
            string sql = "select * from sanpham";
            cmd = new SqlCommand(sql, kn.getketnoi());
            apt = new SqlDataAdapter(cmd);
            apt.Fill(dt);
            return dt;
        }
        public int LayMakhachhang(string tenkhoa)
        {
            SqlConnection conn = kn.getketnoi();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = "SELECT id FROM khachhang WHERE cusname=@id";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = tenkhoa;
            int makhoa = int.Parse(cmd.ExecuteScalar().ToString());
            return makhoa;
        }

        public String Laydiachi(string tenkhoa)
        {
            SqlConnection conn = kn.getketnoi();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = "SELECT cusaddress FROM khachhang WHERE cusname=@id";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = tenkhoa;
            string makhoa = cmd.ExecuteScalar().ToString();
            return makhoa;
        }
        public int laychietkhau(string tenkhoa)
        {
            SqlConnection conn = kn.getketnoi();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = "SELECT chiekhau FROM khachhang WHERE cusname=@id";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = tenkhoa;
            try
            {
                int makhoa = int.Parse(cmd.ExecuteScalar().ToString());
                return makhoa;
            }catch(Exception ex)
            {

            }
            
            return 0;
             
        }
        public int laychietkhauSP(string tenkhoa)
        {
            SqlConnection conn = kn.getketnoi();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = "SELECT chietkhau FROM sanpham WHERE proName=@id";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = tenkhoa;
            try
            {
                int makhoa = int.Parse(cmd.ExecuteScalar().ToString());
                return makhoa;
            }
            catch (Exception ex)
            {

            }

            return 0;

        }
        public void Themkhachhang(khachhang khach)
        {
            SqlConnection conn = kn.getketnoi();
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

                string sql = "INSERT into khachhang values(@cusname,@cusaddress,@SDT ,@Email ,@chiekhau)";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@cusname", SqlDbType.NVarChar).Value = khach.cusname;
                cmd.Parameters.Add("@cusaddress", SqlDbType.NVarChar).Value = khach.cusaddress;
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = khach.SDT;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = khach.Email;
                cmd.Parameters.Add("@chiekhau", SqlDbType.Int).Value = khach.chiekhau;
                cmd.ExecuteNonQuery();
                conn.Close();
         }
        public void ThemSanpham(sanpham sp)
        {
            SqlConnection conn = kn.getketnoi();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string sql = "INSERT into sanpham values(@proname,@idkho,@chietkhau,@gia ,@soluong)";         
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@proname", SqlDbType.NVarChar).Value = sp.proName;
            cmd.Parameters.Add("@idkho", SqlDbType.Int).Value = sp.idkho;
            cmd.Parameters.Add("@chietkhau", SqlDbType.Int).Value = sp.chietkhau;
            cmd.Parameters.Add("@gia", SqlDbType.Float).Value = sp.gia;
            cmd.Parameters.Add("@soluong", SqlDbType.Int).Value = sp.soluong;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
    
}
