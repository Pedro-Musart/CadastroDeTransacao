using Microsoft.AspNetCore.Mvc;

namespace CadastrodeTransacao.Repositorio
{
    public class TransacoesRepositorio : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
