using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TimApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        // Función para convertir kilogramos a libras
        private double KilogramosALibras(double kilogramos)
        {
            // 1 kilogramo es aproximadamente igual a 2.20462 libras
            return kilogramos * 2.20462;
        }

        // Función para convertir litros a galones
        private double LitrosAGalones(double litros)
        {
            // 1 litro es igual a 0.264172 galones
            return litros * 0.264172;
        }

        // Función para convertir grados Celsius a grados Fahrenheit
        private double CelsiusAFahrenheit(double celsius)
        {
            // Fórmula de conversión: Fahrenheit = (Celsius * 9/5) + 32
            return (celsius * 9 / 5) + 32;
        }

        // Manejar el botón de conversión de peso
        private void PesoButton_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(pesoEntry.Text))
            {
                double kilogramos = double.Parse(pesoEntry.Text);
                double libras = KilogramosALibras(kilogramos);
                resultadoLabel.Text = libras.ToString("N2") + " libras";
            }
        }

        // Manejar el botón de conversión de volumen
        private void VolumenButton_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(volumenEntry.Text))
            {
                double litros = double.Parse(volumenEntry.Text);
                double galones = LitrosAGalones(litros);
                resultadoLabel.Text = galones.ToString("N2") + " galones";
            }
        }

        // Manejar el botón de conversión de temperatura
        private void TemperaturaButton_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(temperaturaEntry.Text))
            {
                double celsius = double.Parse(temperaturaEntry.Text);
                double fahrenheit = CelsiusAFahrenheit(celsius);
                resultadoLabel.Text = fahrenheit.ToString("N2") + " °F";
            }
        }
    }
}
