using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ConverterApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        
        private void Cel_Changing(object sender, TextBoxTextChangingEventArgs args)
        {
            fahrenheit.TextChanging -= Fah_Changing;
            kelvin.TextChanging -= Kel_Changing;
            rankine.TextChanging -= Ran_Changing;
            reamur.TextChanging -= Rea_Changing;
            if (celsius.Text == "")
            {
                celsius.Text = "0";
            }

            double celDouble = 0;
            if (double.TryParse(celsius.Text, out celDouble))
            {
                fahrenheit.Text = Convert.ToString((celDouble * 9 / 5) + 32);
                kelvin.Text = Convert.ToString(celDouble + 273.15);
                rankine.Text = Convert.ToString((celDouble + 273.15) * 9 / 5);
                reamur.Text = Convert.ToString((celDouble * 4 / 5));
            }

            fahrenheit.TextChanging += Fah_Changing;
            kelvin.TextChanging += Kel_Changing;
            rankine.TextChanging += Ran_Changing;
            reamur.TextChanging += Rea_Changing;
        }

        private void Fah_Changing(object sender, TextBoxTextChangingEventArgs args)
        {
            celsius.TextChanging -= Cel_Changing;
            kelvin.TextChanging -= Kel_Changing;
            rankine.TextChanging -= Ran_Changing;
            reamur.TextChanging -= Rea_Changing;
            if (fahrenheit.Text == "")
            {
                fahrenheit.Text = "0";
            }
            double fahDouble = 0;

            if (double.TryParse(fahrenheit.Text, out fahDouble))
            {
                celsius.Text = Convert.ToString(((fahDouble - 32) * 5) / 9);
                kelvin.Text = Convert.ToString((fahDouble - 32) * 5 / 9 + 273.15);
                rankine.Text = Convert.ToString(fahDouble + 459.67);
                reamur.Text = Convert.ToString(((fahDouble - 32) * 4) / 9);

            }

            celsius.TextChanging += Cel_Changing;
            kelvin.TextChanging += Kel_Changing;
            rankine.TextChanging += Ran_Changing;
            reamur.TextChanging += Rea_Changing;
        }

        private void Kel_Changing(object sender, TextBoxTextChangingEventArgs args)
        {
            celsius.TextChanging -= Cel_Changing;
            fahrenheit.TextChanging -= Fah_Changing;
            rankine.TextChanging -= Ran_Changing;
            reamur.TextChanging -= Rea_Changing;
            if (kelvin.Text == "")
            {
                kelvin.Text = "0";
            }
            double kelDouble = 0;

            if (double.TryParse(kelvin.Text, out kelDouble))
            {
                celsius.Text = Convert.ToString(kelDouble - 273.15);
                fahrenheit.Text = Convert.ToString(((kelDouble - 273.15) * 9 / 5) + 32);
                rankine.Text = Convert.ToString(kelDouble * 9 / 5);
                reamur.Text = Convert.ToString((kelDouble - 273.15) * 4 / 5);
            }

            celsius.TextChanging += Cel_Changing;
            fahrenheit.TextChanging += Fah_Changing;
            rankine.TextChanging += Ran_Changing;
            reamur.TextChanging += Rea_Changing;
        }

        private void Ran_Changing(object sender, TextBoxTextChangingEventArgs args)
        {
            celsius.TextChanging -= Cel_Changing;
            fahrenheit.TextChanging -= Fah_Changing;
            kelvin.TextChanging -= Kel_Changing;
            reamur.TextChanging -= Rea_Changing;
            if (rankine.Text == "")
            {
                rankine.Text = "0";
            }
            double ranDouble = 0;

            if (double.TryParse(rankine.Text, out ranDouble))
            {
                celsius.Text = Convert.ToString((ranDouble - 491.67) * 5 / 9);
                fahrenheit.Text = Convert.ToString(ranDouble - 459.67);
                kelvin.Text = Convert.ToString(ranDouble * 5 / 9);
                reamur.Text = Convert.ToString((ranDouble - 491.67) * 4 / 9);
            }

            celsius.TextChanging += Cel_Changing;
            fahrenheit.TextChanging += Fah_Changing;
            kelvin.TextChanging += Kel_Changing;
            reamur.TextChanging += Rea_Changing;
        }

        private void Rea_Changing(object sender, TextBoxTextChangingEventArgs args)
        {
            celsius.TextChanging -= Cel_Changing;
            fahrenheit.TextChanging -= Fah_Changing;
            kelvin.TextChanging -= Kel_Changing;
            rankine.TextChanging -= Ran_Changing;
            if (reamur.Text == "")
            {
                reamur.Text = "0";
            }
            double reaDouble = 0;

            if (double.TryParse(reamur.Text, out reaDouble))
            {
                celsius.Text = Convert.ToString(reaDouble * 5 / 4);
                fahrenheit.Text = Convert.ToString(reaDouble * 9 / 4 + 32);
                kelvin.Text = Convert.ToString(reaDouble * 5 / 4 + 273.15);
                reamur.Text = Convert.ToString(reaDouble * 9 / 4 + 491.67);
            }

            celsius.TextChanging += Cel_Changing;
            fahrenheit.TextChanging += Fah_Changing;
            kelvin.TextChanging += Kel_Changing;
            rankine.TextChanging += Ran_Changing;
        }
    }
}
