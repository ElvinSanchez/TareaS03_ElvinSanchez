using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaS02_ElvinSanchez
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //habilitar la navegacion
            MainPage = new NavigationPage (new Login());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
