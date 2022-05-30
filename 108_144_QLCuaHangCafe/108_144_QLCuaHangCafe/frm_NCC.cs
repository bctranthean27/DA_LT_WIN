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
            loadData_DataGrid(dgv_DanhSach, "select * from NhaCungCap");
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
        private void btn_Them_Click(object sender, EventArgs e)
        {
            
            XuLiTextBox(false);
            XuLiButton(false);
            flag = 1;
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            XuLiTextBox(false);
            XuLiButton(false);
            btn_Luu.Enabled = true;
            flag = 2;
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
                    {
                        try
                        {
                            string sql = "insert into NhaCungCap(MaNCC,TenNCC,SDT,Mail,DChi,TrangThai) values ('" + m1 + "',N'" + m2 + "',N'" + m3 + "','" + m4 + "',N'" + m5 + "','" + 1 + "')";
                            if (c.CapNhatDulieu(sql) > 0)
                            {
                                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                                frm_NCC_Load(sender, e);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi cập nhật", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            XuLiTextBox(false);
                        }
                    }
                    break;
                case 2:
                    {
                        try
                        {

                            string sql = "update NhaCungCap set ";
                            sql += " MaNCC='" + m1;
                            sql += "',TenNCC=N'" + m2;
                            sql += "',SDT='" + m3;
                            sql += "',Mail='" + m4;
                            sql += "',DChi=N'" + m5;
                            sql += "',TrangThai='" + m6;
                            sql += "' where MaNCC='" + Old_Value + "'";

                            if (c.CapNhatDulieu(sql) > 0)
                            {
                                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                                frm_NCC_Load(sender, e);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi cập nhật\nHãy chắc chắn bạn chọn đúng cột muốn sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
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
    }
}
