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
    public partial class frm_ThongKeLoiNhuan : Form
    {
        bool flag = true;
        public frm_ThongKeLoiNhuan()
        {
            InitializeComponent();
        }

        private void frm_ThongKeLoiNhuan_Load(object sender, EventArgs e)
        {

            loadData_cbo(cbo_Nam, "select DISTINCT YEAR(NgayLap) as 'nam' from HoaDon", "nam", "nam");
            flag = false;
        }
        cls_QLCHCAFE c = new cls_QLCHCAFE();
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
        string TongLoiNhuanNam()
        {
            int ketQua = 0;
            if (dgv_ThongKeNam.Rows.Count == 0) return ketQua.ToString();
            else
            {
                for (int i = 0; i < dgv_ThongKeNam.Rows.Count; i++) 
                {
                    int loiNhuanNam = int.Parse(dgv_ThongKeNam.Rows[i].Cells["LoiNhuan"].Value.ToString());
                    ketQua += loiNhuanNam;
                }
            }
            return ketQua.ToString();
        }
        string LoiNhuanThangCaoNhat()
        {
            int max = 0;
            if (dgv_ThongKeNam.Rows.Count == 0) return "0";
            for (int i = 0; i < dgv_ThongKeNam.Rows.Count; i++)
            {
                int loiNhuan = Convert.ToInt32(dgv_ThongKeNam.Rows[i].Cells["LoiNhuan"].Value);
                if (loiNhuan > max) max = loiNhuan;
            }
            return max.ToString();
        }
        string ThangLoiNhuanCaoNhat()
        {
            string thang = "";
            if (dgv_ThongKeNam.Rows.Count == 0) return "";
            for (int i = 0; i < dgv_ThongKeNam.Rows.Count; i++)
            {
                int loiNhuanThang = Convert.ToInt32(dgv_ThongKeNam.Rows[i].Cells["LoiNhuan"].Value);
                int loiNhuanMax = int.Parse(LoiNhuanThangCaoNhat());
                if (loiNhuanThang == loiNhuanMax && loiNhuanMax != 0)
                    thang = dgv_ThongKeNam.Rows[i].Cells["Thang"].Value.ToString();
            }
            return thang;
        }
        void XuLiTinhToan()
        {
            lbl_LoiNhuanNam.Text = TongLoiNhuanNam();
            if (dgv_ThongKeNam.Rows.Count != 0)
            {
                int trungbinh = int.Parse(TongLoiNhuanNam()) / 12;
                lbl_TrungBinhNam.Text = trungbinh.ToString();
            }
            else lbl_TrungBinhNam.Text = "0";
            lbl_thangMax.Text = ThangLoiNhuanCaoNhat();
            lbl_doanhthuMax.Text = LoiNhuanThangCaoNhat();
        }
        private void cbo_Nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_Nam.SelectedIndex == -1 || flag )
                return;
            
            try
            {
                int nam;
                bool result = Int32.TryParse(cbo_Nam.Text, out nam);

                if (result)
                {
                    loadData_DataGrid(dgv_ThongKeNam, "exec thong_ke_loi_nhuan @nam=" + nam);
                    XuLiTinhToan();
                }
                


            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
