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
        Form frm;
        Boolean check = false;

        void xulyfrm(Form f) {
            if (check)
            {
                frm.Hide();
            }
            else
            {
                check = true;
            }
            frm = f;
            frm.MdiParent = this;
            frm.Show();
        }
        public frm_Menu()
        {
            InitializeComponent();
        }
        private void mnuLoaiHD_Click(object sender, EventArgs e)
        {
            Form f = new frm_LoaiHoaDon();
            xulyfrm(f);
        }

        private void mnu_LoaiSP_Click(object sender, EventArgs e)
        {
            Form f = new frm_LoaiSanPham();
            xulyfrm(f);
        }

        private void mnu_ChucVu_Click(object sender, EventArgs e)
        {
            Form f  = new frm_ChucVu();
            xulyfrm(f);
        }

        private void mnu_NCC_Click(object sender, EventArgs e)
        {
            Form f  = new frm_NCC();
            xulyfrm(f);
        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {

        }
        private void mnu_Size_Click(object sender, EventArgs e)
        {
            Form f  = new frm_Size();
            xulyfrm(f);

        }

        private void mnu_NhanVien_Click(object sender, EventArgs e)
        {
            Form f = new frm_NhanVien();
            xulyfrm(f);
        }
        private void mnu_SanPham_Click(object sender, EventArgs e)
        {
            Form f = new frm_SanPham();
            xulyfrm(f);
        }
        private void mnu_KhachHang_Click(object sender, EventArgs e)
        {
            Form f = new frm_KhachHang();
            xulyfrm(f);
        }

        private void mnu_HoaDon_Click(object sender, EventArgs e)
        {
            Form f = new frm_HoaDon();
            xulyfrm(f);
        }

        private void mnu_SearchKH_Click(object sender, EventArgs e)
        {
            Form f = new frm_SearchKH();
            xulyfrm(f);
        }

        private void mnu_SearchSP_Click(object sender, EventArgs e)
        {
            Form f = new frm_SearchSP();
            xulyfrm(f);
        }

        private void mnu_SearchHD_Click(object sender, EventArgs e)
        {
            Form f = new frm_SearchHD();
            xulyfrm(f);
        }

        private void mnu_ThongKeNgay_Click(object sender, EventArgs e)
        {
            Form f = new frm_ThongKeNgay();
            xulyfrm(f);
        }

        private void mnu_ThongKeThang_Click(object sender, EventArgs e)
        {
            Form f = new frm_ThongKeThang();
            xulyfrm(f);
        }

        private void mnu_ThongKeNam_Click(object sender, EventArgs e)
        {
            Form f = new frm_ThongKeNam();
            xulyfrm(f);
        }

        private void mnu_ThongKeNV_Click(object sender, EventArgs e)
        {
            Form f = new frm_ThongKeNV();
            xulyfrm(f);
        }

        private void mnu_DangNhap_Click(object sender, EventArgs e)
        {
            Form f = new DangNhap();
            xulyfrm((DangNhap)f);
        }
    }
}
