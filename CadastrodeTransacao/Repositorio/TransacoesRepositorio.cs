using CadastrodeTransacao.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastrodeTransacao.Repositorio
{
    public class TransacoesRepositorio : ITransacoesRepositorio
    {
        // Declaração de uma variável privada para armazenar uma instância de DataContext.
        private readonly DataContext _context;

        // Construtor da classe que recebe um DataContext como parâmetro e armazena na variável privada _context.
        public TransacoesRepositorio(DataContext context)
        {
            _context = context;
        }

        // Método para adicionar uma nova transação ao contexto e salvar as alterações no banco de dados.
        public TransacoesModel AdicionarTransacao(TransacoesModel transacao)
        {
            _context.Transacoes.Add(transacao);
            _context.SaveChanges();
            return transacao;
        }

        // Método que retorna uma lista com todas as transações.
        public List<TransacoesModel> ListarTransacoes()
        {
            throw new NotImplementedException();
        }

        // Método que retorna uma transação com um determinado ID.
        public TransacoesModel TransacaoId(int Id)
        {
            throw new NotImplementedException();
        }

        // Implementação da interface ITransacoesRepositorio para retornar a soma das transações.

    }
}

