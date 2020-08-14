using Locadora.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Locadora
{
    public partial class FormCliente : Form
    {
        DataBase db = new DataBase();

        public FormCliente()
        {
            InitializeComponent();
        }
        private void Clear_TextBox()
        {
            nomeTextBox.Text = "";
            emailTextBox.Text = "";
            cPFTextBox.Text = "";
            telefoneTextBox.Text = "";
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            string sqlDataGrid = "SELECT * FROM Cliente";
            clienteDataGridView.DataSource = db.Consulta(sqlDataGrid);
        }

        private void ClienteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nomeTextBox.Text = clienteDataGridView.CurrentRow.Cells[1].Value.ToString();
            emailTextBox.Text = clienteDataGridView.CurrentRow.Cells[2].Value.ToString();
            cPFTextBox.Text = clienteDataGridView.CurrentRow.Cells[3].Value.ToString();
            telefoneTextBox.Text = clienteDataGridView.CurrentRow.Cells[4].Value.ToString();
        }

        public void Atualizar_Click(object sender, EventArgs e)
        {
            try
            {
                FormCliente_Load(sender, e);
                Clear_TextBox();  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorre erro" + ex.Message);
            }
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            try
            {
                if (string.IsNullOrWhiteSpace(nomeTextBox.Text))
                {
                    MessageBox.Show("O campo Nome está em branco!");
                }
                else if (string.IsNullOrWhiteSpace(emailTextBox.Text))
                {
                    MessageBox.Show("O campo Email está em branco!");
                }
                else if (string.IsNullOrWhiteSpace(cPFTextBox.Text))
                {
                    MessageBox.Show("O campo CPF está em branco!");
                }
                else if (string.IsNullOrWhiteSpace(telefoneTextBox.Text))
                {
                    MessageBox.Show("O campo Telefone está em branco!");
                }
                else
                {
                    cliente.Nome = nomeTextBox.Text;
                    cliente.Email = emailTextBox.Text;
                    cliente.CPF = cPFTextBox.Text;
                    cliente.Telefone = telefoneTextBox.Text;

                    cliente.Salvar(cliente);
                }
            }
            catch (SqlException  ex)
            {
                MessageBox.Show("CPF já cadastrado!" + ex.Message);
            }
            finally
            {
                FormCliente_Load(sender, e);
                Clear_TextBox();
            }
        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            try
            {
                if (string.IsNullOrWhiteSpace(nomeTextBox.Text))
                {
                    MessageBox.Show("O campo Nome está em branco!");
                }
                else if (string.IsNullOrWhiteSpace(emailTextBox.Text))
                {
                    MessageBox.Show("O campo Email está em branco!");
                }
                else if (string.IsNullOrWhiteSpace(cPFTextBox.Text))
                {
                    MessageBox.Show("O campo CPF está em branco!");
                }
                else if (string.IsNullOrWhiteSpace(telefoneTextBox.Text))
                {
                    MessageBox.Show("O campo Telefone está em branco!");
                }
                else
                {
                    cliente.ClienteId = int.Parse(clienteDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    cliente.Nome = nomeTextBox.Text;
                    cliente.Email = emailTextBox.Text;
                    cliente.CPF = cPFTextBox.Text;
                    cliente.Telefone = telefoneTextBox.Text;

                    cliente.Alterar(cliente);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorre erro: " + ex.Message);
            }
            finally
            {
                FormCliente_Load(sender, e);
                Clear_TextBox();
            }
        }

        private void Deletar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            try
            {
                cliente.ClienteId = int.Parse(clienteDataGridView.SelectedRows[0].Cells[0].Value.ToString());

                cliente.Deletar(cliente); ;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorre erro: " + ex.Message);
            }
            finally
            {
                FormCliente_Load(sender, e);
                Clear_TextBox();
            }
        }
    }
}
