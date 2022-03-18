using Portafolio.Models;

namespace Portafolio.Services
{
    public class RepositorioProyectos
    {

        public List<ProyectoViewModel> ObtenerProyectos()
        {
            return new List<ProyectoViewModel>() {
                new ProyectoViewModel
            {
                Titulo = "Amazon",
                Descripcion ="E-Commerce realizado en ASP.NET Core",
                Link = "https://amazon.com",
                ImagenURL = "/imagenes/amazon.png"
            },
                  new ProyectoViewModel
            {
                Titulo = "New York Times",
                Descripcion ="Página de noticias en React",
                Link = "https://nytimes.com",
                ImagenURL = "/imagenes/nyt.png"
            },
                    new ProyectoViewModel
            {
                Titulo = "Reddit",
                Descripcion ="Red social para compartir en comunidades",
                Link = "https://reddit.com",
                ImagenURL = "/imagenes/reddit.png"
            },
                      new ProyectoViewModel
            {
                Titulo = "Steam",
                Descripcion ="Tienda en línea para comprar videojuegos",
                Link = "https://store.steampowered.com",
                ImagenURL = "/imagenes/steam.png"
            }
            };
        }

    }
}
