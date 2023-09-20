using System.Collections.Generic;

namespace TrabajoIntegrador.Models
{
    public class Usuario
    {
        //Deben poder crearse Usuarios los cuales tienen un nombre de usuario, una contraseña, un email, y un tipo(Vendedor o Cliente), estos deben ser almacenados en una lista.
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public string Email { get; set; }
        public string Tipo { get; set; }

        public static List<Usuario> usuarios = new List<Usuario>();

        public static Usuario usuarioActual = null;

    }
}
