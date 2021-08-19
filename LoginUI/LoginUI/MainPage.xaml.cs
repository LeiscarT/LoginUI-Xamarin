using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameEntry.Text) || string.IsNullOrEmpty(passwordEntry.Text))
            {
                await DisplayAlert("Error", "Debe de llenar los campos", "Ok");
            }

            else
            {
                await DisplayAlert("Bienvenido", $"Hola {nameEntry.Text}", "Ok");
            }
        }
    }
}
