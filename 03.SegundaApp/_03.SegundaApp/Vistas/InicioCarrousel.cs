using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _03.SegundaApp.Vistas
{
    public class InicioCarrousel: CarouselPage
    {
        public InicioCarrousel()
        {
            this.Title = "Inicio con Carrousel";

            NavigationPage.SetHasBackButton(this, false);

            var imagen1 = new Image
            {
                Source = "http://3.bp.blogspot.com/-P_cJ5BSx9A8/T4rvvWfTToI/AAAAAAAAAbo/716pM6gxHOc/s1600/tux6.png"
            };

            var tab1 = new ContentPage
            {
                Title = "Tux Ejecutivo",
                Content = new StackLayout
                {
                    Children = { imagen1 }
                }
            };

            var imagen2 = new Image
            {
                Source = "http://www.gifs-animados.es/gifs-imagenes/t/tux/gifs-animados-tux-971914.gif"
            };

            var tab2 = new ContentPage
            {
                Title = "Tux Batman",
                Content = new StackLayout
                {
                    Children = { imagen2 }
                }
            };

            var imagen3 = new Image
            {
                Source = "https://ugc.kn3.net/i/origin/http://3.bp.blogspot.com/_UqUwVPikChs/R-C7THbATKI/AAAAAAAAC90/C-R3ioFvlmQ/s320/santang-rambo-tux-2036.png"
            };

            var tab3 = new ContentPage
            {
                Title = "Tux Rambo",
                Content = new StackLayout
                {
                    Children = { imagen3 }
                }
            };

            Children.Add(tab1);
            Children.Add(tab2);
            Children.Add(tab3);
        }
    }
}
