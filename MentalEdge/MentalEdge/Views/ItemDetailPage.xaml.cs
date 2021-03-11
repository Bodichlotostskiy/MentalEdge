using MentalEdge.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MentalEdge.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}