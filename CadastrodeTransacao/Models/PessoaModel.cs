using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastrodeTransacao.Models
{
    //classe que representa a tabela Pessoa no banco de dados SQlite
    public class PessoaModel
    {
        [Key]
        public int PK_Pessoa { get; set; } //chave primaria

        public string Nome { get; set; } 

        public int Idade { get; set; }
    }
}
