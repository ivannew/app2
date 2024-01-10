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
            string mensaje = nombreText +": ";

            if (Hombre.IsChecked == true)
            {
                if (checkBoxAlto.IsChecked == true)
                {
                    mensaje += "alto, ";
                }
                if (checkBoxExtrav.IsChecked == true)
                {
                    mensaje += "extravago, ";
                }
                if (checkBoxFeo.IsChecked == true)
                {
                    mensaje += "feo, ";
                }
                if (checkBoxGrande.IsChecked == true)
                {
                    mensaje += "grande, ";
                }
                if (checkBoxListo.IsChecked == true)
                {
                    mensaje += "listo, ";
                }
                if (checkBoxRaro.IsChecked == true)
                {
                    mensaje += "raro, ";
                }
            }
            //-------------------------------------------------------------------------------------------------------

            else if (Mujer.IsChecked == true)
            {
                if (checkBoxAlto.IsChecked == true)
                {
                    mensaje += "alta, ";
                }
                if (checkBoxExtrav.IsChecked == true)
                {
                    mensaje += "extravaga, ";
                }
                if (checkBoxFeo.IsChecked == true)
                {
                    mensaje += "fea, ";
                }
                if (checkBoxGrande.IsChecked == true)
                {
                    mensaje += "grande, ";
                }
                if (checkBoxListo.IsChecked == true)
                {
                    mensaje += "lista, ";
                }
                if (checkBoxRaro.IsChecked == true)
                {
                    mensaje += "rara, ";
                }
            }

            todo.Text = mensaje;
        }
    }
}
