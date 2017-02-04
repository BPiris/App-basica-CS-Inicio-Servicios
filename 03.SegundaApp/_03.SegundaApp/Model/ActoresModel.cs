using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SegundaApp.Model
{
    public class ActoresModel
    {
        public int idActores { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }

        //Externa al modelo
        public int SueldoActorEnPelicula { get; set; }

        //Necesaria para el uso de MVC
        public int idPelicula { get; set; }
    }
}
