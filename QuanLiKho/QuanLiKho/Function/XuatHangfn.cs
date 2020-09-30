using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLiKho.Function
{
    public class XuatHangfn
    {
        DataTable dt;
        Dataconnection dc;
        SqlConnection con;
        public XuatHangfn()
        {
            dt = new DataTable();
            dc = new Dataconnection();
            con = dc.GetSqlConnection();
        }
        public DataTable GetAllPhieuXuat()
        {
            con.Open();
            string sql = " SELECT pn.MaLoHang,lh.MaHH,lh.NSX,lh.HSD,NgayXuat,SoLuong,(SELECT GiaSP FROM HangHoa hh WHERE hh.MaHH=lh.MaHH) as Gia FROM PhieuXuat pn,LoHang lh where pn.MaLoHang=lh.MaLoHang";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public bool ThemPhieuXuat( string MaLoHang, string NgayNhap, string SoLuong)
        {
            con.Open();
            try
            {
                
                string sql2 = "insert into PhieuXuat(MaLoHang,NgayXuat,SoLuong)values('" + MaLoHang + "','" + NgayNhap + "'," + SoLuong + ")";
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                cmd2.ExecuteNonQuery();
                try
                {
                    string sql3 = "UPDATE KhoHang SET SoLuong =SoLuong - " + SoLuong + "where MaLoHang ='" + MaLoHang + "' ";
                    SqlCommand cmd3 = new SqlCommand(sql3, con);
                    cmd3.ExecuteNonQuery();
                }
                catch
                {
                    con.Close();
                    return false;
                }

            }
            catch
            {


                con.Close();
                return false;
            }


            con.Close();
            return true;
        }
        public bool SuaPhieuNhap(string MaLoHang, string NgayNhap, string SoLuong)
        {

            con.Open();
            try
            {
                string sql1 = "UPDATE  PhieuXuat SET SoLuong = " + SoLuong +  " where MaLoHang='" + MaLoHang + "'";
                SqlCommand cmd = new SqlCommand(sql1, con);
                cmd.ExecuteNonQuery();
                string sql2 = "Update KhoHang SET SoLuong = SoLuong +" + SoLuong + " Where MaLoHang = '" + MaLoHang + "'";
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                cmd2.ExecuteNonQuery();

            }
            catch
            {


                con.Close();
                return false;
            }


            con.Close();
            return true;
        }
        public bool XoaPhieuNhap( string MaLoHang, string NgayNhap,  string SoLuong)
        {

            con.Open();
            try
            {

                string sql2 = "DELETE PhieuXuat  Where MaLoHang = '" + MaLoHang + "' and NgayXuat = '" + NgayNhap + "'";
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                cmd2.ExecuteNonQuery();

            }
            catch
            {


                con.Close();
                return false;
            }


            con.Close();
            return true;
        }
    }
}
