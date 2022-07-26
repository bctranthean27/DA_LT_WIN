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
    public partial class frm_Size : Form
    {
        cls_QLCHCAFE c = new cls_QLCHCAFE();
        int vt = 0;
        DataSet ds = new DataSet();
        int flag = 0;
        string Old_Value = "";
        public frm_Size()
        {
            InitializeComponent();
        }
        private void frm_Size_Load(object sender, EventArgs e)
        {
            XuLiTextBox(true);
            XuLiButton(true);
            loadData_DataGrid(dgv_DanhSach, "select * from Size where TrangThai='1'");
        }
        void loadData_DataGrid(DataGridView d, string sql)
        {
            DataSet ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];

        }
        void XuLiTextBox(Boolean t)
        {
            txt_MaSize.ReadOnly = t;
            txt_TenSize.ReadOnly = t;
        }
        void XuLiButton(Boolean t)
        {
            btn_Them.Enabled = t;
            btn_Sua.Enabled = t;
            btn_Xoa.Enabled = t;
            btn_Lưu.Enabled = !t;
            dgv_DanhSach.Enabled = t;
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
            ds = c.LayDuLieu("select * from Size");
            clearTextbox();
            txt_MaSize.Text = autoCode(ds, "S");     
            XuLiTextBox(false);
            XuLiButton(false);
            txt_MaSize.ReadOnly = true;
            flag = 1;
        }

        void them(object sender, EventArgs e, string m1, string m2)
        {
            try
            {
                if (m1.Trim() == "" || m2.Trim() == "")
                    throw new Exception("Vui lòng điền đủ thông tin");
                //string sql = "insert into Size(MaSize,TenSize,TrangThai) values ('" + m1 + "',N'" + m2 + "','" + 1 + "')";
                //proc
                string sql = "EXEC them_size @masize = '" + m1 + "', @tensize = N'" + m2 + "';";

                if (c.CapNhatDulieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                    frm_Size_Load(sender, e);
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
                if (txt_MaSize.Text == "")
                {
                    throw new Exception("Lỗi cập nhật\nHãy chắc chắn bạn chọn đúng cột muốn sửa");
                }
                //sql = "update Size set ";
                //if (m1.Trim() != "")
                //    sql += " MaSize='" + m1 + "',";
                //if (m1.Trim() != "")
                //    sql += " TenSize=N'" + m2 + "',";
                //sql += " TrangThai='" + m3;
                //sql += "' where MaSize='" + Old_Value + "'";
                if (m1.Trim() == "" && m2.Trim() == "")
                    sql = "update Size set TrangThai = '" + 0 + "'where MaSize = '" + Old_Value + "'";
                else
                    sql = "EXEC sua_size @masize = '" + m1 + "', @tensize = N'" + m2 + "', @trangthai = '" + m3 + "';";

                if (c.CapNhatDulieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                    frm_Size_Load(sender, e);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_Sua_Click(sender, e);
            }
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            XuLiTextBox(true);
            XuLiButton(true);
            string m1 = txt_MaSize.Text;
            string m2 = txt_TenSize.Text;
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

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            XuLiTextBox(false);
            XuLiButton(false);
            flag = 2;
            txt_MaSize.ReadOnly = true;
        }
        void loadData_cboFromList(DataTable dt, ComboBox cbo, string disMember)
        {

            string value = dt.Rows[vt][disMember].ToString();
            for (int i = 0; i < cbo.Items.Count; i++)
            {
                if (cbo.ValueMember == value) cbo.SelectedIndex = i;
            }
        }
        void hienThiTextBox(DataTable dt, int vt)
        {
            if (dgv_DanhSach.CurrentRow != null)
            {
                DataGridViewRow row = dgv_DanhSach.CurrentRow;
                if (row.Cells["MaSize"].Value == DBNull.Value)
                {
                    txt_MaSize.Text = "";
                    txt_TenSize.Text = "";
                    btn_Sua.Enabled = false;
                    btn_Xoa.Enabled = false;
                }
                else
                {
                    txt_MaSize.Text = row.Cells["MaSize"].Value.ToString();
                    txt_TenSize.Text = row.Cells["TenSize"].Value.ToString();
                }
            }
        }
        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ds = c.LayDuLieu("select * from Size where TrangThai='1'");
            int vt = dgv_DanhSach.CurrentCell.RowIndex;
            hienThiTextBox(ds.Tables[0], vt);
            Old_Value = txt_MaSize.Text; // lấy giá trị cũ để sửa đổi
        }
        void clearTextbox()
        {
            txt_MaSize.Text = "";
            txt_TenSize.Text = "";
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            sua(sender, e);
        }
        private void dgv_DanhSach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ds = c.LayDuLieu("select * from Size");
            if (dgv_DanhSach.CurrentRow != null)
            {
                DataGridViewRow row = dgv_DanhSach.CurrentRow;//get row at select row
                string val1 = row.Cells["TenSize"].Value == DBNull.Value ? "" : row.Cells["TenSize"].Value.ToString();
                string ma = row.Cells["MaSize"].Value == DBNull.Value ? "" : row.Cells["MaSize"].Value.ToString();
                sua(sender, null, ma, val1, "1");
            }
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
