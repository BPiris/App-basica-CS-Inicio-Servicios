using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _03.SegundaApp.Vistas
{
    public class Inicio: ContentPage
    {
        public Inicio()
        {
            var txtBienvenido = new Label
            {
                Text = "Bienvenido a la pagina de inicio"
            };

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children = { txtBienvenido}
            };

            Title = "Eres un h4x0r";
            
            NavigationPage.SetHasBackButton(this, false);

        }
    }
}
