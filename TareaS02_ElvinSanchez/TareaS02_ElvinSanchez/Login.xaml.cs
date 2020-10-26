using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaS02_ElvinSanchez
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            //para el texto de login
            string user = txtUser.Text;
            string pass = txtPass.Text;   
            
            if (user != "estudiante2020" || pass != "uisrael2020")
            {
                await DisplayAlert("Alerta", "Usuario Invalido", "Reintentar");
                    return;
            }
            else 
            {
                await Navigation.PushAsync(new MainPage());
                await DisplayAlert("Alert", "Bienvenido al Sistema de Calificaciones", "Aceptar");
            }
        }
    }
}