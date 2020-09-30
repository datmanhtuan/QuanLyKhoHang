using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLiKho.Function
{
    public class LoaiHangHoa
    {
        Dataconnection dc;
        SqlConnection con;
        public LoaiHangHoa()
        {
            dc = new Dataconnection();
            con = dc.GetSqlConnection();
        }

        public DataTable GetAllHH()
        {
            con.Open();
            string sql = " SELECT * FROM HangHoa";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public bool ThemHangHoa(string MaHH,string TenHH, string Gia)
        {
            con.Open();
            try
            {
                string sql1 = "insert into HangHoa(MaHH,TenHH,GiaSP)values('" + MaHH + "',N'" + TenHH + "'," + Gia + ")";
                SqlCommand cmd = new SqlCommand(sql1, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {


                con.Close();
                return false;
            }


            con.Close();
            return true;
        }
        public bool SuaHangHoa(string MaHH, string TenHH, string Gia)
        {

            con.Open();
            try
            {
                string sql1 = "UPDATE  HangHoa SET TenHH = N'" + TenHH + "',GiaSP=" + Gia +  " where MaHH='" + MaHH + "'";
                SqlCommand cmd = new SqlCommand(sql1, con);
                cmd.ExecuteNonQuery();
                

            }
            catch
            {


                con.Close();
                return false;
            }


            con.Close();
            return true;
        }
        public bool XoaPhieuNhap(string MaHH)
        {

            con.Open();
            try
            {

                string sql2 = "DELETE HangHoa  Where MaHH = '" + MaHH + "'";
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
