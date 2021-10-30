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
    public partial class resumen : ContentPage
    {
        public resumen(string usuario1, string usuario, string cuotaI, string cuotas)
        {
            InitializeComponent();
            //envio a los label
            lbUsuario.Text = usuario1;
           // lblUsuario.Text = usuario;
            //lblCuotaI.Text = cuotaI;
            //lblCuotas.Text = cuotas;
            //envio cajas de texto
            txtUsuario.Text = usuario;
            txtCuotaI.Text = cuotaI;
            txtcuotas.Text = cuotas;
            //txtUsuario.Text = usuario;
            //txtContrasena.Text = contrasena;
        }
    }
}