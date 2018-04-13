using System;
using System.Net;
using Windows.UI.Xaml.Controls;
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
            carat.TextChanging -= Carat_Changing;

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
            carat.TextChanging += Carat_Changing;
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
            carat.TextChanging -= Carat_Changing;

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
            carat.TextChanging += Carat_Changing;
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
            carat.TextChanging -= Carat_Changing;

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
            carat.TextChanging += Carat_Changing;
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
            carat.TextChanging -= Carat_Changing;

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
            carat.TextChanging += Carat_Changing;
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
            carat.TextChanging -= Carat_Changing;

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
            carat.TextChanging += Carat_Changing;
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
            carat.TextChanging -= Carat_Changing;

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
            carat.TextChanging += Carat_Changing;
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
            carat.TextChanging -= Carat_Changing;

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
            carat.TextChanging += Carat_Changing;
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
            carat.TextChanging -= Carat_Changing;

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
            carat.TextChanging += Carat_Changing;
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
            carat.TextChanging -= Carat_Changing;

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
            carat.TextChanging += Carat_Changing;
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
            carat.TextChanging -= Carat_Changing;

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
            carat.TextChanging += Carat_Changing;
        }

        private void Carat_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
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
                dec.Text = Convert.ToString(metreDouble * 10);
                cent.Text = Convert.ToString(metreDouble * 100);
                mil.Text = Convert.ToString(metreDouble * 1000);
                microm.Text = Convert.ToString(metreDouble * 1e+6);
                nanom.Text = Convert.ToString(metreDouble * 1e+9);
                ang.Text = Convert.ToString(metreDouble * 1e+10);
                yard.Text = Convert.ToString(metreDouble * 1.09361);
                foot.Text = Convert.ToString(metreDouble * 3.28083);
                inch.Text = Convert.ToString(metreDouble * 39.36996);
                
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
                nanom.Text = Convert.ToString(inchDouble * 25400000);
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
                nanom.Text = Convert.ToString(footDouble * 304800000);
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
                nanom.Text = Convert.ToString(yardDouble * 914400000);
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
                nanom.Text = Convert.ToString(angDouble * 0.1);
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

        private void Mcub_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            hec.TextChanging -= Hec_Changing;
            litre.TextChanging -= Litre_Changing;
            decl.TextChanging -= Decl_Changing;
            mill.TextChanging -= Mill_Changing;
            micl.TextChanging -= Micl_Changing;
            gal.TextChanging -= Gal_Changing;
            pint.TextChanging -= Pint_Changing;
            ounc.TextChanging -= Ounc_Changing;
            cubinch.TextChanging -= Cubinch_Changing;

            if (mcub.Text == "")
            {
                mcub.Text = "0";
            }
            double mcubDouble = 0;

            if (double.TryParse(mcub.Text, out mcubDouble))
            {
                hec.Text = Convert.ToString(mcubDouble * 10);
                litre.Text = Convert.ToString(mcubDouble * 1000);
                decl.Text = Convert.ToString(mcubDouble * 10000);
                mill.Text = Convert.ToString(mcubDouble * 10000000);
                micl.Text = Convert.ToString(mcubDouble * 1000000000);
                gal.Text = Convert.ToString(mcubDouble * 219.9692483);
                pint.Text = Convert.ToString(mcubDouble * 1759.7539864);
                ounc.Text = Convert.ToString(mcubDouble * 35195.079728);
                cubinch.Text = Convert.ToString(mcubDouble * 61023.744095);

            }

            hec.TextChanging += Hec_Changing;
            litre.TextChanging += Litre_Changing;
            decl.TextChanging += Decl_Changing;
            mill.TextChanging += Mill_Changing;
            micl.TextChanging += Micl_Changing;
            gal.TextChanging += Gal_Changing;
            pint.TextChanging += Pint_Changing;
            ounc.TextChanging += Ounc_Changing;
            cubinch.TextChanging += Cubinch_Changing;
        }

        private void Hec_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            mcub.TextChanging -= Mcub_Changing;
            litre.TextChanging -= Litre_Changing;
            decl.TextChanging -= Decl_Changing;
            mill.TextChanging -= Mill_Changing;
            micl.TextChanging -= Micl_Changing;
            gal.TextChanging -= Gal_Changing;
            pint.TextChanging -= Pint_Changing;
            ounc.TextChanging -= Ounc_Changing;
            cubinch.TextChanging -= Cubinch_Changing;

            if (hec.Text == "")
            {
                hec.Text = "0";
            }
            double hecDouble = 0;

            if (double.TryParse(hec.Text, out hecDouble))
            {
                mcub.Text = Convert.ToString(hecDouble * 0.1);
                litre.Text = Convert.ToString(hecDouble * 100);
                decl.Text = Convert.ToString(hecDouble * 1000);
                mill.Text = Convert.ToString(hecDouble * 100000);
                micl.Text = Convert.ToString(hecDouble * 100000000);
                gal.Text = Convert.ToString(hecDouble * 21.99692483);
                pint.Text = Convert.ToString(hecDouble * 175.97539864);
                ounc.Text = Convert.ToString(hecDouble * 3519.5079728);
                cubinch.Text = Convert.ToString(hecDouble * 6102.3744095);

            }

            mcub.TextChanging += Mcub_Changing;
            litre.TextChanging += Litre_Changing;
            decl.TextChanging += Decl_Changing;
            mill.TextChanging += Mill_Changing;
            micl.TextChanging += Micl_Changing;
            gal.TextChanging += Gal_Changing;
            pint.TextChanging += Pint_Changing;
            ounc.TextChanging += Ounc_Changing;
            cubinch.TextChanging += Cubinch_Changing;
        }

        private void Litre_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            mcub.TextChanging -= Mcub_Changing;
            hec.TextChanging -= Hec_Changing;
            decl.TextChanging -= Decl_Changing;
            mill.TextChanging -= Mill_Changing;
            micl.TextChanging -= Micl_Changing;
            gal.TextChanging -= Gal_Changing;
            pint.TextChanging -= Pint_Changing;
            ounc.TextChanging -= Ounc_Changing;
            cubinch.TextChanging -= Cubinch_Changing;

            if (litre.Text == "")
            {
                litre.Text = "0";
            }
            double litreDouble = 0;

            if (double.TryParse(litre.Text, out litreDouble))
            {
                mcub.Text = Convert.ToString(litreDouble * 0.001);
                hec.Text = Convert.ToString(litreDouble * 0.01);
                decl.Text = Convert.ToString(litreDouble * 10);
                mill.Text = Convert.ToString(litreDouble * 1000);
                micl.Text = Convert.ToString(litreDouble * 1000000);
                gal.Text = Convert.ToString(litreDouble * 0.2199692483);
                pint.Text = Convert.ToString(litreDouble * 1.7597539864);
                ounc.Text = Convert.ToString(litreDouble * 35.195079728);
                cubinch.Text = Convert.ToString(litreDouble * 61.023744095);

            }

            mcub.TextChanging += Mcub_Changing;
            hec.TextChanging += Hec_Changing;
            decl.TextChanging += Decl_Changing;
            mill.TextChanging += Mill_Changing;
            micl.TextChanging += Micl_Changing;
            gal.TextChanging += Gal_Changing;
            pint.TextChanging += Pint_Changing;
            ounc.TextChanging += Ounc_Changing;
            cubinch.TextChanging += Cubinch_Changing;
        }

        private void Decl_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            mcub.TextChanging -= Mcub_Changing;
            hec.TextChanging -= Hec_Changing;
            litre.TextChanging -= Litre_Changing;
            mill.TextChanging -= Mill_Changing;
            micl.TextChanging -= Micl_Changing;
            gal.TextChanging -= Gal_Changing;
            pint.TextChanging -= Pint_Changing;
            ounc.TextChanging -= Ounc_Changing;
            cubinch.TextChanging -= Cubinch_Changing;

            if (decl.Text == "")
            {
                decl.Text = "0";
            }
            double declDouble = 0;

            if (double.TryParse(decl.Text, out declDouble))
            {
                mcub.Text = Convert.ToString(declDouble * 0.0001);
                hec.Text = Convert.ToString(declDouble * 0.001);
                litre.Text = Convert.ToString(declDouble * 0.1);
                mill.Text = Convert.ToString(declDouble * 100);
                micl.Text = Convert.ToString(declDouble * 100000);
                gal.Text = Convert.ToString(declDouble * 0.0219969248);
                pint.Text = Convert.ToString(declDouble * 0.1759753986);
                ounc.Text = Convert.ToString(declDouble * 3.5195079728);
                cubinch.Text = Convert.ToString(declDouble * 6.1023744095);

            }

            mcub.TextChanging += Mcub_Changing;
            hec.TextChanging += Hec_Changing;
            litre.TextChanging += Litre_Changing;
            mill.TextChanging += Mill_Changing;
            micl.TextChanging += Micl_Changing;
            gal.TextChanging += Gal_Changing;
            pint.TextChanging += Pint_Changing;
            ounc.TextChanging += Ounc_Changing;
            cubinch.TextChanging += Cubinch_Changing;
        }

        private void Mill_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            mcub.TextChanging -= Mcub_Changing;
            hec.TextChanging -= Hec_Changing;
            litre.TextChanging -= Litre_Changing;
            decl.TextChanging -= Decl_Changing;
            micl.TextChanging -= Micl_Changing;
            gal.TextChanging -= Gal_Changing;
            pint.TextChanging -= Pint_Changing;
            ounc.TextChanging -= Ounc_Changing;
            cubinch.TextChanging -= Cubinch_Changing;

            if (mill.Text == "")
            {
                mill.Text = "0";
            }
            double millDouble = 0;

            if (double.TryParse(mill.Text, out millDouble))
            {
                mcub.Text = Convert.ToString(millDouble * 0.000001);
                hec.Text = Convert.ToString(millDouble * 0.00001);
                litre.Text = Convert.ToString(millDouble * 0.001);
                decl.Text = Convert.ToString(millDouble * 0.01);
                micl.Text = Convert.ToString(millDouble * 1000);
                gal.Text = Convert.ToString(millDouble * 0.0002199692);
                pint.Text = Convert.ToString(millDouble * 0.001759754);
                ounc.Text = Convert.ToString(millDouble * 0.0351950797);
                cubinch.Text = Convert.ToString(millDouble * 0.0610237441);

            }

            mcub.TextChanging += Mcub_Changing;
            hec.TextChanging += Hec_Changing;
            litre.TextChanging += Litre_Changing;
            decl.TextChanging += Decl_Changing;
            micl.TextChanging += Micl_Changing;
            gal.TextChanging += Gal_Changing;
            pint.TextChanging += Pint_Changing;
            ounc.TextChanging += Ounc_Changing;
            cubinch.TextChanging += Cubinch_Changing;
        }

        private void Micl_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            mcub.TextChanging -= Mcub_Changing;
            hec.TextChanging -= Hec_Changing;
            litre.TextChanging -= Litre_Changing;
            decl.TextChanging -= Decl_Changing;
            mill.TextChanging -= Mill_Changing;
            gal.TextChanging -= Gal_Changing;
            pint.TextChanging -= Pint_Changing;
            ounc.TextChanging -= Ounc_Changing;
            cubinch.TextChanging -= Cubinch_Changing;

            if (micl.Text == "")
            {
                micl.Text = "0";
            }
            double miclDouble = 0;

            if (double.TryParse(micl.Text, out miclDouble))
            {
                mcub.Text = Convert.ToString(miclDouble * 1e-9);
                hec.Text = Convert.ToString(miclDouble * 1e-8);
                litre.Text = Convert.ToString(miclDouble * 0.000001);
                decl.Text = Convert.ToString(miclDouble * 0.00001);
                mill.Text = Convert.ToString(miclDouble * 0.001);
                gal.Text = Convert.ToString(miclDouble * 2.199692482e-7);
                pint.Text = Convert.ToString(miclDouble * 0.0000017598);
                ounc.Text = Convert.ToString(miclDouble * 0.0000351951);
                cubinch.Text = Convert.ToString(miclDouble * 0.0000610237);

            }

            mcub.TextChanging += Mcub_Changing;
            hec.TextChanging += Hec_Changing;
            litre.TextChanging += Litre_Changing;
            decl.TextChanging += Decl_Changing;
            mill.TextChanging += Mill_Changing;
            gal.TextChanging += Gal_Changing;
            pint.TextChanging += Pint_Changing;
            ounc.TextChanging += Ounc_Changing;
            cubinch.TextChanging += Cubinch_Changing;
        }

        private void Gal_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            mcub.TextChanging -= Mcub_Changing;
            hec.TextChanging -= Hec_Changing;
            litre.TextChanging -= Litre_Changing;
            decl.TextChanging -= Decl_Changing;
            mill.TextChanging -= Mill_Changing;
            micl.TextChanging -= Micl_Changing;
            pint.TextChanging -= Pint_Changing;
            ounc.TextChanging -= Ounc_Changing;
            cubinch.TextChanging -= Cubinch_Changing;

            if (gal.Text == "")
            {
                gal.Text = "0";
            }
            double galDouble = 0;

            if (double.TryParse(gal.Text, out galDouble))
            {
                mcub.Text = Convert.ToString(galDouble * 0.00454609);
                hec.Text = Convert.ToString(galDouble * 0.0454609);
                litre.Text = Convert.ToString(galDouble * 4.54609);
                decl.Text = Convert.ToString(galDouble * 45.4609);
                mill.Text = Convert.ToString(galDouble * 4546.09);
                micl.Text = Convert.ToString(galDouble * 4546090);
                pint.Text = Convert.ToString(galDouble * 8);
                ounc.Text = Convert.ToString(galDouble * 160);
                cubinch.Text = Convert.ToString(galDouble * 277.41943279);

            }

            mcub.TextChanging += Mcub_Changing;
            hec.TextChanging += Hec_Changing;
            litre.TextChanging += Litre_Changing;
            decl.TextChanging += Decl_Changing;
            mill.TextChanging += Mill_Changing;
            micl.TextChanging += Micl_Changing;
            pint.TextChanging += Pint_Changing;
            ounc.TextChanging += Ounc_Changing;
            cubinch.TextChanging += Cubinch_Changing;
        }

        private void Pint_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            mcub.TextChanging -= Mcub_Changing;
            hec.TextChanging -= Hec_Changing;
            litre.TextChanging -= Litre_Changing;
            decl.TextChanging -= Decl_Changing;
            mill.TextChanging -= Mill_Changing;
            micl.TextChanging -= Micl_Changing;
            gal.TextChanging -= Gal_Changing;
            ounc.TextChanging -= Ounc_Changing;
            cubinch.TextChanging -= Cubinch_Changing;

            if (pint.Text == "")
            {
                pint.Text = "0";
            }
            double pintDouble = 0;

            if (double.TryParse(pint.Text, out pintDouble))
            {
                mcub.Text = Convert.ToString(pintDouble * 0.0005682613);
                hec.Text = Convert.ToString(pintDouble * 0.0056826125);
                litre.Text = Convert.ToString(pintDouble * 0.56826125);
                decl.Text = Convert.ToString(pintDouble * 5.6826125);
                mill.Text = Convert.ToString(pintDouble * 568.26125);
                micl.Text = Convert.ToString(pintDouble * 568261.25);
                gal.Text = Convert.ToString(pintDouble * 0.125);
                ounc.Text = Convert.ToString(pintDouble * 20);
                cubinch.Text = Convert.ToString(pintDouble * 34.677429099);

            }

            mcub.TextChanging += Mcub_Changing;
            hec.TextChanging += Hec_Changing;
            litre.TextChanging += Litre_Changing;
            decl.TextChanging += Decl_Changing;
            mill.TextChanging += Mill_Changing;
            micl.TextChanging += Micl_Changing;
            gal.TextChanging += Gal_Changing;
            ounc.TextChanging += Ounc_Changing;
            cubinch.TextChanging += Cubinch_Changing;
        }

        private void Ounc_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            mcub.TextChanging -= Mcub_Changing;
            hec.TextChanging -= Hec_Changing;
            litre.TextChanging -= Litre_Changing;
            decl.TextChanging -= Decl_Changing;
            mill.TextChanging -= Mill_Changing;
            micl.TextChanging -= Micl_Changing;
            gal.TextChanging -= Gal_Changing;
            pint.TextChanging -= Pint_Changing;
            cubinch.TextChanging -= Cubinch_Changing;

            if (ounc.Text == "")
            {
                ounc.Text = "0";
            }
            double ouncDouble = 0;

            if (double.TryParse(ounc.Text, out ouncDouble))
            {
                mcub.Text = Convert.ToString(ouncDouble * 0.0000284131);
                hec.Text = Convert.ToString(ouncDouble * 0.0002841306);
                litre.Text = Convert.ToString(ouncDouble * 0.0284130625);
                decl.Text = Convert.ToString(ouncDouble * 0.284130625);
                mill.Text = Convert.ToString(ouncDouble * 28.4130625);
                micl.Text = Convert.ToString(ouncDouble * 28413.0625);
                gal.Text = Convert.ToString(ouncDouble * 0.00625);
                pint.Text = Convert.ToString(ouncDouble * 0.05);
                cubinch.Text = Convert.ToString(ouncDouble * 1.7338714549);

            }

            mcub.TextChanging += Mcub_Changing;
            hec.TextChanging += Hec_Changing;
            litre.TextChanging += Litre_Changing;
            decl.TextChanging += Decl_Changing;
            mill.TextChanging += Mill_Changing;
            micl.TextChanging += Micl_Changing;
            gal.TextChanging += Gal_Changing;
            pint.TextChanging += Ounc_Changing;
            cubinch.TextChanging += Cubinch_Changing;
        }

        private void Cubinch_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            mcub.TextChanging -= Mcub_Changing;
            hec.TextChanging -= Hec_Changing;
            litre.TextChanging -= Litre_Changing;
            decl.TextChanging -= Decl_Changing;
            mill.TextChanging -= Mill_Changing;
            micl.TextChanging -= Micl_Changing;
            gal.TextChanging -= Gal_Changing;
            pint.TextChanging -= Pint_Changing;
            ounc.TextChanging -= Ounc_Changing;

            if (cubinch.Text == "")
            {
                cubinch.Text = "0";
            }
            double cubinchDouble = 0;

            if (double.TryParse(cubinch.Text, out cubinchDouble))
            {
                mcub.Text = Convert.ToString(cubinchDouble * 0.0000163871);
                hec.Text = Convert.ToString(cubinchDouble * 0.0001638706);
                litre.Text = Convert.ToString(cubinchDouble * 0.016387064);
                decl.Text = Convert.ToString(cubinchDouble * 0.16387064);
                mill.Text = Convert.ToString(cubinchDouble * 16.387064);
                micl.Text = Convert.ToString(cubinchDouble * 16387.064);
                gal.Text = Convert.ToString(cubinchDouble * 0.0036046501);
                pint.Text = Convert.ToString(cubinchDouble * 0.0288372012);
                ounc.Text = Convert.ToString(cubinchDouble * 0.576744024);

            }

            mcub.TextChanging += Mcub_Changing;
            hec.TextChanging += Hec_Changing;
            litre.TextChanging += Litre_Changing;
            decl.TextChanging += Decl_Changing;
            mill.TextChanging += Mill_Changing;
            micl.TextChanging += Micl_Changing;
            gal.TextChanging += Gal_Changing;
            pint.TextChanging += Ounc_Changing;
            ounc.TextChanging += Cubinch_Changing;
        }

        private void Mph_Changing(object sender, TextBoxTextChangingEventArgs args)
        {
            kph.TextChanging -= Kph_Changing;
            ms.TextChanging -= Ms_Changing;
            cms.TextChanging -= Cms_Changing;
            knot.TextChanging -= Knot_Changing;
            if (mph.Text == "")
            {
                mph.Text = "0";
            }

            double mphDouble = 0;
            if (double.TryParse(mph.Text, out mphDouble))
            {
                kph.Text = Convert.ToString(mphDouble * 1.609344);
                ms.Text = Convert.ToString(mphDouble * 0.447040);
                cms.Text = Convert.ToString(mphDouble * 44.704000);
                knot.Text = Convert.ToString(mphDouble * 0.868976);
            }

            kph.TextChanging += Kph_Changing;
            ms.TextChanging += Ms_Changing;
            cms.TextChanging += Cms_Changing;
            knot.TextChanging += Knot_Changing;
        }

        private void Kph_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            mph.TextChanging -= Mph_Changing;
            ms.TextChanging -= Ms_Changing;
            cms.TextChanging -= Cms_Changing;
            knot.TextChanging -= Knot_Changing;
            if (kph.Text == "")
            {
                kph.Text = "0";
            }

            double kphDouble = 0;
            if (double.TryParse(kph.Text, out kphDouble))
            {
                mph.Text = Convert.ToString(kphDouble * 0.621371);
                ms.Text = Convert.ToString(kphDouble * 0.277778);
                cms.Text = Convert.ToString(kphDouble * 27.777778);
                knot.Text = Convert.ToString(kphDouble * 0.539957);
            }

            mph.TextChanging += Mph_Changing;
            ms.TextChanging += Ms_Changing;
            cms.TextChanging += Cms_Changing;
            knot.TextChanging += Knot_Changing;
        }

        private void Ms_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            mph.TextChanging -= Mph_Changing;
            kph.TextChanging -= Kph_Changing;
            cms.TextChanging -= Cms_Changing;
            knot.TextChanging -= Knot_Changing;
            if (ms.Text == "")
            {
                ms.Text = "0";
            }

            double msDouble = 0;
            if (double.TryParse(ms.Text, out msDouble))
            {
                mph.Text = Convert.ToString(msDouble * 2.236936);
                kph.Text = Convert.ToString(msDouble * 3.6);
                cms.Text = Convert.ToString(msDouble * 100);
                knot.Text = Convert.ToString(msDouble * 1.943844);
            }

            mph.TextChanging += Mph_Changing;
            kph.TextChanging += Kph_Changing;
            cms.TextChanging += Cms_Changing;
            knot.TextChanging += Knot_Changing;
        }

        private void Cms_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            mph.TextChanging -= Mph_Changing;
            kph.TextChanging -= Kph_Changing;
            ms.TextChanging -= Ms_Changing;
            knot.TextChanging -= Knot_Changing;
            if (cms.Text == "")
            {
                cms.Text = "0";
            }

            double cmsDouble = 0;
            if (double.TryParse(cms.Text, out cmsDouble))
            {
                mph.Text = Convert.ToString(cmsDouble * 0.022369);
                kph.Text = Convert.ToString(cmsDouble * 0.036);
                ms.Text = Convert.ToString(cmsDouble * 0.01);
                knot.Text = Convert.ToString(cmsDouble * 0.019438);
            }

            mph.TextChanging += Mph_Changing;
            kph.TextChanging += Kph_Changing;
            ms.TextChanging += Ms_Changing;
            knot.TextChanging += Knot_Changing;
        }

        private void Knot_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            mph.TextChanging -= Mph_Changing;
            kph.TextChanging -= Kph_Changing;
            ms.TextChanging -= Ms_Changing;
            cms.TextChanging -= Cms_Changing;
            if (knot.Text == "")
            {
                knot.Text = "0";
            }

            double knotDouble = 0;
            if (double.TryParse(knot.Text, out knotDouble))
            {
                mph.Text = Convert.ToString(knotDouble * 1.150779);
                kph.Text = Convert.ToString(knotDouble * 1.852);
                ms.Text = Convert.ToString(knotDouble * 0.514444);
                cms.Text = Convert.ToString(knotDouble * 51.444444);
            }

            mph.TextChanging += Mph_Changing;
            kph.TextChanging += Kph_Changing;
            ms.TextChanging += Ms_Changing;
            cms.TextChanging += Cms_Changing;
        }

        private void Acre_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            hect.TextChanging -= Hect_Changing;
            sqm.TextChanging -= Sqm_Changing;
            sqf.TextChanging -= Sqf_Changing;
            sqcm.TextChanging -= Sqcm_Changing;
            sqi.TextChanging -= Sqi_Changing;
            if (acre.Text == "")
            {
                acre.Text = "0";
            }

            double acreDouble = 0;
            if (double.TryParse(acre.Text, out acreDouble))
            {
                hect.Text = Convert.ToString(acreDouble * 0.404686);
                sqm.Text = Convert.ToString(acreDouble * 4046.856422);
                sqf.Text = Convert.ToString(acreDouble * 43560);
                sqcm.Text = Convert.ToString(acreDouble * 40468564.224);
                sqi.Text = Convert.ToString(acreDouble * 6272640);
            }

            hect.TextChanging += Hect_Changing;
            sqm.TextChanging += Sqm_Changing;
            sqf.TextChanging += Sqf_Changing;
            sqcm.TextChanging += Sqcm_Changing;
            sqi.TextChanging += Sqi_Changing;
        }

        private void Hect_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            acre.TextChanging -= Acre_Changing;
            sqm.TextChanging -= Sqm_Changing;
            sqf.TextChanging -= Sqf_Changing;
            sqcm.TextChanging -= Sqcm_Changing;
            sqi.TextChanging -= Sqi_Changing;
            if (hect.Text == "")
            {
                hect.Text = "0";
            }

            double hectDouble = 0;
            if (double.TryParse(hect.Text, out hectDouble))
            {
                acre.Text = Convert.ToString(hectDouble * 2.471054);
                sqm.Text = Convert.ToString(hectDouble * 10000);
                sqf.Text = Convert.ToString(hectDouble * 107639.104167);
                sqcm.Text = Convert.ToString(hectDouble * 100000000);
                sqi.Text = Convert.ToString(hectDouble * 15500031.000062);
            }

            acre.TextChanging += Acre_Changing;
            sqm.TextChanging += Sqm_Changing;
            sqf.TextChanging += Sqf_Changing;
            sqcm.TextChanging += Sqcm_Changing;
            sqi.TextChanging += Sqi_Changing;
        }

        private void Sqm_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            acre.TextChanging -= Acre_Changing;
            hect.TextChanging -= Hect_Changing;
            sqf.TextChanging -= Sqf_Changing;
            sqcm.TextChanging -= Sqcm_Changing;
            sqi.TextChanging -= Sqi_Changing;
            if (sqm.Text == "")
            {
                sqm.Text = "0";
            }

            double sqmDouble = 0;
            if (double.TryParse(sqm.Text, out sqmDouble))
            {
                acre.Text = Convert.ToString(sqmDouble * 0.000247);
                hect.Text = Convert.ToString(sqmDouble * 0.0001);
                sqf.Text = Convert.ToString(sqmDouble * 10.763910);
                sqcm.Text = Convert.ToString(sqmDouble * 10000);
                sqi.Text = Convert.ToString(sqmDouble * 1550.0031);
            }

            acre.TextChanging += Acre_Changing;
            hect.TextChanging += Hect_Changing;
            sqf.TextChanging += Sqf_Changing;
            sqcm.TextChanging += Sqcm_Changing;
            sqi.TextChanging += Sqi_Changing;
        }

        private void Sqf_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            acre.TextChanging -= Acre_Changing;
            hect.TextChanging -= Hect_Changing;
            sqm.TextChanging -= Sqm_Changing;
            sqcm.TextChanging -= Sqcm_Changing;
            sqi.TextChanging -= Sqi_Changing;
            if (sqf.Text == "")
            {
                sqf.Text = "0";
            }

            double sqfDouble = 0;
            if (double.TryParse(sqf.Text, out sqfDouble))
            {
                acre.Text = Convert.ToString(sqfDouble * 0.000023);
                hect.Text = Convert.ToString(sqfDouble * 0.000009);
                sqm.Text = Convert.ToString(sqfDouble * 0.092903);
                sqcm.Text = Convert.ToString(sqfDouble * 929.0304);
                sqi.Text = Convert.ToString(sqfDouble * 144);
            }

            acre.TextChanging += Acre_Changing;
            hect.TextChanging += Hect_Changing;
            sqm.TextChanging += Sqm_Changing;
            sqcm.TextChanging += Sqcm_Changing;
            sqi.TextChanging += Sqi_Changing;
        }

        private void Sqcm_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            acre.TextChanging -= Acre_Changing;
            hect.TextChanging -= Hect_Changing;
            sqm.TextChanging -= Sqm_Changing;
            sqf.TextChanging -= Sqf_Changing;
            sqi.TextChanging -= Sqi_Changing;
            if (sqcm.Text == "")
            {
                sqcm.Text = "0";
            }

            double sqcmDouble = 0;
            if (double.TryParse(sqcm.Text, out sqcmDouble))
            {
                acre.Text = Convert.ToString(sqcmDouble * 2.47105e-8);
                hect.Text = Convert.ToString(sqcmDouble * 1e-8);
                sqm.Text = Convert.ToString(sqcmDouble * 0.0001);
                sqf.Text = Convert.ToString(sqcmDouble * 0.001076);
                sqi.Text = Convert.ToString(sqcmDouble * 0.155);
            }

            acre.TextChanging += Acre_Changing;
            hect.TextChanging += Hect_Changing;
            sqm.TextChanging += Sqm_Changing;
            sqf.TextChanging += Sqf_Changing;
            sqi.TextChanging += Sqi_Changing;
        }

        private void Sqi_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            acre.TextChanging -= Acre_Changing;
            hect.TextChanging -= Hect_Changing;
            sqm.TextChanging -= Sqm_Changing;
            sqf.TextChanging -= Sqf_Changing;
            sqcm.TextChanging -= Sqcm_Changing;
            if (sqi.Text == "")
            {
                sqi.Text = "0";
            }

            double sqiDouble = 0;
            if (double.TryParse(sqi.Text, out sqiDouble))
            {
                acre.Text = Convert.ToString(sqiDouble * 1.59423e-7);
                hect.Text = Convert.ToString(sqiDouble * 6.4516e-8);
                sqm.Text = Convert.ToString(sqiDouble * 0.000645);
                sqf.Text = Convert.ToString(sqiDouble * 0.006944);
                sqcm.Text = Convert.ToString(sqiDouble * 6.4516);
            }

            acre.TextChanging += Acre_Changing;
            hect.TextChanging += Hect_Changing;
            sqm.TextChanging += Sqm_Changing;
            sqf.TextChanging += Sqf_Changing;
            sqcm.TextChanging += Sqcm_Changing;
        }

        private void Byte_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            kb.TextChanging -= Kb_Changing;
            mb.TextChanging -= Mb_Changing;
            gb.TextChanging -= Gb_Changing;
            tb.TextChanging -= Tb_Changing;
            pb.TextChanging -= Pb_Changing;
            if (b.Text == "")
            {
                b.Text = "0";
            }

            double bDouble = 0;
            if (double.TryParse(b.Text, out bDouble))
            {
                kb.Text = Convert.ToString(bDouble * 0.001);
                mb.Text = Convert.ToString(bDouble * 1e-6);
                gb.Text = Convert.ToString(bDouble * 1.25e-10);
                tb.Text = Convert.ToString(bDouble * 1.25e-13);
                pb.Text = Convert.ToString(bDouble * 1e-15);
            }

            kb.TextChanging += Kb_Changing;
            mb.TextChanging += Mb_Changing;
            gb.TextChanging += Gb_Changing;
            tb.TextChanging += Tb_Changing;
            pb.TextChanging += Pb_Changing;
        }

        private void Kb_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            b.TextChanging -= Byte_Changing;
            mb.TextChanging -= Mb_Changing;
            gb.TextChanging -= Gb_Changing;
            tb.TextChanging -= Tb_Changing;
            pb.TextChanging -= Pb_Changing;
            if (kb.Text == "")
            {
                kb.Text = "0";
            }

            double kbDouble = 0;
            if (double.TryParse(kb.Text, out kbDouble))
            {
                b.Text = Convert.ToString(kbDouble * 1000);
                mb.Text = Convert.ToString(kbDouble * 0.001);
                gb.Text = Convert.ToString(kbDouble * 1e-6);
                tb.Text = Convert.ToString(kbDouble * 1e-9);
                pb.Text = Convert.ToString(kbDouble * 1e-12);
            }

            b.TextChanging += Byte_Changing;
            mb.TextChanging += Mb_Changing;
            gb.TextChanging += Gb_Changing;
            tb.TextChanging += Tb_Changing;
            pb.TextChanging += Pb_Changing;
        }

        private void Mb_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            b.TextChanging -= Byte_Changing;
            kb.TextChanging -= Kb_Changing;
            gb.TextChanging -= Gb_Changing;
            tb.TextChanging -= Tb_Changing;
            pb.TextChanging -= Pb_Changing;
            if (mb.Text == "")
            {
                mb.Text = "0";
            }

            double mbDouble = 0;
            if (double.TryParse(mb.Text, out mbDouble))
            {
                b.Text = Convert.ToString(mbDouble * 1000000);
                kb.Text = Convert.ToString(mbDouble * 1000);
                gb.Text = Convert.ToString(mbDouble * 0.001);
                tb.Text = Convert.ToString(mbDouble * 1e-6);
                pb.Text = Convert.ToString(mbDouble * 1e-9);
            }

            b.TextChanging += Byte_Changing;
            kb.TextChanging += Kb_Changing;
            gb.TextChanging += Gb_Changing;
            tb.TextChanging += Tb_Changing;
            pb.TextChanging += Pb_Changing;
        }

        private void Gb_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            b.TextChanging -= Byte_Changing;
            kb.TextChanging -= Kb_Changing;
            mb.TextChanging -= Mb_Changing;
            tb.TextChanging -= Tb_Changing;
            pb.TextChanging -= Pb_Changing;
            if (gb.Text == "")
            {
                gb.Text = "0";
            }

            double gbDouble = 0;
            if (double.TryParse(gb.Text, out gbDouble))
            {
                b.Text = Convert.ToString(gbDouble * 1e+9);
                kb.Text = Convert.ToString(gbDouble * 1000000);
                mb.Text = Convert.ToString(gbDouble * 1000);
                tb.Text = Convert.ToString(gbDouble * 0.001);
                pb.Text = Convert.ToString(gbDouble * 1e-6);
            }

            b.TextChanging += Byte_Changing;
            kb.TextChanging += Kb_Changing;
            mb.TextChanging += Mb_Changing;
            tb.TextChanging += Tb_Changing;
            pb.TextChanging += Pb_Changing;
        }

        private void Tb_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            b.TextChanging -= Byte_Changing;
            kb.TextChanging -= Kb_Changing;
            mb.TextChanging -= Mb_Changing;
            gb.TextChanging -= Gb_Changing;
            pb.TextChanging -= Pb_Changing;
            if (tb.Text == "")
            {
                tb.Text = "0";
            }

            double tbDouble = 0;
            if (double.TryParse(tb.Text, out tbDouble))
            {
                b.Text = Convert.ToString(tbDouble * 8e+12);
                kb.Text = Convert.ToString(tbDouble * 1e+9);
                mb.Text = Convert.ToString(tbDouble * 1000000);
                gb.Text = Convert.ToString(tbDouble * 1000);
                pb.Text = Convert.ToString(tbDouble * 0.001);
            }

            b.TextChanging += Byte_Changing;
            kb.TextChanging += Kb_Changing;
            mb.TextChanging += Mb_Changing;
            gb.TextChanging += Gb_Changing;
            pb.TextChanging += Pb_Changing;
        }

        private void Pb_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            b.TextChanging -= Byte_Changing;
            kb.TextChanging -= Kb_Changing;
            mb.TextChanging -= Mb_Changing;
            gb.TextChanging -= Gb_Changing;
            tb.TextChanging -= Tb_Changing;
            if (pb.Text == "")
            {
                pb.Text = "0";
            }

            double pbDouble = 0;
            if (double.TryParse(pb.Text, out pbDouble))
            {
                b.Text = Convert.ToString(pbDouble * 1e+15);
                kb.Text = Convert.ToString(pbDouble * 1e+12);
                mb.Text = Convert.ToString(pbDouble * 1e+9);
                gb.Text = Convert.ToString(pbDouble * 1e+6);
                tb.Text = Convert.ToString(pbDouble * 1000);
            }

            b.TextChanging += Byte_Changing;
            kb.TextChanging += Kb_Changing;
            mb.TextChanging += Mb_Changing;
            gb.TextChanging += Gb_Changing;
            tb.TextChanging += Tb_Changing;
        }

        private void Eur_Changing(object sender, TextBoxTextChangingEventArgs args)
        {
            ste.TextChanging -= Ste_Changing;
            usd.TextChanging -= Usd_Changing;
            ad.TextChanging -= Ad_Changing;
            yen.TextChanging -= Yen_Changing;
            rub.TextChanging -= Rub_Changing;
            bah.TextChanging -= Bah_Changing;
            rup.TextChanging -= Rup_Changing;
            peso.TextChanging -= Peso_Changing;
            can.TextChanging -= Can_Changing;
            rand.TextChanging -= Rand_Changing;

            if (eur.Text == "")
            {
                eur.Text = "0";
            }
            double eurDouble = 0;

            if (double.TryParse(eur.Text, out eurDouble))
            {
                ste.Text = Convert.ToString(eurDouble * 0.86);
                usd.Text = Convert.ToString(eurDouble * 1.23);
                ad.Text = Convert.ToString(eurDouble * 1.58);
                yen.Text = Convert.ToString(eurDouble * 132.73);
                rub.Text = Convert.ToString(eurDouble * 76.12);
                bah.Text = Convert.ToString(eurDouble * 38.39);
                rup.Text = Convert.ToString(eurDouble * 80.431);
                peso.Text = Convert.ToString(eurDouble * 22.31);
                can.Text = Convert.ToString(eurDouble * 1.55);
                rand.Text = Convert.ToString(eurDouble * 14.84);

            }

            ste.TextChanging += Ste_Changing;
            usd.TextChanging += Usd_Changing;
            ad.TextChanging += Ad_Changing;
            yen.TextChanging += Yen_Changing;
            rub.TextChanging += Rub_Changing;
            bah.TextChanging += Bah_Changing;
            rup.TextChanging += Rup_Changing;
            peso.TextChanging += Peso_Changing;
            can.TextChanging += Can_Changing;
            rand.TextChanging += Rand_Changing;
        }

        private void Ste_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            eur.TextChanging -= Eur_Changing;
            usd.TextChanging -= Usd_Changing;
            ad.TextChanging -= Ad_Changing;
            yen.TextChanging -= Yen_Changing;
            rub.TextChanging -= Rub_Changing;
            bah.TextChanging -= Bah_Changing;
            rup.TextChanging -= Rup_Changing;
            peso.TextChanging -= Peso_Changing;
            can.TextChanging -= Can_Changing;
            rand.TextChanging -= Rand_Changing;

            if (ste.Text == "")
            {
                ste.Text = "0";
            }
            double steDouble = 0;

            if (double.TryParse(ste.Text, out steDouble))
            {
                eur.Text = Convert.ToString(steDouble * 1.16);
                usd.Text = Convert.ToString(steDouble * 1.43);
                ad.Text = Convert.ToString(steDouble * 1.83);
                yen.Text = Convert.ToString(steDouble * 153.64);
                rub.Text = Convert.ToString(steDouble * 88.20);
                bah.Text = Convert.ToString(steDouble * 44.44);
                rup.Text = Convert.ToString(steDouble * 93.13);
                peso.Text = Convert.ToString(steDouble * 25.82);
                can.Text = Convert.ToString(steDouble * 1.79);
                rand.Text = Convert.ToString(steDouble * 17.19);

            }

            eur.TextChanging += Eur_Changing;
            usd.TextChanging += Usd_Changing;
            ad.TextChanging += Ad_Changing;
            yen.TextChanging += Yen_Changing;
            rub.TextChanging += Rub_Changing;
            bah.TextChanging += Bah_Changing;
            rup.TextChanging += Rup_Changing;
            peso.TextChanging += Peso_Changing;
            can.TextChanging += Can_Changing;
            rand.TextChanging += Rand_Changing;
        }

        private void Usd_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            eur.TextChanging -= Eur_Changing;
            ste.TextChanging -= Ste_Changing;
            ad.TextChanging -= Ad_Changing;
            yen.TextChanging -= Yen_Changing;
            rub.TextChanging -= Rub_Changing;
            bah.TextChanging -= Bah_Changing;
            rup.TextChanging -= Rup_Changing;
            peso.TextChanging -= Peso_Changing;
            can.TextChanging -= Can_Changing;
            rand.TextChanging -= Rand_Changing;

            if (usd.Text == "")
            {
                usd.Text = "0";
            }
            double usdDouble = 0;

            if (double.TryParse(usd.Text, out usdDouble))
            {
                eur.Text = Convert.ToString(usdDouble * 0.81);
                ste.Text = Convert.ToString(usdDouble * 0.70);
                ad.Text = Convert.ToString(usdDouble * 1.28);
                yen.Text = Convert.ToString(usdDouble * 107.70);
                rub.Text = Convert.ToString(usdDouble * 61.85);
                bah.Text = Convert.ToString(usdDouble * 31.15);
                rup.Text = Convert.ToString(usdDouble * 65.27);
                peso.Text = Convert.ToString(usdDouble * 18.10);
                can.Text = Convert.ToString(usdDouble * 1.26);
                rand.Text = Convert.ToString(usdDouble * 12.05);

            }

            eur.TextChanging += Eur_Changing;
            ste.TextChanging += Ste_Changing;
            ad.TextChanging += Ad_Changing;
            yen.TextChanging += Yen_Changing;
            rub.TextChanging += Rub_Changing;
            bah.TextChanging += Bah_Changing;
            rup.TextChanging += Rup_Changing;
            peso.TextChanging += Peso_Changing;
            can.TextChanging += Can_Changing;
            rand.TextChanging += Rand_Changing;
        }

        private void Ad_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            eur.TextChanging -= Eur_Changing;
            ste.TextChanging -= Ste_Changing;
            usd.TextChanging -= Usd_Changing;
            yen.TextChanging -= Yen_Changing;
            rub.TextChanging -= Rub_Changing;
            bah.TextChanging -= Bah_Changing;
            rup.TextChanging -= Rup_Changing;
            peso.TextChanging -= Peso_Changing;
            can.TextChanging -= Can_Changing;
            rand.TextChanging -= Rand_Changing;

            if (ad.Text == "")
            {
                ad.Text = "0";
            }
            double adDouble = 0;

            if (double.TryParse(ad.Text, out adDouble))
            {
                eur.Text = Convert.ToString(adDouble * 0.63);
                ste.Text = Convert.ToString(adDouble * 0.55);
                usd.Text = Convert.ToString(adDouble * 0.78);
                yen.Text = Convert.ToString(adDouble * 83.93);
                rub.Text = Convert.ToString(adDouble * 48.20);
                bah.Text = Convert.ToString(adDouble * 24.28);
                rup.Text = Convert.ToString(adDouble * 50.88);
                peso.Text = Convert.ToString(adDouble * 14.11);
                can.Text = Convert.ToString(adDouble * 0.98);
                rand.Text = Convert.ToString(adDouble * 9.39);

            }

            eur.TextChanging += Eur_Changing;
            ste.TextChanging += Ste_Changing;
            usd.TextChanging += Usd_Changing;
            yen.TextChanging += Yen_Changing;
            rub.TextChanging += Rub_Changing;
            bah.TextChanging += Bah_Changing;
            rup.TextChanging += Rup_Changing;
            peso.TextChanging += Peso_Changing;
            can.TextChanging += Can_Changing;
            rand.TextChanging += Rand_Changing;
        }

        private void Yen_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            eur.TextChanging -= Eur_Changing;
            ste.TextChanging -= Ste_Changing;
            usd.TextChanging -= Usd_Changing;
            ad.TextChanging -= Ad_Changing;
            rub.TextChanging -= Rub_Changing;
            bah.TextChanging -= Bah_Changing;
            rup.TextChanging -= Rup_Changing;
            peso.TextChanging -= Peso_Changing;
            can.TextChanging -= Can_Changing;
            rand.TextChanging -= Rand_Changing;

            if (yen.Text == "")
            {
                yen.Text = "0";
            }
            double yenDouble = 0;

            if (double.TryParse(yen.Text, out yenDouble))
            {
                eur.Text = Convert.ToString(yenDouble * 0.0075);
                ste.Text = Convert.ToString(yenDouble * 0.0065);
                usd.Text = Convert.ToString(yenDouble * 0.0093);
                ad.Text = Convert.ToString(yenDouble * 0.012);
                rub.Text = Convert.ToString(yenDouble * 0.57);
                bah.Text = Convert.ToString(yenDouble * 0.29);
                rup.Text = Convert.ToString(yenDouble * 0.61);
                peso.Text = Convert.ToString(yenDouble * 0.17);
                can.Text = Convert.ToString(yenDouble * 0.012);
                rand.Text = Convert.ToString(yenDouble * 0.11);

            }

            eur.TextChanging += Eur_Changing;
            ste.TextChanging += Ste_Changing;
            usd.TextChanging += Usd_Changing;
            ad.TextChanging += Ad_Changing;
            rub.TextChanging += Rub_Changing;
            bah.TextChanging += Bah_Changing;
            rup.TextChanging += Rup_Changing;
            peso.TextChanging += Peso_Changing;
            can.TextChanging += Can_Changing;
            rand.TextChanging += Rand_Changing;
        }

        private void Rub_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            eur.TextChanging -= Eur_Changing;
            ste.TextChanging -= Ste_Changing;
            usd.TextChanging -= Usd_Changing;
            ad.TextChanging -= Ad_Changing;
            yen.TextChanging -= Yen_Changing;
            bah.TextChanging -= Bah_Changing;
            rup.TextChanging -= Rup_Changing;
            peso.TextChanging -= Peso_Changing;
            can.TextChanging -= Can_Changing;
            rand.TextChanging -= Rand_Changing;

            if (rub.Text == "")
            {
                rub.Text = "0";
            }
            double rubDouble = 0;

            if (double.TryParse(rub.Text, out rubDouble))
            {
                eur.Text = Convert.ToString(rubDouble * 0.013);
                ste.Text = Convert.ToString(rubDouble * 0.011);
                usd.Text = Convert.ToString(rubDouble * 0.016);
                ad.Text = Convert.ToString(rubDouble * 0.021);
                yen.Text = Convert.ToString(rubDouble * 1.74);
                bah.Text = Convert.ToString(rubDouble * 0.5);
                rup.Text = Convert.ToString(rubDouble * 1.05);
                peso.Text = Convert.ToString(rubDouble * 0.29);
                can.Text = Convert.ToString(rubDouble * 0.020);
                rand.Text = Convert.ToString(rubDouble * 0.19);

            }

            eur.TextChanging += Eur_Changing;
            ste.TextChanging += Ste_Changing;
            usd.TextChanging += Usd_Changing;
            ad.TextChanging += Ad_Changing;
            yen.TextChanging += Yen_Changing;
            bah.TextChanging += Bah_Changing;
            rup.TextChanging += Rup_Changing;
            peso.TextChanging += Peso_Changing;
            can.TextChanging += Can_Changing;
            rand.TextChanging += Rand_Changing;
        }

        private void Bah_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            eur.TextChanging -= Eur_Changing;
            ste.TextChanging -= Ste_Changing;
            usd.TextChanging -= Usd_Changing;
            ad.TextChanging -= Ad_Changing;
            yen.TextChanging -= Yen_Changing;
            rub.TextChanging -= Rub_Changing;
            rup.TextChanging -= Rup_Changing;
            peso.TextChanging -= Peso_Changing;
            can.TextChanging -= Can_Changing;
            rand.TextChanging -= Rand_Changing;

            if (bah.Text == "")
            {
                bah.Text = "0";
            }
            double bahDouble = 0;

            if (double.TryParse(bah.Text, out bahDouble))
            {
                eur.Text = Convert.ToString(bahDouble * 0.026);
                ste.Text = Convert.ToString(bahDouble * 0.023);
                usd.Text = Convert.ToString(bahDouble * 0.032);
                ad.Text = Convert.ToString(bahDouble * 0.041);
                yen.Text = Convert.ToString(bahDouble * 3.46);
                rub.Text = Convert.ToString(bahDouble * 1.99);
                rup.Text = Convert.ToString(bahDouble * 2.10);
                peso.Text = Convert.ToString(bahDouble * 0.58);
                can.Text = Convert.ToString(bahDouble * 0.040);
                rand.Text = Convert.ToString(bahDouble * 0.39);

            }

            eur.TextChanging += Eur_Changing;
            ste.TextChanging += Ste_Changing;
            usd.TextChanging += Usd_Changing;
            ad.TextChanging += Ad_Changing;
            yen.TextChanging += Yen_Changing;
            rub.TextChanging += Rub_Changing;
            rup.TextChanging += Rup_Changing;
            peso.TextChanging += Peso_Changing;
            can.TextChanging += Can_Changing;
            rand.TextChanging += Rand_Changing;
        }

        private void Rup_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            eur.TextChanging -= Eur_Changing;
            ste.TextChanging -= Ste_Changing;
            usd.TextChanging -= Usd_Changing;
            ad.TextChanging -= Ad_Changing;
            yen.TextChanging -= Yen_Changing;
            rub.TextChanging -= Rub_Changing;
            bah.TextChanging -= Bah_Changing;
            peso.TextChanging -= Peso_Changing;
            can.TextChanging -= Can_Changing;
            rand.TextChanging -= Rand_Changing;

            if (rup.Text == "")
            {
                rup.Text = "0";
            }
            double rupDouble = 0;

            if (double.TryParse(rup.Text, out rupDouble))
            {
                eur.Text = Convert.ToString(rupDouble * 0.012);
                ste.Text = Convert.ToString(rupDouble * 0.011);
                usd.Text = Convert.ToString(rupDouble * 0.015);
                ad.Text = Convert.ToString(rupDouble * 0.020);
                yen.Text = Convert.ToString(rupDouble * 1.65);
                rub.Text = Convert.ToString(rupDouble * 0.95);
                bah.Text = Convert.ToString(rupDouble * 0.48);
                peso.Text = Convert.ToString(rupDouble * 0.28);
                can.Text = Convert.ToString(rupDouble * 0.019);
                rand.Text = Convert.ToString(rupDouble * 0.18);

            }

            eur.TextChanging += Eur_Changing;
            ste.TextChanging += Ste_Changing;
            usd.TextChanging += Usd_Changing;
            ad.TextChanging += Ad_Changing;
            yen.TextChanging += Yen_Changing;
            rub.TextChanging += Rub_Changing;
            bah.TextChanging += Bah_Changing;
            peso.TextChanging += Peso_Changing;
            can.TextChanging += Can_Changing;
            rand.TextChanging += Rand_Changing;
        }

        private void Peso_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            eur.TextChanging -= Eur_Changing;
            ste.TextChanging -= Ste_Changing;
            usd.TextChanging -= Usd_Changing;
            ad.TextChanging -= Ad_Changing;
            yen.TextChanging -= Yen_Changing;
            rub.TextChanging -= Rub_Changing;
            bah.TextChanging -= Bah_Changing;
            rup.TextChanging -= Rup_Changing;
            can.TextChanging -= Can_Changing;
            rand.TextChanging -= Rand_Changing;

            if (peso.Text == "")
            {
                peso.Text = "0";
            }
            double pesoDouble = 0;

            if (double.TryParse(peso.Text, out pesoDouble))
            {
                eur.Text = Convert.ToString(pesoDouble * 0.045);
                ste.Text = Convert.ToString(pesoDouble * 0.039);
                usd.Text = Convert.ToString(pesoDouble * 0.055);
                ad.Text = Convert.ToString(pesoDouble * 0.071);
                yen.Text = Convert.ToString(pesoDouble * 5.96);
                rub.Text = Convert.ToString(pesoDouble * 3.42);
                bah.Text = Convert.ToString(pesoDouble * 1.72);
                rup.Text = Convert.ToString(pesoDouble * 3.61);
                can.Text = Convert.ToString(pesoDouble * 0.070);
                rand.Text = Convert.ToString(pesoDouble * 0.67);

            }

            eur.TextChanging += Eur_Changing;
            ste.TextChanging += Ste_Changing;
            usd.TextChanging += Usd_Changing;
            ad.TextChanging += Ad_Changing;
            yen.TextChanging += Yen_Changing;
            rub.TextChanging += Rub_Changing;
            bah.TextChanging += Bah_Changing;
            rup.TextChanging += Rup_Changing;
            can.TextChanging += Can_Changing;
            rand.TextChanging += Rand_Changing;
        }

        private void Can_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            eur.TextChanging -= Eur_Changing;
            ste.TextChanging -= Ste_Changing;
            usd.TextChanging -= Usd_Changing;
            ad.TextChanging -= Ad_Changing;
            yen.TextChanging -= Yen_Changing;
            rub.TextChanging -= Rub_Changing;
            bah.TextChanging -= Bah_Changing;
            rup.TextChanging -= Rup_Changing;
            peso.TextChanging -= Peso_Changing;
            rand.TextChanging -= Rand_Changing;

            if (can.Text == "")
            {
                can.Text = "0";
            }
            double canDouble = 0;

            if (double.TryParse(can.Text, out canDouble))
            {
                eur.Text = Convert.ToString(canDouble * 0.65);
                ste.Text = Convert.ToString(canDouble * 0.56);
                usd.Text = Convert.ToString(canDouble * 0.79);
                ad.Text = Convert.ToString(canDouble * 1.02);
                yen.Text = Convert.ToString(canDouble * 85.67);
                rub.Text = Convert.ToString(canDouble * 49.23);
                bah.Text = Convert.ToString(canDouble * 24.76);
                rup.Text = Convert.ToString(canDouble * 51.88);
                peso.Text = Convert.ToString(canDouble * 14.37);
                rand.Text = Convert.ToString(canDouble * 9.59);

            }

            eur.TextChanging += Eur_Changing;
            ste.TextChanging += Ste_Changing;
            usd.TextChanging += Usd_Changing;
            ad.TextChanging += Ad_Changing;
            yen.TextChanging += Yen_Changing;
            rub.TextChanging += Rub_Changing;
            bah.TextChanging += Bah_Changing;
            rup.TextChanging += Rup_Changing;
            peso.TextChanging += Peso_Changing;
            rand.TextChanging += Rand_Changing;
        }

        private void Rand_Changing(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            eur.TextChanging -= Eur_Changing;
            ste.TextChanging -= Ste_Changing;
            usd.TextChanging -= Usd_Changing;
            ad.TextChanging -= Ad_Changing;
            yen.TextChanging -= Yen_Changing;
            rub.TextChanging -= Rub_Changing;
            bah.TextChanging -= Bah_Changing;
            rup.TextChanging -= Rup_Changing;
            peso.TextChanging -= Peso_Changing;
            can.TextChanging -= Can_Changing;

            if (rand.Text == "")
            {
                rand.Text = "0";
            }
            double randDouble = 0;

            if (double.TryParse(rand.Text, out randDouble))
            {
                eur.Text = Convert.ToString(randDouble * 0.067);
                ste.Text = Convert.ToString(randDouble * 0.058);
                usd.Text = Convert.ToString(randDouble * 0.083);
                ad.Text = Convert.ToString(randDouble * 0.11);
                yen.Text = Convert.ToString(randDouble * 8.92);
                rub.Text = Convert.ToString(randDouble * 5.13);
                bah.Text = Convert.ToString(randDouble * 2.58);
                rup.Text = Convert.ToString(randDouble * 5.4);
                peso.Text = Convert.ToString(randDouble * 1.5);
                can.Text = Convert.ToString(randDouble * 0.1);

            }

            eur.TextChanging += Eur_Changing;
            ste.TextChanging += Ste_Changing;
            usd.TextChanging += Usd_Changing;
            ad.TextChanging += Ad_Changing;
            yen.TextChanging += Yen_Changing;
            rub.TextChanging += Rub_Changing;
            bah.TextChanging += Bah_Changing;
            rup.TextChanging += Rup_Changing;
            peso.TextChanging += Peso_Changing;
            can.TextChanging += Can_Changing;
        }
    }
    
}
