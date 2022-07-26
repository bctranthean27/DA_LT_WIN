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
        bool flag = true;
        public frm_ThongKeThang()
        {
            InitializeComponent();
        }

        private void frm_ThongKeThang_Load(object sender, EventArgs e)
        {
            loadData_cbo(cbo_Nam, "select DISTINCT YEAR(NgayLap) as 'nam' from HoaDon", "nam", "nam");
            cbo_Nam.SelectedIndex = -1;
            flag = false;
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

        private void cbo_ThongKeThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_ThongKeThang.SelectedIndex == -1 || cbo_Nam.SelectedIndex == -1)
                {
                    throw new Exception("Vui chọn tháng và năm cần thống kê");
                }
                loadData_DataGrid(dgv_DanhSach, "exec thong_ke_thang @thang='" + cbo_ThongKeThang.Text + "', @nam='" + cbo_Nam.Text + "'");
                XuLiTinhToan();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void XuLiTinhToan()
        {
            lbl_DoanhThuNgay.Text = TongDoanhThuThang();
            lbl_SoHoaDon.Text = TongSoDon();
            if (lbl_DoanhThuNgay.Text != "0" && lbl_SoHoaDon.Text != "0")
            {
                int trungbinh = int.Parse(lbl_DoanhThuNgay.Text) / 31;
                lbl_TrungBinh.Text = trungbinh.ToString();
            }
            else
                lbl_TrungBinh.Text = "0";
        }

        string TongDoanhThuThang()
        {
            int ketqua = 0;
            if (dgv_DanhSach.Rows.Count == 0) return "0";
            for (int i = 0; i < dgv_DanhSach.Rows.Count; i++)
            {
                int doanhThuThang = int.Parse(dgv_DanhSach.Rows[i].Cells["TongTien"].Value.ToString());
                ketqua += doanhThuThang;
            }
            return ketqua.ToString();
        }
        string TongSoDon()
        {
            int ketqua = 0;
            if (dgv_DanhSach.Rows.Count == 0) return "0";
            for (int i = 0; i < dgv_DanhSach.Rows.Count; i++)
            {
                int sodon = int.Parse(dgv_DanhSach.Rows[i].Cells["SoLuongDon"].Value.ToString());
                ketqua += sodon;
            }
            return ketqua.ToString();
        }
        private void cbo_Nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_Nam.SelectedIndex == -1 || flag)
            {
                cbo_ThongKeThang.Enabled = false;
                return;
            }
            else
            {
                cbo_ThongKeThang.Enabled = true;
                if(cbo_ThongKeThang.SelectedIndex != -1)
                    try
                    {
                        if (cbo_ThongKeThang.SelectedIndex == -1 || cbo_Nam.SelectedIndex == -1)
                        {
                            throw new Exception("Vui chọn tháng và năm cần thống kê");
                        }
                        loadData_DataGrid(dgv_DanhSach, "exec thong_ke_thang @thang='" + cbo_ThongKeThang.Text + "', @nam='" + cbo_Nam.Text + "'");
                        XuLiTinhToan();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        }
    }
}
