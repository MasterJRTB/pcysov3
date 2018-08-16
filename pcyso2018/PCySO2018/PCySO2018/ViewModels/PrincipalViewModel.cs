namespace PCySO2018.ViewModels
{
    using System.Collections.ObjectModel;
    using Services;
    using Xamarin.Forms;


    public class PrincipalViewModel : BaseViewModel
    {

        #region Atributos
        private ObservableCollection<PrincipalViewModel> Principal;
        #endregion

        #region Propiedades
        public ObservableCollection<PrincipalViewModel> PaginaPrincipal
        {
            get { return this.Principal; }
            set { SetValue(ref this.Principal, value); }
        }
        #endregion

        #region Constructores
        public PrincipalViewModel()
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
        }
        #endregion

        #region Servicios
        private ApiService apiService;
        #endregion
    }
}
