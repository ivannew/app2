using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app2;
namespace app2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void mostrar(object sender, EventArgs e)
        {
            var nombreText = nombre.Text;
            string mensaje = nombreText + ": ";

            if (Hombre.IsChecked == true)
            {
                Agregar(checkBoxAlto, ref mensaje, "alto");
                Agregar(checkBoxExtrav, ref mensaje, "extravo");
                Agregar(checkBoxFeo, ref mensaje, "feo");
                Agregar(checkBoxGrande, ref mensaje, "grande");
                Agregar(checkBoxListo, ref mensaje, "listo");
                Agregar(checkBoxRaro, ref mensaje, "raro");
            }
            //-------------------------------------------------------------------------------------------------------

            else if (Mujer.IsChecked == true)
            {
                Agregar(checkBoxAlto, ref mensaje, "alta");
                Agregar(checkBoxExtrav, ref mensaje, "extravaga");
                Agregar(checkBoxFeo, ref mensaje, "fea");
                Agregar(checkBoxGrande, ref mensaje, "grande");
                Agregar(checkBoxListo, ref mensaje, "lista");
                Agregar(checkBoxRaro, ref mensaje, "rara");
            }

          
            mensaje = mensaje.TrimEnd(' ', ',');
            int ultimacoma = mensaje.LastIndexOf(", ");
            if (ultimacoma >= 0)
            {
                mensaje = mensaje.Substring(0, ultimacoma) + " y " + mensaje.Substring(ultimacoma + 2)+".";
            }

            todo.Text = mensaje;
        }

        private void Agregar(CheckBox checkBox, ref string mensaje, string palabra)
        {
            if (checkBox.IsChecked == true)
            {
                if (!string.IsNullOrEmpty(mensaje) && !mensaje.EndsWith(": "))
                {
                    mensaje += ", ";
                }

                mensaje += $"{palabra}";
            }
        }


    }
}
