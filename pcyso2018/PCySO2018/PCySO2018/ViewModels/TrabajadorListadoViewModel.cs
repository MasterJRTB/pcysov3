﻿namespace PCySO2018.ViewModels
{
    using PCySO2018.Models;
    using System.Collections.ObjectModel;

    public class TrabajadorListadoViewModel : TrabajadorModel
    {
        private ObservableCollection<TrabajadorModel> ListadoTrabajador;

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
    }
}