using Microsoft.AspNetCore.Mvc;
using CrudMoura.Models;


namespace CrudMoura.Controllers
{

    public class FrutasController : Controller
    {
        private readonly ILogger<FrutasController> _logger;

        public static List<Fruta> listaDeFrutas = new List<Fruta>
        {
            new Fruta{ Id = 1, Nome = "Morango", Preço = 5.99f, Quantidade = 10, Categoria = "Tropical"},
            new Fruta{ Id = 2, Nome = "Abacate", Preço = 5.99f, Quantidade = 12, Categoria = "Tropical"},
            new Fruta{ Id = 3, Nome = "Limão", Preço = 2.95f, Quantidade = 100, Categoria = "citrica"},
        };

        public FrutasController(ILogger<FrutasController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {


            return View();
        }


        public IActionResult ListarFrutas()
        {
            ViewBag.sacolinha = listaDeFrutas;

            return View();
        }





        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        // [ValidateAntiForgeryToken]

        public IActionResult SalvarFruta(Fruta frutaCadastrada)
        {

            frutaCadastrada.Id = listaDeFrutas.Max(f => f.Id) + 1;
            listaDeFrutas.Add(frutaCadastrada);
            return RedirectToAction(nameof(ListarFrutas));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}