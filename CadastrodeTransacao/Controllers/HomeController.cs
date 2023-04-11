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

    //Controller das 
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<PessoaModel> pessoas = _contaRepositorio.ListarPessoas();
            return View(pessoas);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Apagar(int Id)
        {
            PessoaModel pessoa =_contaRepositorio.ListarID(Id);
            
            return View(pessoa);
        }

        public IActionResult ConfirmaDelete(int Id)
        {
            _contaRepositorio.Apagar(Id);
            return RedirectToAction("Index");
        }

        private readonly IContaRepositorio _contaRepositorio;
        public HomeController(IContaRepositorio contaRepositorio)
        {
            _contaRepositorio = contaRepositorio;
        }

        [HttpPost]
        public IActionResult Criar (PessoaModel pessoa)
        {
            _contaRepositorio.Adicionar(pessoa);
                return RedirectToAction("Index");
        }

    }
}
