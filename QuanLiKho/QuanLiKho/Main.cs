using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiKho.User;

namespace QuanLiKho
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void btTeacher_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            pnMain.Controls.Add(new NhapHangUC());
        }

        private void btStudent_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            pnMain.Controls.Add(new XuatHangUC());
        }

        private void btClass_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            pnMain.Controls.Add(new KhoUC());
        }

        private void btHomeroomTeacher_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            pnMain.Controls.Add(new TimKiemUC());
        }

        private void btStudentInClass_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            //pnMain.Controls.Add(new StudentInClassUC());
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.ShowDialog();
            this.Close();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            pnMain.Controls.Add(new TrangChu());
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            pnMain.Controls.Add(new LoaiHangHoaUC());
        }
    }
}
