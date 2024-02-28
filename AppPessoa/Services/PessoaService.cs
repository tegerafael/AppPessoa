using AppPessoa.Contexto;
using AppPessoa.Models;

namespace AppPessoa.Services
{
    public class PessoaService
    {
        private readonly ContextBD _context;

        public PessoaService(ContextBD context)
        {
            _context = context;
        }

        public async Task<List<Pessoa>>? Pessoas()
        {
            var pessoas = _context.Pessoas?.ToList();
            return pessoas;
        }

        public async Task<Pessoa>? GetPessoa(int id)
        {
            var pessoa = _context.Pessoas?.Where(p => p.Id == id).FirstOrDefault();
            return pessoa;
        }

        public async Task Add(Pessoa pessoa)
        {
            _context.Pessoas?.Add(pessoa);
        }
    }
}
