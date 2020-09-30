using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLiKho.Function
{
    public class ThongKe
    {
        DataTable dt;
        Dataconnection dc;
        SqlConnection con;
        public ThongKe()
        {
            dt = new DataTable();
            dc = new Dataconnection();
            con = dc.GetSqlConnection();
        }
        public DataTable GetAllSanPham()
        {
            con.Open();
            string sql = " SELECT pn.MaLoHang,lh.MaHH,lh.NSX,lh.HSD,SoLuong,(SELECT GiaSP FROM HangHoa hh WHERE hh.MaHH=lh.MaHH) as Gia FROM KhoHang pn,LoHang lh where pn.MaLoHang=lh.MaLoHang";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public List<string> GetAllMaHH()
        {
            List<string> ds = new List<string>(0);
            con.Open();
            string sql = "SELECT MaHH FROM HangHoa";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            foreach(DataRow dr in dt.Rows)
            {
                ds.Add(dr.ItemArray[0].ToString());
            }

            return ds;

        }
        public DataTable TimKiemHH(string MaHH)
        {
            con.Open();
            string sql = " SELECT pn.MaLoHang,lh.MaHH,lh.NSX,lh.HSD,SoLuong,(SELECT GiaSP FROM HangHoa hh WHERE hh.MaHH=lh.MaHH) as Gia FROM KhoHang pn,LoHang lh where pn.MaLoHang=lh.MaLoHang and MaHH = '"+MaHH+"'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable TimKiemDate(string TuNgay,string DenNgay)
        {
            con.Open();
            string sql = " SELECT pn.MaLoHang,lh.MaHH,lh.NSX,lh.HSD,SoLuong,(SELECT GiaSP FROM HangHoa hh WHERE hh.MaHH=lh.MaHH) as Gia FROM KhoHang pn,LoHang lh where pn.MaLoHang=lh.MaLoHang and HSD >= '" + TuNgay + "' and HSD <= '"+DenNgay+"'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
            
    }
}
