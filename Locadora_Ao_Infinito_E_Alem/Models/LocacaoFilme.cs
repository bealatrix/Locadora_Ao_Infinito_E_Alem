using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_Ao_Infinito_E_Alem.Models
{
    [Table("locacao_filme")]
    public class LocacaoFilme
    {
        [Column("id_loc_filme")]
        public int ID { get; set; }

        [Column("quantidade")]
        public int quantidade { get; set; }

        [Column("valor_filme")]
        public decimal valor {  get; set; }

        [Column("fk_locacao")]
        public int LocacaoFK { get; set; }

        [Column("fk_filme")]
        public int FilmeFK { get; set; }


        [ForeignKey("LocacaoFK")]
        public Locacao? Locacao { get; set; }

        [ForeignKey("FilmeFK")]
        public Filme? Filme { get; set; }

    }
}
