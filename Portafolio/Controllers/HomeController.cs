using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        private List<ProyectoViewModel> ObtenerProyectos()
        {
            return new List<ProyectoViewModel>() {
                new ProyectoViewModel
            {
                Titulo = "Amazon",
                Descripcion ="E-Commerce realizado en ASP.NET Core",
                Link = "https://amazon.com",
                ImagenURL = ""
            },
                  new ProyectoViewModel
            {
                Titulo = "New York Times",
                Descripcion ="Página de noticias en React",
                Link = "https://nytimes.com",
                ImagenURL = ""
            },
                    new ProyectoViewModel
            {
                Titulo = "Reddit",
                Descripcion ="Red social para compartir en comunidades",
                Link = "https://reddit.com",
                ImagenURL = ""
            },
                      new ProyectoViewModel
            {
                Titulo = "Steam",
                Descripcion ="Tienda en línea para comprar videojuegos",
                Link = "https://store.steampowered.com",
                ImagenURL = ""
            }
            };
        }

        public IActionResult Privacy()
        {
            return View("Privacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}