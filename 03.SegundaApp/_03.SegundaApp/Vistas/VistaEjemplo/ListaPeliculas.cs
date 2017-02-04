using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using _03.SegundaApp.Model;

namespace _03.SegundaApp.Vistas.VistaEjemplo
{
    public class ListaPeliculas:ContentPage
    {
        public ListaPeliculas()
        {

            var listaPeliculas = new List<PeliculasModel>();
            var listaViewPeliculas = new ListView()
            {
                ItemTemplate = new DataTemplate(() =>
                {
                    var texto = new TextCell();
                    texto.SetBinding(TextCell.TextProperty, "nombrePelicula");
                    return texto;
                }),
                VerticalOptions = LayoutOptions.FillAndExpand,
                SeparatorVisibility = SeparatorVisibility.None
            };

            var btnObtenerPeliculas = new Button()
            {
                Text = "Obtener Peliculas"
            };

            btnObtenerPeliculas.Clicked += async (sender, args) =>
            {
                listaPeliculas = await new Servicios<PeliculasModel>().Get("peliculas");
                listaViewPeliculas.ItemsSource = listaPeliculas;
            };

            Content = new StackLayout()
            {
                Children = { btnObtenerPeliculas,listaViewPeliculas}
            };
        }
    }
}
