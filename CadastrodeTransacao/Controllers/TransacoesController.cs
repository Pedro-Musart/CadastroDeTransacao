using CadastrodeTransacao.Models;
using CadastrodeTransacao.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastrodeTransacao.Controllers
{
    public class TransacoesController : Controller
    {
        // Ação responsável por mostrar a lista de transações
        public IActionResult Index()
        {
            // Faz a junção das tabelas Transacoes e Pessoa, criando uma lista de tuplas
            List<Tuple<TransacoesModel, PessoaModel>> transacoes =
                (from t in _context.Transacoes
                 join p in _context.Pessoa on t.FK_Pessoa equals p.PK_Pessoa
                 select Tuple.Create(t, p))
                .ToList();

           
            return View(transacoes);
        }

        // Ação responsável por mostrar a view de Transacao
        public IActionResult Transacao()
        {
            return View();
        }

        // Ação responsável por mostrar a view de adição de Despesa
        public IActionResult Despesa()
        {
            return View();
        }


        private ITransacoesRepositorio _transacoesRepositorio;
        // Contexto do banco de dados
        private readonly DataContext _context;

        // Injecao de dependencia
        public TransacoesController(ITransacoesRepositorio transacoes, DataContext context)
        {
            _transacoesRepositorio = transacoes;
            _context = context;
        }

        // Ação responsável por adicionar uma receita ao context
        [HttpPost]
        public IActionResult Receita(TransacoesModel transacao)
        {
      
            var pessoa = _context.Pessoa.FirstOrDefault(p => p.PK_Pessoa == transacao.FK_Pessoa);

            // Verifica se a pessoa é menor de idade
            if (pessoa.Idade < 18)
            {
                ModelState.AddModelError("Idade", "A pessoa é menor de idade e não pode realizar.");
                ViewBag.ErrorMessage = "A pessoa é menor de idade e não pode realizar.";
            }

            // Define o tipo da transação como Receita
            transacao.Tipo = "Receita";
   
            _transacoesRepositorio.AdicionarTransacao(transacao);

            return RedirectToAction("Index");
        }

        // Ação responsável por adicionar uma despesa
        [HttpPost]
        public IActionResult Despesa(TransacoesModel transacao)
        {
            // Define o tipo da transação como Despesa
            transacao.Tipo = "Despesa";
            // Inverte o sinal do valor, para ficar negativo
            transacao.Valor *= -1;

            _transacoesRepositorio.AdicionarTransacao(transacao);

            // Redireciona para a página de listagem de transações
            return RedirectToAction("Index");
        }
    }
}
