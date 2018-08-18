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
	public partial class MedicaPage : ContentPage
	{
		public MedicaPage ()
		{
			InitializeComponent ();
            //btnantecedentes.Clicked += Btnantecedentes_Clicked;
            //btnatencion.Clicked += Btnatencion_Clicked;
            //btnincapacidad.Clicked += Btnincapacidad_Clicked;
		}

        
        //private void Btnantecedentes_Clicked(object sender, EventArgs e)
        //{
        //    //throw new NotImplementedException();
        //    ((NavigationPage)this.Parent).PushAsync(new AntecedentesPage());
        //}
        //private void Btnatencion_Clicked(object sender, EventArgs e)
        //{
        //    //throw new NotImplementedException();
        //    ((NavigationPage)this.Parent).PushAsync(new AtencionPage());
        //}
        //private void Btnincapacidad_Clicked(object sender, EventArgs e)
        //{
        //    //throw new NotImplementedException();
        //    ((NavigationPage)this.Parent).PushAsync(new IncapacidadPage());
        //}


    }
}