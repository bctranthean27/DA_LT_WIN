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
    public partial class frm_HoaDonNhap : Form
    {
        public frm_HoaDonNhap()
        {
            InitializeComponent();
        }
        public frm_HoaDonNhap(string manv)
        {
            this.manv = manv;
            InitializeComponent();
        }
        private void frm_HoaDonNhap_Load(object sender, EventArgs e)
        {
            XuLiButton_ct(false, false, false);
            XuLiTextBox_ct(false);
            //loadData_DataGrid(dgv_DanhSach, "select * from HoaDon where TrangThai='1'");
            loadNhanVien(sender, e);
            loadData_cbo(cbo_SanPham, "select MaSP,TenSP from SanPham where TrangThai='1'", "MaSP", "TenSP");
            loadData_cbo(cbo_Size, "select MaSize,TenSize from Size where TrangThai='1'", "MaSize", "TenSize");
        }
        cls_QLCHCAFE c = new cls_QLCHCAFE();
        DataSet ds = new DataSet();
        int flag = 0;
        public string manv;
        
        


        void loadNhanVien(object sender, EventArgs e)
        {
            DataSet dl = c.LayDuLieu("select MaNV,TenNV from NhanVien where MaNV='" + manv + "'");
            cbo_NhanVien.DataSource = dl.Tables[0];
            cbo_NhanVien.ValueMember = "MaNV";
            cbo_NhanVien.DisplayMember = "TenNV";
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
        void XuLiButton_ct(bool key_them, bool key_xoa, bool key_sua)
        {
            btn_ThemCT.Enabled = key_them;
            btn_LuuCT.Enabled = !key_them;
            btn_XoaCT.Enabled = key_xoa;
            btn_SuaCT.Enabled = key_sua;
        }
        void XuLiTextBox_ct(bool key)
        {
            cbo_SanPham.Enabled = key;
            cbo_Size.Enabled = key;
            txt_SoLuong.Enabled = key;
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
        private void btn_ThemHD_Click(object sender, EventArgs e)
        {
            btn_ThemHD.Enabled = false;
            txt_MaHD.Text = autoCode("P");
            AddRowHoaDon();
            btn_Reset.Enabled = true;
            btn_ThemCT.Enabled = true;
        }
        private void btn_XuatHD_Click(object sender, EventArgs e)
        {

            if (dgv_CTHD.Rows.Count == 0)
                MessageBox.Show("Vui lòng không xuất hoá đơn trống", "Lưu ý", MessageBoxButtons.OK);
            else
            {
                LuuVeSQL(sender, e);
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
                frm_HoaDonNhap_Load(sender, e);
            }
        }
        void AddRowHoaDon()
        {
            string maHD = autoCode("P");
            dgv_DanhSach.Rows.Add(maHD, NgayHienTai(), "K01", manv, "0", "1");
            XuLiButton_ct(true, false, false);
        }

        private void btn_ThemCT_Click(object sender, EventArgs e)
        {
            XuLiButton_ct(false, false, false);
            XuLiTextBox_ct(true);
            ResetTextBox_CT();
            dgv_CTHD.Enabled = false;
            flag = 1;
        }

        private void btn_SuaCT_Click(object sender, EventArgs e)
        {
            XuLiButton_ct(false, false, false);
            XuLiTextBox_ct(true);
            btn_LuuCT.Enabled = true;
            dgv_CTHD.Enabled = false;
            flag = 2;
        }

        private void btn_XoaCT_Click(object sender, EventArgs e)
        {
            dgv_CTHD.Rows.RemoveAt(dgv_CTHD.CurrentRow.Index);
            dgv_CTHD.Enabled = true;
            XuLiTextBox_ct(false);
            capnhatThanhTien(sender, e);
            ResetTextBox_CT();
        }
        string getDonGia(string masp, string masize)
        {
            string dongia = "0";
            if (masp != "" && masize != "")
            {
                string mactsp = masp + masize;
                DataSet data = c.LayDuLieu("select * from ChiTietSanPham where MaCTSP = '" + mactsp + "' ");

                dongia = data.Tables[0].Rows[0]["GiaNhap"].ToString();
            }
            return dongia;
        }
        void AddRowCTHoaDon(object sender, EventArgs e)
        {
            string soluong = txt_SoLuong.Text;
            string maSize = cbo_Size.SelectedValue.ToString();
            string maSP = cbo_SanPham.SelectedValue.ToString();
            string dongia = getDonGia(maSP, maSize);
            string maCTHD = txt_MaHD.Text + maSP + maSize;
            capNhatGia(cbo_SanPham.SelectedValue.ToString(), cbo_Size.SelectedValue.ToString(), int.Parse(txt_SoLuong.Text));
            string thanhtien = txt_ThanhTien.Text;
            dgv_CTHD.Rows.Add(maCTHD, maSP, maSize, soluong, dongia.ToString(),thanhtien,"-1", thanhtien);
        }
        void SuaCTHoaDon(object sender, EventArgs e)
        {
            string soluong = txt_SoLuong.Text;

            string maSize = cbo_Size.SelectedValue.ToString();
            string maSP = cbo_SanPham.SelectedValue.ToString();
            string dongia = getDonGia(maSP, maSize);
            string maCTHD = txt_MaHD.Text + maSP + maSize;
            string thanhtien = txt_ThanhTien.Text;
            dgv_CTHD.CurrentRow.SetValues(maCTHD, maSP, maSize, soluong, dongia.ToString(), thanhtien, "-1", thanhtien);

        }
        void ResetTextBox_CT()
        {
            cbo_SanPham.SelectedIndex = 0;
            cbo_Size.SelectedIndex = 0;
            txt_SoLuong.Text = "1";
            string masp = cbo_SanPham.SelectedValue.ToString();
            string masize = cbo_Size.SelectedValue.ToString();
            txt_ThanhTien.Text = getDonGia(masp, masize).ToString();
        }
        void capNhatGia(string maSP, string maSize, int soluong = 1)
        {
            string dongia = getDonGia(maSP, maSize);
            int thanhtien = Convert.ToInt32(dongia) * soluong;
            txt_ThanhTien.Text = thanhtien.ToString();
        }
        private void btn_LuuCT_Click(object sender, EventArgs e)
        {
            string masp = cbo_SanPham.SelectedValue.ToString();
            string masize = cbo_Size.SelectedValue.ToString();
            string sl = txt_SoLuong.Text;
            switch (flag)
            {
                case 1:
                    {
                        if (kiemTraGiong(masp, masize))
                        {
                            DialogResult kq = MessageBox.Show("Sản phầm đã tồn tại, nhấn YES để gộp hai chi tiết," +
                                " nhấn NO đề chọn chi tiết khác", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (kq == DialogResult.Yes)
                            {
                                ThemTienCTHD(sl, masp, masize);
                                XuLiButton_ct(true, false, false);
                                capnhatThanhTien(sender, e);
                                dgv_CTHD.Enabled = true;
                                XuLiTextBox_ct(false);
                                ResetTextBox_CT();
                            }
                        }
                        else
                        {
                            AddRowCTHoaDon(sender, e);
                            XuLiButton_ct(true, false, false);
                            capnhatThanhTien(sender, e);
                            dgv_CTHD.Enabled = true;
                            XuLiTextBox_ct(false);
                            ResetTextBox_CT();
                        }

                    }; break;
                case 2:
                    {
                        XuLiButton_ct(true, false, false);
                        SuaCTHoaDon(sender, e);
                        capnhatThanhTien(sender, e);
                        dgv_CTHD.Enabled = true;
                        XuLiTextBox_ct(false);
                        ResetTextBox_CT();
                    }; break;
            }
        }
        private void cbo_SanPham_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbo_Size.SelectedValue.ToString() == "") return;
            if (txt_SoLuong.Text != "0")
                capNhatGia(cbo_SanPham.SelectedValue.ToString(), cbo_Size.SelectedValue.ToString(),Convert.ToInt32(txt_SoLuong.Text));
            else
            {
                txt_ThanhTien.Text = "0";
            }
        }
        void capnhatThanhTien(object sender, EventArgs e)
        {
            int thanhtien = 0;
            for (int i = 0; i < dgv_CTHD.Rows.Count; i++)
                thanhtien += Convert.ToInt32(dgv_CTHD.Rows[i].Cells["ThanhTien"].Value.ToString());
            dgv_DanhSach.Rows[0].Cells["TongTien"].Value = thanhtien;
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
        void ThemTienCTHD(string slthem, string masp, string masize)
        {
            for (int i = 0; i < dgv_CTHD.Rows.Count; i++)
            {
                if (masp == dgv_CTHD.Rows[i].Cells["MaSP"].Value.ToString() && masize == dgv_CTHD.Rows[i].Cells["MaSize"].Value.ToString())
                {
                    int sl = Convert.ToInt32(dgv_CTHD.Rows[i].Cells["SoLuong"].Value);
                    sl += Convert.ToInt32(slthem);
                    dgv_CTHD.Rows[i].Cells["SoLuong"].Value = sl;
                    int thanhtien = sl * int.Parse(getDonGia(masp, masize));
                    dgv_CTHD.Rows[i].Cells["GiaGoc"].Value = dgv_CTHD.Rows[i].Cells["ThanhTien"].Value = thanhtien;

                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString("Ngày: " + DateTime.Now, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("Nhân Viên Lập: " + cbo_NhanVien.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 40));

            e.Graphics.DrawString("BLF COFFEE", new Font("Arial", 26, FontStyle.Regular), Brushes.Black, new Point(300, 80));
            e.Graphics.DrawString("HÓA ĐƠN NHẬP HÀNG", new Font("Arial", 26, FontStyle.Regular), Brushes.Black, new Point(220, 120));

            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 180));
            e.Graphics.DrawString("Tên Sản Phẩm", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 200));
            e.Graphics.DrawString("Số Lượng", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(180, 200));
            e.Graphics.DrawString("Size", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(300, 200));
            e.Graphics.DrawString("Đơn Giá", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(420, 200));
            e.Graphics.DrawString("Thành Tiền", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(550, 200));
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 220));
            int yPos = 240;

            for (int i = 0; i < dgv_CTHD.Rows.Count; i++)
            {
                DataSet getSize = c.LayDuLieu("Select * from Size where MaSize = '" + dgv_CTHD.Rows[i].Cells["MaSize"].Value.ToString() + "'");
                DataSet getTenSanPham = c.LayDuLieu("Select * from SanPham where MaSP = '" + dgv_CTHD.Rows[i].Cells["MaSP"].Value.ToString() + "'");
                string size = getSize.Tables[0].Rows[0]["TenSize"].ToString();
                string tenSP = getTenSanPham.Tables[0].Rows[0]["TenSP"].ToString();
                e.Graphics.DrawString(tenSP, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, yPos));
                e.Graphics.DrawString(dgv_CTHD.Rows[i].Cells["SoLuong"].Value.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(200, yPos));
                e.Graphics.DrawString(size, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(300, yPos));
                e.Graphics.DrawString(dgv_CTHD.Rows[i].Cells["DonGia"].Value.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(420, yPos));
                e.Graphics.DrawString(dgv_CTHD.Rows[i].Cells["ThanhTien"].Value.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(550, yPos));
                yPos += 30;
            }
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, yPos));
            e.Graphics.DrawString("Tổng thanh toán: " + dgv_DanhSach.Rows[0].Cells["TongTien"].Value.ToString() + " VNĐ", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(500, yPos + 30));
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
            txt_ThanhTien.Text = dgv_CTHD.CurrentRow.Cells["ThanhTien"].Value.ToString();
            loadData_cboFromList(cbo_Size, "MaSize");
            loadData_cboFromList(cbo_SanPham, "MaSP");
            XuLiButton_ct(true, true, true);
        }
        void LuuVeSQL(object sender, EventArgs e)
        {
            //Luu hoa don
            string maHD = txt_MaHD.Text;
            string ngayLap = NgayHienTai();
            string maloaiHD = "K01";
            string tongtien = dgv_DanhSach.Rows[0].Cells["TongTien"].Value.ToString();
            string sql_hoadon = "EXEC them_hd @mahd = '" + maHD + "',@ngaylap = '" + ngayLap + "', @maloaihd = '" + maloaiHD + "',@manv = '" + manv + "',@tongtien = " + tongtien + ",@tenKH = ''";
            if (c.CapNhatDulieu(sql_hoadon) > 0)
                MessageBox.Show("Cập nhật hoá đơn thành công", "Thông báo", MessageBoxButtons.OK);
            //Luu chi tiet hoa don
            for (int i = 0; i < dgv_CTHD.Rows.Count; i++)
            {
                string maSP = dgv_CTHD.Rows[i].Cells["MaSP"].Value.ToString();
                string maSize = dgv_CTHD.Rows[i].Cells["MaSize"].Value.ToString();
                string soLuong = dgv_CTHD.Rows[i].Cells["SoLuong"].Value.ToString();
                string donGia = dgv_CTHD.Rows[i].Cells["DonGia"].Value.ToString();
                string giaGoc = dgv_CTHD.Rows[i].Cells["GiaGoc"].Value.ToString();
                string khuyenMai = dgv_CTHD.Rows[i].Cells["KhuyenMai"].Value.ToString();
                string thanhTien = dgv_CTHD.Rows[i].Cells["ThanhTien"].Value.ToString();
                string sql_chitiethoadon = "EXEC capnhat_cthd @mahd = '" + maHD + "', @masp = '" + maSP + "', @masize = '" + maSize + "', @sl = " + soLuong + ", @dongia = " + donGia + ", @giagoc = " + giaGoc + ", @khuyenmai = " + khuyenMai + ", @thanhtien = " + thanhTien;
                if (c.CapNhatDulieu(sql_chitiethoadon) > 0 && i == dgv_CTHD.Rows.Count - 1)
                {
                    MessageBox.Show("Cập nhật các chi tiết hoá đơn thành công", "Thông báo", MessageBoxButtons.OK);
                    frm_HoaDonNhap_Load(sender, e);
                }
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_MaHD.Text = "";
            ResetTextBox_CT();
            dgv_CTHD.Rows.Clear();
            dgv_DanhSach.Rows.Clear();
            btn_ThemHD.Enabled = true;
            XuLiButton_ct(false, false, false);
            btn_ThemHD.Enabled = true;
            btn_LuuCT.Enabled = false;
        }

        
        private void txt_Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {
            if (txt_SoLuong.Text == "")
            {
                txt_SoLuong.Text = "0";
                MessageBox.Show("Vui lòng không để trống số lượng", "Thông báo", MessageBoxButtons.OK);

            }
            else
            {
                int sl = int.Parse(txt_SoLuong.Text); 
                if (sl < 0)
                    txt_SoLuong.Text = "0";
                else if (sl > 1000)
                    txt_SoLuong.Text = "1000";
            } 
            capNhatGia(cbo_SanPham.SelectedValue.ToString(), cbo_Size.SelectedValue.ToString(), Convert.ToInt32(txt_SoLuong.Text));
        }
    }
}

