using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _108_144_QLCuaHangCafe
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }
        private void mnuLoaiHD_Click(object sender, EventArgs e)
        {
            frm_LoaiHoaDon f = new frm_LoaiHoaDon();
            f.MdiParent = this;
            f.Show();
        }

        private void mnu_LoaiSP_Click(object sender, EventArgs e)
        {
            frm_LoaiSanPham f = new frm_LoaiSanPham();
            f.MdiParent = this;
            f.Show();
        }

        private void mnu_ChucVu_Click(object sender, EventArgs e)
        {
            frm_ChucVu f = new frm_ChucVu();
            f.MdiParent = this;
            f.Show();
        }

        private void mnu_NCC_Click(object sender, EventArgs e)
        {
            frm_NCC f = new frm_NCC();
            f.MdiParent = this;
            f.Show();
        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {

        }
        private void mnu_Size_Click(object sender, EventArgs e)
        {
            frm_Size f = new frm_Size();
            f.MdiParent = this;
            f.Show();
        }
    }
}
