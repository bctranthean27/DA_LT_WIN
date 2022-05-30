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
            loadData_DataGrid(dgv_DanhSach, "select * from HoaDon");
            cbo_TrangThai.SelectedIndex = 0;
            cbo_TrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            dtp_MaxNgayLap.Value = DateTime.Now;
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
            loadData_DataGrid(dgv_DanhSach, "select * from HoaDon where NgayLap between '" + MinNgay + "' and '" + MaxNgay + "'" + " and TrangThai like '" + cbo_TrangThai.Text + "'");
        }
    }
}
