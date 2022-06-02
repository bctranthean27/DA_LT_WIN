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
    
    public partial class frm_ChucVu : Form
    {
        cls_QLCHCAFE c = new cls_QLCHCAFE();
        int vt = 0;
        DataSet ds = new DataSet();
        int flag = 0;
        string Old_Value = "";
        public frm_ChucVu()
        {
            InitializeComponent();
        }

        
        private void frm_ChucVu_Load(object sender, EventArgs e)
        {
            XuLiTextBox(true);
            XuLiButton(true);
            loadData_DataGrid(dgv_DanhSach, "select * from ChucVu where TrangThai = '1'");
            cbo_TrangThai.SelectedIndex = 0;
            cbo_TrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        void loadData_DataGrid(DataGridView d, string sql)
        {
            ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];

        }
        void XuLiTextBox(Boolean t)
        {
            txt_MaCV.ReadOnly = t;
            txt_TenCV.ReadOnly = t;
            cbo_TrangThai.Enabled = !t;
        }
        void XuLiButton(Boolean t)
        {
            btn_Them.Enabled = t;
            btn_Sua.Enabled = t;
            btn_Xoa.Enabled = t;
            btn_Lưu.Enabled = !t;
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
            ds = c.LayDuLieu("select * from ChucVu");
            clearTextbox();
            txt_MaCV.Text = autoCode(ds,"C");
            XuLiTextBox(false);
            XuLiButton(false);
            txt_MaCV.ReadOnly = true;
            flag = 1;
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            XuLiTextBox(false);
            XuLiButton(false);
            btn_Lưu.Enabled = true;
            flag = 2;
        }
        void them(object sender,EventArgs e, string m1, string m2, string m3 = "1")
        {
            try
            {
                if (m1.Trim() == "" || m2.Trim() == "")
                    throw new Exception("Vui lòng điền đủ thông tin");
                string sql = "insert into ChucVu(MaChucVu,TenChucVu,TrangThai) values ('" + m1 + "',N'" + m2 + "','" + m3 + "')";
                if (c.CapNhatDulieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                    frm_ChucVu_Load(sender, e);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                c.DongKetNoi();
                btn_Them_Click(sender, e);
                
            }
        }
        void sua(object sender, EventArgs e, string m1 = "", string m2 = "", string m3 = "0")
        {
            string sql = "update ChucVu set ";
            try
            {
                if (txt_MaCV.Text == "")
                {
                    throw new Exception("Lỗi cập nhật\nHãy chắc chắn bạn chọn đúng cột muốn sửa");
                }
                if (m1.Trim() != "")
                    sql += " MaChucVu='" + m1;
                if (m2.Trim() != "")
                    sql += "',TenChucVu=N'" + m2;
                sql += "',TrangThai='" + m3;
                sql += "' where MaChucVu='" + Old_Value + "'";

                if (c.CapNhatDulieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                    frm_ChucVu_Load(sender, e);
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_Sua_Click(sender, e);
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            XuLiTextBox(true);
            XuLiButton(true);
            string m1 = txt_MaCV.Text;
            string m2 = txt_TenCV.Text;
            string m3 = cbo_TrangThai.SelectedItem.ToString();
            switch (flag)
            {
                case 1:
                    clearTextbox();
                    them(sender, e, m1, m2, m3);
                    break;
                case 2:
                    
                    sua(sender, e, m1, m2, m3);
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
            txt_MaCV.Text = dt.Rows[vt]["MaChucVu"].ToString();
            txt_TenCV.Text = dt.Rows[vt]["TenChucVu"].ToString();
            loadData_cboFromList(dt, cbo_TrangThai, "TrangThai");
        }
        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int vt = dgv_DanhSach.CurrentCell.RowIndex;
                hienThiTextBox(ds.Tables[0], vt);
                Old_Value = txt_MaCV.Text; // lấy giá trị cũ để sửa đổi
            }
            catch (Exception err)
            {
                MessageBox.Show("Vui lòng không chọn dòng trống", "Thông báo", MessageBoxButtons.OK);
            }
        }
        void clearTextbox()
        {
            txt_MaCV.Text = "";
            txt_TenCV.Text = "";
            cbo_TrangThai.SelectedIndex = 0;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string m1 = txt_MaCV.Text;
            string m2 = txt_TenCV.Text;
            string m3 = cbo_TrangThai.SelectedItem.ToString();
            sua(sender, e);
            //try
            //{
            //    if (txt_MaCV.Text == "")
            //        throw new Exception("Lỗi cập nhật\nHãy chắc chắn bạn chọn đúng cột muốn xoá");
            //    string sql = "DELETE from ChucVu where MaChucVu='" + Old_Value + "'";
            //    if (c.CapNhatDulieu(sql) > 0)
            //    {
            //        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
            //        frm_ChucVu_Load(sender, e);
            //        clearTextbox();
            //    }
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    frm_ChucVu_Load(sender, e);
            //}
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
