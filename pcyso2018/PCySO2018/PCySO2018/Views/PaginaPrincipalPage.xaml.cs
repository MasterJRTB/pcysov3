using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PCySO2018.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaPrincipalViewModel : ContentPage
    {
        public PaginaPrincipalViewModel()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        public string Nombre { get; internal set; }
        public string Descripcion { get; internal set; }

        private void Button_Clicked(object sender, System.EventArgs e)
        {

        }

        //public PaginaPrincipalPage PaginaPrincipalViewModel { get; private set; }

        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    PaginaPrincipalViewModel = new PaginaPrincipalPage();
        //    General.ItemsSource = PaginaPrincipalViewModel._elementos;


        //}
    }
}
