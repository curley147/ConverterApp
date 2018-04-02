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
        private void Rectangle_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }
        private void Tb_Tapped(object sender, TappedRoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }

        /*private void ChangeColorItem_Click(object sender, RoutedEventArgs e)
        {
            // Change the color from red to blue or blue to red.
            if (rectangleFill.Color == Windows.UI.Colors.Red)
            {
                rectangleFill.Color = Windows.UI.Colors.Blue;
            }
            else
            {
                rectangleFill.Color = Windows.UI.Colors.Red;
            }
        }*/
        private void Cel_Changing(object sender, TextBoxTextChangingEventArgs args)
        {
            fahrenheit.TextChanging -= Fah_Changing;
            kelvin.TextChanging -= Kel_Changing;
            if (celsius.Text == null)
            {
                celsius.Text = "0";
            }
            double celDouble = Convert.ToDouble(celsius.Text);
            fahrenheit.Text = Convert.ToString((celDouble * 9 / 5.0) + 32);
            kelvin.Text = Convert.ToString(celDouble + 273.15);

            fahrenheit.TextChanging += Fah_Changing;
            kelvin.TextChanging += Kel_Changing;
        }

        private void Fah_Changing(object sender, TextBoxTextChangingEventArgs args)
        {
            celsius.TextChanging -= Cel_Changing;
            kelvin.TextChanging -= Kel_Changing;
            if (fahrenheit.Text == null)
            {
                fahrenheit.Text = "0";
            }
            double fahDouble = Convert.ToDouble(fahrenheit.Text);
            celsius.Text = Convert.ToString(((fahDouble - 32) * 5) / 9);
            kelvin.Text = Convert.ToString(5 / 9 * (fahDouble - 32) + 273.15);

            celsius.TextChanging += Cel_Changing;
            kelvin.TextChanging += Kel_Changing;
        }

        private void Kel_Changing(object sender, TextBoxTextChangingEventArgs args)
        {
            celsius.TextChanging -= Cel_Changing;
            fahrenheit.TextChanging -= Fah_Changing;
            if (kelvin.Text == null)
            {
                kelvin.Text = "0";
            }
            double kelDouble = Convert.ToDouble(kelvin.Text);
            celsius.Text = Convert.ToString(kelDouble - 273.15);
            fahrenheit.Text = Convert.ToString(((kelDouble - 273) * 9 / 5) + 32);

            celsius.TextChanging += Cel_Changing;
            fahrenheit.TextChanging += Fah_Changing;
        }

        private void Temp_Changed(object sender, TextChangedEventArgs args)
        {
            
        }

    }
}
