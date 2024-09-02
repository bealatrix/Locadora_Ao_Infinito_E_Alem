using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_Ao_Infinito_E_Alem.Models
{
    public class filme
    {
        public int ID { get; set; }
        public string titulo { get; set; }
        public string classificacao_indicativa { get; set; }
        public int duracao { get; set; }
        public decimal preco { get; set; }
        public string estoque { get; set; }
    }
}
