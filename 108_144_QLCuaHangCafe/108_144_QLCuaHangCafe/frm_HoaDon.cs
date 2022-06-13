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
        public frm_HoaDon()
        {
            InitializeComponent();
        }

        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            XuLiTextBox(true);
            XuLiButton(true);
            loadData_DataGrid(dgv_DanhSach, "select * from HoaDon where TrangThai='1'");
            loadData_cbo(cbo_KhachHang, "select MaKH,TenKH from KhachHang where TrangThai='1'", "MaKH", "TenKH");
            loadData_cbo(cbo_LoaiHD, "select MaLoaiHD,TenLoaiHD from LoaiHoaDon where TrangThai='1'", "MaLoaiHD", "TenLoaiHD");
            loadData_cbo(cbo_NhanVien, "select MaNV,TenNV from NhanVien where TrangThai='1'", "MaNV", "TenNV");
            cbo_KhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_LoaiHD.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_NhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_TrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_TrangThai.SelectedIndex = 0;
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
            txt_MaHD.ReadOnly = t;
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
            ds = c.LayDuLieu("select * from HoaDon");
            clearTextbox();
            txt_MaHD.Text = autoCode(ds, "P");
            XuLiTextBox(false);
            XuLiButton(false);
            txt_MaHD.ReadOnly = true;
            flag = 1;
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            XuLiTextBox(false);
            XuLiButton(false);
            txt_MaHD.ReadOnly = true;
            flag = 2;
        }
        string NgayThangNam(DateTimePicker dtp)
        {
            string NgayDayDu = "";
            string ngay = dtp.Value.Day.ToString();
            string thang = dtp.Value.Month.ToString();
            string nam = dtp.Value.Year.ToString();
            NgayDayDu = thang + "/" + ngay + "/" + nam;
            return NgayDayDu;
        }

        void them(object sender, EventArgs e, string m1, string m2, string m3, string m4, string m5, string m6 = "1")
        {

            try
            {
                if (m1.Trim() == "" || m2.Trim() == "" || m3.Trim() == "" || m4.Trim() == "" || m5.Trim() == "" )
                    throw new Exception("Vui lòng điền đủ thông tin");
                //string sql = "insert into HoaDon(MaHD,MaKH,NgayLap,MaLoaiHD,MaNV,TrangThai) values ('" + m1 + "',N'" + m2 + "',N'" + m3 + "','" + m4 + "',N'" + m5 + "',N'" + m6  + "')";
                //proc
                string sql = "EXEC them_hd @mahd = '" + m1 + "', @makh = '" + m2 + "', @ngaylap = '" + m3 + "', @maloaihd = N'" + m4 + "', @manv = '" + m5 + "';";
                if (c.CapNhatDulieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                    frm_HoaDon_Load(sender, e);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                c.DongKetNoi();
                btn_Them_Click(sender, e);
            }
        }
        void sua(object sender, EventArgs e, string m1 = "", string m2 = "", string m3 = "", string m4 = "", string m5 = "", string m6 = "")
        {
            try
            {
                string sql = "";
                if (txt_MaHD.Text == "")
                {
                    throw new Exception("Lỗi cập nhật\nHãy chắc chắn bạn chọn đúng cột muốn sửa");
                }
                //sql = "update HoaDon set ";
                //if (m1.Trim() != "")
                //    sql += " MaHD='" + m1 + "',";
                //if (m2.Trim() != "")
                //    sql += " MaKH='" + m2 + "',";
                //if (m3.Trim() != "")
                //    sql += " NgayLap=N'" + m3 + "',";
                //if (m4.Trim() != "")
                //    sql += " MaLoaiHD=N'" + m4 + "',";
                //if (m5.Trim() != "")
                //    sql += " MaNV='" + m5 + "',";
                //sql += " TrangThai='" + m6;
                //sql += "' where MaHD='" + Old_Value + "'";
                if (m1.Trim() == "" && m2.Trim() == "" && m3.Trim() == "" && m4.Trim() == "" && m5.Trim() == "")
                    sql = "update HoaDon set TrangThai = '" + 0 + "'where MaHD = '" + Old_Value + "'";
                else
                    sql = "EXEC sua_hd @mahd = '" + m1 + "', @makh = '" + m2 + "', @ngaylap = N'" + m3 + "', @maloaihd = N'" + m4 + "', @manv = '" + m5 + "', @trangthai = '" + m6 + "';";

                if (c.CapNhatDulieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                    frm_HoaDon_Load(sender, e);
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
            string m1 = txt_MaHD.Text;
            string m2 = cbo_KhachHang.SelectedValue.ToString();
            string m3 = NgayThangNam(dtp_NgayLap);
            string m4 = cbo_LoaiHD.SelectedValue.ToString();
            string m5 = cbo_NhanVien.SelectedValue.ToString();
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
                if (row.Cells["MaHD"].Value == DBNull.Value)
                {
                    txt_MaHD.Text = "";
                    btn_Sua.Enabled = false;
                    btn_Xoa.Enabled = false;
                }
                else
                {
                    txt_MaHD.Text = ds.Tables[0].Rows[vt]["MaHD"].ToString();
                    loadData_cboFromList(dt, cbo_KhachHang, "MaKH",vt);
                    loadData_cboFromList(dt, cbo_LoaiHD, "MaLoaiHD",vt);
                    loadData_cboFromList(dt, cbo_NhanVien, "MaNV",vt);
                    loadData_cboFromList(dt, cbo_TrangThai, "TrangThai",vt);
                    dtp_NgayLap.Value = DateTime.Parse(ds.Tables[0].Rows[vt]["NgayLap"].ToString());
                }
            }

        }
        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ds = c.LayDuLieu("select * from HoaDon  where TrangThai='1'");
            int vt = dgv_DanhSach.CurrentCell.RowIndex;
            hienThiTextBox(ds.Tables[0], vt);
            Old_Value = txt_MaHD.Text;
            
        }
        void clearTextbox()
        {
            txt_MaHD.Text = "";
            cbo_KhachHang.SelectedIndex = 0;
            cbo_LoaiHD.SelectedIndex = 0;
            cbo_NhanVien.SelectedIndex = 0;
            cbo_TrangThai.SelectedIndex = 0;
            dtp_NgayLap.Value = DateTime.Now;

        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            sua(sender, e);
            clearTextbox();
            //try
            //{
            //    if (txt_MaHD.Text == "")
            //        throw new Exception("Lỗi cập nhật\nHãy chắc chắn bạn chọn đúng cột muốn xoá");
            //    string sql = "DELETE from HoaDon where MaHD='" + Old_Value + "'";
            //    if (c.CapNhatDulieu(sql) > 0)
            //    {
            //        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
            //        frm_HoaDon_Load(sender, e);
            //        clearTextbox();
            //    }
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    frm_HoaDon_Load(sender, e);
            //}
        }

        private void dgv_DanhSach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ds = c.LayDuLieu("select * from HoaDon");

            if (dgv_DanhSach.CurrentRow != null)
            {
                DataGridViewRow row = dgv_DanhSach.CurrentRow;//get row at select row
                string m2 = row.Cells["MaKH"].Value == DBNull.Value ? "K01" : row.Cells["MaKH"].Value.ToString();
                string m3 = row.Cells["NgayLap"].Value == DBNull.Value ? "1/1/2020" : row.Cells["NgayLap"].Value.ToString();
                string m4 = row.Cells["MaLoaiHD"].Value == DBNull.Value ? "K01" : row.Cells["MaLoaiHD"].Value.ToString();
                string m5 = row.Cells["MaNV"].Value == DBNull.Value ? "Y03" : row.Cells["MaNV"].Value.ToString();
                string m1 = row.Cells["MaHD"].Value == DBNull.Value ? autoCode(ds, "P") : row.Cells["MaHD"].Value.ToString();

                if (row.Cells["MaHD"].Value == DBNull.Value)
                {
                    them(sender, e, m1, m2, m3, m4, m5);
                }
                else
                {
                    sua(sender, e, m1, m2, m3, m4, m5);
                }

            }
        }
    }
}
