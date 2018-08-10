

namespace PCySO2018.Views
{
    using PCySO2018.ViewModels;
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrabajadorPage : ContentPage
    {
        
		public TrabajadorPage ()
		{
			InitializeComponent ();
            this.BindingContext = new TrabajadorViewModel();
            listtrabajador.Clicked += Listtrabajador_Clicked;
            
        }

        private void Listtrabajador_Clicked(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            ((NavigationPage)this.Parent).PushAsync(new TrabajadorListadoPage());
        }

        
    }
}