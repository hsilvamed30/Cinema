using Mobil.Helpers;
using Mobil.Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobil.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CarteleraPage : ContentPage
	{
		public CarteleraPage ()
		{
			InitializeComponent ();
            CargarPeliculas();

        }

        private void CargarPeliculas()
        {
            HttpClient Cliente = new HttpClient();
            Cliente.BaseAddress = new Uri("https://misapis.azurewebsites.net");
            var request = Cliente.GetAsync("/api/Cartelera").Result;
            if (request.IsSuccessStatusCode)
            {
                var responseJson = request.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<List<PeliculaDTO>>(responseJson);
                response.ToList();

                ListPeliculas.ItemsSource = response;
            }
        }

        private async void Item_Selecte(object sender, SelectedItemChangedEventArgs e)
        {
            var Pelicula = e.SelectedItem as Modelo.PeliculaDTO;

            await Navigation.PushAsync(new FuncionesPage(Pelicula));
        }

        private async void Logout()
        {
            Settings.IsLoggedIn = false;
            await Navigation.PushAsync(new LoginPage());
        }
    }
}