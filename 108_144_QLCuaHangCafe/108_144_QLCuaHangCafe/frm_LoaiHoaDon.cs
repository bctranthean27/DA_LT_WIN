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
            loadData_DataGrid(dgv_DanhSach, "select * from LoaiHoaDon");
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
            string m1 = txt_MaLoaiHD.Text;
            string m2 = txt_TenLoaiHD.Text;
            string m3 = cbo_TrangThai.SelectedItem.ToString();
            switch (flag)
            {
                case 1:
                    {
                        try
                        {
                            string sql = "insert into LoaiHoaDon(MaLoaiHD,TenLoaiHD,TrangThai) values ('" + m1 + "',N'" + m2 + "','" + 1 + "')";
                            if (c.CapNhatDulieu(sql) > 0)
                            {
                                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                                frm_LoaiHoaDon_Load(sender, e);

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi cập nhật ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            XuLiTextBox(false);
                        }
                    }
                    break;
                case 2:
                    {
                        try
                        {

                            string sql = "update LoaiHoaDon set ";
                            sql += " MaLoaiHD='" + m1;
                            sql += "',TenLoaiHD=N'" + m2;
                            sql += "',TrangThai='" + m3;
                            sql += "' where MaLoaiHD='" + Old_Value + "'";
                            MessageBox.Show(sql, "Thông báo", MessageBoxButtons.OK);
                            if (c.CapNhatDulieu(sql) > 0)
                            {
                                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                                frm_LoaiHoaDon_Load(sender, e);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi cập nhật \nHãy chắc chắn bạn chọn đúng cột muốn sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txt_MaLoaiHD.Text = ds.Tables[0].Rows[vt]["MaLoaiHD"].ToString();
            txt_TenLoaiHD.Text = ds.Tables[0].Rows[vt]["TenLoaiHD"].ToString();
            loadData_cboFromList(dt, cbo_TrangThai, "TrangThai");
        }
        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ds = c.LayDuLieu("select * from LoaiHoaDon");
            int vt = dgv_DanhSach.CurrentCell.RowIndex;
            hienThiTextBox(ds.Tables[0], vt);
            Old_Value = txt_MaLoaiHD.Text; // lấy giá trị cũ để sửa đổi
        }

    }
}
