using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using _03.SegundaApp.Model;

namespace _03.SegundaApp.Vistas.Controles
{
    public class Selector : ContentPage
    {

        List<SelectorModelo> listado = new List<SelectorModelo>()
        {
            new SelectorModelo() { Key = 0, Titulo = "bebote", Url = "http://blogs.altuxa.com/tapaponga/files/2011/02/tux-baby.png" },
            new SelectorModelo() { Key = 1, Titulo = "Indio", Url = "https://s-media-cache-ak0.pinimg.com/originals/eb/41/69/eb416974b479f24060d3910dc1e5f28e.jpg" },
            new SelectorModelo() { Key = 2, Titulo = "Paladin", Url = "http://img.webme.com/pic/y/yonkislinux/knight-tux.png"}
        };

        public Selector()
        {
            var cabecera = new Label()
            {
                Text = "Seleccione texto"
            };

            var selector = new Picker()
            {
                Title = "Seleccione Imagen"
            };

            foreach (var item in listado)
            {
                selector.Items.Add(item.Titulo);
            }

            var imagenInicio = new Image()
            {
                Source = "http://blogs.altuxa.com/tapaponga/files/2011/02/tux-baby.png"
            };

            selector.SelectedIndexChanged += (sender, args) =>
            {
                if (selector.SelectedIndex == -1)
                {
                    imagenInicio.Source = "http://blogs.altuxa.com/tapaponga/files/2011/02/tux-baby.png";
                }
                else
                {
                    imagenInicio.Source = listado.AsQueryable().First(bd => bd.Key == selector.SelectedIndex).Url;
                }
            };

            Content = new StackLayout()
            {
                Children = { cabecera, selector, imagenInicio }
            };
        }
    }
}
