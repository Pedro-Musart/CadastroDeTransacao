using CadastrodeTransacao.Models;

namespace CadastrodeTransacao.Repositorio
{
    public interface IContaRepositorio
    {
        PessoaModel Adicionar(PessoaModel pessoa);

        List<PessoaModel> ListarPessoas();

        PessoaModel ListarID(int PK_Pessoa);

        bool Apagar(int id);
    }

        
}
