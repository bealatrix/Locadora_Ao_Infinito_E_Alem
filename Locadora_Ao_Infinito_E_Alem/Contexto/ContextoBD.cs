using Locadora_Ao_Infinito_E_Alem.Models;
using Microsoft.EntityFrameworkCore;

namespace Locadora_Ao_Infinito_E_Alem.Contexto
{
    public class ContextoBD : DbContext
    {
        public ContextoBD(DbContextOptions<ContextoBD> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Locacao> Locacoes { get; set; }
        public DbSet<LocacaoFilme> Locacao_Filmes { get; set; }
    }
}
