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
    public partial class frm_KhachHang : Form
    {
        cls_QLCHCAFE c = new cls_QLCHCAFE();
        public frm_KhachHang()
        {
            InitializeComponent();
        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            XuLiTextBox(true);
            XuLiButton(true);
            loadData_DataGrid(dgv_DanhSach, "select * from KhachHang");
        }
        void loadData_DataGrid(DataGridView d, string sql)
        {
            DataSet ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];

        }
        void XuLiTextBox(Boolean t)
        {
            txt_MaKH.ReadOnly = t;
            txt_TenKH.ReadOnly = t;
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
    }
}
