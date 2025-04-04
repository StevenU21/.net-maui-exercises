using System;
using Microsoft.Maui.Controls;

namespace MauiAPP.Pages;

public partial class ParImparPage : ContentPage
{
	public ParImparPage()
	{
		InitializeComponent();
	}

    private void OnVerificarClicked(object sender, EventArgs e)
    {
        if (int.TryParse(entryNumero.Text, out int numero))
        {
            labelResultado.Text = (numero % 2 == 0) ? "El número es par" : "El número es impar";
        }
        else
        {
            labelResultado.Text = "Ingresa un número válido";
        }
    }   
}