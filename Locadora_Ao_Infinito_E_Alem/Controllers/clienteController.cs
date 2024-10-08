﻿using Locadora_Ao_Infinito_E_Alem.Contexto;
using Locadora_Ao_Infinito_E_Alem.Models;
using Microsoft.EntityFrameworkCore;

namespace Locadora_Ao_Infinito_E_Alem.Controllers
{
    public class ClienteController
    {
        private readonly ContextoBD _context;

        public ClienteController(ContextoBD context)
        {
            _context = context;
        }

        public async Task<List<Cliente>>? ListarClientes()
        {
            var clientes = await _context.Clientes.Include(x => x.Locacoes).ToListAsync();
            return clientes;
        }

        public async Task<Cliente?> BuscarCliente(string nome)
        {
            var clientes = await _context.Clientes.Where(p => p.nome == nome).Include(x => x.Locacoes).FirstOrDefaultAsync();
            return clientes;
        }
        public async Task CadastrarCliente(Cliente cliente)
        {
            await _context.Clientes.AddAsync(cliente);
        }

        public async Task SalvarAlteracoes()
        {
            await _context.SaveChangesAsync();
        }
    }
}
