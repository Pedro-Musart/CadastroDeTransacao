using Microsoft.AspNetCore.Mvc;

namespace CadastrodeTransacao.Controllers
{
    public class TransacoesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
