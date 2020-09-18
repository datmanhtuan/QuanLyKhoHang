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
    public partial class TimKiemUC : UserControl
    {
        TimKiem da;
        bool kt = true;
        public TimKiemUC()
        {
            InitializeComponent();
            da = new TimKiem();
        }

        private void TimKiemUC_Load(object sender, EventArgs e)
        {
            dgView.DataSource = da.GetAllPhieuNhap();
            foreach (string item in da.GetAllMaHH())
            {
                comboBox1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
               dgView.DataSource = da.GetAllPhieuNhap();
               foreach (string item in da.GetAllMaHH())
               {
                    comboBox1.Items.Add(item);
               }
          }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
