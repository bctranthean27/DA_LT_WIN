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
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            XuLiTextBox(true);
            XuLiButton(true);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            XuLiTextBox(false);
            XuLiButton(false);
            btn_Luu.Enabled = true;
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
        }
    }
}
