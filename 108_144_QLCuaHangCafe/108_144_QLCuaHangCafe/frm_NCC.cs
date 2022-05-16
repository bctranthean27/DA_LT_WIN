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
    public partial class frm_NCC : Form
    {
        public frm_NCC()
        {
            InitializeComponent();
        }
        private void frm_NCC_Load(object sender, EventArgs e)
        {
            XuLiTextBox(true);
            XuLiButton(true);
        }
        void XuLiTextBox(Boolean t)
        {
            txt_NCC.ReadOnly = t;
            txt_TenNCC.ReadOnly = t;
            txt_DiaChiMail.ReadOnly = t;
            txt_DienThoai.ReadOnly = t;
            txt_SoTK.ReadOnly = t;
            rtxt_DiaChi.ReadOnly = t;
            txt_TenTK.ReadOnly = t;
        }
        void XuLiButton(Boolean t)
        {
            btn_Them.Enabled = t;
            btn_Sua.Enabled = t;
            btn_Xoa.Enabled = t;
            btn_Luu.Enabled = !t;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            XuLiTextBox(false);
            XuLiButton(false);
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            XuLiTextBox(true);
            XuLiButton(true);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            XuLiTextBox(false);
            XuLiButton(false);
            btn_Luu.Enabled = true;
        }
    }
}
