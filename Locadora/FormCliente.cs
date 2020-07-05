using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void limpa_TextBox()
        {
            nomeTextBox.Text = "";
            emailTextBox.Text = "";
            cPFTextBox.Text = "";
            telefoneTextBox.Text = "";
        }

        private void clienteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nomeTextBox.Text = clienteDataGridView.CurrentRow.Cells[1].Value.ToString();
            emailTextBox.Text = clienteDataGridView.CurrentRow.Cells[2].Value.ToString();
            cPFTextBox.Text = clienteDataGridView.CurrentRow.Cells[3].Value.ToString();
            telefoneTextBox.Text = clienteDataGridView.CurrentRow.Cells[4].Value.ToString();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'locadoraDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.locadoraDataSet.Cliente);

        }

        private void atualiza_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-M10J657;Initial Catalog=Locadora;Integrated Security=True");

            SqlCommand comando = new SqlCommand("SELECT * FROM Cliente", conexao);
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                SqlDataAdapter adapta = new SqlDataAdapter();
                DataSet dataset = new DataSet();
                adapta.SelectCommand = comando;
                adapta.Fill(dataset);
                clienteDataGridView.DataSource = dataset;
                clienteDataGridView.DataMember = dataset.Tables[0].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
            finally
            {
                conexao.Close();
                limpa_TextBox();
            }
        }

        private void salva_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-M10J657;Initial Catalog=Locadora;Integrated Security=True");
            string inserir = "INSERT INTO Cliente(Nome, Email, CPF, Telefone) VALUES (@Nome, @Email, @CPF, @Telefone)";
            SqlCommand comando = new SqlCommand(inserir, conexao);

            try
            {    // insere os dados dos textBox no comando 'inserir'              
                comando.Parameters.Add(new SqlParameter("@Nome", this.nomeTextBox.Text));
                comando.Parameters.Add(new SqlParameter("@Email", this.emailTextBox.Text));
                comando.Parameters.Add(new SqlParameter("@CPF", this.cPFTextBox.Text));
                comando.Parameters.Add(new SqlParameter("@Telefone", this.telefoneTextBox.Text));

                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Salvo com sucesso!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorre erro: " + ex.Message);
            }
            finally
            {
                atualiza_Click(sender, e);
                limpa_TextBox();
            }
        }     

        private void altera_Click(object sender, EventArgs e)
        {

            SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-M10J657;Initial Catalog=Locadora;Integrated Security=True");
            string alterar = "UPDATE Cliente SET Nome=@Nome, Email=@Email, CPF=@CPF, Telefone=@Telefone WHERE Id=@Id";
            SqlCommand comando = new SqlCommand(alterar, conexao);

            try
            {    // insere os dados dos textBox no comando 'inserir'     
                comando.Parameters.Add(new SqlParameter("@Id", clienteDataGridView.SelectedRows[0].Cells[0].Value.ToString()));
                comando.Parameters.Add(new SqlParameter("@Nome", this.nomeTextBox.Text));
                comando.Parameters.Add(new SqlParameter("@Email", this.emailTextBox.Text));
                comando.Parameters.Add(new SqlParameter("@CPF", this.cPFTextBox.Text));
                comando.Parameters.Add(new SqlParameter("@Telefone", this.telefoneTextBox.Text));

                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Alterado com sucesso!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorre erro: " + ex.Message);
            }
            finally
            {
                atualiza_Click(sender, e);
                limpa_TextBox();
            }
        }

        private void deleta_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-M10J657;Initial Catalog=Locadora;Integrated Security=True");
            string deletar = "DELETE FROM Cliente WHERE Id =@Id";
            SqlCommand comando = new SqlCommand(deletar, conexao);

            try
            {
                comando.Parameters.Add(new SqlParameter("@Id", clienteDataGridView.SelectedRows[0].Cells[0].Value.ToString()));

                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Deletado com sucesso!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorre erro: " + ex.Message);
            }
            finally
            {
                atualiza_Click(sender, e);
                limpa_TextBox();
            }
        }   

    }
}
