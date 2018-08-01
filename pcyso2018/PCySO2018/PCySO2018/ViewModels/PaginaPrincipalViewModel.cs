namespace PCySO2018.ViewModels
{
    using Java.Lang;
    using System.Collections;
    using System.Collections.Generic;
    //using static Android.Util.EventLogTags;

    public class PaginaPrincipalViewModel : BaseViewModel
    {

        #region Atributos
        ////private ObservableCollection<PaginaPrincipalViewModel> paginaPrincipal
        public string Number { get; internal set; }
        public string Nombre { get; internal set; }
        public string Description { get; internal set; }
        public string Descripcion{ get; internal set;}
        public IEnumerable _elementos { get; internal set; }
        #endregion

        #region Propiedades
        //public ObservableCollection<PaginaPrincipalViewModel> PaginaPrincipal
        //{
        //    get { return this.paginaPrincipal; }
        //    set { SetValue(ref this.paginaPrincipal, value); }
        //}
        #endregion

        #region Constructores
        //public PaginaPrincipalViewModel()
        //{
        //    this.apiService = new ApiService();
        //    this.LoadPaginaPrincipal();
        //}
        #endregion

        #region Metodos
        //private async void LoadPaginaPrincipal()
        //{
        //    var connection = await this.apiService.CheckConnection();
        //    if (!connection.IsSuccess)
        //    {
        //        await Application.Current.MainPage.DisplayAlert(
        //            "Error",
        //            connection.Message,
        //            "Aceptar");
        //        await Application.Current.MainPage.Navigation.PopAsync();
        //        return;
        //    }


        //if (!response.IsSuccess)
        //{
        //    await Application.Current.MainPage.DisplayAlert(
        //        "Error",
        //        response.Message,
        //        "Aceptar");
        //    await Application.Current.MainPage.Navigation.PopAsync();
        //    return;
        //}
        //var response = await this.apiService.GetList<PaginaPrincipal>("", "", "");
        //throw new NotImplementedException();
        //}
        #endregion

        #region Servicios
        //private ApiService apiService;
        #endregion
    }

    public class ListaElmentos
    {
        public List<PaginaPrincipalViewModel> _elementos
        {
            get;
            set;
        }
        private string Nombre { get; set; }
        public string Descripcion { get; set; }
        public static object ItemsSource { get; internal set; }

        public ListaElmentos()
        {
            _elementos = new List<PaginaPrincipalViewModel>();
            LoadElements();
        }

        public void LoadElements()
        {
            _elementos.Add(new PaginaPrincipalViewModel
            {
                Nombre = "Recursos Humanos",
                Descripcion = "En este módulo se lleva el control de: Trabajador, Contratista, Proveedor"
            });

            _elementos.Add(new PaginaPrincipalViewModel
            {
                Nombre = "Recursos Materiales",
                Descripcion = "En este módulo se lleva el control de: Extintor, Bitacora Extintor, Inmueble"
            });

            _elementos.Add(new PaginaPrincipalViewModel
            {
                Nombre = "Unidad Médica",
                Descripcion = "En este módulo se lleva el control de: Antecedentes, Atención, Incapacidad del Trabajador"
            });

            _elementos.Add(new PaginaPrincipalViewModel
            {
                Nombre = "Ayuda",
                Descripcion = "Este módulo sirve como referencia básica"
            });

        }
    }
}
