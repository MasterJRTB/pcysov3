using PCySO2018.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PCySO2018.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TrabajadorListadoPage : ContentPage
    {
      

        public TrabajadorListadoPage()
        {
            InitializeComponent();
            
            this.BindingContext = new TrabajadorListadoViewModel();
            //btnSeleccionado.Clicked += BtnSeleccionado_Clicked;
        }

        
        //private void BtnSeleccionado_Clicked(object sender, EventArgs e)
        //{
        //    //throw new NotImplementedException();
        //    ((NavigationPage)this.Parent).PushAsync(new TrabajadorDatosPage());
        //}
        //private void SelectTrabajadorCommand()
        //{
        //    ((NavigationPage)this.Parent).PushAsync(new TrabajadorDatosPage());
        //}
    }

   
}