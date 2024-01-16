using app2.ViewModel;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace app2.ModeloVista
{
    internal class VMcritico : BaseViewModel 
    {
        #region VARIABLES
        private string _Nombre;
        private bool _Alto;
        private bool _Feo;
        private bool _Listo;
        private bool _Extravago;
        private bool _Raro;
        private bool _Grande;
        private bool _Hombre;
        private bool _Mujer;
        private string _Mensaje;
        #endregion

        #region CONSTRUCTOR
        public VMcritico(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJETOS 
        public string Nombre
        {
            get { return _Nombre; }
            set { SetValue(ref _Nombre, value); }
        }
        public bool Hombre
        {
            get { return _Hombre; }
            set { SetValue(ref _Hombre, value); }
        }
        public bool Mujer
        {
            get { return _Mujer; }
            set { SetValue(ref _Mujer, value); }
        }
        public bool Alto
        {
            get { return _Alto; }
            set { SetValue(ref _Alto, value); }
        }
        public bool Feo
        {
            get { return _Feo; }
            set { SetValue(ref _Feo, value); }
        }
        public bool Listo
        {
            get { return _Listo; }
            set { SetValue(ref _Listo, value); }
        }
        public bool Extrav
        {
            get { return _Extravago; }
            set { SetValue(ref _Extravago, value); }
        }
        public bool Raro
        {
            get { return _Raro; }
            set { SetValue(ref _Raro, value); }
        }
        public bool Grande
        {
            get { return _Grande; }
            set { SetValue(ref _Grande, value); }
        }
        public string Mensaje
        {
            get { return _Mensaje; }
            set { SetValue(ref _Mensaje, value); }
        }
        #endregion
        private void Mostrar()
        {
            string mensaje = $"{Nombre}: ";

            if (Hombre)
            {
                Agregar(Alto, ref mensaje, "alto");
                Agregar(Extrav, ref mensaje, "extravago");
                Agregar(Feo, ref mensaje, "feo");
                Agregar(Grande, ref mensaje, "grande");
                Agregar(Listo, ref mensaje, "listo");
                Agregar(Raro, ref mensaje, "raro");
            }
            else if (Mujer)
            {
                Agregar(Alto, ref mensaje, "alta");
                Agregar(Extrav, ref mensaje, "extravag");
                Agregar(Feo, ref mensaje, "fea");
                Agregar(Grande, ref mensaje, "grande");
                Agregar(Listo, ref mensaje, "lista");
                Agregar(Raro, ref mensaje, "rara");
            }

            mensaje = mensaje.TrimEnd(' ', ',');
            int ultimacoma = mensaje.LastIndexOf(", ");
            if (ultimacoma >= 0)
            {
                mensaje = mensaje.Substring(0, ultimacoma) + " y " + mensaje.Substring(ultimacoma + 2) + ".";
            }

            Mensaje = mensaje;
        }

        private void Agregar(bool isChecked, ref string mensaje, string palabra)
        {
            if (isChecked)
            {
                if (!string.IsNullOrEmpty(mensaje) && !mensaje.EndsWith(": "))
                {
                    mensaje += ", ";
                }

                mensaje += $"{palabra}";
            }
        }

        public ICommand MostrarCommand => new Command(Mostrar);
    }
}
