using Locadora.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Repositorio
{
    public class ClienteRepositorio : DataBase
    {
        public DataTable dataTable = new DataTable();
        public DataSet dataSet = new DataSet();
        public Cliente cliente = new Cliente();

        public ClienteRepositorio()
        {
        }

        public void Atualizar(string sql)
        {
            dataTable.Clear();
           
            SqlCommand comando = new SqlCommand(sql, conexao);
            SqlDataAdapter adapta = new SqlDataAdapter();

            adapta.Fill(dataSet);
            dataTable = dataSet.Tables[0];
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Salvar(string sql)
        {
            conexao.Open();
            SqlCommand comando = new SqlCommand(sql, conexao);

            comando.Parameters.Add(new SqlParameter("@Nome", cliente.Nome));
            comando.Parameters.Add(new SqlParameter("@Email", cliente.Email));
            comando.Parameters.Add(new SqlParameter("@CPF", cliente.CPF));
            comando.Parameters.Add(new SqlParameter("@Telefone", cliente.Telefone));

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Alterar(string sql)
        {
            conexao.Open();
            SqlCommand comando = new SqlCommand(sql, conexao);

            comando.Parameters.Add(new SqlParameter("@Id", cliente.Id));
            comando.Parameters.Add(new SqlParameter("@Nome", cliente.Nome));
            comando.Parameters.Add(new SqlParameter("@Email", cliente.Email));
            comando.Parameters.Add(new SqlParameter("@CPF", cliente.CPF));
            comando.Parameters.Add(new SqlParameter("@Telefone", cliente.Telefone));

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Deletar(string sql)
        {
            conexao.Open();

            
            SqlCommand comando = new SqlCommand(sql, conexao);

            comando.Parameters.Add(new SqlParameter("@Id", cliente.Id));

            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}
