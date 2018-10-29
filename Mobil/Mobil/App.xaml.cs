using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Mobil.Views;
using Mobil.Modelo;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Mobil
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //es para que el Email pueda navegar 
            MainPage = new NavigationPage(new LoginPage());
       
        }

        

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
