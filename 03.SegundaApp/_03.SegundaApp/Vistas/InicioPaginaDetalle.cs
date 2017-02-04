using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using _03.SegundaApp.Model;

namespace _03.SegundaApp.Vistas
{
    public class InicioPaginaDetalle: MasterDetailPage
    {
        PaginaMaestra miPaginaMaestra;

        public InicioPaginaDetalle()
        {
            miPaginaMaestra = new PaginaMaestra();
            Master = miPaginaMaestra;
            Detail = new NavigationPage(new Inicio());

            miPaginaMaestra.ListView.ItemSelected += OnItemSelected;

            NavigationPage.SetHasNavigationBar(this,false);
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as ElementoMasterPageModel;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.EnlacePagina));
                miPaginaMaestra.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }

    }
}
