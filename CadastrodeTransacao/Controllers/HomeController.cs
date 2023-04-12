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
    public class HomeController : Controller
    {
        private readonly DataContext _context;
        private readonly IContaRepositorio _contaRepositorio;

        // Constructor para inicializar o DbContext e o repositório de contas
        public HomeController(IContaRepositorio contaRepositorio, DataContext context)
        {
            _contaRepositorio = contaRepositorio;
            _context = context;
        }

        public IActionResult Index()
        {
            // Seleciona as transações e as pessoas relacionadas em um Tuple e retorna para a view
            List<Tuple<TransacoesModel, PessoaModel>> transacoes =
                (from t in _context.Transacoes
                 join p in _context.Pessoa on t.FK_Pessoa equals p.PK_Pessoa
                 select Tuple.Create(t, p))
                .ToList();

            return View(transacoes);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Contas()
        {
            // Lista as pessoas e retorna para a view
            List<PessoaModel> pessoas = _contaRepositorio.ListarPessoas();
            return View(pessoas);
        }

        public IActionResult Apagar(int Id)
        {
            // Retorna a view de confirmação de exclusão de uma pessoa específica
            PessoaModel pessoa = _contaRepositorio.ListarID(Id);
            return View(pessoa);
        }

        public IActionResult ConfirmaDelete(int Id)
        {
            // Exclui a pessoa do banco de dados e redireciona para a página inicial
            _contaRepositorio.Apagar(Id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Criar(PessoaModel pessoa)
        {
            // Adiciona uma nova pessoa ao banco de dados e redireciona para a página inicial
            _contaRepositorio.Adicionar(pessoa);
            return RedirectToAction("Index");
        }
    }
}

