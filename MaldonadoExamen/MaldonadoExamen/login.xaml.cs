using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MaldonadoExamen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            //Almacenar datos en variables
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;


            if ((usuario == "estudiante2021") && (contrasena == "uisrael2021"))
            {
                //Navego a la ventana dos
                await Navigation.PushAsync(new registro(usuario, contrasena));

            }
            else
            {
                lblResultado.Text = "EL usuario o la contrasena es incorrecto";

            }

        }
    }
}
