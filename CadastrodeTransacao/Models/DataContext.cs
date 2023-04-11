using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastrodeTransacao.Models
{
    // Contexto para o banco de dados que herda da classe DbContext
    public class DataContext : DbContext
    {
        // DbSet para a tabela Pessoa, que utiliza o modelo PessoaModel
        public DbSet<PessoaModel> Pessoa { get; set; }

        // DbSet para a tabela Transacoes, que utiliza o modelo TransacoesModel
        public DbSet<TransacoesModel> Transacoes { get; set; }

        // Construtor que recebe as opções de configuração para o DbContext
        public DataContext(DbContextOptions<DataContext> opcoes) : base(opcoes)
        {
        }
    }
}