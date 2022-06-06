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

    public partial class frm_NCC : Form
    {
        cls_QLCHCAFE c = new cls_QLCHCAFE();
        int vt = 0;
        DataSet ds = new DataSet();
        int flag = 0;
        string Old_Value = "";
        public frm_NCC()
        {

            InitializeComponent();
        }
        private void frm_NCC_Load(object sender, EventArgs e)
        {
            XuLiTextBox(true);
            XuLiButton(true);
            loadData_DataGrid(dgv_DanhSach, "select * from NhaCungCap where TrangThai = '1'");
            cbo_TrangThai.SelectedIndex = 0;
            cbo_TrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        void loadData_DataGrid(DataGridView d, string sql)
        {
            ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];

        }
        void loadData_cboFromList(DataTable dt,ComboBox cbo,string disMember)
        {
            string value = dt.Rows[vt][disMember].ToString();
            for (int i = 0; i < cbo.Items.Count; i++) 
            {
                if(cbo.Items[i].ToString() == value) cbo.SelectedIndex = i;
            }
        }
        void XuLiTextBox(Boolean t)
        {
            txt_NCC.ReadOnly = t;
            txt_TenNCC.ReadOnly = t;
            txt_DiaChiMail.ReadOnly = t;
            txt_DienThoai.ReadOnly = t;
            txt_DiaChi.ReadOnly = t;
            cbo_TrangThai.Enabled = !t;
        }
        void XuLiButton(Boolean t)
        {
            btn_Them.Enabled = t;
            btn_Sua.Enabled = t;
            btn_Xoa.Enabled = t;
            btn_Luu.Enabled = !t;
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
            ds = c.LayDuLieu("select * from NhaCungCap");
            clearTextbox();
            txt_NCC.Text = autoCode(ds, "N");
            XuLiTextBox(false);
            XuLiButton(false);
            txt_NCC.ReadOnly = true;  
            flag = 1;
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            XuLiTextBox(false);
            XuLiButton(false);
            btn_Luu.Enabled = true;
            flag = 2;
        }
        void them(object sender, EventArgs e, string m1, string m2, string m3, string m4, string m5, string m6 = "1")
        {
            try
            {
                if (m1.Trim() == "" || m2.Trim() == "" || m3.Trim() == "" || m4.Trim() == "" || m5.Trim() == "")
                    throw new Exception("Vui lòng điền đủ thông tin");
                //string sql = "insert into NhaCungCap(MaNCC,TenNCC,SDT,Mail,DChi,TrangThai) values ('" + m1 + "',N'" + m2 + "',N'" + m3 + "','" + m4 + "',N'" + m5 + "','" + m6 + "')";
                //proc
                    string sql = "EXEC them_ncc @mancc = '" + m1 + "', @tenncc = N'" + m2 + "', @dchi = N'" + m3 + "', @sdt = '" + m4 + "', @mail = '" + m5 + "';";
                if (c.CapNhatDulieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                    frm_NCC_Load(sender, e);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                c.DongKetNoi();
                btn_Them_Click(sender, e);
            }
        }
        void sua(object sender, EventArgs e, string m1 = "", string m2 = "", string m3 = "", string m4 = "", string m5 = "" , string m6 = "0")
        {
            try
            {
                string sql = "";
                if (txt_NCC.Text == "")
                {
                    throw new Exception("Lỗi cập nhật\nHãy chắc chắn bạn chọn đúng cột muốn sửa");
                }
                //sql = "update NhaCungCap set ";
                //if (m1.Trim() != "")
                //    sql += " MaNCC='" + m1 + "',";
                //if (m2.Trim() != "")
                //    sql += " TenNCC=N'" + m2 + "',";
                //if (m3.Trim() != "")
                //    sql += " SDT='" + m3 + "',";
                //if (m4.Trim() != "")
                //    sql += " Mail='" + m4 + "',";
                //if (m5.Trim() != "")
                //    sql += " DChi=N'" + m5 + "',";
                //sql += "TrangThai='" + m6;
                //sql += "' where MaNCC='" + Old_Value + "'";
                if (m1.Trim() == "" && m2.Trim() == "" && m3.Trim() == "" && m4.Trim() == "" && m5.Trim() == "")
                    sql = "update NhaCungCap set TrangThai = '" + 0 + "'where MaNCC = '" + Old_Value + "'";
                else
                    sql = "EXEC sua_ncc @mancc = '" + m1 + "', @tenncc = N'" + m2 + "', @dchi = N'" + m3 + "', @sdt = '" + m4 + "', @mail = '" + m5 + "',@trangthai = '" + m6 + "';";
                if (c.CapNhatDulieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                    frm_NCC_Load(sender, e);
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
            string m1 = txt_NCC.Text;
            string m2 = txt_TenNCC.Text;
            string m3 = txt_DienThoai.Text;
            string m4 = txt_DiaChiMail.Text;
            string m5 = txt_DiaChi.Text;
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

        
        void hienThiTextBox(DataTable dt, int vt)
        {
            txt_NCC.Text = dt.Rows[vt]["MaNCC"].ToString();
            txt_DiaChi.Text = dt.Rows[vt]["DChi"].ToString();
            txt_DiaChiMail.Text = dt.Rows[vt]["Mail"].ToString();
            txt_DienThoai.Text = dt.Rows[vt]["SDT"].ToString();
            txt_TenNCC.Text = dt.Rows[vt]["TenNCC"].ToString();
            loadData_cboFromList(dt, cbo_TrangThai, "TrangThai");

        }
        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = dgv_DanhSach.CurrentCell.RowIndex;
            hienThiTextBox(ds.Tables[0], vt);
            Old_Value = txt_NCC.Text; // lấy giá trị cũ để sửa đổi
        }
        void clearTextbox()
        {
            txt_NCC.Text = "";
            txt_TenNCC.Text = "";
            txt_DiaChi.Text = "";
            txt_DiaChiMail.Text = "";
            txt_DienThoai.Text = "";
            cbo_TrangThai.SelectedIndex = 0;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            sua(sender, e);
            clearTextbox();
            //try
            //{
            //    if (txt_NCC.Text == "")
            //        throw new Exception("Lỗi cập nhật\nHãy chắc chắn bạn chọn đúng cột muốn xoá");
            //    string sql = "DELETE from NhaCungCap where MaNCC='" + Old_Value + "'";
            //    if (c.CapNhatDulieu(sql) > 0)
            //    {
            //        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
            //        frm_NCC_Load(sender, e);
            //        clearTextbox();
            //    }
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    frm_NCC_Load(sender, e);
            //}
        }

        private void Btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
