using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using locadora_de_veiculos.Models;

namespace locadora_de_veiculos.Views.Cliente
{ 
    public partial class NovoCadastro : Form
    {
        Models.Cliente cliente = new Models.Cliente();
        public NovoCadastro()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // cria uma string 'connection'
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-M10J657;Initial Catalog=LocacaoVeiculos;Integrated Security=True");

            // cria string de insercao form1
            string form1 = "INSERT INTO Cliente(Id, Nome, Email, CPF, Telefone) VALUES (@Id, @Nome, @Email, @CPF, @Telefone)";
            Random randomID = new Random();
            randomID.Next();

            try
            {
                // cria um obejto do tipo 'comando', passando como parametro as strings acima
                SqlCommand conexao = new SqlCommand(form1, connection);

                // insere os dados dos textBox no comando 'form1'
                conexao.Parameters.Add(new SqlParameter("@Id", randomID.Next()));
                conexao.Parameters.Add(new SqlParameter("@Nome", this.textNome.Text));
                conexao.Parameters.Add(new SqlParameter("@Email", this.textEmail.Text));
                conexao.Parameters.Add(new SqlParameter("@CPF", this.textCPF.Text));
                conexao.Parameters.Add(new SqlParameter("@Telefone", this.textTelefone.Text));

                // Abrir a conexao com o banco de dados
                connection.Open();
                // Executa o comando 'conexao' no banco de dados
                conexao.ExecuteNonQuery();
                // fecha a conexao
                connection.Close();

                MessageBox.Show("Salvo com sucesso!");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ocorre: " + ex);
            }
            finally
            {
                connection.Close();
            }
        
        
        }
    }
}
