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

        // Adiciona uma pessoa ao banco de dados
        public PessoaModel Adicionar(PessoaModel pessoa)
        {
            _context.Pessoa.Add(pessoa); // Adiciona a pessoa ao contexto do banco de dados
            _context.SaveChanges(); // Salva as alterações no banco de dados
            return pessoa; // Retorna a pessoa adicionada com a chave primária atualizada
        }

        // Remove uma pessoa do banco de dados com base no seu Id
        public bool Apagar(int Id)
        {
            PessoaModel pessoaDB = ListarID(Id); // Busca a pessoa no banco de dados com base no Id
            if (pessoaDB == null) throw new System.Exception("Houve um erro para deletar o contato!");

            _context.Pessoa.Remove(pessoaDB); // Remove a pessoa do contexto do banco de dados
            _context.SaveChanges(); // Salva as alterações no banco de dados

            return true;
        }

        // Busca uma pessoa no banco de dados com base no seu Id
        public PessoaModel ListarID(int Id)
        {
            return _context.Pessoa.FirstOrDefault(x => x.PK_Pessoa == Id); // Busca a pessoa com base no Id
        }

        // Lista todas as pessoas do banco de dados
        public List<PessoaModel> ListarPessoas()
        {
            return _context.Pessoa.ToList(); // Retorna uma lista com todas as pessoas do banco de dados
        }
    }
}
