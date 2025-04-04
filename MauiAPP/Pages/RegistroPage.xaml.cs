using System;
using Microsoft.Maui.Controls;

namespace MauiAPP.Pages;

public partial class RegistroPage : ContentPage
{
	public RegistroPage()
	{
		InitializeComponent();
	}
    private void OnRegistrarClicked(object sender, EventArgs e)
    {
        string nombre = entryNombre.Text;
        string correo = entryCorreo.Text;
        string edad = entryEdad.Text;
        labelConfirmacion.Text = $"Registro: {nombre}, {correo}, {edad} años";
    }
}