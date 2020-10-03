using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiKho.Function;

namespace QuanLiKho.User
{
    public partial class XuatHangUC : UserControl
    {
        XuatHangfn da;
        string MaLoHang1, MaHH1, NgayNhap1, NSX1, HSD1, SoLuong1, Gia1;

        private void button3_Click(object sender, EventArgs e)
        {
            if (da.XoaPhieuNhap( MaLoHang.Text, NgayNhap.Value.ToString("yyyy-MM-dd"), SoLuong.Text))
            {
                MessageBox.Show("Xoa Thanh công");
                MaLoHang.Text = "";
                SoLuong.Text = "";
                dgView.DataSource = da.GetAllPhieuXuat();
            }
            else
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            MaLoHang1 = dgView.Rows[e.RowIndex].Cells["ML"].Value.ToString();
            NgayNhap1 = dgView.Rows[e.RowIndex].Cells["NH"].Value.ToString();
            SoLuong1 = dgView.Rows[e.RowIndex].Cells["SL"].Value.ToString();
            SoLuong.Text = SoLuong1;
            MaLoHang.Text = MaLoHang1;
            try
            {
                NgayNhap.Value = DateTime.Parse(NgayNhap1);
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (da.SuaPhieuNhap( MaLoHang.Text, NgayNhap.Value.ToString("yyyy-MM-dd"),  SoLuong.Text))
            {
                MessageBox.Show("Sua thành công");
                dgView.DataSource = da.GetAllPhieuXuat();
            }
            else
            {
                MessageBox.Show("Sua không thành công");
            }
        }

        public XuatHangUC()
        {
            InitializeComponent();
            da = new XuatHangfn();
        }


    }
}
