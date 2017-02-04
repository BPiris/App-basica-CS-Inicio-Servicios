using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _03.SegundaApp.Vistas.Controles
{
    public class BarraProgreso:ContentPage
    {
        public BarraProgreso()
        {
            var miBarraProgreso = new ProgressBar()
            {
                Progress = .0
            };

            var btnIniciar = new Button()
            {
                Text = "Iniciar",
            };

            btnIniciar.Clicked += async (sender, args) =>
            {
                await miBarraProgreso.ProgressTo(1, 1500, Easing.Linear);
            };

        Content = new StackLayout()
            {
                Children = { btnIniciar, miBarraProgreso}                
            };

        }
    }
}
