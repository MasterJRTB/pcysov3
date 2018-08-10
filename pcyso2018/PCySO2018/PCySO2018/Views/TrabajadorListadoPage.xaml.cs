
namespace PCySO2018.Views
{
    using PCySO2018.ViewModels;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TrabajadorListadoPage : ContentPage
	{
		public TrabajadorListadoPage ()
		{
			InitializeComponent ();
            this.BindingContext = new TrabajadorListadoViewModel();
        }
	}
}