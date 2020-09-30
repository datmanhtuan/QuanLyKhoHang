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
        

        

       

        private void NhapHangUC_Load(object sender, EventArgs e)
        {
            dgView.DataSource=displayALLPhieuNhap();
        }

       
    }
}

