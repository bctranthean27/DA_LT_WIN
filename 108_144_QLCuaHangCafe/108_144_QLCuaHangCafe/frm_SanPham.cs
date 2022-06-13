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
        int flag = 0;
        string Old_Value = "";
        public frm_SanPham()
        {
            InitializeComponent();
        }

        private void frm_SanPham_Load(object sender, EventArgs e)
        {
            XuLiTextBox(true);
            XuLiButton(true);
            loadData_DataGrid(dgv_DanhSach, "select * from SanPham where TrangThai = '1'");
            loadData_cbo(cbo_LoaiSanPham, "select MaLoai,TenLoai from LoaiSanPham where TrangThai = '1'", "MaLoai", "TenLoai");
            loadData_cbo(cbo_NCC, "select MaNCC,TenNCC from NhaCungCap where TrangThai = '1'", "MaNCC", "TenNCC");
            cbo_TrangThai.SelectedIndex = 0;
            cbo_TrangThai.DropDownStyle= ComboBoxStyle.DropDownList;
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
            txt_MaSP.ReadOnly = t;
            txt_TenSP.ReadOnly = t;
            txt_DonGia.ReadOnly = t;
            cbo_LoaiSanPham.Enabled = !t;
            cbo_NCC.Enabled = !t;
            cbo_TrangThai.Enabled = !t;
        }
        void XuLiButton(Boolean t)
        {
            btn_Them.Enabled = t;
            btn_Sua.Enabled = t;
            btn_Xoa.Enabled = t;
            btn_Luu.Enabled = !t;
            dgv_DanhSach.Enabled = t;
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
            XuLiButton(false);
            txt_MaSP.ReadOnly = true;
            flag = 1;
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            XuLiTextBox(false);
            XuLiButton(false);
            txt_MaSP.ReadOnly = true;
            flag = 2;
        }
        void them(object sender, EventArgs e, string m1, string m2, string m3, string m4, string m5, string m6 = "1")
        {

            try
            {
                if (m1.Trim() == "" || m2.Trim() == "" || m3.Trim() == "" || m4.Trim() == "" || m5.Trim() == "")
                    throw new Exception("Vui lòng điền đủ thông tin");
                //string sql = "insert into SanPham(MaSP,TenSP,MaLoai,MaNCC,DonGia,TrangThai) values ('" + m1 + "',N'" + m2 + "',N'" + m3 + "','" + m4 + "',N'" + m5 + "',N'" + m6  + "')";
                //proc
                string sql = "EXEC them_sp @masp = '" + m1 + "', @tensp = N'" + m2 + "', @maloai = '" + m3 + "', @mancc = N'" + m4 + "', @dongia = '" + m5  + "';";
                if (c.CapNhatDulieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                    frm_SanPham_Load(sender, e);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                c.DongKetNoi();
                btn_Them_Click(sender, e);
            }
        }
        void sua(object sender, EventArgs e, string m1 = "", string m2 = "", string m3 = "", string m4 = "", string m5 = "", string m6 = "0")
        {
            try
            {
                string sql = "";
                if (txt_MaSP.Text == "")
                {
                    throw new Exception("Lỗi cập nhật\nHãy chắc chắn bạn chọn đúng cột muốn sửa");
                }
                //sql = "update SanPham set ";
                //if (m1.Trim() != "")
                //    sql += " MaSP='" + m1 + "',";
                //if (m2.Trim() != "")
                //    sql += " TenSP=N'" + m2 + "',";
                //if (m3.Trim() != "")
                //    sql += " MaLoai='" + m3 + "',";
                //if (m4.Trim() != "")
                //    sql += " MaNCC=N'" + m4 + "',";
                //if (m5.Trim() != "")
                //    sql += " DonGia=N'" + m5 + "',";
                //sql += " TrangThai='" + m6;
                //sql += "' where MaSP='" + Old_Value + "'";
                if (m1.Trim() == "" && m2.Trim() == "" && m3.Trim() == "" && m4.Trim() == "" && m5.Trim() == "")
                    sql = "update SanPham set TrangThai = '" + 0 + "'where MaSP = '" + Old_Value + "'";
                else
                    sql = "EXEC sua_sp @masp = '" + m1 + "', @tensp = N'" + m2 + "', @maloai = N'" + m3 + "', @mancc = N'" + m4 + "', @dongia = '" + m5  + "', @trangthai = '" + m6 + "';";


                if (c.CapNhatDulieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                    c.DongKetNoi();
                    frm_SanPham_Load(sender, e);
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
            XuLiTextBox(true);
            XuLiButton(true);
            string m1 = txt_MaSP.Text;
            string m2 = txt_TenSP.Text;
            string m3 = cbo_LoaiSanPham.SelectedValue.ToString();
            string m4 = cbo_NCC.SelectedValue.ToString();
            string m5 = txt_DonGia.Text;
            string m6 = cbo_TrangThai.SelectedItem.ToString();
            switch (flag)
            {
                case 1:
                    clearTextbox();
                    them(sender, e, m1, m2, m3, m4, m5, m6);
                    break;
                case 2:
                    sua(sender, e, m1, m2, m3, m4, m5, m6);
                    break;

            }
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
                if (row.Cells["MaSP"].Value == DBNull.Value)
                {
                    txt_MaSP.Text = "";
                    txt_TenSP.Text = "";
                    txt_DonGia.Text = "";
                    btn_Sua.Enabled = false;
                    btn_Xoa.Enabled = false;
                }
                else
                {
                    txt_MaSP.Text = ds.Tables[0].Rows[vt]["MaSP"].ToString();
                    txt_TenSP.Text = ds.Tables[0].Rows[vt]["TenSP"].ToString();
                    txt_DonGia.Text = ds.Tables[0].Rows[vt]["DonGia"].ToString();
                    loadData_cboFromList(dt, cbo_LoaiSanPham, "MaLoai",vt);
                    loadData_cboFromList(dt, cbo_NCC, "MaNCC",vt);
                    loadData_cboFromList(dt, cbo_TrangThai, "TrangThai",vt);
                }
            }
        }
        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ds = c.LayDuLieu("select * from SanPham where TrangThai='1'");
            int vt = dgv_DanhSach.CurrentCell.RowIndex;
            hienThiTextBox(ds.Tables[0], vt);
            Old_Value = txt_MaSP.Text;
        }
        void clearTextbox()
        {
            txt_MaSP.Text = "";
            txt_TenSP.Text = "";
            txt_DonGia.Text = "";
            cbo_NCC.SelectedIndex = 0;
            cbo_TrangThai.SelectedIndex = 0;
            cbo_LoaiSanPham.SelectedIndex = 0;      
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            sua(sender, e);
            clearTextbox();
            //try
            //{
            //    if (txt_MaSP.Text == "")
            //        throw new Exception("Lỗi cập nhật\nHãy chắc chắn bạn chọn đúng cột muốn xoá");
            //    string sql = "DELETE from SanPham where MaSP='" + Old_Value + "'";
            //    if (c.CapNhatDulieu(sql) > 0)
            //    {
            //        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
            //        frm_SanPham_Load(sender, e);
            //        clearTextbox();
            //    }
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    frm_SanPham_Load(sender, e);
            //}
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_AddImage_Click(object sender, EventArgs e)
        {
            //tạo hộp thoại nhập hình ảnh
            OpenFileDialog Odlg_HinhAnh = new OpenFileDialog();
            Odlg_HinhAnh.InitialDirectory = Path.GetFullPath("Image") + @"\";
            //hiển thị ảnh từ file đã chọn
            if(Odlg_HinhAnh.ShowDialog() == DialogResult.Cancel)
                Odlg_HinhAnh.ShowDialog();
            string ten_anh = Odlg_HinhAnh.FileName;
            Bitmap bitmap = new Bitmap(ten_anh);

            pic_HinhAnh.Image = bitmap;
            pic_HinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            string[] ten = ten_anh.Split('\\');

            tool_HinhAnh = ten[ten.Length - 2] + "\\"+ten[ten.Length - 1];
        }
        string tool_HinhAnh = "";
        private void pic_HinhAnh_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();
            tool.AutoPopDelay = 5000;
            tool.InitialDelay = 500;
            tool.ReshowDelay = 500;
            tool.ToolTipIcon = ToolTipIcon.Info;
            tool.ToolTipTitle = "Chú ý";

            tool.SetToolTip(pic_HinhAnh, tool_HinhAnh); // Bạn cần hiển thị gì thì lấy trong cơ sở dữ liệu ra ném vào đó là được
            //tool.IsBalloon = true;
        }
        private void dgv_DanhSach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ds = c.LayDuLieu("select * from SanPham");

            if (dgv_DanhSach.CurrentRow != null)
            {
                DataGridViewRow row = dgv_DanhSach.CurrentRow;//get row at select row
                string m2 = row.Cells["TenSP"].Value == DBNull.Value ? "" : row.Cells["TenSP"].Value.ToString();
                string m3 = row.Cells["MaLoai"].Value == DBNull.Value ? "L01" : row.Cells["MaLoai"].Value.ToString();
                string m4 = row.Cells["MaNCC"].Value == DBNull.Value ? "N01" : row.Cells["MaNCC"].Value.ToString();
                string m5 = row.Cells["DonGia"].Value == DBNull.Value ? "0" : row.Cells["DonGia"].Value.ToString();
                string m1 = row.Cells["MaSP"].Value == DBNull.Value ? autoCode(ds, "X") : row.Cells["MaSP"].Value.ToString();

                if (row.Cells["MaSP"].Value == DBNull.Value)
                {
                    them(sender, null, m1, m2, m3, m4, m5, "1");
                }
                else
                {
                    sua(sender, null, m1, m2, m3, m4, m5, "1");
                }

            }
        }
    }
}
