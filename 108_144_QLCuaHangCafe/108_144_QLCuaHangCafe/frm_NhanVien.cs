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
    public partial class frm_NhanVien : Form
    {
        cls_QLCHCAFE c = new cls_QLCHCAFE();
        int vt = 0;
        DataSet ds = new DataSet();
        int flag = 0;
        string Old_Value = "";
        public frm_NhanVien()
        {
            InitializeComponent();
        }
        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            XuLiTextBox(true);
            XuLiButton(true);
            loadData_DataGrid(dgv_DanhSach, "select * from NhanVien where TrangThai='1'");
            loadData_cbo(cbo_ChucVu, "select MaChucVu,TenChucVu from ChucVu where TrangThai='1'", "MaChucVu", "TenChucVu");
            cbo_TrangThai.SelectedIndex = 0;
            cbo_TrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_ChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_ChucVu.SelectedIndex = 1;
        }
        void loadData_DataGrid(DataGridView d, string sql)
        {
            ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];

        }
        void loadData_cbo(ComboBox cbo, string sql, string valMember, string disMember)
        {
            ds = c.LayDuLieu(sql);
            cbo.DataSource = ds.Tables[0];
            cbo.ValueMember = valMember;
            cbo.DisplayMember = disMember; 
        }
        void XuLiTextBox(Boolean t)
        {
            txt_TenNV.ReadOnly = t;
            txt_HoNV.ReadOnly = t;
            txt_MaNV.ReadOnly = t;
            txt_DiaChi.ReadOnly = t;
            cbo_ChucVu.Enabled = !t;
            cbo_TrangThai.Enabled = !t;
            dtp_NgayVaoLam.Enabled = !t;
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
            else if (pos < 100) code += pos.ToString();
            return code;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            ds = c.LayDuLieu("select * from NhanVien");
            clearTextbox();
            txt_MaNV.Text = autoCode(ds, "Y");
            XuLiTextBox(false);
            XuLiButton(false);
            txt_MaNV.ReadOnly = true;
            flag = 1;
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            XuLiTextBox(false);
            XuLiButton(false);
            flag = 2;
            txt_MaNV.ReadOnly = true;
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

        void them(object sender, EventArgs e, string m1, string m2, string m3, string m4, string m5, string m6, string roles, string m7  = "1")
        {
            DataSet dstk = c.LayDuLieu("select * from TaiKhoan");
            string maTK = autoCode(dstk, "TK");
            string taiKhoan = m1.ToUpper() + "@gmail.com";
            string matKhau = "123";
            try
            {
                if (m1.Trim() == "" )
                    throw new Exception("Vui lòng điền đủ thông tin");
                //string sql = "insert into NhanVien(MaNV,HoNV,TenNV,DChi,NgayVaolam,MaChucVu,TrangThai) values ('" + m1 + "',N'" + m2 + "',N'" + m3 + "',N'" + m4 + "',N'" + m5 + "',N'" + m6 + "','" + m7 + "')";
                //proc
                
                string sql = "EXEC them_nhan_vien @manv = '" + m1 + "', @honv = N'" + m2 + "', @tennv = N'" + m3 + "', @dchi = N'" + m4 + "', @ngayvaolam = '" + m5 + "', @machucvu = '" + m6 + "', @roles = '" + roles + "';";
                string sql_role = "EXEC tao_tai_khoan @matk = '" + maTK + "', @taikhoan = N'" + taiKhoan + "', @mk = N'" + matKhau + "', @manv = N'" + m1 + "', @trangthai = N'" + 1 +  "';";


                if (c.CapNhatDulieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật nhân viên thành công", "Thông báo", MessageBoxButtons.OK);
                    frm_NhanVien_Load(sender, e);
                }
                if (c.CapNhatDulieu(sql_role) > 0)
                {
                    MessageBox.Show("Cập nhật tài khoản thành công", "Thông báo", MessageBoxButtons.OK);
                    frm_NhanVien_Load(sender, e);
                }

                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                c.DongKetNoi();
                btn_Them_Click(sender, e);
            }
        }
        void sua(object sender, EventArgs e, string m1 = "", string m2 = "", string m3 = "", string m4 = "", string m5 = "", string m6 = "",string roles = "")
        {
            
            try
            {
                string sql = "";
                string sql_role = "";
                if (txt_MaNV.Text == "")
                {
                    throw new Exception("Lỗi cập nhật\nHãy chắc chắn bạn chọn đúng cột muốn sửa");
                }
                //sql = "update NhanVien set ";
                //if (m1.Trim() != "")
                //    sql += " MaNV='" + m1 + "',";
                //if (m2.Trim() != "")
                //    sql += " HoNV=N'" + m2 + "',";
                //if (m3.Trim() != "")
                //    sql += " TenNV=N'" + m3 + "',";
                //if (m4.Trim() != "")
                //    sql += " DChi=N'" + m4 + "',";
                //if (m5.Trim() != "")
                //    sql += " NgayVaoLam=N'" + m5 + "',";
                //if (m6.Trim() != "")
                //    sql += " MaChucVu='" + m6 + "',";
                //sql += " TrangThai='" + m7;
                //sql += "' where MaNV='" + Old_Value + "'";
                if (m1.Trim() == "" && m2.Trim() == "" && m3.Trim() == "" && m4.Trim() == "" && m5.Trim() == "" && m6.Trim() == "" && roles.Trim() == "")
                {
                    sql = "update NhanVien set TrangThai = '" + 0 + "'where MaNV = '" + Old_Value + "'";
                    sql_role = "update TaiKhoan set TrangThai = '" + 0 + "'where MaNV = '" + Old_Value + "'";
                }
                else
                {
                    sql = "EXEC sua_nhan_vien @manv = '" + m1 + "', @honv = N'" + m2 + "', @tennv = N'" + m3 + "', @dchi = N'" + m4 + "', @ngayvaolam = '" + m5 + "', @machucvu = '" + m6 + "', @roles = '" + roles + "', @trangthai = '" + 1 + "';";

                }
                if (c.CapNhatDulieu(sql) > 0 )
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                    frm_NhanVien_Load(sender, e);
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
            string m1 = txt_MaNV.Text;
            string m2 = txt_HoNV.Text;
 void loadData_cboFromList(DataTable dt, ComboBox cbo, string disMember,int vt)
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
                foreach(DataRowView rowView in cbo.Items)
                {
                    string val = rowView.Row[0].ToString();
                    string name = rowView.Row[1].ToString();
                    if(val == value)
                    {
                        cbo.Text = name;
                        break;
                    }

                }
            }
        }           string m3 = txt_TenNV.Text;
            string m4 = txt_DiaChi.Text;
            string m5 = NgayThangNam(dtp_NgayVaoLam);
            string m6 = cbo_ChucVu.SelectedValue.ToString();
            string roles = "";
            if (m6 == "C01") roles = "QL";
            if (m6 == "C02") roles = "NV";
            string m7 = cbo_TrangThai.SelectedItem.ToString();
            switch (flag)
            {
                case 1:
                    clearTextbox();
                    them(sender, e, m1, m2, m3, m4, m5, m6, roles);
                    break;
                case 2:
                    sua(sender, e, m1, m2, m3, m4, m5, m6, roles);
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
                if (row.Cells["MaNV"].Value == DBNull.Value)
                {
                    txt_MaNV.Text = "";
                    txt_HoNV.Text = "";
                    txt_TenNV.Text = "";
                    txt_DiaChi.Text = "";
                    btn_Sua.Enabled = false;
                    btn_Xoa.Enabled = false;
                }
                else
                {
                    txt_MaNV.Text = dt.Rows[vt]["MaNV"].ToString();
                    txt_HoNV.Text = dt.Rows[vt]["HoNV"].ToString();
                    txt_TenNV.Text = dt.Rows[vt]["TenNV"].ToString();
                    txt_DiaChi.Text = dt.Rows[vt]["DChi"].ToString();
                    loadData_cboFromList(dt, cbo_ChucVu, "MaChucVu", vt);
                    loadData_cboFromList(dt, cbo_TrangThai, "TrangThai", vt);
                    dtp_NgayVaoLam.Value = DateTime.Parse(dt.Rows[vt]["NgayVaoLam"].ToString());
                }
            }

        }
        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ds = c.LayDuLieu("select * from NhanVien where TrangThai='1'");
            int vt = dgv_DanhSach.CurrentCell.RowIndex;
            hienThiTextBox(ds.Tables[0], vt);
            Old_Value = txt_MaNV.Text; // lấy giá trị cũ để sửa đổi
        }
        void clearTextbox()
        {
            txt_MaNV.Text = "";
            txt_HoNV.Text = "";
            txt_TenNV.Text = "";
            txt_DiaChi.Text = "";
            cbo_TrangThai.SelectedIndex = 0;
            dtp_NgayVaoLam.Value = DateTime.Now;
            cbo_TrangThai.SelectedIndex = 0;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            sua(sender, e);
            clearTextbox();
            //try
            //{
            //    if (txt_MaNV.Text == "")
            //        throw new Exception("Lỗi cập nhật\nHãy chắc chắn bạn chọn đúng cột muốn xoá");
            //    string sql = "DELETE from NhanVien where MaNV='" + Old_Value + "'";
            //    if (c.CapNhatDulieu(sql) > 0)
            //    {
            //        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
            //        frm_NhanVien_Load(sender, e);
            //        clearTextbox();
            //    }
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    frm_NhanVien_Load(sender, e);
            //}
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dgv_DanhSach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ds = c.LayDuLieu("select * from NhanVien");
            DataSet dstk = c.LayDuLieu("select * from TaiKhoan");
            
            if (dgv_DanhSach.CurrentRow != null)
            {
                DataGridViewRow row = dgv_DanhSach.CurrentRow;//get row at select row
                string m2 = row.Cells["HoNV"].Value == DBNull.Value ? "" : row.Cells["HoNV"].Value.ToString();
                string m3 = row.Cells["TenNV"].Value == DBNull.Value ? "" : row.Cells["TenNV"].Value.ToString();
                string m4 = row.Cells["DChi"].Value == DBNull.Value ? "" : row.Cells["DChi"].Value.ToString();
                string m5 = row.Cells["NgayVaoLam"].Value == DBNull.Value ? "1/1/2000" : row.Cells["NgayVaoLam"].Value.ToString();
                string m6 = row.Cells["MaChucVu"].Value == DBNull.Value ? "C02" : row.Cells["MaChucVu"].Value.ToString();
                string roles = "";
                if (m6 == "C01") roles = "QL";
                if (m6 == "C02") roles = "NV";
                string m1 = row.Cells["MaNV"].Value == DBNull.Value ? autoCode(ds, "Y") : row.Cells["MaNV"].Value.ToString();

                if (row.Cells["MaNV"].Value == DBNull.Value)
                {
                    them(sender,null, m1, m2, m3, m4, m5, m6,roles);
                }
                else
                {
                    sua(sender, null, m1, m2, m3, m4, m5, m6, roles);
                }

            }
        }
    }
}
