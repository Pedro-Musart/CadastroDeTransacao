using CadastrodeTransacao.Models;

namespace CadastrodeTransacao.Repositorio
{
    public class ContaRepositorio : IContaRepositorio
    {
        private readonly DataContext _context;
        public ContaRepositorio(DataContext context)
        {
            _context = context;
        }
        public PessoaModel Adicionar(PessoaModel pessoa)
        {
            _context.Pessoa.Add(pessoa);
            _context.SaveChanges();
            return pessoa;
        }

        public bool Apagar(int Id)
        {
            PessoaModel pessoaDB = ListarID(Id);
            if (pessoaDB == null) throw new System.Exception("Houve um erro para deletar o contato!");

            _context.Pessoa.Remove(pessoaDB);
            _context.SaveChanges();

            return true;

        }

        public PessoaModel ListarID(int Id)
        {

            return _context.Pessoa.FirstOrDefault(x => x.PK_Pessoa == Id);
        }

        public List<PessoaModel> ListarPessoas()
        {
            return _context.Pessoa.ToList();
        }

    }
}
