using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _108_144_QLCuaHangCafe
{
    public partial class frm_SanPham : Form
    {
        cls_QLCHCAFE c = new cls_QLCHCAFE();
        int vt = 0;
        DataSet ds = new DataSet();
        DataSet dx = new DataSet();
        int flag = 0;
        string Old_Value = "";
        string tool_HinhAnh = "";
        string maLoaiAnh = "";
        string maAnh = "";
        public frm_SanPham()
        {
            InitializeComponent();
        }

        private void frm_SanPham_Load(object sender, EventArgs e)
        {

            XuLiTextBox(true);
            XuLiTextBox_ctsp(true);
            XuLiButton(true, false , false, false, false);
            loadData_DataGrid(dgv_DanhSach, "select * from SanPham where TrangThai = '1'");
            loadData_cbo(cbo_LoaiSanPham, "select MaLoai,TenLoai from LoaiSanPham where TrangThai = '1'", "MaLoai", "TenLoai");
            loadData_cbo(cbo_NCC, "select MaNCC,TenNCC from NhaCungCap where TrangThai = '1'", "MaNCC", "TenNCC");
            loadData_cbo(cbo_Size, "select MaSize,TenSize from Size where TrangThai = '1'", "MaSize", "TenSize");

        }
        void loadData_DataGrid(DataGridView d, string sql)
        {
            ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];

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
        void XuLiTextBox(Boolean t)
        {
            txt_TenSP.ReadOnly = t;
            cbo_LoaiSanPham.Enabled = !t;
            cbo_NCC.Enabled = !t;
        }
        void XuLiTextBox_ctsp(Boolean t)
        {
            txt_GiaBan.ReadOnly = t;
            txt_GiaNhap.ReadOnly = t;
            txt_SoLuong.ReadOnly = t;
        }
        void XuLiButton(bool key_them = true, bool key_xoa = true, bool key_sua = true, bool key_luu = true, bool key_image = true)
        {
            btn_Them.Enabled = key_them;
            btn_Xoa.Enabled = key_xoa;
            btn_Sua.Enabled = key_sua;
            btn_Luu.Enabled = key_luu;
            btn_AddImage.Enabled = key_image;
        }
        string autoCode(DataSet ds, string pri)
        {
            string code = pri;
            int pos = ds.Tables[0].Rows.Count + 1;
            if (pos < 10) code += "0" + pos.ToString();
            else if (pos < 100) code += "" + pos.ToString();
            return code;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            
            ds = c.LayDuLieu("select * from SanPham");
            clearTextbox();
            txt_MaSP.Text = autoCode(ds, "X");
            XuLiTextBox(false);
            XuLiButton(false, false, false, true, true);
            dgv_DanhSach.Enabled = false;
            dgv_CTSP.Enabled = false;
            pic_HinhAnh.Visible = false;
            maLoaiAnh = "";
            tool_HinhAnh = "";
            pic_HinhAnh.Image = null;
            flag = 1;
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            maLoaiAnh = "";
            tool_HinhAnh = "";
            if (txt_SoLuong.Text != "") XuLiTextBox_ctsp(false);
            else XuLiTextBox(false);
            XuLiButton(false, false, false, true, true);
            dgv_DanhSach.Enabled = false;
            dgv_CTSP.Enabled = false;
            pic_HinhAnh.Image = null;
            flag = 2;
        }
        void them(object sender, EventArgs e, string m1, string m2, string m3, string m4,string maLoaiAnh,string tenAnh)
        {
                if (m1.Trim() == "" || m2.Trim() == "" || m3.Trim() == "" || m4.Trim() == "")
                    throw new Exception("Vui lòng điền đủ thông tin");
                string maA = autoCode(ds, "A");
                string sql = "EXEC them_sp @masp = '" + m1 + "', @tensp = N'" + m2 + "', @maloai = '" + m3 + "', @mancc = N'" + m4 + "', @maHinh = '" + maA + "';";
                if ( c.CapNhatDulieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công", "Thông báo", MessageBoxButtons.OK);
                }
                string sql2 = "EXEC them_hinh @maHinh = '" + maA + "', @maLoaiHinh = '" + maLoaiAnh + "', @tenHinh = '" + tenAnh + "';";
                if (c.CapNhatDulieu(sql2) > 0 )
                {
                    MessageBox.Show("Cập nhật hình ảnh sản phẩm thành công", "Thông báo", MessageBoxButtons.OK);
                    frm_SanPham_Load(sender, e);
                }
                string sql3 = "EXEC them_ctsp @masp = '"+ m1 +"', @soLuong = " + 0 + " , @giaBan =  " + 25000 + ", @giaNhap = " + 15000;
                if (c.CapNhatDulieu(sql3) > 0)
                {
                    MessageBox.Show("Cập nhật chi tiết sản phẩm thành công", "Thông báo", MessageBoxButtons.OK);
                    frm_SanPham_Load(sender, e);
                }    
        }
        void sua(object sender, EventArgs e, string maSP = "", string tenSP = "", string maLoai = "", string maNCC = "", string trangThai = "0", string maLoaiAnh = "", string tenAnh = "")
        {
            try
            {
                if (txt_MaSP.Text == "")
                {
                    throw new Exception("Lỗi cập nhật\nHãy chắc chắn bạn chọn đúng cột muốn sửa");
                }
                string sql = "EXEC sua_sp @masp = '" + maSP + "',@tensp =N'"+ tenSP + "',@maloai ='" + maLoai + "',@mancc = '" + maNCC + "',@trangthai='1'";
                if (maLoai != "" || tenAnh != "") 
                {
                    string sql2 = "EXEC sua_hinh @maHinh = '" + maAnh + "', @maLoaiHinh = '" + maLoaiAnh + "', @tenHinh = '" + tenAnh + "';";
                    if (c.CapNhatDulieu(sql2) > 0)
                    {
                        MessageBox.Show("Cập nhật hình ảnh sản phẩm thành công", "Thông báo", MessageBoxButtons.OK);
                        c.DongKetNoi();
                    }
                }
                if (c.CapNhatDulieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công", "Thông báo", MessageBoxButtons.OK);
                    c.DongKetNoi();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_Sua_Click(sender, e);
            }
        }
        void sua_ctsp(object sender, EventArgs e, string masize, string soluong = "0", string giaban = "0", string gianhap = "0")
        {
            try
            {
                string sql = "EXEC sua_ctsp @masp = '"+Old_Value+ "', @masize = '"+masize+ "', @soluong = '" + soluong + "' , @giaban = '" + giaban + "' , @gianhap = ' " + gianhap + "'";
                if (c.CapNhatDulieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công", "Thông báo", MessageBoxButtons.OK);
                    c.DongKetNoi();
                    loadData_DataGrid(dgv_CTSP, "select * from ChiTietSanPham where MaSanPham ='" + Old_Value + "'");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_Sua_Click(sender, e);
            }
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string m1 = txt_MaSP.Text;
            string m2 = txt_TenSP.Text;
            string m3 = cbo_LoaiSanPham.SelectedValue.ToString();
            string m4 = cbo_NCC.SelectedValue.ToString();
            string soLuong = txt_SoLuong.Text;
            string giaBan = txt_GiaBan.Text;
            string giaNhap = txt_GiaNhap.Text;
            string maSize = cbo_Size.SelectedValue.ToString();
            switch (flag)
            {
                case 1:
                    clearTextbox();
                    them(sender, e, m1, m2, m3, m4, maLoaiAnh, tool_HinhAnh);
                    break;
                case 2:
                    {
                        if (soLuong == "")
                            sua(sender, e, m1, m2, m3, m4, "1", maLoaiAnh, tool_HinhAnh);
                        else
                            sua_ctsp(sender, e, maSize, soLuong, giaBan, giaNhap);
                    }
                    break;

            }
            frm_SanPham_Load(sender, e);
            dgv_DanhSach.Enabled = true;
            dgv_CTSP.Enabled = true;
        }
        void loadData_cboFromList(DataTable dt, ComboBox cbo, string disMember, int vt)
        {

            string value = dt.Rows[vt][disMember].ToString();
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
        void hienThiTextBox(DataTable dt, int vt)
        {
            txt_MaSP.Text = ds.Tables[0].Rows[vt]["MaSP"].ToString();
            txt_TenSP.Text = ds.Tables[0].Rows[vt]["TenSP"].ToString();
            loadData_cboFromList(dt, cbo_LoaiSanPham, "MaLoai", vt);
            loadData_cboFromList(dt, cbo_NCC, "MaNCC", vt);
        }
        void HienThiAnh(string ma)
        {
            if (ma == "") return;
            DataSet data = c.LayDuLieu("Select  * from Hinh where MaHinh = '" + ma + "'");
            string LoaiAnh = data.Tables[0].Rows[0]["MaLoaiHinh"] == DBNull.Value ? "" : data.Tables[0].Rows[0]["MaLoaiHinh"].ToString();
            string ten = data.Tables[0].Rows[0]["TenHinh"] == DBNull.Value ? "" : data.Tables[0].Rows[0]["TenHinh"].ToString();

            if (LoaiAnh != "" && ten != "")
            {
                pic_HinhAnh.Image = Image.FromFile(@"C:\text\WinForm\108_144_QLCuaHangCafe\108_144_QLCuaHangCafe\bin\Image\" + LoaiAnh + @"\" + ten);
                pic_HinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                pic_HinhAnh.Visible = true;
            }
            else if (LoaiAnh == "" && ten == "") pic_HinhAnh.Visible = false;
        }
        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {   
            ds = c.LayDuLieu("select * from SanPham where TrangThai='1'");
            int vt = dgv_DanhSach.CurrentCell.RowIndex;
            hienThiTextBox(ds.Tables[0], vt);
            Old_Value = txt_MaSP.Text;
            maAnh = ds.Tables[0].Rows[vt]["MaHinh"].ToString() == "" ? "" : ds.Tables[0].Rows[vt]["MaHinh"].ToString();
            HienThiAnh(maAnh);
            XuLiButton(true, true, true, false, false);
            loadData_DataGrid(dgv_CTSP, "select * from ChiTietSanPham where MaSanPham ='"+Old_Value+"'");
        }
        void clearTextbox()
        {
            txt_MaSP.Text = "";
            txt_TenSP.Text = "";
            cbo_NCC.SelectedIndex = 0;
            cbo_LoaiSanPham.SelectedIndex = 0;      
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "update SanPham set TrangThai = '" + 0 + "'where MaSP = '" + Old_Value + "'";
            if (c.CapNhatDulieu(sql) > 0)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                c.DongKetNoi();
            }
            frm_SanPham_Load(sender,e);

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_AddImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog Odlg_HinhAnh = new OpenFileDialog();
            Odlg_HinhAnh.InitialDirectory = Path.GetFullPath("Image") + @"\";
            while (Odlg_HinhAnh.ShowDialog() == DialogResult.Cancel) {
                Odlg_HinhAnh.ShowDialog();
            }
            string ten_anh = Odlg_HinhAnh.FileName;
            Bitmap bitmap = new Bitmap(ten_anh);
            pic_HinhAnh.Image = bitmap;
            pic_HinhAnh.Visible = true;
            pic_HinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            string[] ten = ten_anh.Split('\\');
            maLoaiAnh = ten[ten.Length - 2];
            tool_HinhAnh = ten[ten.Length - 1];
        }

        private void dgv_DanhSach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ds = c.LayDuLieu("select * from SanPham");
            DataGridViewRow row = dgv_DanhSach.CurrentRow;//get row at select row
            if(row != null)
            {
                string m2 = row.Cells["TenSP"].Value.ToString();
                string m3 = row.Cells["MaLoai"].Value.ToString();
                string m4 = row.Cells["MaNCC"].Value.ToString();
                string m1 = row.Cells["MaSP"].Value.ToString();
                sua(sender, null, m1, m2, m3, m4, "1");
            }
        }
        void hienThiTextBox2(DataTable data, int vt2)
        {
            txt_SoLuong.Text = dx.Tables[0].Rows[vt2]["SoLuong"].ToString();
            txt_GiaBan.Text = dx.Tables[0].Rows[vt2]["GiaBan"].ToString();
            txt_GiaNhap.Text = dx.Tables[0].Rows[vt2]["GiaNhap"].ToString();
            loadData_cboFromList(dx.Tables[0], cbo_Size, "MaSize", vt2);
        }
        private void dgv_CTSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dx = c.LayDuLieu("select * from ChiTietSanPham where MaSanPham ='" + Old_Value + "'");
            if (dgv_CTSP.DataSource == null) return;    
            int vt2 = dgv_CTSP.CurrentCell.RowIndex;
            hienThiTextBox2(null,vt2);
            XuLiButton(true, false, true, false, false);
        }

        private void dgv_CTSP_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dgv_CTSP.CurrentRow;//get row at select row
            if(row != null)
            {
                string maSize = row.Cells["MaSize"].Value.ToString();
                string soLuong = row.Cells["SoLuong"].Value.ToString();
                string giaBan = row.Cells["GiaBan"].Value.ToString();
                string giaNhap = row.Cells["GiaNhap"].Value.ToString();
                sua(sender, e, maSize, soLuong, giaBan, giaNhap);
            }
        }
    }
}
