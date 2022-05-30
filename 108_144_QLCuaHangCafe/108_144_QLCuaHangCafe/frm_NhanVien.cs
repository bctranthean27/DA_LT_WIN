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
            cbo_TrangThai.SelectedIndex = 0;
            cbo_TrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_ChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
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
            cbo_ChucVu.Enabled = !t;
            cbo_TrangThai.Enabled = !t;
            dtp_NgayVaoLam.Enabled = !t;
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
        void loadData_cboFromList(DataTable dt, ComboBox cbo, string disMember,int vt)
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
                foreach(DataRowView rowView in cbo.Items)
                {
                    string val = rowView.Row[0].ToString();
                    string name = rowView.Row[1].ToString();
                    if(val == value)
                    {
                        cbo.Text = name;
                        break;
                    }

                }
            }
        }
        void hienThiTextBox(DataTable dt, int vt)
        {
            txt_MaNV.Text = dt.Rows[vt]["MaNV"].ToString();
            txt_HoNV.Text = dt.Rows[vt]["HoNV"].ToString();
            txt_TenNV.Text = dt.Rows[vt]["TenNV"].ToString();
            txt_DiaChi.Text = dt.Rows[vt]["DChi"].ToString();
            loadData_cboFromList(dt, cbo_ChucVu, "MaChucVu",vt);
            loadData_cboFromList(dt, cbo_TrangThai, "TrangThai",vt);
            dtp_NgayVaoLam.Value = DateTime.Parse(dt.Rows[vt]["NgayVaoLam"].ToString());

        }
        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ds = c.LayDuLieu("select * from NhanVien");
            int vt = dgv_DanhSach.CurrentCell.RowIndex;
            hienThiTextBox(ds.Tables[0], vt);

        }

    }
}
