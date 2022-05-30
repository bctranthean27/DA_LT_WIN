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
    public partial class frm_HoaDon : Form
    {
        cls_QLCHCAFE c = new cls_QLCHCAFE();
        int vt = 0;
        DataSet ds = new DataSet();
        public frm_HoaDon()
        {
            InitializeComponent();
        }

        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            XuLiTextBox(true);
            XuLiButton(true);
            loadData_DataGrid(dgv_DanhSach, "select * from HoaDon");
            loadData_cbo(cbo_KhachHang, "select MaKH,TenKH from KhachHang", "MaKH", "TenKH");
            loadData_cbo(cbo_LoaiHD, "select MaLoaiHD,TenLoaiHD from LoaiHoaDon", "MaLoaiHD", "TenLoaiHD");
            loadData_cbo(cbo_NhanVien, "select MaNV,TenNV from NhanVien", "MaNV", "TenNV");
            cbo_KhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_LoaiHD.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_NhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_TrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_TrangThai.SelectedIndex = 0;
        }
        void loadData_DataGrid(DataGridView d, string sql)
        {
            ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];
        }
        void loadData_cbo(ComboBox cbo, string sql, string valMember, string disMember)
        {
            ds = c.LayDuLieu(sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cbo.DataSource = ds.Tables[0];
                cbo.ValueMember = valMember;
                cbo.DisplayMember = disMember;
            }
        }
        void XuLiTextBox(Boolean t)
        {
            txt_MaHD.ReadOnly = t;
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
                    if (cbo.ValueMember == value) cbo.SelectedIndex = i;
                }
            }
        }
        void hienThiTextBox(DataTable dt, int vt)
        {
            txt_MaHD.Text = ds.Tables[0].Rows[vt]["MaHD"].ToString();
            loadData_cboFromList(dt, cbo_KhachHang, "MaKH");
            loadData_cboFromList(dt, cbo_LoaiHD, "MaLoaiHD");
            loadData_cboFromList(dt, cbo_NhanVien, "MaNV");
            loadData_cboFromList(dt, cbo_TrangThai, "TrangThai");
            dtp_NgayLap.Value = DateTime.Parse(ds.Tables[0].Rows[vt]["NgayLap"].ToString());

        }
        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ds = c.LayDuLieu("select * from HoaDon");
            int vt = dgv_DanhSach.CurrentCell.RowIndex;
            hienThiTextBox(ds.Tables[0], vt);
            
        }

        
    }
}
