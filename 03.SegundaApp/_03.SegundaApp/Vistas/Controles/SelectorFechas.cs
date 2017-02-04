using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _03.SegundaApp.Vistas.Controles
{
    public class SelectorFechas:ContentPage
    {
        public SelectorFechas()
        {
            var datePicker = new DatePicker()
            {
                Format = "d",
                VerticalOptions = LayoutOptions.Center
            };

            Content = new StackLayout()
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Children = { datePicker}
            };
        }
    }
}
