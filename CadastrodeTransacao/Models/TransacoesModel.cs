using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using CadastrodeTransacao.Models;

namespace CadastrodeTransacao.Models
{
    //classe que representa a tabela transações no banco de dados SQlite
    public class TransacoesModel
    {
        
        [Key]
        public int PK_Transacao { get; set; } //chave primaria que adicionei para cada transação

        public PessoaModel PK_Pessoa { get; set; } //representa a chave estrangeira PessoaModel

        [ForeignKey("PK_Pessoa")]
        [Required]
        public int FK_Pessoa { get; set; }//essa é a propria chave estrangeira da classe PessoaModel

        public string Descricao { get; set; }

        public int Valor { get; set; }

        public Boolean Tipo { get; set; }
    }
}
