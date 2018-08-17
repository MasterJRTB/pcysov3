using System.ComponentModel;

namespace PCySO2018.ViewModels
{
    public class MainViewModel : Component
    {
        #region ViewModels
        public LoginViewModel Login
        {
            get;
            set;
        }

        public PrincipalViewModel Principal
        {
            get;
            set;
        }

        
        #endregion

        #region Contructores
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
        }
        #endregion

        #region Singleton
        //metodo para evitar crear varias veces la misma pagina Main
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }

            return instance;
        }
        #endregion
    }
}
