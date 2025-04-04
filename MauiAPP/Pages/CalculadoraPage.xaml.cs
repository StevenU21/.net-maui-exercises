using System;
using Microsoft.Maui.Controls;

namespace MauiAPP.Pages;

public partial class CalculadoraPage : ContentPage
{
	public CalculadoraPage()
	{
		InitializeComponent();
	}

    private void OnOperacionClicked(object sender, EventArgs e)
    {
        if (double.TryParse(entryNumero1.Text, out double num1) &&
            double.TryParse(entryNumero2.Text, out double num2))
        {
            var button = sender as Button;
            double resultado = 0;
            string operacion = button.Text;
            switch (operacion)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "×":
                    resultado = num1 * num2;
                    break;
                case "÷":
                    if (num2 != 0)
                        resultado = num1 / num2;
                    else
                    {
                        labelResultadoCalc.Text = "División por cero no permitida";
                        return;
                    }
                    break;
            }
            labelResultadoCalc.Text = $"Resultado: {resultado}";
        }
        else
        {
            labelResultadoCalc.Text = "Ingresa números válidos";
        }
    }
}