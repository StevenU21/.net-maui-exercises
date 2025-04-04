using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace MauiAPP.Pages;

public partial class CalculoEdadPage : ContentPage
{
	public CalculoEdadPage()
	{
		InitializeComponent();
	}

    private void OnCalcularEdadClicked(object sender, EventArgs e)
    {
        if (DateTime.TryParseExact(entryFechaNacimiento.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaNacimiento))
        {
            int edad = DateTime.Now.Year - fechaNacimiento.Year;

            if (DateTime.Now.DayOfYear < fechaNacimiento.DayOfYear)
                edad--;

            labelEdad.Text = $"Tu edad es: {edad} años";
        }
        else
        {
            labelEdad.Text = "Ingresa una fecha válida en el formato dd/MM/yyyy";
        }
    }
}