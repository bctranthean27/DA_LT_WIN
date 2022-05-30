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
    public partial class frm_SearchSP : Form
    {
        cls_QLCHCAFE c = new cls_QLCHCAFE();
        DataSet ds = new DataSet();
        int vt = 0;
        public frm_SearchSP()
        {
            InitializeComponent();
        }

        private void frm_SearchSP_Load(object sender, EventArgs e)
        {
            loadData_DataGrid(dgv_DanhSach, "select * from SanPham");
            cbo_TrangThai.SelectedIndex = 0;
            loadData_cbo(cbo_LoaiSP, "select MaLoai,TenLoai from LoaiSanPham", "MaLoai", "TenLoai");
            loadData_cbo(cbo_NCC, "select MaNCC,TenNCC from NhaCungCap", "MaNCC", "TenNCC");
            cbo_LoaiSP.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_NCC.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_TrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        void loadData_DataGrid(DataGridView d, string sql)
        {
            DataSet ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];

        }
        void loadData_cbo(ComboBox cbo,string sql, string valMember, string disMember)
        {
            ds = c.LayDuLieu(sql);
            for(int i=0;i<ds.Tables[0].Rows.Count;i++)
            {
                cbo.DataSource = ds.Tables[0];
                cbo.ValueMember= valMember;
                cbo.DisplayMember= disMember;
            }
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            int giaMax = 0;
            int giaMin = txt_MinGiaSP.Text.Trim() != "" ? int.Parse(txt_MinGiaSP.Text) : 0;
            string dk_MaLoai = ((DataRowView)cbo_LoaiSP.SelectedItem)["MaLoai"].ToString();
            string dk_Ncc = ((DataRowView)cbo_NCC.SelectedItem)["MaNCC"].ToString();
            string dk_TrangThai = cbo_TrangThai.Text;
            string tk = "select * from SanPham";
            try
            {
                if (txt_MaxGiaSP.Text == "")
                {
                giaMin = int.Parse(txt_MinGiaSP.Text);
                tk += " where DonGia >= " + giaMin ;
                }
                else if (txt_MinGiaSP.Text == "")
                {
                giaMax = int.Parse(txt_MaxGiaSP.Text);
                tk += " where DonGia <= " + giaMax;
                }
                else
                {
                giaMin = int.Parse(txt_MinGiaSP.Text);
                giaMax = int.Parse(txt_MaxGiaSP.Text);
                tk += " where DonGia >= " + giaMin + " and DonGia <= " + giaMax;
                }
                tk += "and MaLoai like '" + dk_MaLoai + "'and MaNCC like '" + dk_Ncc + "' and TrangThai like '" + dk_TrangThai + "'";
                
                loadData_DataGrid(dgv_DanhSach, tk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập vào giá sản phẩm muốn tìm", "Thông báo", MessageBoxButtons.OK);
            }
        }

        
    }
}
