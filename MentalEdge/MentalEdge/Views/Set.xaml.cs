using MentalEdge.Controls;
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
    public partial class Set : ContentPage
    {
        bool button1 = true;
        bool button2 = true;
        bool button3 = true;
        bool button4 = true;
        bool button5 = true;
        bool button6 = true;
        bool button7 = true;
        bool button8 = true;
        bool button9 = true;
        readonly Color color1 = new Color();
        public Set()
        {
            InitializeComponent();
            color1 = Relaxed.BackgroundColor;
            textbar2.BackgroundColor = color1;
            textbar1.BackgroundColor = color1;
        }

        private  void Button_Clicked(object sender, EventArgs e)
        {
            Shell.Current.FlyoutIsPresented = true;
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {


            Selector.Children[(int)(e.NewValue)].Scale += 0.5;
            Selector.Children[(int)(e.OldValue)].Scale -= 0.5;
        }



        private void Relaxed_Clicked(object sender, EventArgs e)
        {
            if (button1)
            {
                Relaxed.BackgroundColor = Color.LimeGreen;
                button1 = false;
                Relaxed.TextColor = Color.Black;
            }
            else if (!button1)
            {
                Relaxed.BackgroundColor = color1;
                button1 = true;
                Relaxed.TextColor = Color.Gray;
            }
        }



        private void Grateful_Clicked(object sender, EventArgs e)
        {
            if (button2)
            {
                Grateful.BackgroundColor = Color.LimeGreen;
                button2 = false;
                Grateful.TextColor = Color.Black;
            }
            else if (!button2)
            {
                Grateful.BackgroundColor = color1;
                button2 = true;
                Grateful.TextColor = Color.Gray;
            }
        }

        private void Happy_Clicked(object sender, EventArgs e)
        {
            if (button3)
            {
                Happy.BackgroundColor = Color.LimeGreen;
                button3 = false;
                Happy.TextColor = Color.Black;
            }
            else if (!button3)
            {
                Happy.BackgroundColor = color1;
                button3 = true;
                Happy.TextColor = Color.Gray;
            }
        }

        private void Contents_Clicked(object sender, EventArgs e)
        {
            if (button4)
            {
                Contents.BackgroundColor = Color.LimeGreen;
                button4 = false;
                Contents.TextColor = Color.Black;
            }
            else if (!button4)
            {
                Contents.BackgroundColor = color1;
                button4 = true;
                Contents.TextColor = Color.Gray;
            }
        }

        private void Confident_Clicked(object sender, EventArgs e)
        {
            if (button5)
            {
                Confident.BackgroundColor = Color.LimeGreen;
                button5 = false;
                Confident.TextColor = Color.Black;
            }
            else if (!button5)
            {
                Confident.BackgroundColor = color1;
                button5 = true;
                Confident.TextColor = Color.Gray;
            }
        }

        private void Slider_ValueChanged_1(object sender, ValueChangedEventArgs e)
        {
            Selectortwo.Children[(int)(e.NewValue)].Scale += 0.5;
            Selectortwo.Children[(int)(e.OldValue)].Scale -= 0.5;
        }

        private void Angry_Clicked(object sender, EventArgs e)
        {
            if (button6)
            {
                Angry.BackgroundColor = Color.Red;
                button6 = false;
                Angry.TextColor = Color.Black;
            }
            else if (!button6)
            {
                Angry.BackgroundColor = color1;
                button6 = true;
                Angry.TextColor = Color.Gray;
            }
        }

        private void BrokeRules_Clicked(object sender, EventArgs e)
        {
            if (button7)
            {
                BrokeRules.BackgroundColor = Color.Red;
                button7 = false;
                BrokeRules.TextColor = Color.Black;
            }
            else if (!button7)
            {
                BrokeRules.BackgroundColor = color1;
                button7 = true;

                BrokeRules.TextColor = Color.Gray;
            }
        }

        private void Chased_Clicked(object sender, EventArgs e)
        {
            if (button8)
            {
                Chased.BackgroundColor = Color.Red;
                button8 = false;

                Chased.TextColor = Color.Black;
            }
            else if (!button8)
            {
                Chased.BackgroundColor = color1;
                button8 = true;

                Chased.TextColor = Color.Gray;
            }
        }

        private void FOMO_Clicked(object sender, EventArgs e)
        {
            if (button9)
            {
                FOMO.BackgroundColor = Color.Red;
                button9 = false;

                FOMO.TextColor = Color.Black;
            }
            else if (!button9)
            {
                FOMO.BackgroundColor = color1;
                button9 = true;

                FOMO.TextColor = Color.Gray;
            }
        }
    }
}