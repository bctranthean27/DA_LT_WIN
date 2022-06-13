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
    public partial class frm_KhachHang : Form
    {
        cls_QLCHCAFE c = new cls_QLCHCAFE();
        int vt = 0;
        DataSet ds = new DataSet();
        int flag = 0;
        string Old_Value = "";
        public frm_KhachHang()
        {
            InitializeComponent();
        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            XuLiTextBox(true);
            XuLiButton(true);
            loadData_DataGrid(dgv_DanhSach, "select * from KhachHang where TrangThai ='1'");
            cbo_TrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_TrangThai.SelectedIndex = 0;
        }
        void loadData_DataGrid(DataGridView d, string sql)
        {
            ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];

        }
        void XuLiTextBox(Boolean t)
        {
            txt_MaKH.ReadOnly = t;
            txt_TenKH.ReadOnly = t;
            txt_DiaChi.ReadOnly = t;
            txt_DienThoai.ReadOnly = t;
            txt_Mail.ReadOnly = t;
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
            ds = c.LayDuLieu("select * from KhachHang");
            clearTextbox();
            txt_MaKH.Text = autoCode(ds, "H");
            XuLiTextBox(false);
            XuLiButton(false);
            txt_MaKH.ReadOnly = true;
            flag = 1;
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            XuLiTextBox(false);
            XuLiButton(false);
            txt_MaKH.ReadOnly = true;
            flag = 2;
        }
        void them(object sender, EventArgs e, string m1, string m2, string m3, string m4, string m5, string m6 = "1")
        {
            try
            {
                if (m1.Trim() == "" || m2.Trim() == "" || m3.Trim() == "" || m4.Trim() == "" || m5.Trim() == "")
                    throw new Exception("Vui lòng điền đủ thông tin");
                //string sql = "insert into KhachHang(MaKH,TenKH,DChi,SDT,Mail,TrangThai) values ('" + m1 + "',N'" + m2 + "',N'" + m3 + "','" + m4 + "',N'" + m5 + "','" + m6 + "')";
                //proc
                string sql = "EXEC them_khach_hang @makh = '" + m1 + "', @tenkh = N'" + m2 + "', @dchi = N'" + m3 + "', @sdt = '" + m4 + "', @mail = '" + m5 + "';";
                if (c.CapNhatDulieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                    frm_KhachHang_Load(sender, e);
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
                if (txt_MaKH.Text == "")
                {
                    throw new Exception("Lỗi cập nhật\nHãy chắc chắn bạn chọn đúng cột muốn sửa");
                }
                //string sql = "update KhachHang set ";
                //if (m1.Trim() != "")
                //    sql += " MaKH='" + m1 + "',";
                //if (m2.Trim() != "")
                //    sql += " TenKH=N'" + m2 + "',";if(m1.Trim() != "")
                //if(m3.Trim() != "")
                //sql += " DChi='" + m3 + "',";
                //if (m4.Trim() != "")
                //    sql += " SDT='" + m4 + "',";
                //if (m5.Trim() != "")
                //    sql += " Mail='" + m5 + "',";
                //sql += "TrangThai='" + m6;
                //sql += "' where MaKH='" + Old_Value + "'";
                if (m1.Trim() == "" && m2.Trim() == "" && m3.Trim() == "" && m4.Trim() == "" && m5.Trim() == "")
                    sql = "update KhachHang set TrangThai = '" + 0 + "'where MaKH = '" + Old_Value + "'";
                else
                    sql = "EXEC sua_khach_hang @makh = '" + m1 + "', @tenkh = N'" + m2 + "', @dchi = N'" + m3 + "', @sdt = '" + m4 + "', @mail = '" + m5 + "',@trangthai = '" + m6 + "';";
                if (c.CapNhatDulieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                    frm_KhachHang_Load(sender, e);
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
            string m1 = txt_MaKH.Text;
            string m2 = txt_TenKH.Text;
            string m3 = txt_DiaChi.Text;
            string m4 = txt_DienThoai.Text;
            string m5 = txt_Mail.Text;
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

        
        void loadData_cboFromList(DataTable dt, ComboBox cbo, string disMember)
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
                for (int i = 0; i < cbo.Items.Count; i++)
                {
                    if (cbo.ValueMember == value) cbo.SelectedIndex = i;
                }
            }
        }
        void hienThiTextBox(DataTable dt, int vt)
        {
            if (dgv_DanhSach.CurrentRow != null)
            {
                DataGridViewRow row = dgv_DanhSach.CurrentRow;
                if (row.Cells["MaKH"].Value == DBNull.Value)
                {
                    txt_MaKH.Text = "";
                    txt_TenKH.Text = "";
                    txt_DienThoai.Text = "";
                    txt_Mail.Text = "";
                    txt_DiaChi.Text = "";
                    btn_Sua.Enabled = false;
                    btn_Xoa.Enabled = false;
                }
                else
                {
                     txt_MaKH.Text = ds.Tables[0].Rows[vt]["MaKH"].ToString();
                     txt_TenKH.Text = ds.Tables[0].Rows[vt]["TenKH"].ToString();
                     txt_DienThoai.Text = ds.Tables[0].Rows[vt]["SDT"].ToString();
                     txt_Mail.Text = ds.Tables[0].Rows[vt]["Mail"].ToString();
                     txt_DiaChi.Text = ds.Tables[0].Rows[vt]["DChi"].ToString();
                     loadData_cboFromList(dt, cbo_TrangThai, "TrangThai");
                }
            }
            
        }
        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ds = c.LayDuLieu("select * from KhachHang where TrangThai = '1'");
            int vt = dgv_DanhSach.CurrentCell.RowIndex;
            hienThiTextBox(ds.Tables[0], vt);
            Old_Value = txt_MaKH.Text; // lấy giá trị cũ để sửa đổi
        }
        void clearTextbox()
        {
            txt_MaKH.Text = "";
            txt_TenKH.Text = "";
            txt_DiaChi.Text = "";
            txt_Mail.Text = "";
            txt_DienThoai.Text = "";
            cbo_TrangThai.SelectedIndex = 0;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            sua(sender, e);
            //try
            //{
            //    if (txt_MaKH.Text == "")
            //        throw new Exception("Lỗi cập nhật\nHãy chắc chắn bạn chọn đúng cột muốn xoá");
            //    string sql = "DELETE from KhachHang where MaKH='" + Old_Value + "'";
            //    if (c.CapNhatDulieu(sql) > 0)
            //    {
            //        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
            //        frm_KhachHang_Load(sender, e);
            //        clearTextbox();
            //    }
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    frm_KhachHang_Load(sender, e);
            //}
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dgv_DanhSach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ds = c.LayDuLieu("select * from KhachHang");
            if (dgv_DanhSach.CurrentRow != null)
            {
                DataGridViewRow row = dgv_DanhSach.CurrentRow;//get row at select row
                string val1 = row.Cells["TenKH"].Value == DBNull.Value ? "" : row.Cells["TenKH"].Value.ToString();
                string val2 = row.Cells["DChi"].Value == DBNull.Value ? "" : row.Cells["DChi"].Value.ToString();
                string val3 = row.Cells["SDT"].Value == DBNull.Value ? "" : row.Cells["SDT"].Value.ToString();
                string val4 = row.Cells["Mail"].Value == DBNull.Value ? "" : row.Cells["Mail"].Value.ToString();

                string val5 = row.Cells["TrangThai"].Value == DBNull.Value ? "" : row.Cells["TrangThai"].Value.ToString();
                string ma = row.Cells["MaKH"].Value == DBNull.Value ? "" : row.Cells["MaKH"].Value.ToString();
                if (row.Cells["MaKH"].Value == DBNull.Value)
                {
                    
                    string sql = "EXEC them_khach_hang @makh = '" + autoCode(ds, "H") + "', @tenkh = N'" + val1 + "', @dchi = N'" + val2 + "', @sdt = '" + val3 + "', @mail = '" + val4 + "';";
                    if (c.CapNhatDulieu(sql) > 0)
                        frm_KhachHang_Load(sender, e);
                }
                else
                {
                    sua(sender, null, ma, val1, val2, val3, val4, val5);
                }

            }
        }
    }
}
