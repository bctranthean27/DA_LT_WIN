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
        public frm_SearchSP()
        {
            InitializeComponent();
        }

        private void frm_SearchSP_Load(object sender, EventArgs e)
        {
            loadData_DataGrid(dgv_DanhSach, "select * from SanPham");
            cbo_TrangThai.SelectedIndex = 0;
            loadData_cbo(cbo_LoaiSP, "select MaLoai,TenLoai from LoaiSanPham", "MaLoai", "TenLoai");
            loadData_cbo(cbo_Size, "select MaSize,TenSize from Size", "MaSize", "TenSize");
            loadData_cbo(cbo_NCC, "select MaNCC,TenNCC from NhaCungCap", "MaNCC", "TenNCC");
        }
        void loadData_DataGrid(DataGridView d, string sql)
        {
            DataSet ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];

        }
        void loadData_cbo(ComboBox cbo,string sql, string valMember, string disMember)
        {
            DataSet ds = c.LayDuLieu(sql);
            for(int i=0;i<ds.Tables[0].Rows.Count;i++)
            {
                cbo.DataSource = ds.Tables[0];
                cbo.ValueMember= valMember;
                cbo.DisplayMember= disMember;
            }
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            int giaMin = 0, giaMax = 0;
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
                tk += " and TrangThai like '" + cbo_TrangThai.Text + "'";
                loadData_DataGrid(dgv_DanhSach, tk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập vào giá sản phẩm muốn tìm", "Thông báo", MessageBoxButtons.OK);
            }
}
    }
}
