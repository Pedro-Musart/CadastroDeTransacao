using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using CadastrodeTransacao.Models;

namespace CadastrodeTransacao.Models
{

    public class TransacoesModel
    {
        
        [Key]
        public int PK_Transacao { get; set; }

        public PessoaModel PK_Pessoa { get; set; } 

        [ForeignKey("PK_Pessoa")]
        [Required]
        public int FK_Pessoa { get; set; }

        public string? Descricao { get; set; }

        public int Valor { get; set; }

        public string Tipo { get; set; } 

       
    }
}
