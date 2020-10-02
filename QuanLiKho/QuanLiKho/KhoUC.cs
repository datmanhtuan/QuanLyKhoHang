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
    public partial class KhoUC : UserControl
    {
        ThongKe da;
        
        public KhoUC()
        {
            InitializeComponent();
            da = new ThongKe();
        }

        private void KhoUC_Load(object sender, EventArgs e)
        {
            dgView.DataSource = da.GetAllSanPham();
            foreach(string item in da.GetAllMaHH())
            {
                comboBox1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgView.DataSource = da.TimKiemHH(comboBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgView.DataSource = da.TimKiemDate(NgayNhap.Value.ToString("yyyy-MM-dd"),dateTimePicker1.Value.ToString("yyyy-MM-dd"));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
