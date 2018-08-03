using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PCySO2018
{
    using PCySO2018.Views;
    using Xamarin.Forms;
    
    public partial class App : Application
	{
        #region Constructores
        public App ()
		{
			InitializeComponent();

			this.MainPage = new NavigationPage(new PrincipalPage());
		}
        #endregion

        #region Metodos
        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
        #endregion
    }
}
