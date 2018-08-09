using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PCySO2018.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrabajadorPage : ContentPage
    {
        
		public TrabajadorPage ()
		{
			InitializeComponent ();
            listtrabajador.Clicked += Listtrabajador_Clicked;
        }

        private void Listtrabajador_Clicked(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            ((NavigationPage)this.Parent).PushAsync(new TrabajadorListadoPage());
        }

        
    }
}