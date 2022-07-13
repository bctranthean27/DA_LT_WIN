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
    public partial class frm_ThongKeNam : Form
    {
        cls_QLCHCAFE c = new cls_QLCHCAFE();
        public frm_ThongKeNam()
        {
            InitializeComponent();
        }

        private void frm_ThongKeNam_Load(object sender, EventArgs e)
        {
            loadData_cbo(cbo_Nam, "select DISTINCT YEAR(NgayLap) as 'nam' from HoaDon", "nam", "nam");
        }
        void loadData_cbo(ComboBox cbo, string sql, string valMember, string disMember)
        {
            DataSet ds = c.LayDuLieu(sql);
            cbo.DataSource = ds.Tables[0];
            cbo.ValueMember = valMember;
            cbo.DisplayMember = disMember;
        }

        private void cbo_Nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                int nam;
                bool result = Int32.TryParse(cbo_Nam.Text, out nam);
                
                if (result){
                    loadData_DataGrid(dgv_ThongKeNam, "exec thong_ke_nam @nam='" + nam + "'");
                }

               
            } catch (Exception err) {
                MessageBox.Show(err.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void loadData_DataGrid(DataGridView d, string sql)
        {
            DataSet ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];
        }

        private void btn_TopDoanhThu_Click(object sender, EventArgs e)
        {
            if (dgv_ThongKeNam.Rows.Count <= 0) return;
            try
            {
                int nam;
                bool result = Int32.TryParse(cbo_Nam.Text, out nam);

                if (result)
                {
                    loadData_DataGrid(dgv_ThongKeNam, "exec max_thang @nam='" + nam + "'");
                }


            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
