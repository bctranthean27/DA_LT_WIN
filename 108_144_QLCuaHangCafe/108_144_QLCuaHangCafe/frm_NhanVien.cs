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
    public partial class frm_NhanVien : Form
    {
        cls_QLCHCAFE c = new cls_QLCHCAFE();
        int vt = 0;
        DataSet ds = new DataSet();
        public frm_NhanVien()
        {
            InitializeComponent();
        }
        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            XuLiTextBox(true);
            XuLiButton(true);
            loadData_DataGrid(dgv_DanhSach, "select * from NhanVien");
            loadData_cbo(cbo_ChucVu, "select MaChucVu,TenChucVu from ChucVu", "MaChucVu", "TenChucVu");
        }
        void loadData_DataGrid(DataGridView d, string sql)
        {
            ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];

        }
        void loadData_cbo(ComboBox cbo, string sql, string valMember, string disMember)
        {
            ds = c.LayDuLieu(sql);
            cbo.DataSource = ds.Tables[0];
            cbo.ValueMember = valMember;
            cbo.DisplayMember = disMember; 
        }
        void XuLiTextBox(Boolean t)
        {
            txt_TenNV.ReadOnly = t;
            txt_HoNV.ReadOnly = t;
            txt_MaNV.ReadOnly = t;
            txt_DiaChi.ReadOnly = t;
            //cbo_ChucVu.Visible = !t;
            //cbo_TrangThai.Visible = !t;
            //dtp_NgayVaoLam.Visible = !t;
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
                    if (cbo.SelectedValue.ToString() == value) cbo.SelectedIndex = i;
                }
            }
        }
        void hienThiTextBox(DataTable dt, int vt)
        {
            txt_MaNV.Text = ds.Tables[0].Rows[vt]["MaNV"].ToString();
            txt_HoNV.Text = ds.Tables[0].Rows[vt]["HoNV"].ToString();
            txt_TenNV.Text = ds.Tables[0].Rows[vt]["TenNV"].ToString();
            txt_DiaChi.Text = ds.Tables[0].Rows[vt]["DChi"].ToString();
            loadData_cboFromList(dt, cbo_ChucVu, "MaChucVu");
            loadData_cboFromList(dt, cbo_TrangThai, "TrangThai");
            dtp_NgayVaoLam.Value = DateTime.Parse(ds.Tables[0].Rows[vt]["NgayVaoLam"].ToString());

        }
        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ds = c.LayDuLieu("select * from NhanVien");
            int vt = dgv_DanhSach.CurrentCell.RowIndex;
            hienThiTextBox(ds.Tables[0], vt);

        }

        private void dgv_DanhSach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
