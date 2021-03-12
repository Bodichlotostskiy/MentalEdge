using MentalEdge.ViewModels;
using MentalEdge.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;


namespace MentalEdge
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
        private async void OnMenuItemClicked2(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//List");
        }

        private async void OnMenuItemClicked3(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Player");
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {

        }

        private async void MenuItem_Clicked_1(object sender, EventArgs e)
        {

            await Shell.Current.GoToAsync("//List");
        }

        private async void MenuItem_Clicked_2(object sender, EventArgs e)
        {

            await Shell.Current.GoToAsync("//Calendar");
        }

        private async void MenuItem_Clicked_3(object sender, EventArgs e)
        {

            await Shell.Current.GoToAsync("//Set");

        }

        private void MenuItem_Clicked_4(object sender, EventArgs e)
        {

        }

        private async void MenuItem_Clicked_5(object sender, EventArgs e)
        {

            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
