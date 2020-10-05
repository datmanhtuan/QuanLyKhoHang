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
        public void SetNull()
        {
            txtTK.Text = "";
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtNSX.Text = "";
            txtMoTa.Text = "";
            pictureBox1.Image = null;
        }
        public void HienThi()
        {
            dataGridView1.DataSource = sp.ShowSanPham("");
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
            Init();
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
