using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
             cliente.Nome = textBox1.Text;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            cliente.Email = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            cliente.CPF = int.Parse(textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            cliente.Telefone = int.Parse(textBox4.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro realizado com sucesso!\n"
                + cliente );
        }
    }
}
