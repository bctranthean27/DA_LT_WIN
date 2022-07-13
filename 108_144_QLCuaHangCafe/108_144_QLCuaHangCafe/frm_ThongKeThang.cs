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
    public partial class frm_ThongKeThang : Form
    {
        cls_QLCHCAFE c = new cls_QLCHCAFE();
        public frm_ThongKeThang()
        {
            InitializeComponent();
        }
        private void frm_ThongKeThang_Load(object sender, EventArgs e)
        {
            loadData_cbo(cbo_Nam, "select DISTINCT YEAR(NgayLap) as 'nam' from HoaDon", "nam","nam");
            cbo_Nam.SelectedIndex = -1;
        }

        void loadData_DataGrid(DataGridView d, string sql)
        {
            DataSet ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];

        }

        void loadData_cbo(ComboBox cbo, string sql,string valMember,string disMember)
        {
            DataSet ds = c.LayDuLieu(sql);
            cbo.DataSource = ds.Tables[0];
            cbo.ValueMember = valMember;
            cbo.DisplayMember = disMember;
        }


        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbo_ThongKeThang.SelectedIndex == -1 || cbo_Nam.SelectedIndex == -1)
                {
                    throw new Exception("Vui chọn tháng và năm cần thống kê");
                }
                loadData_DataGrid(dgv_ThongKeThang, "exec thong_ke_thang @thang='" + cbo_ThongKeThang.Text + "', @nam='" + cbo_Nam.Text + "'");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
