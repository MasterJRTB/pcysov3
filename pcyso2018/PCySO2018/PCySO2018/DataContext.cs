

namespace PCySO2018
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using PCySO2018.Models;
    using SQLite.Net;
    using Xamarin.Forms;

    public class DataContext : IDisposable
    {
        private SQLiteConnection cnn;

        public DataContext()
        {
            var configuracion = DependencyService.Get<iConfiguration>();

            //Se crea la base de datos
            cnn = new SQLiteConnection(configuracion.plataforma, Path.Combine(configuracion.directorio, "administracion.db3"));

            //se crea la tabla
            cnn.CreateTable<TrabajadorModel>();
        }

        public void Dispose()
        {
            cnn.Dispose();
        }


        //se debe de crear los procesos CRUD por tabla

        #region Trabajador
        public void InsertarTrabajador(TrabajadorModel trabajadorModel)
        {
            cnn.Insert(trabajadorModel);
        }

        

        public void ActualizarTrabajador(TrabajadorModel trabajadorModel)
        {
            cnn.Update(trabajadorModel);
        }

        public void EliminarTrabajador(TrabajadorModel trabajadorModel)
        {
            cnn.Delete(trabajadorModel);
        }


        public TrabajadorModel ConsultarTrabajador(int id)
        {
           return cnn.Table<TrabajadorModel>().FirstOrDefault(p => p.IdTrabajador == id);
        }

        public List<TrabajadorModel> ConsultarTrabajador()
        {
            return cnn.Table<TrabajadorModel>().ToList();
        }
        #endregion
    }
}
