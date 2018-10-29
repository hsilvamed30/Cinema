using Mobil.Modelo;
using Newtonsoft.Json;
using SimpleLogin.ViewModels;
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
	public partial class LoginPage : ContentPage
	{
        public LoginPage()
        {
            InitializeComponent();
            CargaUser();
        }

        private void CargaUser()
        {
            HttpClient Cliente = new HttpClient();
            Cliente.BaseAddress = new Uri("https://misapis.azurewebsites.net");
            var request = Cliente.GetAsync("/api/Seguridad").Result;
            if (request.IsSuccessStatusCode)
            {
                var responseJson = request.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<List<ViewModelBase>>(responseJson);
                response.ToList();
              
            }
        }


    }
}