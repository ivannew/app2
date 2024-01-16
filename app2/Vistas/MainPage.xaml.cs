using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app2;
using static app2.MainPage;
using Xamarin.Forms.Xaml;
using app2.ModeloVista;
namespace app2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new VMcritico(Navigation);
        }


      

    }
}
