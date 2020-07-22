using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Models
{
    class Locacao
    {
        public int LocacaoId { get; set; }
        public Cliente ClienteId { get; set; }
        public Carro CarroId { get; set; }
        public DateTime DataRetirada { get; set; }
        public DateTime Devolucao { get; set; }
    }
}
