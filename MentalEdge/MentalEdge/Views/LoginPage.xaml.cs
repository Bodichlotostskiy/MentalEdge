using MentalEdge.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MentalEdge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        Color color;
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();

            color=create.BackgroundColor;
            email.BackgroundColor = color;
            password.BackgroundColor = color;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(List)}");
        }
    }
}