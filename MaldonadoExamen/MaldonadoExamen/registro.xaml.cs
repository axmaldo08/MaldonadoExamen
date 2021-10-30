using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaldonadoExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registro : ContentPage
    {
        public registro(string usuario, string contrasena)
        {
            InitializeComponent();
            lbUsuario.Text = "Usuario conectado: " + usuario;
        }

        private void btnMensual_Clicked(object sender, EventArgs e)
        {
            double dato2 = Convert.ToDouble(txtDato2.Text);

            double cuota = ((1800-dato2)/3);
            double cuotaDos = (cuota * 0.05) + cuota;
            txtDato4.Text = Convert.ToString(cuotaDos);

            //txtResultado.Text = Convert.ToString(promedioFinal);

        }

        private void txtDato1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtDato2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double dato2 = Convert.ToDouble(txtDato2.Text);
                if (dato2 > 1800)
                {
                    DisplayAlert("Mensaje de Alerta", "No se permite datos mayores a 1800", "OK");
                    txtDato2.Text = "";

                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "ok");
            }

        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string usuario1 = lbUsuario.Text;
            string usuario = txtDato1.Text;
            string cuotaI = txtDato2.Text;
            string cuotas = txtDato4.Text;

            await DisplayAlert("Mensaje de Alerta", "Datos Guardados", "OK");
            await Navigation.PushAsync(new resumen(usuario1, usuario, cuotaI, cuotas));

        }
    }
    }
