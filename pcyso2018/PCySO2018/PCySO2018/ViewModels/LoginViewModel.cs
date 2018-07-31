namespace PCySO2018.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using Services;
    using System.Windows.Input;
    using Views;
    using Xamarin.Forms;

    public class LoginViewModel : BaseViewModel
    //Component
    {

        #region Services
        private ApiService apiService;
        #endregion

        #region Variables
        private string email;
        private string contrasena;
        private bool isRunning;
        private bool isHabilitado;
        #endregion

        #region Propiedades
        public string Email
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }

        public string Contrasena
        {
            get { return this.contrasena; }
            set { SetValue(ref this.contrasena, value); }
        }
        public bool IsRunning /*Todas las propiedades que inicien con Is son booleanas*/
        {
            /*la información del get y del set, se obtienen de la clase BaseViewModel
            Esta clase BaseViewModel, se debe de crear en cada proyecto cuando se va a utilizar
            el mismo pedazo de codigo en varias secciones de una clase*/
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
        }

        public bool IsRecordado
        {
            get;
            set;
        }

        public bool IsHabilitado /*Todas las propiedades que inicien con Is son booleanas*/
        {
            get { return this.isHabilitado; }
            set { SetValue(ref this.isHabilitado, value); }
        }
        #endregion

        #region Constructores
        public LoginViewModel()
        {
            this.apiService = new ApiService();

            this.IsRecordado = true;
            this.IsHabilitado = true;

        }
        #endregion

        #region Comandos
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }


        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                //metodo para mandar un mensaje tipo Toast
                await Application.Current.MainPage.DisplayAlert(
                    "Falta Información", "Debe ingresar un Email valido", "Aceptar");
                return;
            }
            if (string.IsNullOrEmpty(this.Contrasena))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Falta Información", "Debe ingresar su Contraseña correcta", "Aceptar");
                return;
            }

            this.IsRunning = true;
            this.IsHabilitado = false;

            if (this.Email != "rbasto23@gmail.com" || this.Contrasena != "1234")
            {
                this.IsRunning = false;
                this.IsHabilitado = true;
                await Application.Current.MainPage.DisplayAlert(
                    "Difiere la Información", "Email o Contraseña Incorrecta", "Aceptar");
                this.Contrasena = string.Empty;
                return;
            }

            this.IsRunning = false;
            this.IsHabilitado = true;

            //comando sirve para limpiar los textedit (entry)
            this.Email = string.Empty;
            this.contrasena = string.Empty;

            //comando para llamar a otra pagina dentro de la app
            MainViewModel.GetInstance().PaginaPrincipal = new PaginaPrincipalViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new PaginaPrincipalPage());
                      
        }
        #endregion
    }
}