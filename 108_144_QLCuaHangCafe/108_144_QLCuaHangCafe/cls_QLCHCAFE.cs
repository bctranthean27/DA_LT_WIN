using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Windows.Forms;


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
        public int CapNhatDulieu(string sql/*, ArrayList arl = null*/)
        {

            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = sql;
            //foreach (var i in arl )
            //{
            //    cmd.Parameters.Add(i);
            //} 

            //cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            int val = cmd.ExecuteNonQuery();
            con.Close();
            
            return val;
        }
        public void DongKetNoi()
        {
            
            con.Close();
        }
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
        public ArrayList laygiatri(string[]dsbien, ArrayList dsthamso)
        {
            ArrayList dsGiatri = new ArrayList();
            dsGiatri = null;
            try
            {   
                if(dsthamso.Count != dsbien.Length )
                    throw new Exception("Cập nhật không thành công");
                for(int i = 0;i< dsthamso.Count; i++)
                {
                    SqlParameter bien = new SqlParameter()
                    {
                        ParameterName = dsbien[i],
                        Value = dsbien[i],
                        Direction = ParameterDirection.Input,
                    };
                    dsGiatri.Add(bien);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
            return dsGiatri;
        }
    }
}
