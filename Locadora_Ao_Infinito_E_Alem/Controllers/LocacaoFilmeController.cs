using Locadora_Ao_Infinito_E_Alem.Contexto;
using Locadora_Ao_Infinito_E_Alem.Models;
using Microsoft.EntityFrameworkCore;

namespace Locadora_Ao_Infinito_E_Alem.Controllers
{
    public class LocacaoFilmeController
    {
        private readonly ContextoBD _context;

        public LocacaoFilmeController(ContextoBD context)
        {
            _context = context;
        }

        public async Task<List<LocacaoFilme>>? ListarFilmesLocados()
        {
            var FilmesLocados = await _context.Locacao_Filmes.Include(x => x.Filme).Include(y => y.Locacao).ToListAsync();
            return FilmesLocados;
        }

        public async Task<LocacaoFilme?> BuscarFilmeLocado(Filme filme)
        {
            var FilmesLocados = await _context.Locacao_Filmes.Where(p => p.Filme == filme).Include(x => x.Filme).Include(y => y.Locacao).FirstOrDefaultAsync();
            return FilmesLocados;
        }
        public async Task CadastrarLocacaoFilme(LocacaoFilme locacao_filme)
        {
            await _context.Locacao_Filmes.AddAsync(locacao_filme);
        }

        public async Task SalvarAlteracoes()
        {
            await _context.SaveChangesAsync();
        }
    }
}
