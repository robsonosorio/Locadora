using System;
using Locadora.LocadoraDataSetTableAdapters;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora.Models
{
    class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }

        public Cliente()
        {
        }

        public void Atualizar()
        {
            
        }

        public void Salvar(Cliente cliente)
        {

            SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-M10J657;Initial Catalog=Locadora;Integrated Security=True");
            string inserir = "INSERT INTO Cliente(Nome, Email, CPF, Telefone) VALUES (@Nome, @Email, @CPF, @Telefone)";
            SqlCommand comando = new SqlCommand(inserir, conexao);

            try
            {    // insere os dados dos textBox no comando 'inserir'              
                comando.Parameters.Add(new SqlParameter("@Nome", cliente.Nome));
                comando.Parameters.Add(new SqlParameter("@Email", cliente.Email));
                comando.Parameters.Add(new SqlParameter("@CPF", cliente.CPF));
                comando.Parameters.Add(new SqlParameter("@Telefone", cliente.Telefone));

                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Salvo com sucesso!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorre erro: " + ex.Message);
            }

        }

        public void Alterar(Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-M10J657;Initial Catalog=Locadora;Integrated Security=True");
            string alterar = "UPDATE Cliente SET Nome=@Nome, Email=@Email, CPF=@CPF, Telefone=@Telefone WHERE Id=@Id";
            SqlCommand comando = new SqlCommand(alterar, conexao);

            try
            {    // insere os dados dos textBox no comando 'inserir'     
                comando.Parameters.Add(new SqlParameter("@Id", cliente.Id));
                comando.Parameters.Add(new SqlParameter("@Nome", cliente.Nome));
                comando.Parameters.Add(new SqlParameter("@Email", cliente.Email));
                comando.Parameters.Add(new SqlParameter("@CPF", cliente.CPF));
                comando.Parameters.Add(new SqlParameter("@Telefone", cliente.Telefone));

                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Alterado com sucesso!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorre erro: " + ex.Message);
            }
        }

        public void Deletar(Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-M10J657;Initial Catalog=Locadora;Integrated Security=True");
            string deletar = "DELETE FROM Cliente WHERE Id =@Id";
            SqlCommand comando = new SqlCommand(deletar, conexao);

            try
            {
                comando.Parameters.Add(new SqlParameter("@Id", cliente.Id));

                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Deletado com sucesso!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorre erro: " + ex.Message);
            }
        }


    }
}
