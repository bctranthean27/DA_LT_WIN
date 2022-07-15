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
            dgv_DanhSach.Enabled = true;
            XuLiTextBox(true);
            XuLiButton(true,false,false,false);
            loadData_DataGrid(dgv_DanhSach, "select * from ChucVu where TrangThai = '1'");
        }
        void loadData_DataGrid(DataGridView d, string sql)
        {
            ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];

        }
        void XuLiTextBox(Boolean t)
        {
            txt_TenCV.ReadOnly = t;
        }
        void XuLiButton(bool key_them, bool key_xoa , bool key_sua , bool  key_luu)
        {
            btn_Them.Enabled = key_them;
            btn_Sua.Enabled = key_sua;
            btn_Xoa.Enabled = key_xoa;
            btn_Lưu.Enabled = key_luu;
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
            XuLiButton(false,false,false,true);
            dgv_DanhSach.Enabled = false;
            flag = 1;
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            XuLiTextBox(false);
            XuLiButton(false, false, false, true);
            dgv_DanhSach.Enabled=false;
            flag = 2;
        }
        void them(object sender,EventArgs e, string m1, string m2)
        {
            try
            {
                if (m1.Trim() == "" || m2.Trim() == "")
                    throw new Exception("Vui lòng điền đủ thông tin");
                //string sql = "insert into ChucVu(MaChucVu,TenChucVu,TrangThai) values ('" + m1 + "',N'" + m2 + "','" + m3 + "')";
                //proc
                string sql = "EXEC them_chuc_vu @machucvu = '" + m1 + "', @tenchucvu = N'" + m2 + "';";
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
            string sql = "";
            try
            {
                if (txt_MaCV.Text == "")
                {
                    throw new Exception("Lỗi cập nhật\nHãy chắc chắn bạn chọn đúng cột muốn sửa");
                }
                //string sql = "update ChucVu set ";
                //if (m1.Trim() != "")
                //    sql += " MaChucVu='" + m1;
                //if (m2.Trim() != "")
                //    sql += "',TenChucVu=N'" + m2;
                //sql += "',TrangThai='" + m3;
                //sql += "' where MaChucVu='" + Old_Value + "'";

                //proc
                if (m1.Trim() == "" && m2.Trim() == "")
                    sql = "update ChucVu set TrangThai = '" + 0 + "'where MaChucVu = '" + Old_Value +"'";
                else
                    sql = "EXEC sua_chuc_vu @machucvu = '" + m1 + "', @tenchucvu = N'" + m2 + "',@trangthai = '" + m3 + "';";
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
            XuLiButton(true,false,false,false);
            string m1 = txt_MaCV.Text;
            string m2 = txt_TenCV.Text;
            switch (flag)
            {
                case 1:
                    clearTextbox();
                    them(sender, e, m1, m2);
                    break;
                case 2:
                    
                    sua(sender, e, m1, m2, "1");
                    break;

            }
        }
        void hienThiTextBox(DataTable dt)
        {
            if (dgv_DanhSach.CurrentRow != null)
            {
                DataGridViewRow row = dgv_DanhSach.CurrentRow;
                if (row.Cells["MaChucVu"].Value == DBNull.Value)
                {
                    txt_MaCV.Text = "";
                    txt_TenCV.Text = "";
                    btn_Sua.Enabled = false;
                    btn_Xoa.Enabled = false;
                }
                else
                {
                    txt_MaCV.Text = row.Cells["MaChucVu"].Value.ToString();
                    txt_TenCV.Text = row.Cells["TenChucVu"].Value.ToString();
                }
            }



        }
        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = dgv_DanhSach.CurrentCell.RowIndex;
            hienThiTextBox(ds.Tables[0]);
            Old_Value = txt_MaCV.Text; // lấy giá trị cũ để sửa đổi
            XuLiButton(true, true, true, true);
        }
        void clearTextbox()
        {
            txt_MaCV.Text = "";
            txt_TenCV.Text = "";
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            sua(sender, e);
            clearTextbox();
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
        private void dgv_DanhSach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ds = c.LayDuLieu("select * from LoaiSanPham");
            if (dgv_DanhSach.CurrentRow != null)
            {
                DataGridViewRow row = dgv_DanhSach.CurrentRow;//get row at select row
                string val1 = row.Cells["TenChucVu"].Value == DBNull.Value ? "" : row.Cells["TenChucVu"].Value.ToString();
                string ma = row.Cells["MaChucVu"].Value == DBNull.Value ? "" : row.Cells["MaChucVu"].Value.ToString();
                if (row.Cells["MaChucVu"].Value == DBNull.Value)
                {
                    them(sender, null, autoCode(ds, "C"), val1);
                }
                else
                {
                    sua(sender, null, ma, val1, "1");
                }

            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
