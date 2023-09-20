using Microsoft.AspNetCore.Mvc;
using TrabajoIntegrador.Models;
using System;
using System.Linq;
using System.Collections.Generic;


namespace TrabajoIntegrador.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult IniciarSesion()
        {
            return View();
        }

        public IActionResult Registrarse()
        {
            return View();
        }


        
        public IActionResult CrearUsuario(string nombreUsuario, string contrasena, string email, string tipo)
        {
            ViewBag.ErrorUsuario = "";
            Usuario u = new Usuario();
            u.Nombre = nombreUsuario.Trim();
            u.Contrasena = contrasena.Trim();
            u.Email = email.Trim();
            u.Tipo = tipo;

            IEnumerable<Usuario> usuario = Usuario.usuarios.Where(u => u.Email == email);
            if (usuario.ToList().Count > 0)
            {
                ViewBag.ErrorUsuario = "El usuario ya existe";
                return View("Registrarse");
            }

            Usuario.usuarios.Add(u);
            Usuario.usuarioActual = u;


            return RedirectToAction("Index", "Home");
        }

        public IActionResult Iniciar(string email, string contrasena)
        {
            Usuario us = new Usuario();
            ViewBag.ErrorContrasena = "";
            ViewBag.ErrorMail = "";

            IEnumerable<Usuario> usuario = Usuario.usuarios.Where(u => u.Email == email);
            if(usuario == null || usuario.ToList().Count == 0)
            {
                ViewBag.ErrorMail = "El usuario no existe";
                return View("IniciarSesion");
            }
            foreach (Usuario u in usuario)
            {
                us = u;
            }

            if (us.Contrasena == contrasena)
            {
                Usuario.usuarioActual = us;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.ErrorContrasena = "La contraseña es incorrecta";
                return View("IniciarSesion");
            }


        }

        public IActionResult CerrarSesion()
        {
            Usuario.usuarioActual = null;
            return RedirectToAction("Index", "Home");
        }


    }

}
