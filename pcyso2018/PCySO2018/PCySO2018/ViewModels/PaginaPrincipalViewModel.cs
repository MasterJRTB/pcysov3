namespace PCySO2018.Views
{
    using System.Collections.ObjectModel;
    using PCySO2018.ViewModels;
    using Services;
    using Xamarin.Forms;


    public class PaginaPrincipalViewModel : BaseViewModel
    {

        #region Atributos
        private ObservableCollection<PaginaPrincipalViewModel> paginaPrincipal;
        #endregion

        #region Propiedades
        public ObservableCollection<PaginaPrincipalViewModel> PaginaPrincipal
        {
            get { return this.paginaPrincipal; }
            set { SetValue(ref this.paginaPrincipal, value); }
        }
        #endregion

        #region Constructores
        public PaginaPrincipalViewModel()
        {
            this.apiService = new ApiService();
            this.LoadPaginaPrincipal();
        }
        #endregion

        #region Metodos
        private async void LoadPaginaPrincipal()
        {
            var connection = await this.apiService.CheckConnection();
            if (!connection.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    connection.Message,
                    "Aceptar");
                await Application.Current.MainPage.Navigation.PopAsync();
                return;
            }

            
        #endregion

        #region Servicios
        private ApiService apiService;
        #endregion
    }
}


