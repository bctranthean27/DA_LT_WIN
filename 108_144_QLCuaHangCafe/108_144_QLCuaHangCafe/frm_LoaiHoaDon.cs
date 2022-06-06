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
    public partial class frm_LoaiHoaDon : Form
    {
        cls_QLCHCAFE c = new cls_QLCHCAFE();
        int vt = 0;
        DataSet ds = new DataSet();
        int flag = 0;
        string Old_Value = "";
        public frm_LoaiHoaDon()
        {
            InitializeComponent();
        }

        private void frm_LoaiHoaDon_Load(object sender, EventArgs e)
        {
            XuLiTextBox(true);
            XuLiButton(true);
            loadData_DataGrid(dgv_DanhSach, "select * from LoaiHoaDon where TrangThai='1'");
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
            txt_MaLoaiHD.ReadOnly = t;
            txt_TenLoaiHD.ReadOnly = t;
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
            ds = c.LayDuLieu("select * from LoaiHoaDon");
            clearTextbox();
            txt_MaLoaiHD.Text = autoCode(ds, "K");
            XuLiTextBox(false);
            XuLiButton(false);
            txt_MaLoaiHD.ReadOnly = true;
            flag = 1;
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            XuLiTextBox(false);
            XuLiButton(false);
            txt_MaLoaiHD.ReadOnly = true;
            flag = 2;
        }
        void them(object sender, EventArgs e, string m1, string m2)
        {
            try
            {
                if (m1.Trim() == "" || m2.Trim() == "")
                    throw new Exception("Vui lòng điền đủ thông tin");
                //string sql = "insert into LoaiHoaDon(MaLoaiHD,TenLoaiHD,TrangThai) values ('" + m1 + "',N'" + m2 + "','" + 1 + "')";
                //proc
                string sql = "EXEC them_loai_hd @maloaihd = '" + m1 + "', @tenloaihd = N'" + m2 + "';";

                if (c.CapNhatDulieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                    frm_LoaiHoaDon_Load(sender, e);
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
            try
            {

                string sql = "";
                if (txt_MaLoaiHD.Text == "")
                {
                    throw new Exception("Lỗi cập nhật\nHãy chắc chắn bạn chọn đúng cột muốn sửa");
                }
                //sql = "update LoaiHoaDon set ";
                //if (m1.Trim() != "")
                //    sql += " MaLoaiHD='" + m1 + "',";
                //if (m2.Trim() != "")
                //    sql += " TenLoaiHD=N'" + m2 + "',";
                //sql += "TrangThai='" + m3 + "' ";
                //sql += "where MaLoaiHD='" + Old_Value + "'";
                if (m1.Trim() == "" && m2.Trim() == "")
                    sql = "update LoaiHoaDon set TrangThai = '" + 0 + "'where MaLoaiHD = '" + Old_Value + "'";
                else
                    sql = "EXEC sua_loai_hd @maloaihd = '" + m1 + "', @tenloaihd = N'" + m2 + "',@trangthai = '" + m3 + "';";

                if (c.CapNhatDulieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                    frm_LoaiHoaDon_Load(sender, e);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                c.DongKetNoi();
                btn_Sua_Click(sender, e);
            }
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            XuLiTextBox(true);
            XuLiButton(true);
            string m1 = txt_MaLoaiHD.Text;
            string m2 = txt_TenLoaiHD.Text;
            string m3 = cbo_TrangThai.SelectedItem.ToString();
            switch (flag)
            {
                case 1:
                    clearTextbox();
                    them(sender, e, m1, m2);
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
            txt_MaLoaiHD.Text = ds.Tables[0].Rows[vt]["MaLoaiHD"].ToString();
            txt_TenLoaiHD.Text = ds.Tables[0].Rows[vt]["TenLoaiHD"].ToString();
            loadData_cboFromList(dt, cbo_TrangThai, "TrangThai");
        }
        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ds = c.LayDuLieu("select * from LoaiHoaDon where TrangThai='1'");
            int vt = dgv_DanhSach.CurrentCell.RowIndex;
            hienThiTextBox(ds.Tables[0], vt);
            Old_Value = txt_MaLoaiHD.Text; // lấy giá trị cũ để sửa đổi
        }
        void clearTextbox()
        {
            txt_MaLoaiHD.Text = "";
            txt_TenLoaiHD.Text = "";
            cbo_TrangThai.SelectedIndex = 0;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            sua(sender, e);
            clearTextbox();
            //try
            //{
            //    if (txt_MaLoaiHD.Text == "")
            //        throw new Exception("Lỗi cập nhật\nHãy chắc chắn bạn chọn đúng cột muốn xoá");
            //    string sql = "DELETE from LoaiHoaDon where MaLoaiHD='" + Old_Value + "'";
            //    if (c.CapNhatDulieu(sql) > 0)
            //    {
            //        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
            //        frm_LoaiHoaDon_Load(sender, e);
            //        clearTextbox();
            //    }
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    frm_LoaiHoaDon_Load(sender, e);
            //}
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
