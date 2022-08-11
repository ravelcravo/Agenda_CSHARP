using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace agenda001
{
    class ConexaoLogin
    {
        SqlConnection con = new SqlConnection();

        public ConexaoLogin()
        {
            con.ConnectionString = @"Data Source=DESKTOP-7LHKOP8;Integrated Security=True";
        }

        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
