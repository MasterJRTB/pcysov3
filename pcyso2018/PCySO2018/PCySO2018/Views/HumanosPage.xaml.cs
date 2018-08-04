using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PCySO2018.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HumanosPage : ContentPage
	{
		public HumanosPage ()
		{
			InitializeComponent ();
            btnTrabajador.Clicked += BtnTrabajador_Clicked;
            btnContratista.Clicked += BtnContratista_Clicked;
            btnProveedor.Clicked += BtnProveedor_Clicked;
		}

        private void BtnTrabajador_Clicked(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            ((NavigationPage)this.Parent).PushAsync(new TrabajadorPage());
        }
        private void BtnContratista_Clicked(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            ((NavigationPage)this.Parent).PushAsync(new ContratistaPage());
        }
        private void BtnProveedor_Clicked(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            ((NavigationPage)this.Parent).PushAsync(new ProveedorPage());
        }
    }
}