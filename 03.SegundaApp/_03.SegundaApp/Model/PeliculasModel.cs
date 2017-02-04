using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SegundaApp.Model
{
    public class PeliculasModel
    {
        public int idPelicula { get; set; }
        public string nombrePelicula { get; set; }
        public int anoPelicula { get; set; }
        public string formatoPelicula { get; set; }
        public string Descripcion { get; set; }
        public int? idCliente { get; set; }

        //Externas al modelo
        public List<ActoresModel> ActoresPelicula { get; set; }
    }
}
