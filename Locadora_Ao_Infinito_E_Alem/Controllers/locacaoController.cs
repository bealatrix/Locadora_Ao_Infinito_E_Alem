using Locadora_Ao_Infinito_E_Alem.Contexto;
using Locadora_Ao_Infinito_E_Alem.Models;
using Microsoft.EntityFrameworkCore;

namespace Locadora_Ao_Infinito_E_Alem.Controllers
{
    public class LocacaoController
    {
        private readonly ContextoBD _context;

        public LocacaoController(ContextoBD context)
        {
            _context = context;
        }

        public async Task<List<Locacao>>? ListarLocacoes()
        {
            var locacoes = await _context.Locacoes.Include(x => x.Cliente).Include(y => y.Funcionario).ToListAsync();
            return locacoes;
        }

        public async Task<Locacao?> BuscarLocacao(Cliente cliente)
        {
            var locacoes = await _context.Locacoes.Where(p => p.Cliente == cliente).Include(x => x.Cliente).Include(y => y.Funcionario).FirstOrDefaultAsync();
            return locacoes;
        }
        public async Task<Locacao?> CadastrarLocacao(List<Locacao> locacoes)
        {
            await _context.Locacoes.AddRangeAsync(locacoes);
            var locacaoAtual = await _context.Locacoes.LastAsync();
            return locacaoAtual;
        }

        public async Task SalvarAlteracoes()
        {
            await _context.SaveChangesAsync();
        }
    }
}
