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
    public partial class frm_SearchHD : Form
    {
        cls_QLCHCAFE c = new cls_QLCHCAFE();
        public frm_SearchHD()
        {
            InitializeComponent();
        }

        private void frm_SearchHD_Load(object sender, EventArgs e)
        {
            loadData_cbo(cbo_LoaiHD, "select MaLoaiHD,TenLoaiHD from LoaiHoaDon where TrangThai = '1'", "MaLoaiHD", "TenLoaiHD");
            dtp_MaxNgayLap.Value = DateTime.Now;
        }
        void loadData_cbo(ComboBox cbo, string sql, string valMember, string disMember)
        {
            DataSet data = c.LayDuLieu(sql);
            cbo.DataSource = data.Tables[0];
            cbo.ValueMember = valMember;
            cbo.DisplayMember = disMember;
        }
        void loadData_DataGrid(DataGridView d, string sql)
        {
            DataSet ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];

        }
        string NgayThangNam(DateTimePicker dtp)
        {
            string NgayDayDu = "";
            string ngay = dtp.Value.Day.ToString();
            string thang = dtp.Value.Month.ToString();
            string nam = dtp.Value.Year.ToString();
            NgayDayDu = thang + "/" + ngay + "/" + nam;
            return NgayDayDu;
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            string MinNgay = NgayThangNam(dtp_MinNgayLap);
            string MaxNgay = NgayThangNam(dtp_MaxNgayLap);
            string LoaiHD = cbo_LoaiHD.SelectedValue.ToString();
            string sql = "select * from HoaDon where NgayLap between '" + MinNgay + "' and '" + MaxNgay + "'" + " and TrangThai like '1' and MaLoaiHD ='" + LoaiHD + "'";
            loadData_DataGrid(dgv_DanhSach,sql);
            if (LoaiHD == "K01")
            {
                dgv_DanhSach.Columns["TenKhachHang"].Visible = false;
            }
            else dgv_DanhSach.Columns["TenKhachHang"].Visible = true;
        }

        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string mahd = dgv_DanhSach.CurrentRow.Cells["MaHD"].Value.ToString();
            loadData_DataGrid(dgv_cthd, "select * from ChiTietHoaDon where MaHD = '"+mahd+"'");
        }
    }
}
