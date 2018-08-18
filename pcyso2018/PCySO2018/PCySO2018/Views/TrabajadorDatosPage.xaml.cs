using PCySO2018.Models;
using PCySO2018.ViewModels;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PCySO2018.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrabajadorDatosPage : ContentPage
    {

        public TrabajadorDatosPage()
        {
            InitializeComponent();
            this.BindingContext = new TrabajadorDatosViewModel();
            
        }


    }
}