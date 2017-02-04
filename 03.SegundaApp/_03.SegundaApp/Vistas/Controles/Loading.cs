using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _03.SegundaApp.Vistas.Controles
{
    public class Loading:ContentPage
    {
        public Loading()
        {
            var loading = new ActivityIndicator();
            loading.Color = Color.Blue;
            loading.IsRunning = true;

            Content = new StackLayout()
            {
                Children = { loading}
            };
        }
    }
}
