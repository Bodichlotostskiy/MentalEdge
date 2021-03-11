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
    public partial class Player : ContentPage
    {
        public Player()
        {
            InitializeComponent();
        }

        private  void Button_Clicked(object sender, EventArgs e)
        {
            Shell.Current.FlyoutIsPresented = true;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            timeline.Value -= 10;
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            


        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {

            timeline.Value += 10;
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }
    }
}