using MentalEdge.Services;
using MentalEdge.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MentalEdge
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            Shell.Current.GoToAsync("//LoginPage");
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
