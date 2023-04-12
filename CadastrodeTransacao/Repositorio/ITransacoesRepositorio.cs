using CadastrodeTransacao.Models;

namespace CadastrodeTransacao.Repositorio
{
    public interface ITransacoesRepositorio
    {
        TransacoesModel AdicionarTransacao(TransacoesModel transacao);

        List<TransacoesModel> ListarTransacoes();

        TransacoesModel TransacaoId(int Id);

     
    }
}

