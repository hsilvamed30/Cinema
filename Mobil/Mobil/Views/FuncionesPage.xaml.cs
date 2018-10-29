using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobil.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FuncionesPage : ContentPage
	{
		public FuncionesPage (Modelo.PeliculaDTO Pelicula)
		{
			InitializeComponent ();
            ListFunciones.ItemsSource = Pelicula.Funciones;
            
        }

        private async void Item_Selecte(object sender, SelectedItemChangedEventArgs e)
        {
            var peli = e.SelectedItem as Modelo.PeliculaDTO;
                       

            await Navigation.PushAsync(new Resumen(peli));
        }
    }
}