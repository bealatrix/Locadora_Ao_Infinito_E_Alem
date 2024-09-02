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
    internal class LocacaoController
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
        public async Task CadastrarLocacao(Locacao locacao)
        {
            await _context.Locacoes.AddAsync(locacao);
        }

        public async Task SalvarAlteracoes()
        {
            await _context.SaveChangesAsync();
        }
    }
}
