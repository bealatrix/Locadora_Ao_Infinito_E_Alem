using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_Ao_Infinito_E_Alem.Models
{
    [Table("locacao")]
    public class Locacao
    {
        [Column("id_locacao")]
        public int ID { get; set; }

        [Column("data_locacao")]
        public DateTime data_locacao { get; set; }

        [Column("data_devolucao")]
        public DateTime data_devolucao { get; set; }

        [Column("valor_total")]
        public decimal valor_total { get; set; }

        [Column("status")]
        public char Status { get; set; }

        [Column("fk_cliente")]
        public int ClienteFK { get; set; }

        [Column("fk_funcionario")]
        public int FuncionarioFK { get; set; }

        public List<LocacaoFilme>? LocacaoFilmes { get; set; }

        [ForeignKey("ClienteFK")]
        public Cliente? Cliente { get; set; }

        [ForeignKey("FuncionarioFK")]
        public Funcionario? Funcionario { get; set; }

    }
}
