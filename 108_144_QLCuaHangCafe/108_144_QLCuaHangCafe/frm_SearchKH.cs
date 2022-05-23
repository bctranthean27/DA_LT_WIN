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
    public partial class frm_SearchKH : Form
    {
        cls_QLCHCAFE c = new cls_QLCHCAFE();
        public frm_SearchKH()
        {
            InitializeComponent();
        }

        private void txt_DienThoai_TextChanged(object sender, EventArgs e)
        {
            string dt = txt_DienThoai.Text;
            loadData_DataGrid(dgv_DanhSach, "select * from KhachHang where SDT like '%" + dt + "%'");
        }
        private void frm_SearchKH_Load(object sender, EventArgs e)
        {
            loadData_DataGrid(dgv_DanhSach, "select * from KhachHang");
        }
        void loadData_DataGrid(DataGridView d, string sql)
        {
            DataSet ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];

        }
        private void txt_TenKH_TextChanged(object sender, EventArgs e)
        {
            string ten = txt_TenKH.Text;
            loadData_DataGrid(dgv_DanhSach, "select * from KhachHang where TenKH like N'%" + ten + "%'");
        }
    }
}
