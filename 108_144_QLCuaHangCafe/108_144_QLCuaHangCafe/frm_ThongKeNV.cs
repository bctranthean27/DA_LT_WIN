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
    public partial class frm_ThongKeNV : Form
    {
        cls_QLCHCAFE c = new cls_QLCHCAFE();
        bool flag = false;
        public frm_ThongKeNV()
        {
            InitializeComponent();
        }

        private void frm_ThongKeNV_Load(object sender, EventArgs e)
        {
            loadData_cbo(cbo_NhanVien, "select MaNV, HoNV + ' ' + TenNV as 'HoVaTen' from NhanVien", "MaNV", "HoVaTen");
            cbo_NhanVien.SelectedIndex = -1;
            flag = true;
        }
        void loadData_DataGrid(DataGridView d, string sql)
        {
            DataSet ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];

        }


        void loadData_cbo(ComboBox cbo, string sql, string valMember, string disMember)
        {
            DataSet ds = c.LayDuLieu(sql);
            cbo.DataSource = ds.Tables[0];
            cbo.ValueMember = valMember;
            cbo.DisplayMember = disMember;
        }

        private void cbo_NhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (flag)
                {
                    loadData_DataGrid(dgv_ThongKeNV, "exec thong_ke_nv @manv='" + cbo_NhanVien.SelectedValue.ToString() + "'");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
