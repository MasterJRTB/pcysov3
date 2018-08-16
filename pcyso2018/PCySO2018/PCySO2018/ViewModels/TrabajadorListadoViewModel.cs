using GalaSoft.MvvmLight.Command;
using PCySO2018.Models;
using PCySO2018.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace PCySO2018.ViewModels
{


    public class TrabajadorListadoViewModel : TrabajadorModel
    {
        private ApiService apiService;
        private ObservableCollection<TrabajadorModel> ListadoTrabajador;
        private string filter;

        public TrabajadorListadoViewModel()
          {
          }
        public ObservableCollection<TrabajadorModel> ListadoTrabajador1
        {
            get
            {
                if (ListadoTrabajador == null)
                {
                    llenarTrabajador();
                }
                return ListadoTrabajador;
            }
            set
            {
                ListadoTrabajador = value;
            }
        }

       public void llenarTrabajador()
        {
            using (var contexto = new DataContext())
            {
                ObservableCollection<TrabajadorModel> modelo = new ObservableCollection<TrabajadorModel>(contexto.ConsultarTrabajador());
                ListadoTrabajador = modelo;
            }
        }

        public string Filter
        {
            get { return this.filter; }
            set
            {
                SetValue(ref this.filter, value);
                this.Search();
            }
        }

        private void SetValue(ref string filter, string value)
        {
            throw new NotImplementedException();
        }

        public ICommand SearchCommand
        {
            get
            {
                return new RelayCommand(Search);
            }
        }

        private void Search()
        {
            if (string.IsNullOrEmpty(this.Filter))
            {
                this.ListadoTrabajador1 = new ObservableCollection<TrabajadorModel>(
                    this.ToTrabajadorModel());
            }
        //    else
        //    {
        //        this.ListadoTrabajador1 = new ObservableCollection<LandItemViewModel>(
        //            this.ToLandItemViewModel().Where(
        //                l => l.Id.ToLower().Contains(this.Filter.ToLower()) ||
        //                     l.NombreTrabajador.ToLower().Contains(this.Filter.ToLower())));
        //    }
        }

        private IEnumerable<TrabajadorModel> ToTrabajadorModel()
        {
            throw new NotImplementedException();
        }
    }
}
