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
    public partial class frm_ThongKeNgay : Form
    {
        cls_QLCHCAFE c = new cls_QLCHCAFE();
        
        public frm_ThongKeNgay()
        {
            InitializeComponent();
        }
        private void frm_ThongKeNgay_Load(object sender, EventArgs e)
        {
            loadData_DataGrid(dgv_DanhSach, "select * from HoaDon");
        }
        private void dtp_MinNgay_ValueChanged(object sender, EventArgs e)
        {
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
    }
}
