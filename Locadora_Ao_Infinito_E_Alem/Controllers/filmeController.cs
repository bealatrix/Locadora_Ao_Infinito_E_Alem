using Locadora_Ao_Infinito_E_Alem.Contexto;
using Locadora_Ao_Infinito_E_Alem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_Ao_Infinito_E_Alem.Controllers
{
    internal class FilmeController
    {
        private readonly ContextoBD _context;

        public FilmeController(ContextoBD context)
        {
            _context = context;
        }

        public async Task<List<Filme>>? ListarFilmes()
        {
            var filmes = await _context.Filmes.Include(x => x.LocacoesFilmes).ToListAsync();
            return filmes;
        }

        public async Task<Filme?> BuscarFilme(string titulo)
        {
            var filmes = await _context.Filmes.Where(p => p.titulo == titulo).Include(x => x.LocacoesFilmes).FirstOrDefaultAsync();
            return filmes;
        }
        public async Task CadastrarFilme(Filme filme)
        {
            await _context.Filmes.AddAsync(filme);
        }

        public async Task SalvarAlteracoes()
        {
            await _context.SaveChangesAsync();
        }
    }
}
