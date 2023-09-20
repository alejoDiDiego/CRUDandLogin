using Microsoft.AspNetCore.Mvc;
using TrabajoIntegrador.Models;

namespace TrabajoIntegrador.Controllers
{
    public class PublicacionesController : Controller
    {
        public IActionResult CrearPublicacion()
        {
            return View();
        }

        public IActionResult VerPublicaciones()
        {
            return View();
        }


        public IActionResult CrearP(string titulo, string descripcion, decimal precio)
        {
            ViewBag.PublicacionCreada = "";
            Publicacion p = new Publicacion();
            p.Titulo = titulo.Trim();
            p.Descripcion = descripcion.Trim();
            p.Precio = precio;
            p.EmailVendedor = Usuario.usuarioActual.Email;
            p.NombreVendedor = Usuario.usuarioActual.Nombre;

            Publicacion.contID = Publicacion.contID + 1;

            p.Id = Publicacion.contID;

            Publicacion.publicaciones.Add(p);

            ViewBag.PublicacionCreada = "Se creo una publicacion";
            return View("VerPublicaciones");
        }


    }
}
