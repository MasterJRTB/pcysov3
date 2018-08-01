
using PCySO2018.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections;
using System.Collections.Generic;

namespace PCySO2018.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaginaPrincipalPage : ContentPage
	{
		public PaginaPrincipalPage ()
		{
			InitializeComponent ();
		}

        public PaginaPrincipalViewModel PaginaPrincipalViewModel { get; private set; }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            PaginaPrincipalViewModel = new PaginaPrincipalViewModel();
            General.ItemsSource = PaginaPrincipalViewModel._elementos;

            
        }
    }
}