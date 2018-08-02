using System.Collections;
using System.Collections.Generic;

namespace PCySO2018.Views
{
    #region Atributos
    //public string Nombre { get; internal set; }
    //public string Descripcion { get; internal set; }
    //public IEnumerable _elementos { get; internal set; }
    private bool isRefreshing;
    #endregion

    public class ListaElmentos
    {
        public List<PaginaPrincipalViewModel> _elementos
        {
            get;
            set;
        }
       
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


