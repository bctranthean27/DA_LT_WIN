﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace _108_144_QLCuaHangCafe
{
    public class cls_QLCHCAFE
    {
        SqlConnection con = new SqlConnection();

        public void KetNoi()
        {
            con.ConnectionString = @"Data source=BC27\SQLEXPRESS;Initial Catalog=QL_CH_CAFE;integrated Security=True";
            if(con.State != ConnectionState.Closed)
                con.Open();
        }
        //public void DongKetNoi()
        //{

        //}
        public cls_QLCHCAFE ()
        {
            KetNoi();
        }
        public DataSet LayDuLieu(string sql)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql,con);
            da.Fill(ds);
            return ds;
        }
    }
}