using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using _03.SegundaApp.Model;
using _03.SegundaApp.Vistas.Controles;
using _03.SegundaApp.Vistas.VistaEjemplo;

namespace _03.SegundaApp.Vistas
{
    public class PaginaMaestra: ContentPage
    {
        public ListView ListView { get { return listView; } }

        ListView listView;

        public PaginaMaestra()
        {
            var elementosMasterPage = new List<ElementoMasterPageModel>();

            elementosMasterPage.Add(new ElementoMasterPageModel
            {
                Titulo = "Inicio Simple",
                EnlacePagina = typeof(Inicio)               
            });

            elementosMasterPage.Add(new ElementoMasterPageModel
            {
                Titulo = "Inicio Tabbed",
                EnlacePagina = typeof(InicioTabbed)
            });

            elementosMasterPage.Add(new ElementoMasterPageModel
            {
                Titulo = "Inicio Carrousel",
                EnlacePagina = typeof(InicioCarrousel)
            });

            elementosMasterPage.Add(new ElementoMasterPageModel
            {
                Titulo = "Activity Indicator",
                EnlacePagina = typeof(Loading)
            });

            elementosMasterPage.Add(new ElementoMasterPageModel()
            {
                Titulo = "DatePicker",
                EnlacePagina = typeof(SelectorFechas)
            });

            elementosMasterPage.Add(new ElementoMasterPageModel()
            {
                Titulo = "Caja de Texto",
                EnlacePagina = typeof(EditorTexto)
            });

            elementosMasterPage.Add(new ElementoMasterPageModel()
            {
                Titulo = "Selector",
                EnlacePagina = typeof(Selector)
            });

            elementosMasterPage.Add(new ElementoMasterPageModel()
            {
                Titulo = "Barra de Progreso",
                EnlacePagina = typeof(BarraProgreso)
            });

            elementosMasterPage.Add(new ElementoMasterPageModel()
            {
                Titulo = "Barra Busqueda",
                EnlacePagina = typeof(BarraBusqueda)
            });

            elementosMasterPage.Add(new ElementoMasterPageModel()
            {
                Titulo = "Lista Peliculas",
                EnlacePagina = typeof(ListaPeliculas)
            });

            listView = new ListView
            {
                ItemsSource = elementosMasterPage,
                ItemTemplate = new DataTemplate(() =>
                {
                    var texto = new TextCell();
                    texto.SetBinding(TextCell.TextProperty, "Titulo");
                    return texto;
                }),
                VerticalOptions = LayoutOptions.FillAndExpand,
                SeparatorVisibility = SeparatorVisibility.None
            };

            Padding = new Thickness(0, 0, 0, 0);
            Title = "Personal Organiser";
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = { listView }
            };
        }
    }
}
