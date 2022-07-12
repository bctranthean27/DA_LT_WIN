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
    public partial class frm_LoaiHoaDon : Form
    {
        cls_QLCHCAFE c = new cls_QLCHCAFE();
        int vt = 0;
        DataSet ds = new DataSet();
        int flag = 0;
        string Old_Value = "";
        public frm_LoaiHoaDon()
        {
            InitializeComponent();
        }

        private void frm_LoaiHoaDon_Load(object sender, EventArgs e)
        {
            XuLiButton(true, false, false, false);
            dgv_DanhSach.Enabled = true;
            loadData_DataGrid(dgv_DanhSach, "select * from LoaiHoaDon where TrangThai='1'");

        }
        void loadData_DataGrid(DataGridView d, string sql)
        {
            ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];

        }
        void XuLiButton(bool key_them, bool key_xoa, bool key_sua, bool key_luu)
        {
            btn_Them.Enabled = key_them;
            btn_Xoa.Enabled = key_xoa;
            btn_Sua.Enabled = key_sua;
            btn_Luu.Enabled = key_luu;
        }
        string autoCode(DataSet ds, string pri)
        {
            string code = pri;
            int pos = ds.Tables[0].Rows.Count + 1;
            if (pos < 10) code += "0" + pos.ToString();
            else if (pos < 100) code += "" + pos.ToString();
            return code;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            ds = c.LayDuLieu("select * from LoaiHoaDon");
            clearTextbox();
            txt_MaLoaiHD.Text = autoCode(ds, "K");
            XuLiButton(false,false, false, true);
            dgv_DanhSach.Enabled = false;
            flag = 1;
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            XuLiButton(false, false, false, true);
            dgv_DanhSach.Enabled = false;
            flag = 2;
        }
        void them(object sender, EventArgs e, string m1, string m2)
        {
            try
            {
                if (m1.Trim() == "" || m2.Trim() == "")
                    throw new Exception("Vui lòng điền đủ thông tin");
                //string sql = "insert into LoaiHoaDon(MaLoaiHD,TenLoaiHD,TrangThai) values ('" + m1 + "',N'" + m2 + "','" + 1 + "')";
                //proc
                string sql = "EXEC them_loai_hd @maloaihd = '" + m1 + "', @tenloaihd = N'" + m2 + "';";

                if (c.CapNhatDulieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                    frm_LoaiHoaDon_Load(sender, e);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                c.DongKetNoi();
                btn_Them_Click(sender, e);
                
            }
        }
        void sua(object sender, EventArgs e, string m1 = "", string m2 = "", string m3 = "0")
        {
            try
            {

                string sql = "";
                if (txt_MaLoaiHD.Text == "")
                {
                    throw new Exception("Lỗi cập nhật\nHãy chắc chắn bạn chọn đúng cột muốn sửa");
                }
                //sql = "update LoaiHoaDon set ";
                //if (m1.Trim() != "")
                //    sql += " MaLoaiHD='" + m1 + "',";
                //if (m2.Trim() != "")
                //    sql += " TenLoaiHD=N'" + m2 + "',";
                //sql += "TrangThai='" + m3 + "' ";
                //sql += "where MaLoaiHD='" + Old_Value + "'";
                if (m1.Trim() == "" && m2.Trim() == "")
                    sql = "update LoaiHoaDon set TrangThai = '" + 0 + "'where MaLoaiHD = '" + Old_Value + "'";
                else
                    sql = "EXEC sua_loai_hd @maloaihd = '" + m1 + "', @tenloaihd = N'" + m2 + "',@trangthai = '" + m3 + "';";

                if (c.CapNhatDulieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                    frm_LoaiHoaDon_Load(sender, e);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                c.DongKetNoi();
                btn_Sua_Click(sender, e);
            }
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {

            XuLiButton(true, false, false, false);
            string m1 = txt_MaLoaiHD.Text;
            string m2 = txt_TenLoaiHD.Text;
            switch (flag)
            {
                case 1:
                    clearTextbox();
                    them(sender, e, m1, m2);
                    break;
                case 2:
                    sua(sender, e, m1, m2, "1");
                    break;

            }

        }

        
        void hienThiTextBox(DataTable dt, int vt)
        {
            if (dgv_DanhSach.CurrentRow != null)
            {
                DataGridViewRow row = dgv_DanhSach.CurrentRow;
                if (row.Cells["MaLoaiHD"].Value == DBNull.Value)
                {
                    txt_MaLoaiHD.Text = "";
                    txt_TenLoaiHD.Text = "";
                    btn_Sua.Enabled = false;
                    btn_Xoa.Enabled = false;
                }
                else
                {
                    txt_MaLoaiHD.Text = row.Cells["MaLoaiHD"].Value.ToString();
                    txt_TenLoaiHD.Text = row.Cells["TenLoaiHD"].Value.ToString();
                }
            }
        }
        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ds = c.LayDuLieu("select * from LoaiHoaDon where TrangThai='1'");
            int vt = dgv_DanhSach.CurrentCell.RowIndex;
            hienThiTextBox(ds.Tables[0], vt);
            Old_Value = txt_MaLoaiHD.Text; // lấy giá trị cũ để sửa đổi
            XuLiButton(true, true, true, false);
        }
        void clearTextbox()
        {
            txt_MaLoaiHD.Text = "";
            txt_TenLoaiHD.Text = "";
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            sua(sender, e);
            frm_LoaiHoaDon_Load(sender, e);
            //try
            //{
            //    if (txt_MaLoaiHD.Text == "")
            //        throw new Exception("Lỗi cập nhật\nHãy chắc chắn bạn chọn đúng cột muốn xoá");
            //    string sql = "DELETE from LoaiHoaDon where MaLoaiHD='" + Old_Value + "'";
            //    if (c.CapNhatDulieu(sql) > 0)
            //    {
            //        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
            //        frm_LoaiHoaDon_Load(sender, e);
            //        clearTextbox();
            //    }
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    frm_LoaiHoaDon_Load(sender, e);
            //}
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dgv_DanhSach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ds = c.LayDuLieu("select * from LoaiHoaDon");
            if (dgv_DanhSach.CurrentRow != null)
            {
                DataGridViewRow row = dgv_DanhSach.CurrentRow;//get row at select row
                string val1 = row.Cells["TenLoaiHD"].Value.ToString() ;
                string ma = row.Cells["MaLoaiHD"].Value.ToString();
                sua(sender, null, ma, val1, "1");
            }
        }
    }
}
