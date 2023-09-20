using System.Collections.Generic;

namespace TrabajoIntegrador.Models
{
    public class Publicacion
    {
        //A su vez, también debe poder crearse Publicaciones (Tienen un ID, titulo, descripción, precio y nombre del vendedor), deben ser almacenadas en una lista.
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string EmailVendedor { get; set; }
        public string NombreVendedor { get; set; }

        public static List<Publicacion> publicaciones = new List<Publicacion>();
        public static int contID = 0;

        public static List<Publicacion> busquedaVendedor = new List<Publicacion>();

    }
}
