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
	public partial class PrincipalPage : ContentPage
	{
		public PrincipalPage ()
		{
			InitializeComponent ();
            //metodo para crear la acción del botón
            btnrh.Clicked += Btnrh_Clicked;
            btnrm.Clicked += Btnrm_Clicked;
            btnum.Clicked += Btnum_Clicked;
            btnayu.Clicked += Btnayu_Clicked;
		}

        #region Navegación
        //metodo para llamar a otra pagina
        private void Btnrh_Clicked(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            ((NavigationPage)this.Parent).PushAsync(new HumanosPage());
        }

        private void Btnrm_Clicked(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            ((NavigationPage)this.Parent).PushAsync(new MaterialesPage());
        }

        private void Btnum_Clicked(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            ((NavigationPage)this.Parent).PushAsync(new MedicaPage());
        }

        private void Btnayu_Clicked(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            ((NavigationPage)this.Parent).PushAsync(new AyudaPage());
        }
        #endregion
    }
}