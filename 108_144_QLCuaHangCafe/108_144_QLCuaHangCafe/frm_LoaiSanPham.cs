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
            loadData_DataGrid(dgv_DanhSach, "select * from LoaiSanPham");
            cbo_TrangThai.SelectedIndex = 0;
            cbo_TrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        void loadData_DataGrid(DataGridView d, string sql)
        {
            ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];

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
            btn_Luu.Enabled=true;
            flag = 2;
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
                    {
                        try
                        {
                            string sql = "insert into LoaiSanPham(MaLoai,TenLoai,TrangThai) values ('" + m1 + "',N'" + m2 + "','" + 1 + "')";
                            if (c.CapNhatDulieu(sql) > 0)
                            {
                                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                                frm_LoaiSanPham_Load(sender, e);
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

                            string sql = "update LoaiSanPham set ";
                            sql += " MaLoai='" + m1;
                            sql += "',TenLoai=N'" + m2;
                            sql += "',TrangThai='" + m3;
                            sql += "' where MaLoai='" + Old_Value + "'";
                            
                            if (c.CapNhatDulieu(sql) > 0)
                            {
                                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                                frm_LoaiSanPham_Load(sender, e);
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
            ds = c.LayDuLieu("select * from LoaiSanPham");
            int vt = dgv_DanhSach.CurrentCell.RowIndex;
            hienThiTextBox(ds.Tables[0], vt);
            Old_Value = txt_MaLoaiSP.Text; // lấy giá trị cũ để sửa đổi


        }
    }
}
