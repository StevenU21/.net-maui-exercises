using System;
using Microsoft.Maui.Controls;

namespace MauiAPP.Pages;

public partial class ConversorTemperaturaPage : ContentPage
{
	public ConversorTemperaturaPage()
	{
		InitializeComponent();
	}

    private void OnConvertirClicked(object sender, EventArgs e)
    {
        if (double.TryParse(entryFahrenheit.Text, out double fahrenheit))
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            labelCelsius.Text = $"Temperatura en Celsius: {celsius:F2}°C";
        }
        else
        {
            labelCelsius.Text = "Ingresa un valor válido";
        }
    }
}