using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TrabajoIntegrador.Models;

namespace TrabajoIntegrador.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            Publicacion.busquedaVendedor.Clear();
            return View();
        }

        public IActionResult BuscarVendedor(string barraBusqueda)
        {
            if (barraBusqueda == null)
            {
                return View("Index");
            }
            string busqueda = barraBusqueda.Trim().ToLower();
            IEnumerable<Publicacion> resultado = from p in Publicacion.publicaciones where p.NombreVendedor.ToLower().Trim().Contains(busqueda) || p.EmailVendedor.ToLower().Trim().Contains(busqueda) select p;
            Publicacion.busquedaVendedor = resultado.ToList();
            return View("Index");
        }

        public IActionResult Reset()
        {
            Publicacion.busquedaVendedor.Clear();
            return View("Index");
        }


        

    }
}
