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
    public partial class NhapHangUC : UserControl
    {
        NhapHangfn da;
        string MaLoHang1, MaHH1, NgayNhap1, NSX1, HSD1, SoLuong1, Gia1;
        public NhapHangUC()
        {
            InitializeComponent();
            da = new NhapHangfn();
        }
        

        

        private void button3_Click(object sender, EventArgs e)
        {
            if(da.XoaPhieuNhap(MaHH.Text, MaLoHang.Text, NgayNhap.Value.ToString("yyyy-MM-dd"), NSX.Value.ToString("yyyy-MM-dd"), HSD.Value.ToString("yyyy-MM-dd"), SoLuong.Text))
            {
                MessageBox.Show("Xoa Thanh công");
                MaHH.Text = "";
                MaLoHang.Text = "";
                SoLuong.Text = "";
                dgView.DataSource = displayALLPhieuNhap();
            }
            else
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void NhapHangUC_Load(object sender, EventArgs e)
        {
            dgView.DataSource=displayALLPhieuNhap();
        }

        private DataTable displayALLPhieuNhap()
        {
            return da.GetAllPhieuNhap();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (da.ThemPhieuNhap(MaHH.Text, MaLoHang.Text, NgayNhap.Value.ToString("yyyy-MM-dd"), NSX.Value.ToString("yyyy-MM-dd"), HSD.Value.ToString("yyyy-MM-dd"), SoLuong.Text))            
            {
                MessageBox.Show("Thêm thành công");
                MaHH.Text = "";
                MaLoHang.Text = "";
                SoLuong.Text = "";
                dgView.DataSource = displayALLPhieuNhap();
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void NgayNhap_ValueChanged(object sender, EventArgs e)
        {

        }

        

     

        private void button2_Click(object sender, EventArgs e)
        {
            if(da.SuaPhieuNhap(MaHH.Text, MaLoHang.Text, NgayNhap.Value.ToString("yyyy-MM-dd"), NSX.Value.ToString("yyyy-MM-dd"), HSD.Value.ToString("yyyy-MM-dd"), SoLuong.Text))
            {
                MessageBox.Show("Sua thành công");
                dgView.DataSource = da.GetAllPhieuNhap();
            }
            else
            {
                MessageBox.Show("Sua không thành công");
            }
        }
    }
}

