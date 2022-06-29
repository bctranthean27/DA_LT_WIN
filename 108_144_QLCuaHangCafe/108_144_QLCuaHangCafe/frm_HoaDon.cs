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
    public partial class frm_HoaDon : Form
    {
        cls_QLCHCAFE c = new cls_QLCHCAFE();
        int vt = 0;
        DataSet ds = new DataSet();
        int flag = 0;
        string Old_Value = "";
        public string roles;
        public frm_HoaDon()
        {
            InitializeComponent();
        }
        public frm_HoaDon(string roles)
        {
            this.roles = roles;
            InitializeComponent();
        }

        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            XuLiTextBox_hd(false);
            XuLiButton_ct(false, false, false, false);
            XuLiTextBox_ct(false);
            //loadData_DataGrid(dgv_DanhSach, "select * from HoaDon where TrangThai='1'");
            loadData_cbo(cbo_LoaiHD, "select MaLoaiHD,TenLoaiHD from LoaiHoaDon where TrangThai='1'", "MaLoaiHD", "TenLoaiHD");
            loadData_cbo(cbo_NhanVien, "select MaNV,TenNV from NhanVien where TrangThai='1'", "MaNV", "TenNV");
            loadData_cbo(cbo_SanPham, "select MaSP,TenSP from SanPham where TrangThai='1'", "MaSP", "TenSP");
            loadData_cbo(cbo_Size, "select MaSize,TenSize from Size where TrangThai='1'", "MaSize", "TenSize");
        }
        int SoLuongTon(string maSP, string maSize)
        {
            string maCTSP = maSP + maSize;
            DataSet dk = c.LayDuLieu("select * from ChiTietSanPham where MaCTSP = '" + maCTSP + "' ");
            return Convert.ToInt32(dk.Tables[0].Rows[0]["SoLuong"]);
        }
        void loadData_cbo(ComboBox cbo, string sql, string valMember, string disMember)
        {
            ds = c.LayDuLieu(sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cbo.DataSource = ds.Tables[0];
                cbo.ValueMember = valMember;
                cbo.DisplayMember = disMember;
            }
        }
        void XuLiButton_ct(bool key_them, bool key_xoa, bool key_sua, bool key_sp)
        {
            btn_ThemCT.Enabled = key_them;
            btn_LuuCT.Enabled = !key_them;
            btn_XoaCT.Enabled = key_xoa;
            btn_SuaCT.Enabled = key_sua;
            btn_tangSL.Enabled = btn_giamSL.Enabled = key_sp;
            btn_GiamKM.Enabled = btn_themKM.Enabled = key_sp;
        }
        void XuLiTextBox_hd(bool key)
        {
            cbo_LoaiHD.Enabled = key;
            cbo_NhanVien.Enabled = key;
            txt_tenKH.ReadOnly = !key;
        }
        void XuLiTextBox_ct(bool key)
        {
            cbo_SanPham.Enabled = key;
            cbo_Size.Enabled = key;
        }
        string autoCode(string pri)
        {
            DataSet ds = c.LayDuLieu("select * from HoaDon");
            string code = pri;
            int pos = ds.Tables[0].Rows.Count + 1;
            if (pos < 10) code += "0" + pos.ToString();
            else if (pos < 100) code += "" + pos.ToString();
            return code;
        }

        string NgayHienTai()
        {
            string ngay = DateTime.Now.Day.ToString();
            string thang = DateTime.Now.Month.ToString();
            string nam = DateTime.Now.Year.ToString();
            string NgayDayDu = ngay + "/" + thang + "/" + nam;
            return NgayDayDu;
        }


        void loadData_cboFromList(DataTable dt, ComboBox cbo, string disMember, int vt)
        {

            string value = dt.Rows[vt][disMember].ToString();
            if (disMember == "TrangThai")
            {
                for (int i = 0; i < cbo.Items.Count; i++)
                {
                    if (cbo.Items[i].ToString() == value) cbo.SelectedIndex = i;
                }
            }
            else
            {
                foreach (DataRowView rowView in cbo.Items)
                {
                    string val = rowView.Row[0].ToString();
                    string name = rowView.Row[1].ToString();
                    if (val == value)
                    {
                        cbo.Text = name;
                        break;
                    }

                }
            }
        }
        void hienThiTextBox(DataTable dt, int vt)
        {

            if (dgv_DanhSach.CurrentRow != null)
            {
                DataGridViewRow row = dgv_DanhSach.CurrentRow;
                if (row.Cells["MaHD"].Value == DBNull.Value)
                {
                    txt_MaHD.Text = "";
                    btn_Reset.Enabled = false;
                }
                else
                {
                    txt_MaHD.Text = ds.Tables[0].Rows[vt]["MaHD"].ToString();
                    loadData_cboFromList(dt, cbo_LoaiHD, "MaLoaiHD", vt);
                    loadData_cboFromList(dt, cbo_NhanVien, "MaNV", vt);
                }
            }

        }
        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        void clearTextbox()
        {
            txt_MaHD.Text = "";
            cbo_LoaiHD.SelectedIndex = 0;
            cbo_NhanVien.SelectedIndex = 0;

        }
        private void btn_ThemHD_Click(object sender, EventArgs e)
        {
            clearTextbox();
            btn_ThemHD.Enabled = false;
            txt_MaHD.Text = autoCode("P");
            AddRowHoaDon();
            btn_Reset.Enabled = true;
            btn_ThemCT.Enabled = true;
            XuLiTextBox_hd(true);
        }


        private void btn_XuatHD_Click(object sender, EventArgs e)
        {
            if (dgv_CTHD.Rows.Count == 0)
                MessageBox.Show("Vui lòng không xuất hoá đơn trống", "Lưu ý", MessageBoxButtons.OK);
            else
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
                frm_HoaDon_Load(sender, e);
            }
        }
        void AddRowHoaDon(string tenKH = "Unknown")
        {
            string maHD = autoCode("P");
            string loaiHD = cbo_LoaiHD.SelectedValue.ToString();
            string maNV = cbo_NhanVien.SelectedValue.ToString();
            string tongtien = "0";
            string trangthai = "1";
            dgv_DanhSach.Rows.Add(maHD, NgayHienTai(), loaiHD, maNV, tenKH, tongtien, trangthai);
            XuLiButton_ct(true, false, false, false);
        }
        private void cbo_NhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (dgv_DanhSach != null)
                row = dgv_DanhSach.CurrentRow;
            if (row != null)
                row.Cells["MaNV"].Value = cbo_NhanVien.SelectedValue.ToString();
        }
        private void txt_tenKH_TextChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (dgv_DanhSach != null)
                row = dgv_DanhSach.CurrentRow;
            if (row != null)
            {
                row.Cells["TenKhachHang"].Value = txt_tenKH.Text;
                if (txt_tenKH.Text == "")
                    row.Cells["TenKhachHang"].Value = "Unknown";
            }
        }

        private void btn_ThemCT_Click(object sender, EventArgs e)
        {
            XuLiButton_ct(false, false, false, true);
            XuLiTextBox_ct(true);
            ResetTextBox_CT();
            dgv_CTHD.Enabled = false;
        }

        private void btn_SuaCT_Click(object sender, EventArgs e)
        {

        }

        private void btn_XoaCT_Click(object sender, EventArgs e)
        {

        }
        string getDonGia(string masp, string masize)
        {
            string dongia = "0";
            if (masp != "" && masize != "")
            {
                string mactsp = masp + masize;
                DataSet data = c.LayDuLieu("select * from ChiTietSanPham where MaCTSP = '" + mactsp + "' ");

                dongia = data.Tables[0].Rows[0]["GiaBan"].ToString();
            }
            return dongia;
        }
        void AddRowCTHoaDon(object sender, EventArgs e)
        {;
            string soluong = txt_SoLuong.Text;
            string khuyenmai = txt_KhuyenMai.Text;
            string maSize = cbo_Size.SelectedValue.ToString();
            string maSP = cbo_SanPham.SelectedValue.ToString();
            string dongia = getDonGia(maSP, maSize);
            string maCTHD = txt_MaHD.Text + maSP + maSize;
            capNhatGia(cbo_SanPham.SelectedValue.ToString(), cbo_Size.SelectedValue.ToString(), int.Parse(txt_SoLuong.Text), int.Parse(txt_KhuyenMai.Text));
            string giagoc = txt_GiaGoc.Text;
            string thanhtien = txt_ThanhTien.Text;
            dgv_CTHD.Rows.Add(maCTHD, maSP, maSize, soluong, dongia.ToString(), giagoc, khuyenmai, thanhtien);
        }
        void ResetTextBox_CT()
        {
            cbo_SanPham.SelectedIndex = 0;
            cbo_Size.SelectedIndex = 0;
            txt_SoLuong.Text = "1";
            txt_KhuyenMai.Text = "0";
            string masp = cbo_SanPham.SelectedValue.ToString();
            string masize = cbo_Size.SelectedValue.ToString();
            txt_ThanhTien.Text = txt_GiaGoc.Text = getDonGia(masp, masize).ToString();
        }

        private void btn_tangSL_Click(object sender, EventArgs e)
        {
            int SoLuong = Convert.ToInt32(txt_SoLuong.Text);
            txt_SoLuong.Text = (++SoLuong).ToString();
            if (SoLuong == 10) txt_SoLuong.Text = "10";
            capNhatGia(cbo_SanPham.SelectedValue.ToString(), cbo_Size.SelectedValue.ToString(), int.Parse(txt_SoLuong.Text), int.Parse(txt_KhuyenMai.Text));
        }
        private void btn_giamSL_Click(object sender, EventArgs e)
        {
            int SoLuong = Convert.ToInt32(txt_SoLuong.Text);
            if (SoLuong > 0)
                txt_SoLuong.Text = (--SoLuong).ToString();
            if (SoLuong == 1) txt_SoLuong.Text = "1";
            capNhatGia(cbo_SanPham.SelectedValue.ToString(), cbo_Size.SelectedValue.ToString(), int.Parse(txt_SoLuong.Text), int.Parse(txt_KhuyenMai.Text));
        }

        private void btn_themKM_Click(object sender, EventArgs e)
        {
            int KM = Convert.ToInt32(txt_KhuyenMai.Text);
            txt_KhuyenMai.Text = (KM += 5).ToString();
            capNhatGia(cbo_SanPham.SelectedValue.ToString(), cbo_Size.SelectedValue.ToString(), int.Parse(txt_SoLuong.Text), int.Parse(txt_KhuyenMai.Text));
        }

        private void btn_GiamKM_Click(object sender, EventArgs e)
        {
            int KM = Convert.ToInt32(txt_KhuyenMai.Text);
            if (KM > 0)
                txt_KhuyenMai.Text = (KM -= 5).ToString();
            if (KM == 0) txt_KhuyenMai.Text = "0";
            capNhatGia(cbo_SanPham.SelectedValue.ToString(), cbo_Size.SelectedValue.ToString(), int.Parse(txt_SoLuong.Text), int.Parse(txt_KhuyenMai.Text));
        }

        void capNhatGia(string maSP, string maSize, int soluong = 1, int khuyenmai = 0)
        {
            string dongia = getDonGia(maSP, maSize);
            int giagoc = Convert.ToInt32(dongia) * soluong;
            txt_GiaGoc.Text = giagoc.ToString();
            double thanhtien = (100 - Convert.ToInt32(khuyenmai)) * giagoc / 100;
            txt_ThanhTien.Text = thanhtien.ToString();
        }
        private void btn_LuuCT_Click(object sender, EventArgs e)
        {
            string masp = cbo_SanPham.SelectedValue.ToString();
            string masize = cbo_Size.SelectedValue.ToString();
            XuLiButton_ct(true, false, false, false);
            //if (kiemTraGiong(masp, masize))
            //{
                //MessageBox.Show("có sản phẩm trùng lặp", "thông báo");
            //    ThemTienCTHD_CTHD(txt_SoLuong.Text,txt_GiaGoc.Text,txt_ThanhTien.Text, masp, masize);
            //}
            //else
            AddRowCTHoaDon(sender, e);
            dgv_DanhSach.Rows[0].Cells["TongTien"].Value = (double.Parse(dgv_DanhSach.Rows[0].Cells["TongTien"].Value.ToString()) + double.Parse(txt_ThanhTien.Text)).ToString();
            txt_TongTien.Text = dgv_DanhSach.Rows[0].Cells["TongTien"].Value.ToString();
            dgv_CTHD.Enabled = true;
            XuLiTextBox_ct(false);
        }
        private void cbo_SanPham_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbo_Size.SelectedValue.ToString() == "") return;
            if (txt_SoLuong.Text != "0")
            capNhatGia(cbo_SanPham.SelectedValue.ToString(), cbo_Size.SelectedValue.ToString());
            else
            {
                txt_GiaGoc.Text = "0";
                txt_ThanhTien.Text = "0";
            }
        }
        bool kiemTraGiong(string masp, string masize)
        {
            bool kq = false;
            

            for (int i = 0; i < dgv_CTHD.Rows.Count; i++)
            {
                string masp2 = dgv_CTHD.Rows[i].Cells["MaSP"].Value.ToString();
                string masize2 = dgv_CTHD.Rows[i].Cells["MaSize"].Value.ToString();
                //MessageBox.Show(masp + " " + masp2, masize + " " + masize2);
                if (masp == masp2 && masize == masize2)
                    kq = true;
                
            }
            return kq;
        }
        void ThemTienCTHD_CTHD(string slthem,string giagocthem, string thanhtienthem, string masp, string masize)
        {
            for (int i = 0; i < dgv_CTHD.Rows.Count; i++)
            {
                if (masp == dgv_CTHD.Rows[i].Cells["MaSP"].Value.ToString() && masize == dgv_CTHD.Rows[i].Cells["MaSize"].Value.ToString())
                {
                    int slcosan = Convert.ToInt32(dgv_CTHD.Rows[i].Cells["SoLuong"].Value);
                    slcosan += Convert.ToInt32(slthem);
                    dgv_CTHD.Rows[i].Cells["SoLuong"].Value = slcosan;
                    int giagoccosan = Convert.ToInt32(dgv_CTHD.Rows[i].Cells["GiaGoc"].Value);
                    giagoccosan += Convert.ToInt32(giagocthem);
                    dgv_CTHD.Rows[i].Cells["GiaGoc"].Value = giagoccosan;
                    int thanhtiencosan = Convert.ToInt32(dgv_CTHD.Rows[i].Cells["ThanhTien"].Value);
                    thanhtiencosan += Convert.ToInt32(thanhtienthem);
                    dgv_CTHD.Rows[i].Cells["ThanhTien"].Value = thanhtiencosan;

                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (dgv_DanhSach.Rows.Count <= 0) return;
            e.Graphics.DrawString("Ngay: " + DateTime.Now, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("Nhan Vien Lap: " + lbl_nhanVien.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 40));
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 80));
            e.Graphics.DrawString("Ten San Pham", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 100));
            e.Graphics.DrawString("So Luong", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(200, 100));
            e.Graphics.DrawString("Size", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(340, 100));
            e.Graphics.DrawString("Don Gia", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(420, 100));
            e.Graphics.DrawString("Khuyen Mai", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(530, 100));
            e.Graphics.DrawString("Thanh Tien", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(680, 100));
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 130));

            int yPos = 160;

            for (int i = 0; i < dgv_CTHD.Rows.Count; i++)
            {
                DataSet getSize = c.LayDuLieu("Select * from Size where MaSize = '" + dgv_CTHD.Rows[i].Cells["MaSize"].Value.ToString() + "'");
                DataSet getTenSanPham = c.LayDuLieu("Select * from SanPham where MaSP = '" + dgv_CTHD.Rows[i].Cells["MaSP"].Value.ToString() + "'");
                string size = getSize.Tables[0].Rows[0]["TenSize"].ToString();
                string tenSP = getTenSanPham.Tables[0].Rows[0]["TenSP"].ToString();
                e.Graphics.DrawString(tenSP, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, yPos));
                e.Graphics.DrawString(dgv_CTHD.Rows[i].Cells["SoLuong"].Value.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(230, yPos));
                e.Graphics.DrawString(size, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(340, yPos));
                e.Graphics.DrawString(dgv_CTHD.Rows[i].Cells["DonGia"].Value.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(420, yPos));
                e.Graphics.DrawString(dgv_CTHD.Rows[i].Cells["KhuyenMai"].Value.ToString() + "%", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(530, yPos));
                e.Graphics.DrawString(dgv_CTHD.Rows[i].Cells["ThanhTien"].Value.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(680, yPos));
                yPos += 30;
            }
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, yPos));
            e.Graphics.DrawString("Tong Phai Tra: " + dgv_DanhSach.Rows[0].Cells["TongTien"].Value.ToString() + "VND", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(600, yPos + 30));
        }
        void loadData_cboFromList(ComboBox cbo, string disMember)
        {

            string value = dgv_CTHD.CurrentRow.Cells[disMember].Value.ToString();
            foreach (DataRowView rowView in cbo.Items)
            {
                string val = rowView.Row[0].ToString();
                string name = rowView.Row[1].ToString();
                if (val == value)
                {
                    cbo.Text = name;
                    break;
                }

            }
        }
        private void dgv_CTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_SoLuong.Text = dgv_CTHD.CurrentRow.Cells["SoLuong"].Value.ToString();
            txt_GiaGoc.Text = dgv_CTHD.CurrentRow.Cells["GiaGoc"].Value.ToString();
            txt_ThanhTien.Text = dgv_CTHD.CurrentRow.Cells["ThanhTien"].Value.ToString();
            txt_KhuyenMai.Text = dgv_CTHD.CurrentRow.Cells["KhuyenMai"].Value.ToString();
            loadData_cboFromList(cbo_Size, "MaSize");
            loadData_cboFromList(cbo_SanPham, "MaSP");
        }
    }
}
