using Locadora_Ao_Infinito_E_Alem.Contexto;
using Locadora_Ao_Infinito_E_Alem.Models;
using Microsoft.EntityFrameworkCore;

namespace Locadora_Ao_Infinito_E_Alem.Controllers
{
    public class FuncionarioController
    {
        private readonly ContextoBD _context;

        public FuncionarioController(ContextoBD context)
        {
            _context = context;
        }

        public async Task<List<Funcionario>>? ListarFuncionarios()
        {
            var funcionarios = await _context.Funcionarios.Include(x => x.Locacoes).ToListAsync();
            return funcionarios;
        }

        public async Task<Funcionario?> BuscarFuncionario(string nome)
        {
            var funcionarios = await _context.Funcionarios.Where(p => p.nome == nome).Include(x => x.Locacoes).FirstOrDefaultAsync();
            return funcionarios;
        }
        public async Task CadastrarFuncionario(Funcionario funcionario)
        {
            await _context.Funcionarios.AddAsync(funcionario);
        }

        public async Task SalvarAlteracoes()
        {
            await _context.SaveChangesAsync();
        }
    }
}
