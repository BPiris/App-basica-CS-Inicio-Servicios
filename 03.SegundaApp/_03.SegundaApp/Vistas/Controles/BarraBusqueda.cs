using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _03.SegundaApp.Vistas.Controles
{
    public class BarraBusqueda:ContentPage
    {
        public BarraBusqueda()
        {
            var lblResultados = new Label()
            {
                Text = "Los resultados deben aparecer aquí",
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };

            var inputBusqueda = new SearchBar()
            {
                Placeholder = "Introduzca la busqueda aquí"
            };

            inputBusqueda.SearchCommand = new Command(()=> lblResultados.Text = "Resultados :"+ inputBusqueda.Text);

            Content = new StackLayout()
            {
                Children = { inputBusqueda , lblResultados}
            };
        }
    }
}
