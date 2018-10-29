using Mobil;
using Mobil.Helpers;
using Mobil.Modelo;
using Mobil.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SimpleLogin.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        void CargarUser(object sender, EventArgs e)
        {
            User user = new User(Entry_Email.Text, Entry_Password.Text);
            if (user.CheckInformation())
            {
                DisplayAlert("Iniciar sesión", "Acceso exitoso", "Ok");

            }
            else
            {
                DisplayAlert("Iniciar sesión", "Iniciar sesión incorrecto, Email o password incorrectos.", "Ok");
            }

        }

        private void DisplayAlert(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }
    }

}