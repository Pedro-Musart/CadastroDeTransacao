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
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Receita()
        {
            return View();
        }

        public IActionResult Despesa()
        {
            return View();
        }
    }
}
