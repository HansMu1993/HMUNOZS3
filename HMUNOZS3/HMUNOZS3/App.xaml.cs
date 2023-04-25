using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HMUNOZS3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Habilitamo la navegacion 
            MainPage = new NavigationPage(new Inicio());

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
