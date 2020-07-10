using Locadora.Models;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Locadora.Views.Cliente
{
    public partial class FormVeiculo : Form
    {
        public FormVeiculo()
        {
            InitializeComponent();
        }
        private void FormVeiculo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'locadoraDataSet.Veiculo' table. You can move, or remove it, as needed.
            this.veiculoTableAdapter.Fill(this.locadoraDataSet.Veiculo);

        }

        private void VeiculoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            marcaTextBox.Text = veiculoDataGridView.CurrentRow.Cells[1].Value.ToString();
            modeloTextBox.Text = veiculoDataGridView.CurrentRow.Cells[2].Value.ToString();
            corTextBox.Text = veiculoDataGridView.CurrentRow.Cells[3].Value.ToString();
            valorDiariaTextBox.Text = veiculoDataGridView.CurrentRow.Cells[4].Value.ToString();
        }


        private void Atualizar_Click(object sender, EventArgs e)
        {
            try
            {
                this.veiculoTableAdapter.Fill(this.locadoraDataSet.Veiculo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorre erro" + ex.Message);
            }
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            Veiculo veiculo = new Veiculo();
            try
            {
                veiculo.Marca = marcaTextBox.Text;
                veiculo.Modelo = modeloTextBox.Text;
                veiculo.Cor = corTextBox.Text;
                veiculo.ValorDiaria = double.Parse(valorDiariaTextBox.Text);

                veiculo.Salvar(veiculo);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorre erro: " + ex.Message);
            }
            finally
            {
                this.veiculoTableAdapter.Fill(this.locadoraDataSet.Veiculo);
                Limpa_TextBox();
            }
        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            Veiculo veiculo = new Veiculo();
            try
            {
                veiculo.Id = int.Parse(veiculoDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                veiculo.Marca = marcaTextBox.Text;
                veiculo.Modelo = modeloTextBox.Text;
                veiculo.Cor = corTextBox.Text;
                veiculo.ValorDiaria = double.Parse(valorDiariaTextBox.Text);

                veiculo.Alterar(veiculo);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorre erro: " + ex.Message);
            }
            finally
            {
                this.veiculoTableAdapter.Fill(this.locadoraDataSet.Veiculo);
                Limpa_TextBox();
            }
        }

        private void Deletar_Click(object sender, EventArgs e)
        {
            Veiculo veiculo = new Veiculo();
            try
            {
                veiculo.Id = int.Parse(veiculoDataGridView.SelectedRows[0].Cells[0].Value.ToString());

                veiculo.Deletar(veiculo);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorre erro: " + ex.Message);
            }
            finally
            {
                this.veiculoTableAdapter.Fill(this.locadoraDataSet.Veiculo);
                Limpa_TextBox();
            }
        }

        private void Limpa_TextBox()
        {
            marcaTextBox.Text = "";
            modeloTextBox.Text = "";
            corTextBox.Text = "";
            valorDiariaTextBox.Text = "";
        }
    }
}
