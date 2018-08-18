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
	public partial class MaterialesPage : ContentPage
	{
		public MaterialesPage ()
		{
			InitializeComponent ();
            //btnextintor.Clicked += Btnextintor_Clicked;
            //btnbitacora.Clicked += Btnbitacora_Clicked;
            //btninmueble.Clicked += Btninmueble_Clicked;
		}

        //private void Btnextintor_Clicked(object sender, EventArgs e)
        //{
        //    //throw new NotImplementedException();
        //    ((NavigationPage)this.Parent).PushAsync(new ExtintorPage());
        //}
        //private void Btnbitacora_Clicked(object sender, EventArgs e)
        //{
        //    //throw new NotImplementedException();
        //    ((NavigationPage)this.Parent).PushAsync(new ExtintorBitacoraPage());
        //}
        //private void Btninmueble_Clicked(object sender, EventArgs e)
        //{
        //    //throw new NotImplementedException();
        //    ((NavigationPage)this.Parent).PushAsync(new InmbueblePage());
        //}


    }
}