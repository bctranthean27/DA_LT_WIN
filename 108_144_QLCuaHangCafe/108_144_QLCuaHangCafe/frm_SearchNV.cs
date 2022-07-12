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
    public partial class frm_SearchNV : Form
    {
        cls_QLCHCAFE c = new cls_QLCHCAFE();
        DataSet ds = new DataSet();
        public frm_SearchNV()
        {
            InitializeComponent();
        }

        private void frm_SearchNV_Load(object sender, EventArgs e)
        {
            loadData_DataGrid(dgv_DanhSach, "select * from NhanVien");
            loadData_cbo(cbo_ChucVu, "select MaChucVu,TenChucVu from ChucVu", "MaChucVu", "TenChucVu");
            dtp_MinNgay.Value = DateTime.Now;
        }
        void loadData_DataGrid(DataGridView d, string sql)
        {
            ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];

        }
        void loadData_cbo(ComboBox cbo, string sql, string valMember, string disMember, bool check = true)
        {

            ds = c.LayDuLieu(sql);
            if (check)
            {
                DataRow workRow = ds.Tables[0].NewRow();
                workRow[valMember] = 0;
                workRow[disMember] = "All";
                ds.Tables[0].Rows.InsertAt(workRow, 0);
            }
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cbo.DataSource = ds.Tables[0];
                cbo.ValueMember = valMember;
                cbo.DisplayMember = disMember;
            }
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
            string minNgay = NgayThangNam(dtp_MinNgay);
            string maxNgay = NgayThangNam(dtp_MaxNgay);
            string sql = "select * from NhanVien where MaNV like '%" + txt_MaNV.Text + "%' ";
            if (cbo_ChucVu.SelectedValue.ToString() != "0")
                sql += " and MaChucVu = '" + cbo_ChucVu.SelectedValue.ToString() + "' ";
            if (txt_HoNV.Text != "")
                sql += " and HoNV like N'%" + txt_HoNV.Text + "%' ";
            if (txt_TenNV.Text != "")
                sql += " and TenNV like N'%" + txt_TenNV.Text + "%' ";

            sql += " and NgayVaoLam between '" + minNgay + "' and '" + maxNgay + "'";
            sql += " and TrangThai ='1'";
            loadData_DataGrid(dgv_DanhSach, sql);
        }
    }
}
