

namespace PCySO2018.Models
{
    using System;
    using System.ComponentModel;
    using SQLite.Net.Attributes;
    public class TrabajadorModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int idTrabajador;

        private string nombreTrabajador;
        private string tipoTrabajador;
        private string ctTrabajador;
        private string depaTrabajador;
        private string pueTrabajador;
        private string horTrabajador;
        private string telofiTrabajador;
        private string exttelTrabajador;
        private string emailTrabajador;
        private DateTime faTrabajador;
        private string nssTrabajador;

        private string njTrabajador;
        private string tjTrabajador;
        private string etjTrabajador;
        private string emjTrabajador;

        private string calTrabajador;
        private string neTrabajador;
        private string niTrabajador;
        private string colTrabajador;
        private string cpTrabajador;
        private string dmTrabajador;

        private string nceTrabajador;
        private string pareTrabajador;
        private string tceTrabajador;
        private string celceTrabajador;

        protected virtual void OnPropertyChanged(string propiedad)
        {
            if (PropertyChanged != null)
            {
            }
        }

        [PrimaryKey,AutoIncrement]
        public int IdTrabajador { get => idTrabajador; set => idTrabajador = value; }

        public string NombreTrabajador { get => nombreTrabajador; set => nombreTrabajador = value; }
        public string TipoTrabajador { get => tipoTrabajador; set => tipoTrabajador = value; }
        public string CtTrabajador { get => ctTrabajador; set => ctTrabajador = value; }
        public string DepaTrabajador { get => depaTrabajador; set => depaTrabajador = value; }
        public string PueTrabajador { get => pueTrabajador; set => pueTrabajador = value; }
        public string HorTrabajador { get => horTrabajador; set => horTrabajador = value; }
        public string TelofiTrabajador { get => telofiTrabajador; set => telofiTrabajador = value; }
        public string ExttelTrabajador { get => exttelTrabajador; set => exttelTrabajador = value; }
        public string EmailTrabajador { get => emailTrabajador; set => emailTrabajador = value; }
        public DateTime FaTrabajador { get => faTrabajador; set => faTrabajador = value; }
        public string NssTrabajador { get => nssTrabajador; set => nssTrabajador = value; }
        public string NjTrabajador { get => njTrabajador; set => njTrabajador = value; }
        public string TjTrabajador { get => tjTrabajador; set => tjTrabajador = value; }
        public string EtjTrabajador { get => etjTrabajador; set => etjTrabajador = value; }
        public string EmjTrabajador { get => emjTrabajador; set => emjTrabajador = value; }
        public string CalTrabajador { get => calTrabajador; set => calTrabajador = value; }
        public string NeTrabajador { get => neTrabajador; set => neTrabajador = value; }
        public string NiTrabajador { get => niTrabajador; set => niTrabajador = value; }
        public string ColTrabajador { get => colTrabajador; set => colTrabajador = value; }
        public string CpTrabajador { get => cpTrabajador; set => cpTrabajador = value; }
        public string DmTrabajador { get => dmTrabajador; set => dmTrabajador = value; }
        public string NceTrabajador { get => nceTrabajador; set => nceTrabajador = value; }
        public string PareTrabajador { get => pareTrabajador; set => pareTrabajador = value; }
        public string TceTrabajador { get => tceTrabajador; set => tceTrabajador = value; }
        public string CelceTrabajador { get => celceTrabajador; set => celceTrabajador = value; }

        
    }
}
