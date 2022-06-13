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
    public partial class DangNhap : Form
    {
        cls_QLCHCAFE c = new cls_QLCHCAFE();
       // public string idUser = null;
        public string idUser { get; set; }
        //public string roles { get; set; }
        frm_Menu menu = new frm_Menu();
        public DangNhap()
        {
            InitializeComponent();
        }


        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM TaiKhoan WHERE taikhoan= '" + txtTK.Text.Trim() + "' AND matkhau= '" + txtMK.Text.Trim() + "'" + " AND TrangThai= '1'";
            //frm_Menu menu = new frm_Menu();
            //menu.Show();
            //this.Hide();
            DataSet data = c.LayDuLieu(query);

            if (data.Tables[0].Rows.Count == 1)
            {
                //lay id user
                 idUser = data.Tables[0].Rows[0]["MaNV"].ToString();
                
                menu.idUser = idUser;
                menu.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
