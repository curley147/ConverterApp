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

        private void Ton_Changing(object sender, TextBoxTextChangingEventArgs args)
        {
            kilo.TextChanging -= Kilo_Changing;
            gram.TextChanging -= Gram_Changing;
            mlgram.TextChanging -= Mil_Changing;
            micro.TextChanging -= Mic_Changing;
            nano.TextChanging -= Nano_Changing;
            pico.TextChanging -= Pico_Changing;
            stone.TextChanging -= Sto_Changing;
            pound.TextChanging -= Pou_Changing;
            ounce.TextChanging -= Oun_Changing;
            carat.TextChanging -= Car_Changing;

            if (tonne.Text == "")
            {
                tonne.Text = "0";
            }
            double tonDouble = 0;

            if (double.TryParse(tonne.Text, out tonDouble))
            {
                kilo.Text = Convert.ToString(tonDouble * Math.Pow(10, 3));
                gram.Text = Convert.ToString(tonDouble * Math.Pow(10, 6));
                mlgram.Text = Convert.ToString(tonDouble * Math.Pow(10, 9));
                micro.Text = Convert.ToString(tonDouble * Math.Pow(10, 12));
                nano.Text = Convert.ToString(tonDouble * Math.Pow(10, 15));
                pico.Text = Convert.ToString(tonDouble * Math.Pow(10, 18));
                stone.Text = Convert.ToString(tonDouble * 157.473044);
                pound.Text = Convert.ToString(tonDouble / 0.00045359237);
                ounce.Text = Convert.ToString(tonDouble / 0.0000283495231);
                carat.Text = Convert.ToString(tonDouble * 5000000);

            }

            kilo.TextChanging += Kilo_Changing;
            gram.TextChanging += Gram_Changing;
            mlgram.TextChanging += Mil_Changing;
            micro.TextChanging += Mic_Changing;
            nano.TextChanging += Nano_Changing;
            pico.TextChanging += Pico_Changing;
            stone.TextChanging += Sto_Changing;
            pound.TextChanging += Pou_Changing;
            ounce.TextChanging += Oun_Changing;
            carat.TextChanging += Car_Changing;
        }

        private void Kilo_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            tonne.TextChanging -= Ton_Changing;
            gram.TextChanging -= Gram_Changing;
            mlgram.TextChanging -= Mil_Changing;
            micro.TextChanging -= Mic_Changing;
            nano.TextChanging -= Nano_Changing;
            pico.TextChanging -= Pico_Changing;
            stone.TextChanging -= Sto_Changing;
            pound.TextChanging -= Pou_Changing;
            ounce.TextChanging -= Oun_Changing;
            carat.TextChanging -= Car_Changing;

            if (kilo.Text == "")
            {
                kilo.Text = "0";
            }
            double kiloDouble = 0;

            if (double.TryParse(tonne.Text, out kiloDouble))
            {
                tonne.Text = Convert.ToString(kiloDouble / Math.Pow(10, 3));
                gram.Text = Convert.ToString(kiloDouble * Math.Pow(10, 3));
                mlgram.Text = Convert.ToString(kiloDouble * Math.Pow(10, 6));
                micro.Text = Convert.ToString(kiloDouble * Math.Pow(10, 9));
                nano.Text = Convert.ToString(kiloDouble * Math.Pow(10, 12));
                pico.Text = Convert.ToString(kiloDouble * Math.Pow(10, 15));
                stone.Text = Convert.ToString(kiloDouble / 0.157473044418);
                pound.Text = Convert.ToString(kiloDouble * 2.20462262185);
                ounce.Text = Convert.ToString(kiloDouble * 35.2739619496);
                carat.Text = Convert.ToString(kiloDouble * 5000);

            }

            tonne.TextChanging += Ton_Changing;
            gram.TextChanging += Gram_Changing;
            mlgram.TextChanging += Mil_Changing;
            micro.TextChanging += Mic_Changing;
            nano.TextChanging += Nano_Changing;
            pico.TextChanging += Pico_Changing;
            stone.TextChanging += Sto_Changing;
            pound.TextChanging += Pou_Changing;
            ounce.TextChanging += Oun_Changing;
            carat.TextChanging += Car_Changing;
        }

        private void Gram_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            tonne.TextChanging -= Ton_Changing;
            kilo.TextChanging -= Kilo_Changing;
            mlgram.TextChanging -= Mil_Changing;
            micro.TextChanging -= Mic_Changing;
            nano.TextChanging -= Nano_Changing;
            pico.TextChanging -= Pico_Changing;
            stone.TextChanging -= Sto_Changing;
            pound.TextChanging -= Pou_Changing;
            ounce.TextChanging -= Oun_Changing;
            carat.TextChanging -= Car_Changing;

            if (gram.Text == "")
            {
                gram.Text = "0";
            }
            double gramDouble = 0;

            if (double.TryParse(gram.Text, out gramDouble))
            {
                tonne.Text = Convert.ToString(gramDouble * Math.Pow(10, -6));
                kilo.Text = Convert.ToString(gramDouble * Math.Pow(10, -3));
                mlgram.Text = Convert.ToString(gramDouble * Math.Pow(10, 3));
                micro.Text = Convert.ToString(gramDouble * Math.Pow(10, 6));
                nano.Text = Convert.ToString(gramDouble * Math.Pow(10, 9));
                pico.Text = Convert.ToString(gramDouble * Math.Pow(10, 12));
                stone.Text = Convert.ToString(gramDouble * 0.000157473044418);
                pound.Text = Convert.ToString(gramDouble * 0.00220462262185);
                ounce.Text = Convert.ToString(gramDouble * 0.0352739619496);
                carat.Text = Convert.ToString(gramDouble * 5);

            }

            tonne.TextChanging += Ton_Changing;
            kilo.TextChanging += Kilo_Changing;
            mlgram.TextChanging += Mil_Changing;
            micro.TextChanging += Mic_Changing;
            nano.TextChanging += Nano_Changing;
            pico.TextChanging += Pico_Changing;
            stone.TextChanging += Sto_Changing;
            pound.TextChanging += Pou_Changing;
            ounce.TextChanging += Oun_Changing;
            carat.TextChanging += Car_Changing;
        }

        private void Mil_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            tonne.TextChanging -= Ton_Changing;
            kilo.TextChanging -= Kilo_Changing;
            gram.TextChanging -= Gram_Changing;
            micro.TextChanging -= Mic_Changing;
            nano.TextChanging -= Nano_Changing;
            pico.TextChanging -= Pico_Changing;
            stone.TextChanging -= Sto_Changing;
            pound.TextChanging -= Pou_Changing;
            ounce.TextChanging -= Oun_Changing;
            carat.TextChanging -= Car_Changing;

            if (mlgram.Text == "")
            {
                mlgram.Text = "0";
            }
            double mlgramDouble = 0;

            if (double.TryParse(mlgram.Text, out mlgramDouble))
            {
                tonne.Text = Convert.ToString(mlgramDouble * 1.102311311e-9);
                kilo.Text = Convert.ToString(mlgramDouble * Math.Pow(10, -6));
                gram.Text = Convert.ToString(mlgramDouble * Math.Pow(10, -3));
                micro.Text = Convert.ToString(mlgramDouble * Math.Pow(10, 3));
                nano.Text = Convert.ToString(mlgramDouble * Math.Pow(10, 6));
                pico.Text = Convert.ToString(mlgramDouble * Math.Pow(10, 9));
                stone.Text = Convert.ToString(mlgramDouble * 1.57473044418e-7);
                pound.Text = Convert.ToString(mlgramDouble * 0.00000220462262185);
                ounce.Text = Convert.ToString(mlgramDouble * 0.0000352739619496);
                carat.Text = Convert.ToString(mlgramDouble * 0.005);

            }

            tonne.TextChanging += Ton_Changing;
            kilo.TextChanging += Kilo_Changing;
            gram.TextChanging += Gram_Changing;
            micro.TextChanging += Mic_Changing;
            nano.TextChanging += Nano_Changing;
            pico.TextChanging += Pico_Changing;
            stone.TextChanging += Sto_Changing;
            pound.TextChanging += Pou_Changing;
            ounce.TextChanging += Oun_Changing;
            carat.TextChanging += Car_Changing;
        }

        private void Mic_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            tonne.TextChanging -= Ton_Changing;
            kilo.TextChanging -= Kilo_Changing;
            gram.TextChanging -= Gram_Changing;
            mlgram.TextChanging -= Mil_Changing;
            nano.TextChanging -= Nano_Changing;
            pico.TextChanging -= Pico_Changing;
            stone.TextChanging -= Sto_Changing;
            pound.TextChanging -= Pou_Changing;
            ounce.TextChanging -= Oun_Changing;
            carat.TextChanging -= Car_Changing;

            if (micro.Text == "")
            {
                micro.Text = "0";
            }
            double microDouble = 0;

            if (double.TryParse(micro.Text, out microDouble))
            {
                tonne.Text = Convert.ToString(microDouble * 1e-12);
                kilo.Text = Convert.ToString(microDouble * 1e-9);
                gram.Text = Convert.ToString(microDouble * Math.Pow(10, -6));
                mlgram.Text = Convert.ToString(microDouble * Math.Pow(10, -3));
                nano.Text = Convert.ToString(microDouble * Math.Pow(10, 3));
                pico.Text = Convert.ToString(microDouble * Math.Pow(10, 6));
                stone.Text = Convert.ToString(microDouble * 1.57473044418e-10);
                pound.Text = Convert.ToString(microDouble * 2.20462262185e-9);
                ounce.Text = Convert.ToString(microDouble * 3.52739619496e-8);
                carat.Text = Convert.ToString(microDouble * 0.000005);

            }

            tonne.TextChanging += Ton_Changing;
            kilo.TextChanging += Kilo_Changing;
            gram.TextChanging += Gram_Changing;
            mlgram.TextChanging += Mil_Changing;
            nano.TextChanging += Nano_Changing;
            pico.TextChanging += Pico_Changing;
            stone.TextChanging += Sto_Changing;
            pound.TextChanging += Pou_Changing;
            ounce.TextChanging += Oun_Changing;
            carat.TextChanging += Car_Changing;
        }

        private void Nano_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            tonne.TextChanging -= Ton_Changing;
            kilo.TextChanging -= Kilo_Changing;
            gram.TextChanging -= Gram_Changing;
            mlgram.TextChanging -= Mil_Changing;
            micro.TextChanging -= Mic_Changing;
            pico.TextChanging -= Pico_Changing;
            stone.TextChanging -= Sto_Changing;
            pound.TextChanging -= Pou_Changing;
            ounce.TextChanging -= Oun_Changing;
            carat.TextChanging -= Car_Changing;

            if (nano.Text == "")
            {
                nano.Text = "0";
            }
            double nanoDouble = 0;

            if (double.TryParse(nano.Text, out nanoDouble))
            {
                tonne.Text = Convert.ToString(nanoDouble * 1e-15);
                kilo.Text = Convert.ToString(nanoDouble * 1e-12);
                gram.Text = Convert.ToString(nanoDouble * 1e-9);
                mlgram.Text = Convert.ToString(nanoDouble * Math.Pow(10, -6));
                micro.Text = Convert.ToString(nanoDouble * Math.Pow(10, -3));
                pico.Text = Convert.ToString(nanoDouble * Math.Pow(10, 3));
                stone.Text = Convert.ToString(nanoDouble * 1.57473044418e-13);
                pound.Text = Convert.ToString(nanoDouble * 2.20462262185e-12);
                ounce.Text = Convert.ToString(nanoDouble * 3.52739619496e-11);
                carat.Text = Convert.ToString(nanoDouble * 5e-9);

            }

            tonne.TextChanging += Ton_Changing;
            kilo.TextChanging += Kilo_Changing;
            gram.TextChanging += Gram_Changing;
            mlgram.TextChanging += Mil_Changing;
            micro.TextChanging += Mic_Changing;
            pico.TextChanging += Pico_Changing;
            stone.TextChanging += Sto_Changing;
            pound.TextChanging += Pou_Changing;
            ounce.TextChanging += Oun_Changing;
            carat.TextChanging += Car_Changing;
        }

        private void Pico_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            tonne.TextChanging -= Ton_Changing;
            kilo.TextChanging -= Kilo_Changing;
            gram.TextChanging -= Gram_Changing;
            mlgram.TextChanging -= Mil_Changing;
            micro.TextChanging -= Mic_Changing;
            nano.TextChanging -= Nano_Changing;
            stone.TextChanging -= Sto_Changing;
            pound.TextChanging -= Pou_Changing;
            ounce.TextChanging -= Oun_Changing;
            carat.TextChanging -= Car_Changing;

            if (pico.Text == "")
            {
                pico.Text = "0";
            }
            double picoDouble = 0;

            if (double.TryParse(pico.Text, out picoDouble))
            {
                tonne.Text = Convert.ToString(picoDouble * 1e-18);
                kilo.Text = Convert.ToString(picoDouble * 1e-15);
                gram.Text = Convert.ToString(picoDouble * 1e-12);
                mlgram.Text = Convert.ToString(picoDouble * 1e-9);
                micro.Text = Convert.ToString(picoDouble * Math.Pow(10, -6));
                nano.Text = Convert.ToString(picoDouble * Math.Pow(10, -3));
                stone.Text = Convert.ToString(picoDouble * 1.57473044418e-16);
                pound.Text = Convert.ToString(picoDouble * 2.20462262185e-15);
                ounce.Text = Convert.ToString(picoDouble * 3.52739619496e-14);
                carat.Text = Convert.ToString(picoDouble * 5e-12);

            }

            tonne.TextChanging += Ton_Changing;
            kilo.TextChanging += Kilo_Changing;
            gram.TextChanging += Gram_Changing;
            mlgram.TextChanging += Mil_Changing;
            micro.TextChanging += Mic_Changing;
            nano.TextChanging += Nano_Changing;
            stone.TextChanging += Sto_Changing;
            pound.TextChanging += Pou_Changing;
            ounce.TextChanging += Oun_Changing;
            carat.TextChanging += Car_Changing;
        }

        private void Sto_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            tonne.TextChanging -= Ton_Changing;
            kilo.TextChanging -= Kilo_Changing;
            gram.TextChanging -= Gram_Changing;
            mlgram.TextChanging -= Mil_Changing;
            micro.TextChanging -= Mic_Changing;
            nano.TextChanging -= Nano_Changing;
            pico.TextChanging -= Pico_Changing;
            pound.TextChanging -= Pou_Changing;
            ounce.TextChanging -= Oun_Changing;
            carat.TextChanging -= Car_Changing;

            if (stone.Text == "")
            {
                stone.Text = "0";
            }
            double stoneDouble = 0;

            if (double.TryParse(stone.Text, out stoneDouble))
            {
                tonne.Text = Convert.ToString(stoneDouble * 0.00635029318);
                kilo.Text = Convert.ToString(stoneDouble * 6.35029318);
                gram.Text = Convert.ToString(stoneDouble * 6350.29318);
                mlgram.Text = Convert.ToString(stoneDouble * 6350293.18);
                micro.Text = Convert.ToString(stoneDouble * 6350293180);
                nano.Text = Convert.ToString(stoneDouble * 6350293180000);
                pico.Text = Convert.ToString(stoneDouble * 6350293180000000);
                pound.Text = Convert.ToString(stoneDouble * 14);
                ounce.Text = Convert.ToString(stoneDouble * 224);
                carat.Text = Convert.ToString(stoneDouble * 31751.4659);

            }

            tonne.TextChanging += Ton_Changing;
            kilo.TextChanging += Kilo_Changing;
            gram.TextChanging += Gram_Changing;
            mlgram.TextChanging += Mil_Changing;
            micro.TextChanging += Mic_Changing;
            nano.TextChanging += Nano_Changing;
            pico.TextChanging += Pico_Changing;
            pound.TextChanging += Pou_Changing;
            ounce.TextChanging += Oun_Changing;
            carat.TextChanging += Car_Changing;
        }

        private void Pou_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            tonne.TextChanging -= Ton_Changing;
            kilo.TextChanging -= Kilo_Changing;
            gram.TextChanging -= Gram_Changing;
            mlgram.TextChanging -= Mil_Changing;
            micro.TextChanging -= Mic_Changing;
            nano.TextChanging -= Nano_Changing;
            pico.TextChanging -= Pico_Changing;
            stone.TextChanging -= Sto_Changing;
            ounce.TextChanging -= Oun_Changing;
            carat.TextChanging -= Car_Changing;

            if (pound.Text == "")
            {
                pound.Text = "0";
            }
            double poundDouble = 0;

            if (double.TryParse(pound.Text, out poundDouble))
            {
                tonne.Text = Convert.ToString(poundDouble * 0.00045359237);
                kilo.Text = Convert.ToString(poundDouble * 0.45359237);
                gram.Text = Convert.ToString(poundDouble * 453.59237);
                mlgram.Text = Convert.ToString(poundDouble * 453592.37);
                micro.Text = Convert.ToString(poundDouble * 453592370);
                nano.Text = Convert.ToString(poundDouble * 453592370000);
                pico.Text = Convert.ToString(poundDouble * 453592370000000);
                stone.Text = Convert.ToString(poundDouble * 0.0714285714286);
                ounce.Text = Convert.ToString(poundDouble * 16);
                carat.Text = Convert.ToString(poundDouble * 2267.96185);

            }

            tonne.TextChanging += Ton_Changing;
            kilo.TextChanging += Kilo_Changing;
            gram.TextChanging += Gram_Changing;
            mlgram.TextChanging += Mil_Changing;
            micro.TextChanging += Mic_Changing;
            nano.TextChanging += Nano_Changing;
            pico.TextChanging += Pico_Changing;
            stone.TextChanging += Sto_Changing;
            ounce.TextChanging += Oun_Changing;
            carat.TextChanging += Car_Changing;
        }

        private void Oun_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            tonne.TextChanging -= Ton_Changing;
            kilo.TextChanging -= Kilo_Changing;
            gram.TextChanging -= Gram_Changing;
            mlgram.TextChanging -= Mil_Changing;
            micro.TextChanging -= Mic_Changing;
            nano.TextChanging -= Nano_Changing;
            pico.TextChanging -= Pico_Changing;
            stone.TextChanging -= Sto_Changing;
            pound.TextChanging -= Pou_Changing;
            carat.TextChanging -= Car_Changing;

            if (ounce.Text == "")
            {
                ounce.Text = "0";
            }
            double ounceDouble = 0;

            if (double.TryParse(ounce.Text, out ounceDouble))
            {
                tonne.Text = Convert.ToString(ounceDouble * 0.000028349523125);
                kilo.Text = Convert.ToString(ounceDouble * 0.028349523125);
                gram.Text = Convert.ToString(ounceDouble * 28.349523125);
                mlgram.Text = Convert.ToString(ounceDouble * 28349.523125);
                micro.Text = Convert.ToString(ounceDouble * 28349523.125);
                nano.Text = Convert.ToString(ounceDouble * 28349523125);
                pico.Text = Convert.ToString(ounceDouble * 453592370000000);
                stone.Text = Convert.ToString(ounceDouble * 0.00446428571429);
                pound.Text = Convert.ToString(ounceDouble * 0.0625);
                carat.Text = Convert.ToString(ounceDouble * 141.747615625);

            }

            tonne.TextChanging += Ton_Changing;
            kilo.TextChanging += Kilo_Changing;
            gram.TextChanging += Gram_Changing;
            mlgram.TextChanging += Mil_Changing;
            micro.TextChanging += Mic_Changing;
            nano.TextChanging += Nano_Changing;
            pico.TextChanging += Pico_Changing;
            stone.TextChanging += Sto_Changing;
            pound.TextChanging += Pou_Changing;
            carat.TextChanging += Car_Changing;
        }

        private void Car_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            tonne.TextChanging -= Ton_Changing;
            kilo.TextChanging -= Kilo_Changing;
            gram.TextChanging -= Gram_Changing;
            mlgram.TextChanging -= Mil_Changing;
            micro.TextChanging -= Mic_Changing;
            nano.TextChanging -= Nano_Changing;
            pico.TextChanging -= Pico_Changing;
            stone.TextChanging -= Sto_Changing;
            pound.TextChanging -= Pou_Changing;
            ounce.TextChanging -= Oun_Changing;

            if (carat.Text == "")
            {
                carat.Text = "0";
            }
            double caratDouble = 0;

            if (double.TryParse(carat.Text, out caratDouble))
            {
                tonne.Text = Convert.ToString(caratDouble * 2e-7);
                kilo.Text = Convert.ToString(caratDouble * 0.0002);
                gram.Text = Convert.ToString(caratDouble * 0.2);
                mlgram.Text = Convert.ToString(caratDouble * 200);
                micro.Text = Convert.ToString(caratDouble * 200000);
                nano.Text = Convert.ToString(caratDouble * 200000000);
                pico.Text = Convert.ToString(caratDouble * 200000000000);
                stone.Text = Convert.ToString(caratDouble * 0.0000314946088836);
                pound.Text = Convert.ToString(caratDouble * 0.00044092452437);
                ounce.Text = Convert.ToString(caratDouble * 0.00705479238992);

            }

            tonne.TextChanging += Ton_Changing;
            kilo.TextChanging += Kilo_Changing;
            gram.TextChanging += Gram_Changing;
            mlgram.TextChanging += Mil_Changing;
            micro.TextChanging += Mic_Changing;
            nano.TextChanging += Nano_Changing;
            pico.TextChanging += Pico_Changing;
            stone.TextChanging += Sto_Changing;
            pound.TextChanging += Pou_Changing;
            ounce.TextChanging += Oun_Changing;
        }

        private void Met_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            dec.TextChanging -= Dec_Changing;
            cent.TextChanging -= Cent_Changing;
            mil.TextChanging -= Milm_Changing;
            microm.TextChanging -= Micm_Changing;
            nanom.TextChanging -= Nanom_Changing;
            ang.TextChanging -= Ang_Changing;
            yard.TextChanging -= Yard_Changing;
            foot.TextChanging -= Foot_Changing;
            inch.TextChanging -= Inch_Changing;

            if (metre.Text == "")
            {
                metre.Text = "0";
            }
            double metreDouble = 0;

            if (double.TryParse(metre.Text, out metreDouble))
            {
                dec.Text = Convert.ToString(metreDouble * 2e-7);
                kilo.Text = Convert.ToString(metreDouble * 0.0002);
                mil.Text = Convert.ToString(metreDouble * 0.2);
                microm.Text = Convert.ToString(metreDouble * 200);
                nanom.Text = Convert.ToString(metreDouble * 200000000);
                ang.Text = Convert.ToString(metreDouble * 200000000000);
                yard.Text = Convert.ToString(metreDouble * 0.0000314946088836);
                foot.Text = Convert.ToString(metreDouble * 0.00044092452437);
                inch.Text = Convert.ToString(metreDouble * 0.00705479238992);
                
            }

            dec.TextChanging += Dec_Changing;
            cent.TextChanging += Cent_Changing;
            mil.TextChanging += Milm_Changing;
            microm.TextChanging += Micm_Changing;
            nanom.TextChanging += Nanom_Changing;
            ang.TextChanging += Ang_Changing;
            yard.TextChanging += Yard_Changing;
            foot.TextChanging += Foot_Changing;
            inch.TextChanging += Inch_Changing;
        }

        private void Inch_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            metre.TextChanging -= Met_Changing;
            cent.TextChanging -= Cent_Changing;
            mil.TextChanging -= Milm_Changing;
            microm.TextChanging -= Micm_Changing;
            nanom.TextChanging -= Nanom_Changing;
            ang.TextChanging -= Ang_Changing;
            yard.TextChanging -= Yard_Changing;
            foot.TextChanging -= Foot_Changing;
            inch.TextChanging -= Inch_Changing;

            if (inch.Text == "")
            {
                inch.Text = "0";
            }
            double inchDouble = 0;

            if (double.TryParse(inch.Text, out inchDouble))
            {
                dec.Text = Convert.ToString(inchDouble * 0.254);
                cent.Text = Convert.ToString(inchDouble * 2.54);
                mil.Text = Convert.ToString(inchDouble * 25.4);
                microm.Text = Convert.ToString(inchDouble * 25400);
                nano.Text = Convert.ToString(inchDouble * 25400000);
                ang.Text = Convert.ToString(inchDouble * 254000000);
                yard.Text = Convert.ToString(inchDouble * 0.0277777777778);
                foot.Text = Convert.ToString(inchDouble * 0.0833333333333);
                metre.Text = Convert.ToString(inchDouble * 0.0254);

            }

            dec.TextChanging += Dec_Changing;
            cent.TextChanging += Cent_Changing;
            mil.TextChanging += Milm_Changing;
            microm.TextChanging += Micm_Changing;
            nanom.TextChanging += Nanom_Changing;
            ang.TextChanging += Ang_Changing;
            yard.TextChanging += Yard_Changing;
            foot.TextChanging += Foot_Changing;
            metre.TextChanging += Met_Changing;
        }

        private void Foot_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            metre.TextChanging -= Met_Changing;
            cent.TextChanging -= Cent_Changing;
            mil.TextChanging -= Milm_Changing;
            microm.TextChanging -= Micm_Changing;
            nanom.TextChanging -= Nanom_Changing;
            ang.TextChanging -= Ang_Changing;
            yard.TextChanging -= Yard_Changing;
            dec.TextChanging -= Dec_Changing;
            inch.TextChanging -= Inch_Changing;

            if (foot.Text == "")
            {
                foot.Text = "0";
            }
            double footDouble = 0;

            if (double.TryParse(foot.Text, out footDouble))
            {
                dec.Text = Convert.ToString(footDouble * 3.048);
                cent.Text = Convert.ToString(footDouble * 30.48);
                mil.Text = Convert.ToString(footDouble * 304.8);
                microm.Text = Convert.ToString(footDouble * 304800);
                nano.Text = Convert.ToString(footDouble * 304800000);
                ang.Text = Convert.ToString(footDouble * 3048000000);
                yard.Text = Convert.ToString(footDouble * 0.333333333333);
                inch.Text = Convert.ToString(footDouble * 12);
                metre.Text = Convert.ToString(footDouble * 0.3048);

            }

            dec.TextChanging += Dec_Changing;
            cent.TextChanging += Cent_Changing;
            mil.TextChanging += Milm_Changing;
            microm.TextChanging += Micm_Changing;
            nanom.TextChanging += Nanom_Changing;
            ang.TextChanging += Ang_Changing;
            yard.TextChanging += Yard_Changing;
            inch.TextChanging += Inch_Changing;
            metre.TextChanging += Met_Changing;
        }

        private void Yard_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            metre.TextChanging -= Met_Changing;
            cent.TextChanging -= Cent_Changing;
            mil.TextChanging -= Milm_Changing;
            microm.TextChanging -= Micm_Changing;
            nanom.TextChanging -= Nanom_Changing;
            ang.TextChanging -= Ang_Changing;
            foot.TextChanging -= Foot_Changing;
            dec.TextChanging -= Dec_Changing;
            inch.TextChanging -= Inch_Changing;

            if (yard.Text == "")
            {
                yard.Text = "0";
            }
            double yardDouble = 0;

            if (double.TryParse(yard.Text, out yardDouble))
            {
                dec.Text = Convert.ToString(yardDouble * 9.144);
                cent.Text = Convert.ToString(yardDouble * 91.44);
                mil.Text = Convert.ToString(yardDouble * 914.4);
                microm.Text = Convert.ToString(yardDouble * 914400);
                nano.Text = Convert.ToString(yardDouble * 914400000);
                ang.Text = Convert.ToString(yardDouble * 9144000000);
                foot.Text = Convert.ToString(yardDouble * 3);
                inch.Text = Convert.ToString(yardDouble * 36);
                metre.Text = Convert.ToString(yardDouble * 0.9144);

            }

            dec.TextChanging += Dec_Changing;
            cent.TextChanging += Cent_Changing;
            mil.TextChanging += Milm_Changing;
            microm.TextChanging += Micm_Changing;
            nanom.TextChanging += Nanom_Changing;
            ang.TextChanging += Ang_Changing;
            foot.TextChanging += Foot_Changing;
            inch.TextChanging += Inch_Changing;
            metre.TextChanging += Met_Changing;
        }

        private void Ang_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            metre.TextChanging -= Met_Changing;
            cent.TextChanging -= Cent_Changing;
            mil.TextChanging -= Milm_Changing;
            microm.TextChanging -= Micm_Changing;
            nanom.TextChanging -= Nanom_Changing;
            yard.TextChanging -= Yard_Changing;
            foot.TextChanging -= Foot_Changing;
            dec.TextChanging -= Dec_Changing;
            inch.TextChanging -= Inch_Changing;

            if (ang.Text == "")
            {
                ang.Text = "0";
            }
            double angDouble = 0;

            if (double.TryParse(ang.Text, out angDouble))
            {
                dec.Text = Convert.ToString(angDouble * 1e-9);
                cent.Text = Convert.ToString(angDouble * 1e-8);
                mil.Text = Convert.ToString(angDouble * 1e-7);
                microm.Text = Convert.ToString(angDouble * 0.0001);
                nano.Text = Convert.ToString(angDouble * 0.1);
                yard.Text = Convert.ToString(angDouble * 1.09361329834e-10);
                foot.Text = Convert.ToString(angDouble * 3.28083989501e-10);
                inch.Text = Convert.ToString(angDouble * 3.93700787402e-9);
                metre.Text = Convert.ToString(angDouble * 1e-10);

            }

            dec.TextChanging += Dec_Changing;
            cent.TextChanging += Cent_Changing;
            mil.TextChanging += Milm_Changing;
            microm.TextChanging += Micm_Changing;
            nanom.TextChanging += Nanom_Changing;
            yard.TextChanging += Yard_Changing;
            foot.TextChanging += Foot_Changing;
            inch.TextChanging += Inch_Changing;
            metre.TextChanging += Met_Changing;
        }

        private void Nanom_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            metre.TextChanging -= Met_Changing;
            cent.TextChanging -= Cent_Changing;
            mil.TextChanging -= Milm_Changing;
            microm.TextChanging -= Micm_Changing;
            ang.TextChanging -= Ang_Changing;
            yard.TextChanging -= Yard_Changing;
            foot.TextChanging -= Foot_Changing;
            dec.TextChanging -= Dec_Changing;
            inch.TextChanging -= Inch_Changing;

            if (nanom.Text == "")
            {
                nanom.Text = "0";
            }
            double nanomDouble = 0;

            if (double.TryParse(nanom.Text, out nanomDouble))
            {
                dec.Text = Convert.ToString(nanomDouble * 1e-8);
                cent.Text = Convert.ToString(nanomDouble * 1e-7);
                mil.Text = Convert.ToString(nanomDouble * 0.000001);
                microm.Text = Convert.ToString(nanomDouble * 0.001);
                ang.Text = Convert.ToString(nanomDouble * 10);
                yard.Text = Convert.ToString(nanomDouble * 1.09361329834e-9);
                foot.Text = Convert.ToString(nanomDouble * 3.28083989501e-9);
                inch.Text = Convert.ToString(nanomDouble * 3.93700787402e-8);
                metre.Text = Convert.ToString(nanomDouble * 1e-9);

            }

            dec.TextChanging += Dec_Changing;
            cent.TextChanging += Cent_Changing;
            mil.TextChanging += Milm_Changing;
            microm.TextChanging += Micm_Changing;
            ang.TextChanging += Ang_Changing;
            yard.TextChanging += Yard_Changing;
            foot.TextChanging += Foot_Changing;
            inch.TextChanging += Inch_Changing;
            metre.TextChanging += Met_Changing;
        }

        private void Micm_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            metre.TextChanging -= Met_Changing;
            cent.TextChanging -= Cent_Changing;
            mil.TextChanging -= Milm_Changing;
            nanom.TextChanging -= Nanom_Changing;
            ang.TextChanging -= Ang_Changing;
            yard.TextChanging -= Yard_Changing;
            foot.TextChanging -= Foot_Changing;
            dec.TextChanging -= Dec_Changing;
            inch.TextChanging -= Inch_Changing;

            if (microm.Text == "")
            {
                microm.Text = "0";
            }
            double micromDouble = 0;

            if (double.TryParse(microm.Text, out micromDouble))
            {
                dec.Text = Convert.ToString(micromDouble * 0.00001);
                cent.Text = Convert.ToString(micromDouble * 0.0001);
                mil.Text = Convert.ToString(micromDouble * 0.001);
                nanom.Text = Convert.ToString(micromDouble * 1000);
                ang.Text = Convert.ToString(micromDouble * 10000);
                yard.Text = Convert.ToString(micromDouble * 0.00000109361329834);
                foot.Text = Convert.ToString(micromDouble * 0.00000328083989501);
                inch.Text = Convert.ToString(micromDouble * 0.0000393700787402);
                metre.Text = Convert.ToString(micromDouble * 0.000001);

            }

            dec.TextChanging += Dec_Changing;
            cent.TextChanging += Cent_Changing;
            mil.TextChanging += Milm_Changing;
            nanom.TextChanging += Nanom_Changing;
            ang.TextChanging += Ang_Changing;
            yard.TextChanging += Yard_Changing;
            foot.TextChanging += Foot_Changing;
            inch.TextChanging += Inch_Changing;
            metre.TextChanging += Met_Changing;
        }

        private void Milm_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            {
                metre.TextChanging -= Met_Changing;
                cent.TextChanging -= Cent_Changing;
                microm.TextChanging -= Micm_Changing;
                nanom.TextChanging -= Nanom_Changing;
                ang.TextChanging -= Ang_Changing;
                yard.TextChanging -= Yard_Changing;
                foot.TextChanging -= Foot_Changing;
                dec.TextChanging -= Dec_Changing;
                inch.TextChanging -= Inch_Changing;

                if (mil.Text == "")
                {
                    mil.Text = "0";
                }
                double milDouble = 0;

                if (double.TryParse(mil.Text, out milDouble))
                {
                    dec.Text = Convert.ToString(milDouble * 0.01);
                    cent.Text = Convert.ToString(milDouble * 0.01);
                    microm.Text = Convert.ToString(milDouble * 1000);
                    nanom.Text = Convert.ToString(milDouble * 1000000);
                    ang.Text = Convert.ToString(milDouble * 10000000);
                    yard.Text = Convert.ToString(milDouble * 0.00109361329834);
                    foot.Text = Convert.ToString(milDouble * 0.00328083989501);
                    inch.Text = Convert.ToString(milDouble * 0.0393700787402);
                    metre.Text = Convert.ToString(milDouble * 0.001);

                }

                dec.TextChanging += Dec_Changing;
                cent.TextChanging += Cent_Changing;
                microm.TextChanging += Micm_Changing;
                nanom.TextChanging += Nanom_Changing;
                ang.TextChanging += Ang_Changing;
                yard.TextChanging += Yard_Changing;
                foot.TextChanging += Foot_Changing;
                inch.TextChanging += Inch_Changing;
                metre.TextChanging += Met_Changing;
            }
        }

        private void Cent_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            metre.TextChanging -= Met_Changing;
            mil.TextChanging -= Mil_Changing;
            microm.TextChanging -= Micm_Changing;
            nanom.TextChanging -= Nanom_Changing;
            ang.TextChanging -= Ang_Changing;
            yard.TextChanging -= Yard_Changing;
            foot.TextChanging -= Foot_Changing;
            dec.TextChanging -= Dec_Changing;
            inch.TextChanging -= Inch_Changing;

            if (cent.Text == "")
            {
                cent.Text = "0";
            }
            double centDouble = 0;

            if (double.TryParse(cent.Text, out centDouble))
            {
                dec.Text = Convert.ToString(centDouble * 0.1);
                mil.Text = Convert.ToString(centDouble * 10);
                microm.Text = Convert.ToString(centDouble * 10000);
                nanom.Text = Convert.ToString(centDouble * 10000000);
                ang.Text = Convert.ToString(centDouble * 100000000);
                yard.Text = Convert.ToString(centDouble * 0.0109361329834);
                foot.Text = Convert.ToString(centDouble * 0.0328083989501);
                inch.Text = Convert.ToString(centDouble * 0.393700787402);
                metre.Text = Convert.ToString(centDouble * 0.01);

            }

            dec.TextChanging += Dec_Changing;
            mil.TextChanging += Mil_Changing;
            microm.TextChanging += Micm_Changing;
            nanom.TextChanging += Nanom_Changing;
            ang.TextChanging += Ang_Changing;
            yard.TextChanging += Yard_Changing;
            foot.TextChanging += Foot_Changing;
            inch.TextChanging += Inch_Changing;
            metre.TextChanging += Met_Changing;
        }

        private void Dec_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            metre.TextChanging -= Met_Changing;
            mil.TextChanging -= Mil_Changing;
            microm.TextChanging -= Micm_Changing;
            nanom.TextChanging -= Nanom_Changing;
            ang.TextChanging -= Ang_Changing;
            yard.TextChanging -= Yard_Changing;
            foot.TextChanging -= Foot_Changing;
            cent.TextChanging -= Cent_Changing;
            inch.TextChanging -= Inch_Changing;

            if (dec.Text == "")
            {
                dec.Text = "0";
            }
            double decDouble = 0;

            if (double.TryParse(dec.Text, out decDouble))
            {
                cent.Text = Convert.ToString(decDouble * 0.1);
                mil.Text = Convert.ToString(decDouble * 10);
                microm.Text = Convert.ToString(decDouble * 10000);
                nanom.Text = Convert.ToString(decDouble * 10000000);
                ang.Text = Convert.ToString(decDouble * 100000000);
                yard.Text = Convert.ToString(decDouble * 0.0109361329834);
                foot.Text = Convert.ToString(decDouble * 0.0328083989501);
                inch.Text = Convert.ToString(decDouble * 0.393700787402);
                metre.Text = Convert.ToString(decDouble * 0.01);

            }

            cent.TextChanging += Cent_Changing;
            mil.TextChanging += Mil_Changing;
            microm.TextChanging += Micm_Changing;
            nanom.TextChanging += Nanom_Changing;
            ang.TextChanging += Ang_Changing;
            yard.TextChanging += Yard_Changing;
            foot.TextChanging += Foot_Changing;
            inch.TextChanging += Inch_Changing;
            metre.TextChanging += Met_Changing;
        }
    }
}
