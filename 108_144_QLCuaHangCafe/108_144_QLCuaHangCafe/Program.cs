﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _108_144_QLCuaHangCafe
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //DangNhap dn = new DangNhap();
            //Application.Run(dn);
            //if (dn.Islogin)
            //{
            //    frm_Menu menu = new frm_Menu();
            //    menu.idUser = dn.idUser;

            //}
            Application.Run(new DangNhap());

        }
    }
}
