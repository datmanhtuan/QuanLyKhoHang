using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLiKho.Function
{
    class NhapHangfn
    {
        Dataconnection dc;
        SqlConnection con;
        public NhapHangfn()
        {
            dc = new Dataconnection();
            con = dc.GetSqlConnection();
        }

        public DataTable GetAllPhieuNhap()
        {
            con.Open();
            string sql = " SELECT pn.MaLoHang,lh.MaHH,lh.NSX,lh.HSD,NgayNhap,SoLuong,(SELECT GiaSP FROM HangHoa hh WHERE hh.MaHH=lh.MaHH) as Gia FROM PhieuNhap pn,LoHang lh where pn.MaLoHang=lh.MaLoHang";
            SqlDataAdapter da = new SqlDataAdapter(sql,con) ;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public bool ThemPhieuNhap(string MaHH,string MaLoHang,string NgayNhap,string NSX,string HSD,string SoLuong)
        {
            con.Open();
            try
            {
                string sql1 = "insert into LoHang(MaLoHang,MaHH,NSX,HSD)values('" + MaLoHang + "','" + MaHH + "','" + NSX + "','" + HSD + "')";
                SqlCommand cmd = new SqlCommand(sql1, con);
                cmd.ExecuteNonQuery();
                try
                {
                    string sql2 = "insert into PhieuNhap(MaLoHang,NgayNhap,SoLuong)values('" + MaLoHang + "','" + NgayNhap + "'," + SoLuong  + ")";
                    SqlCommand cmd2 = new SqlCommand(sql2, con);
                    cmd2.ExecuteNonQuery();
                    string sql3 = "insert into KhoHang(MaLoHang,SoLuong)values('" + MaLoHang  + "'," + SoLuong + ")";
                    SqlCommand cmd3 = new SqlCommand(sql3, con);
                    cmd3.ExecuteNonQuery();
                }
                catch
                {
                    string sql3 = "delete LoHang where MaLoHang='" + MaLoHang + "'";
                    SqlCommand cmd3 = new SqlCommand(sql3, con);
                    cmd3.ExecuteNonQuery();
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
        public bool SuaPhieuNhap(string MaHH, string MaLoHang, string NgayNhap, string NSX, string HSD, string SoLuong)
        {

            con.Open();
            try
            {
                string sql1 = "UPDATE  LoHang SET MaHH = '" + MaHH + "',NSX='" + NSX + "',HSD='" + HSD + "' where MaLoHang='"+MaLoHang+"'";
                SqlCommand cmd = new SqlCommand(sql1, con);
                cmd.ExecuteNonQuery();
                string sql2 = "Update PhieuNhap SET SoLuong = " + SoLuong + " Where MaLoHang = '" + MaLoHang + "' and NgayNhap = '" + NgayNhap + "'";
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
        public bool XoaPhieuNhap(string MaHH, string MaLoHang, string NgayNhap, string NSX, string HSD, string SoLuong)
        {

            con.Open();
            try
            {
                
                string sql2 = "DELETE PhieuNhap  Where MaLoHang = '" + MaLoHang + "' and NgayNhap = '" + NgayNhap + "'";
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
