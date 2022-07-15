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
        void loadData_DataGrid(DataGridView d, string sql)
        {
            DataSet ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];
        }
        private void cbo_Nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_Nam.SelectedIndex == -1) return;
            try
            {
                int nam;
                bool result = Int32.TryParse(cbo_Nam.Text, out nam);

                if (result)
                {
                    loadData_DataGrid(dgv_ThongKeNam, "exec thong_ke_nam @nam='" + nam + "'");
                    XuLiTinhToan();
                }


            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void XuLiTinhToan()
        {
            lbl_DoanhThuNam.Text = TongDoanhThuNam();
            if (dgv_ThongKeNam.Rows.Count != 0)
            {
                int trungbinh = int.Parse(TongDoanhThuNam()) / 12;
                lbl_TrungBinhThang.Text = trungbinh.ToString();
            }
            else lbl_TrungBinhThang.Text = "0";
            lbl_thangMax.Text = ThangDoanhThuCaoNhat();
            lbl_doanhthuMax.Text = DoanhThuThangCaoNhat();
        }
        string TongDoanhThuNam()
        {
            int ketqua = 0;
            if (dgv_ThongKeNam.Rows.Count == 0) return "0";
            for (int i = 0; i < dgv_ThongKeNam.Rows.Count; i++)
            {
                int doanhThuNam = int.Parse(dgv_ThongKeNam.Rows[i].Cells["TongTien"].Value.ToString());
                ketqua += doanhThuNam;
            }
            return ketqua.ToString();
        }
        string DoanhThuThangCaoNhat()
        {
            int max = 0;
            if (dgv_ThongKeNam.Rows.Count == 0) return "0";
            for (int i = 0; i < dgv_ThongKeNam.Rows.Count; i++)
            {
                int doanhThuThang = Convert.ToInt32(dgv_ThongKeNam.Rows[i].Cells["TongTien"].Value);
                if (doanhThuThang > max) max = doanhThuThang;
            }
            return max.ToString();
        }
        string ThangDoanhThuCaoNhat()
        {
            string thang = "";
            if (dgv_ThongKeNam.Rows.Count == 0) return "";
            for (int i = 0; i < dgv_ThongKeNam.Rows.Count; i++)
            {
                int doanhThuThang = Convert.ToInt32(dgv_ThongKeNam.Rows[i].Cells["TongTien"].Value);
                int doanhthumax = int.Parse(DoanhThuThangCaoNhat());
                if (doanhThuThang == doanhthumax && doanhthumax != 0)
                    thang = dgv_ThongKeNam.Rows[i].Cells["Thang"].Value.ToString();
            }
            return thang;
        }
    }
}
