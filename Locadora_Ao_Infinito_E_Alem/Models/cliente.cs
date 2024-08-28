using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_Ao_Infinito_E_Alem.Models
{
    internal class cliente
    {
        public int ID { get; set; }
        public string nome { get; set; }
        public DateOnly data_nascimento { get; set; }
        public int telefone { get; set; }
        public int rg { get; set; }
        public string cpf { get; set; }
    }
}
