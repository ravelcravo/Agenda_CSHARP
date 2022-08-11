using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace agenda001
{
    class DALContato
    {
        private Conexao objConexao;

        public DALContato(Conexao conexao)
        {
            objConexao = conexao;
        }
        public void Incluir(Contato contato)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "insert into contato(nome, descricao, data_local, participantes, email, exclusivo) values (@nome, @descricao, @data_local, @participantes,@email,@exclusivo); select @@IDENTITY;";

            cmd.Parameters.AddWithValue("@nome", contato.Nome);
            cmd.Parameters.AddWithValue("@descricao", contato.Descricao);
            cmd.Parameters.AddWithValue("@data_local", contato.Data);
            cmd.Parameters.AddWithValue("@participantes", contato.Participantes);
            cmd.Parameters.AddWithValue("@email", Contato.Email);
            cmd.Parameters.AddWithValue("@exclusivo", Contato.Exclusivo);
            objConexao.Conectar();
            contato.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
            
        }

        public void Alterar(Contato contato)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "update contato set nome = @nome, descricao = @descricao, data_local = @data_local, participantes = @participantes where codigo = @codigo";
            cmd.Parameters.AddWithValue("@nome", contato.Nome);
            cmd.Parameters.AddWithValue("@descricao", contato.Descricao);
            cmd.Parameters.AddWithValue("@data_local", contato.Data);
            cmd.Parameters.AddWithValue("@participantes", contato.Participantes);
            cmd.Parameters.AddWithValue("@codigo", contato.Codigo);
            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();

        }

        public void Excluir (int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "delete from contato where codigo = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();
        }

        public  DataTable Localizar (String valor)
        {
            DataTable tabela = new DataTable();


            var sql = "Select codigo, nome, descricao, participantes, data_local,email from contato,logins where nome like '%" + valor + "%' and email='" + Contato.Email + "'"; 

            SqlDataAdapter da = new SqlDataAdapter("Select codigo, nome, descricao, participantes, data_local,email,exclusivo from contato where nome like '%" + valor + "%' and email='" + Contato.Email + "' or data_local like '%" + valor + "%' and email='" + Contato.Email + "'" , objConexao.StringConexao);
            da.Fill(tabela);
            return tabela;
            
        }
        public DataTable LocalizarTodos(String valor)
        {
            

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select codigo, nome, descricao, participantes, data_local,email,exclusivo from contato where nome like '%" + valor + "%'and exclusivo = 0 or data_local like '%" + valor + "%'and exclusivo = 0 or email like '%" + valor + "%'and exclusivo = 0", objConexao.StringConexao);
            da.Fill(tabela);
            return tabela;


        }

        public Contato carregaContato(int codigo)
        {
            Contato modelo = new Contato();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "Select * from contato where codigo = " + codigo.ToString();
            objConexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if(registro.HasRows)
            {
                registro.Read();
                modelo.Codigo = Convert.ToInt32(registro["codigo"]);
                modelo.Nome = Convert.ToString(registro["nome"]);
                modelo.Descricao = Convert.ToString(registro["descricao"]);
                modelo.Participantes = Convert.ToString(registro["participantes"]);
                modelo.Data = Convert.ToString(registro["data_local"]);
            }
            return modelo;
        }
    }
}
