using Locadora_Ao_Infinito_E_Alem.Models;
using Microsoft.EntityFrameworkCore;

namespace Locadora_Ao_Infinito_E_Alem.Contexto
{
    public class ContextoBD : DbContext
    {
        public ContextoBD(DbContextOptions<ContextoBD> options) : base(options) { }

        public DbSet<cliente> Clientes { get; set; }
        public DbSet<filme> Filmes { get; set; }
        public DbSet<funcionario> Funcionarios { get; set; }
        public DbSet<locacao> Locacoes { get; set; }
        public DbSet<locacao_filme> Locacao_Filmes { get; set; }
    }
}
