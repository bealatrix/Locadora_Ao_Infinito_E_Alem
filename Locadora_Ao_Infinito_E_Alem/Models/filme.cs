using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_Ao_Infinito_E_Alem.Models
{
    [Table("filme")]
    public class Filme
    {
        [Column("id_filme")]
        public int ID { get; set; }

        [Column("titulo")]
        public string titulo { get; set; }
        
        [Column("classificacao_indicativa")]
        public string classificacao_indicativa { get; set; }
        
        [Column("duracao")]
        public int duracao { get; set; }
        
        [Column("preco")]
        public decimal preco { get; set; }
        
        [Column("estoque")]
        public string estoque { get; set; }

        public List<LocacaoFilme>? LocacoesFilmes { get; set; }
    }
}
