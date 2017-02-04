using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace _03.SegundaApp.Vistas
{
    public class Login: ContentPage
    {
        public Login()
        {
            var etiqueta = new Label
            {
                Text = "Bienvenidos"
            };

            var etiquetaBorde = new Frame
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Content = etiqueta
            };

            var inputLogin = new Entry
            {
                Placeholder = "Introduzca el usuario"
            };

            var inputPassword = new Entry
            {
                Placeholder = "Introduzca la password",
                IsPassword = true
            };

            var inputBorde = new Frame
            {
                Content = new StackLayout
                {
                    Children = { inputLogin,inputPassword}
                }
            };

            var btnAcceso = new Button
            {                                
                Text = "Entrar"
            };

            btnAcceso.Clicked += (sender, args) =>
            {
                //Navigation.PushAsync(new Inicio());
                //Navigation.PushAsync(new InicioTabbed());
                //Navigation.PushAsync(new InicioCarrousel());
                Navigation.PushAsync(new InicioPaginaDetalle());

            };

            Content = new StackLayout
            {                
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children = { etiquetaBorde, inputBorde, btnAcceso}
            };

            Title = "Acceso";
        }
    }
}
