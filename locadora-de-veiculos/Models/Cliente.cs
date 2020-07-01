using System;
using System.Collections.Generic;
using System.Text;

namespace locadora_de_veiculos.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int CPF { get; set; }
        public int Telefone { get; set; }

        public Cliente()
        {

        }

        public override string ToString()
        {
            return "Nome: " + Nome
                + "  Email: " + Email
                + "\nCPF: " + CPF
                + "  Tel.: " + Telefone;
        }
    }
}
