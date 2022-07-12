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
        public frm_SearchSP()
        {
            InitializeComponent();
        }

        private void frm_SearchSP_Load(object sender, EventArgs e)
        {
            loadData_DataGrid(dgv_DanhSach, "select * from SanPham");
            loadData_cbo(cbo_LoaiSP, "select MaLoai,TenLoai from LoaiSanPham", "MaLoai", "TenLoai");
            loadData_cbo(cbo_NCC, "select MaNCC,TenNCC from NhaCungCap", "MaNCC", "TenNCC");
            cbo_LoaiSP.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_NCC.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        void loadData_DataGrid(DataGridView d, string sql)
        {
            ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];

        }
        void loadData_cbo(ComboBox cbo,string sql, string valMember, string disMember, bool check=true)
        {
            
            ds = c.LayDuLieu(sql);
            if(check)
            {
                DataRow workRow = ds.Tables [0].NewRow();
                workRow[valMember] = 0;
                workRow[disMember] = "All";
                ds.Tables[0].Rows.InsertAt(workRow, 0);
            }
            for (int i=0;i<ds.Tables[0].Rows.Count;i++)
            {
                cbo.DataSource = ds.Tables[0];
                cbo.ValueMember= valMember;
                cbo.DisplayMember= disMember;
            }
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {

            //string dk_MaLoai = ((DataRowView)cbo_LoaiSP.SelectedItem)["MaLoai"].ToString();
            //string dk_Ncc = ((DataRowView)cbo_NCC.SelectedItem)["MaNCC"].ToString();
            string sql = "select * from SanPham where TenSP like N'%" + txt_TenSP.Text + "%' ";
            if (cbo_LoaiSP.SelectedValue.ToString() != "0")
                sql += " and MaLoai = '" + cbo_LoaiSP.SelectedValue.ToString() + "' ";
            if (cbo_NCC.SelectedValue.ToString() != "0")
                sql += " and MaNCC = '" + cbo_NCC.SelectedValue.ToString() + "' ";
            sql += " and TrangThai ='1'";
            loadData_DataGrid(dgv_DanhSach, sql);
        }
    }
}
