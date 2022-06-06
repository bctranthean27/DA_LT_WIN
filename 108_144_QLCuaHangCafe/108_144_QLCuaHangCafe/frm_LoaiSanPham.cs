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
    public partial class frm_LoaiSanPham : Form
    {
        cls_QLCHCAFE c = new cls_QLCHCAFE();
        int vt = 0;
        DataSet ds = new DataSet();
        int flag = 0;
        string Old_Value = "";
        public frm_LoaiSanPham()
        {
            InitializeComponent();
        }
        void XuLiTextBox(Boolean t)
        {
            txt_MaLoaiSP.ReadOnly = t;
            txt_TenLoaiSP.ReadOnly = t;
            cbo_TrangThai.Enabled = !t;
        }
        void XuLiButton(Boolean t)
        {
            btn_Them.Enabled = t;
            btn_Sua.Enabled = t;
            btn_Xoa.Enabled = t;
            btn_Luu.Enabled = !t;
        }

        private void frm_LoaiSanPham_Load(object sender, EventArgs e)
        {
            XuLiTextBox(true);
            XuLiButton(true);
            loadData_DataGrid(dgv_DanhSach, "select * from LoaiSanPham where TrangThai='1'");
            cbo_TrangThai.SelectedIndex = 0;
            cbo_TrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        void loadData_DataGrid(DataGridView d, string sql)
        {

            ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];

        }
        string autoCode(DataSet ds,string pri)
        {
            string code = pri;
            int pos = ds.Tables[0].Rows.Count + 1;
            if (pos < 10) code += "0" + pos.ToString();
            else if (pos < 100) code += "" + pos.ToString();
            return code ;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            ds = c.LayDuLieu("select * from LoaiSanPham");
            clearTextbox();
            txt_MaLoaiSP.Text = autoCode(ds,"L");
            XuLiTextBox(false);
            XuLiButton(false);
            txt_MaLoaiSP.ReadOnly = true;
            flag = 1;
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            XuLiTextBox(false);
            XuLiButton(false);
            
            flag = 2;
            txt_MaLoaiSP.ReadOnly = true;
        }
        void them(object sender, EventArgs e, string m1, string m2, string m3 = "1")
        {
            try
            {
                if (m1.Trim() == "" || m2.Trim() == "")
                    throw new Exception("Vui lòng điền đủ thông tin");
                //string sql = "insert into LoaiSanPham(MaLoai,TenLoai,TrangThai) values ('" + m1 + "',N'" + m2 + "','" + m3 + "')";
                //proc
                string sql = "EXEC them_loai_sp @maloai = '" + m1 + "', @tenloai = N'" + m2 + "';";
                if (c.CapNhatDulieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                    frm_LoaiSanPham_Load(sender, e);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                c.DongKetNoi();
                btn_Them_Click(sender, e);

            }
        }
        void sua(object sender, EventArgs e, string m1 ="" , string m2 = "" , string m3 = "0")
        {
            try
            {
                string sql = "";
                if (txt_MaLoaiSP.Text == "")
                {
                    throw new Exception("Lỗi cập nhật\nHãy chắc chắn bạn chọn đúng cột muốn sửa");
                }
                //sql = "update LoaiSanPham set ";
                //if (m1.Trim() != "")
                //    sql += " MaLoai='" + m1 + "', ";
                //if (m2.Trim() != "")
                //    sql += "TenLoai=N'" + m2 + "', ";
                //sql += "TrangThai='" + m3 + "'";
                //sql += " where MaLoai='" + Old_Value + "'";

                //proc
                if (m1.Trim() == "" && m2.Trim() == "")
                    sql = "update LoaiSanPham set TrangThai = '" + 0 + "'where MaLoai = '" + Old_Value + "'";
                else
                    sql = "EXEC sua_loai_sp @maloai = '" + m1 + "', @tenloai = N'" + m2 + "',@trangthai = '" + m3 + "';";
                if (c.CapNhatDulieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                    frm_LoaiSanPham_Load(sender, e);
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
            string m1 = txt_MaLoaiSP.Text;
            string m2 = txt_TenLoaiSP.Text;
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
            
            txt_MaLoaiSP.Text = ds.Tables[0].Rows[vt]["MaLoai"].ToString();
            txt_TenLoaiSP.Text = ds.Tables[0].Rows[vt]["TenLoai"].ToString();
            loadData_cboFromList(dt, cbo_TrangThai, "TrangThai");

        }
        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                ds = c.LayDuLieu("select * from LoaiSanPham where TrangThai = '1'");
                int vt = dgv_DanhSach.CurrentCell.RowIndex;
                hienThiTextBox(ds.Tables[0], vt);
                Old_Value = txt_MaLoaiSP.Text; // lấy giá trị cũ để sửa đổi
            }
            catch (Exception err)
            {
                MessageBox.Show("Vui lòng không chọn dòng trống", "Thông báo", MessageBoxButtons.OK);
            }


        }
        void clearTextbox()
        {
            txt_MaLoaiSP.Text = "";
            txt_TenLoaiSP.Text = "";
            cbo_TrangThai.SelectedIndex = 0;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            sua(sender, e);
            clearTextbox();
            //try
            //{
            //    if (txt_MaLoaiSP.Text == "")
            //        throw new Exception("Lỗi cập nhật\nHãy chắc chắn bạn chọn đúng cột muốn xoá");
            //    string sql = "DELETE from LoaiSanPham where MaLoai='" + Old_Value + "'";
            //    if (c.CapNhatDulieu(sql) > 0)
            //    {
            //        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
            //        frm_LoaiSanPham_Load(sender, e);
            //        clearTextbox();
            //    }
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    frm_LoaiSanPham_Load(sender, e);
            //}
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
