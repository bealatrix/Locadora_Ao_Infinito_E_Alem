using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_Ao_Infinito_E_Alem.Models
{
    [Table("funcionario")]
    public class Funcionario
    {
        [Column("id_funcionario")]
        public int ID { get; set; }
        
        [Column("nome")]
        public string nome { get; set; }
        
        [Column("data_nascimento")]
        public DateOnly data_nascimento { get; set; }
        
        [Column("telefone")]
        public int telefone { get; set; }
        
        [Column("rg")]
        public int rg { get; set; }
        
        [Column("cpf")]
        public string cpf { get; set; }
        
        [Column("salario")]
        public decimal salario { get; set; }

        public List<Locacao>? Locacoes { get; set; }
    }
}
