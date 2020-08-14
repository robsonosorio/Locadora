using Locadora.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Locadora.Views
{
    public partial class FormVeiculo : Form
    {
        DataBase db = new DataBase();

        public FormVeiculo()
        {
            InitializeComponent();
        }

        private void Clear_TextBox()
        {
            MarcaComboBox.Text = "";
            modeloTextBox.Text = "";
            corTextBox.Text = "";
            valorDiariaTextBox.Text = "";
        }

        private void FormVeiculo_Load(object sender, EventArgs e)
        {
            string sqlDataGrid = "SELECT cr.CarroId, mc.Marca, cr.Modelo, cr.Cor, cr.ValorDiaria " +
                 "FROM Carro AS cr " +
                 "INNER JOIN MarcaCarro AS mc ON cr.MarcaId = mc.MarcaId";
            carroDataGridView.DataSource = db.Consulta(sqlDataGrid);

            string sqlMarca = "SELECT MarcaId, Marca FROM MarcaCarro ORDER BY Marca";
            MarcaComboBox.DataSource = db.Consulta(sqlMarca);
            MarcaComboBox.DisplayMember = "Marca";
            MarcaComboBox.ValueMember = "MarcaId";

            Clear_TextBox();
        }

        private void CarroDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            MarcaComboBox.Text = carroDataGridView.CurrentRow.Cells[1].Value.ToString();
            modeloTextBox.Text = carroDataGridView.CurrentRow.Cells[2].Value.ToString();
            corTextBox.Text = carroDataGridView.CurrentRow.Cells[3].Value.ToString();
            valorDiariaTextBox.Text = carroDataGridView.CurrentRow.Cells[4].Value.ToString();
        }

        private void AtualizarButton_Click(object sender, EventArgs e)
        {
            try
            {
                FormVeiculo_Load(sender, e);
                Clear_TextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorre erro" + ex.Message);
            }
        }

        private void SalvarButton_Click(object sender, EventArgs e)
        {
            Carro carro = new Carro();
            try
            {
                carro.MarcaId = int.Parse(MarcaComboBox.SelectedValue.ToString());
                carro.Modelo = modeloTextBox.Text;
                carro.Cor = corTextBox.Text;
                carro.ValorDiaria = double.Parse(valorDiariaTextBox.Text);

                carro.Salvar(carro);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
            }
            finally
            {
                FormVeiculo_Load(sender, e);
                Clear_TextBox();
            }
        }

        private void AlterarButton_Click(object sender, EventArgs e)
        {
            Carro carro = new Carro();
            try
            {
                carro.CarroId = int.Parse(carroDataGridView.CurrentRow.Cells[0].Value.ToString());
                carro.MarcaId = int.Parse(MarcaComboBox.SelectedValue.ToString());
                carro.Modelo = modeloTextBox.Text;
                carro.Cor = corTextBox.Text;
                carro.ValorDiaria = double.Parse(valorDiariaTextBox.Text);

                carro.Alterar(carro);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
            }
            finally
            {
                FormVeiculo_Load(sender, e);
                Clear_TextBox();
            }
        }

        private void DeletarButton_Click(object sender, EventArgs e)
        {
            Carro carro = new Carro();
            try
            {
                carro.CarroId = int.Parse(carroDataGridView.CurrentRow.Cells[0].Value.ToString());
  
                carro.Deletar(carro);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
            }
            finally
            {
                FormVeiculo_Load(sender, e);
                Clear_TextBox();
            }
        }

        private void SalvarMarcaButton_Click(object sender, EventArgs e)
        {
            MarcaCarro marca = new MarcaCarro();
            try
            {
                marca.Marca = cadastraMarcaTextBox.Text;

                marca.Salvar(marca);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
            }
            finally
            {
                FormVeiculo_Load(sender, e);
                Clear_TextBox();
            }
        }
    }
}
