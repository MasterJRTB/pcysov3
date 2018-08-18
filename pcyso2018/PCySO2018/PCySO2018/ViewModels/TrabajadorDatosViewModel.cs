using System;
using System.Collections.Generic;
using System.Text;

namespace PCySO2018.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using PCySO2018.Models;
    using PCySO2018.Services;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Windows.Input;

    public class TrabajadorDatosViewModel : TrabajadorModel
    {
        private ApiService apiService;
        private ObservableCollection<TrabajadorModel> TrabajadorDatos;
        private string filter;

        public TrabajadorDatosViewModel()
        {
        }
        public ObservableCollection<TrabajadorModel> TrabajadorDatos1
        {
            get
            {
                if (TrabajadorDatos == null)
                {
                    llenarTrabajador();
                }
                return TrabajadorDatos;
            }
            set
            {
                TrabajadorDatos = value;
            }
        }

        public void llenarTrabajador()
        {
            using (var contexto = new DataContext())
            {
                ObservableCollection<TrabajadorModel> modelo = new ObservableCollection<TrabajadorModel>(contexto.ConsultarTrabajador());
                TrabajadorDatos = modelo;
            }
        }

        
    }
}
