using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _03.SegundaApp.Vistas.Controles
{
    public class EditorTexto:ContentPage
    {
        public EditorTexto()
        {
            var miCajaTexto = new Editor()
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Keyboard = Keyboard.Chat
            };

            Content = miCajaTexto;

        }
    }
}
