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
        cls_QLCHCAFE c = new cls_QLCHCAFE();
        public string idUser { get; set; }
        public string roles { get; set; }
        bool isExit = true;

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

        void phanQuyen(string role) {
            if (role.ToUpper() == "NV") {
                mnu_NhanVien.Visible = false;
                mnu_ThongKe.Visible = false;
                mnu_LoaiHD.Visible = false;
                mnu_LoaiSP.Visible = false;
                mnu_Size.Visible = false;
                mnu_ChucVu.Visible = false;
                mnu_NCC.Visible = false;
            }
        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM NhanVien WHERE MaNV= '" + idUser + "'";
            
            DataSet data = c.LayDuLieu(query);

            if (data.Tables[0].Rows.Count == 1)
            {
                //set ma chuc vu de phan quyen
                roles = data.Tables[0].Rows[0]["roles"].ToString();
                phanQuyen(roles);
            }
            else
            {
                MessageBox.Show("Nhân viên chưa được phân công.");
            }
            
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

        private void mnu_HoaDon_Click(object sender, EventArgs e)
        {
            Form f = new frm_HoaDon(idUser);
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

        private void mnu_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                isExit = false;
                this.Close();
                DangNhap dangNhap = new DangNhap();

                dangNhap.Show();
            }
            
            
            
        }

        private void frm_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit) {
                Application.Exit();
            }
            
        }

        private void hoáĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frm_HoaDonNhap(idUser);
            xulyfrm(f);
        }
    }
}
