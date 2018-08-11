

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
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
        }

        [PrimaryKey, AutoIncrement]
        public int IdTrabajador
        {
            get
            {
                return idTrabajador;
            }
            set
            {
                if (idTrabajador != value)
                {
                    idTrabajador = value;
                    OnPropertyChanged("idTrabajador");
                }
                
            }
        }

        
        public string NombreTrabajador
        {
            get
            {
                return nombreTrabajador;
            }
            set
            {
                if (nombreTrabajador != value)
                {
                    nombreTrabajador = value;
                    OnPropertyChanged("nombreTrabajador");
                }
            }
        }
        public string TipoTrabajador
        {
            get
            {
                return tipoTrabajador;
            }
            set
            {
                if (tipoTrabajador != value)
                {
                    tipoTrabajador = value;
                    OnPropertyChanged("tipoTrabajador");
                }
            }
        }
        public string CtTrabajador
        {
            get
            {
                return ctTrabajador;
            }
            set
            {
                if (ctTrabajador != value)
                {
                    ctTrabajador = value;
                    OnPropertyChanged("ctTrabajador");
                }
            }
        }
        public string DepaTrabajador
        {
            get
            {
                return depaTrabajador;
            }
            set
            {
                if (depaTrabajador != value)
                {
                    depaTrabajador = value;
                    OnPropertyChanged("depaTrabajador");
                }
            }
        }
        public string PueTrabajador
        {
            get
            {
                return pueTrabajador;
            }
            set
            {
                if (pueTrabajador != value)
                {
                    pueTrabajador = value;
                    OnPropertyChanged("puTrabajador");
                }
            }
        }
        public string HorTrabajador
        {
            get
            {
                return horTrabajador;
            }
            set
            {
                if (horTrabajador != value)
                {
                    horTrabajador = value;
                    OnPropertyChanged("horTrabajador");
                }
            }
        }
        public string TelofiTrabajador
        {
            get
            {
                return telofiTrabajador;
            }
            set
            {
                if (telofiTrabajador != value)
                {
                    telofiTrabajador = value;
                    OnPropertyChanged("telofiTrabajador");
                }
            }
        }
        public string ExttelTrabajador
        {
            get
            {
                return exttelTrabajador;
            }
            set
            {
                if (exttelTrabajador != value)
                {
                    exttelTrabajador = value;
                    OnPropertyChanged("exttelTrabajador");
                }
            }
        }
        public string EmailTrabajador {
                get
                {
                    return emailTrabajador;
                }
                set
                {
                  if (emailTrabajador != value)
                  {
                    emailTrabajador = value;
                    OnPropertyChanged("emailTrabajador");
                  }
                }
            }
        public DateTime FaTrabajador
        {
            get
            {
                return faTrabajador;
            }
            set
            {
                if (faTrabajador != value)
                {
                    faTrabajador = value;
                    OnPropertyChanged("faTrabajador");
                }
            }
        }
        public string NssTrabajador
        {
            get
            {
                return nssTrabajador;
            }
            set
            {
                if (nssTrabajador != value)
                {
                    nssTrabajador = value;
                    OnPropertyChanged("nssTrabajador");
                }
            }
        }


        public string NjTrabajador
        {
            get
            {
                return njTrabajador;
            }
            set
            {
                if (njTrabajador != value)
                {
                    njTrabajador = value;
                    OnPropertyChanged("njTrabajador");
                }
            }
        }
        public string TjTrabajador
        {
            get
            {
                return tjTrabajador;
            }
            set
            {
                if (tjTrabajador != value)
                {
                    tjTrabajador = value;
                    OnPropertyChanged("tjTrabajador");
                }
                tjTrabajador = value;
            }
        }
        public string EtjTrabajador
        {
            get
            {
                return etjTrabajador;
            }
            set
            {
                if (etjTrabajador != value)
                {
                    etjTrabajador = value;
                    OnPropertyChanged("etjTrabajador");
                }
           }
        }
        public string EmjTrabajador
        {
            get
            {
                return emjTrabajador;
            }
            set
            {
                if (emjTrabajador != value)
                {
                    emjTrabajador = value;
                    OnPropertyChanged("emjTrabajador");
                }
            }
        }


        public string CalTrabajador {
                get
                {
                    return calTrabajador;
                }
                set
                {
                  if (calTrabajador != value)
                  {
                    calTrabajador = value;
                    OnPropertyChanged("calTrabajador");
                  }
                }
            }
        public string NeTrabajador
        {
            get
            {
                return neTrabajador;
            }
            set
            {
                if (neTrabajador != value)
                {
                    neTrabajador = value;
                    OnPropertyChanged("neTrabajador");
                }
                neTrabajador = value;
            }
        }
        public string NiTrabajador
        {
            get
            {
                return niTrabajador;
            }
            set
            {
                if (niTrabajador != value)
                {
                    niTrabajador = value;
                    OnPropertyChanged("niTrabajador");
                }
            }
        }
        public string ColTrabajador
        {
            get
            {
                return colTrabajador;
            }
            set
            {
                if (colTrabajador != value)
                {
                    colTrabajador = value;
                    OnPropertyChanged("colTrabajador");
                }
            }
        }
        public string CpTrabajador
        {
            get
            {
                return cpTrabajador;
            }
            set
            {
                if (cpTrabajador != value)
                {
                    cpTrabajador = value;
                    OnPropertyChanged("cpTrabajador");
                }
            }
        }
        public string DmTrabajador
        {
            get
            {
                return dmTrabajador;
            }
            set
            {
                if (dmTrabajador != value)
                {
                    dmTrabajador = value;
                    OnPropertyChanged("dmTrabajador");
                }
            }
        }


        public string NceTrabajador
        {
            get
            {
                return nceTrabajador;
            }
            set
            {
                if (nceTrabajador != value)
                {
                    nceTrabajador = value;
                    OnPropertyChanged("nceTrabajador");
                }
            }
        }
        public string PareTrabajador
        {
            get
            {
                return pareTrabajador;
            }
            set
            {
                if (pareTrabajador != value)
                {
                    pareTrabajador = value;
                    OnPropertyChanged("pareTrabajador");
                }
            }
        }
        public string TceTrabajador
        {
            get
            {
                return tceTrabajador;
            }
            set
            {
                if (tceTrabajador != value)
                {
                    tceTrabajador = value;
                    OnPropertyChanged("tceTrabajador");
                }
            }
        }
        public string CelceTrabajador
        {
            get
            {
                return celceTrabajador;
            }
            set
            {
                if (celceTrabajador != value)
                {
                    celceTrabajador = value;
                    OnPropertyChanged("celceTrabajador");
                }
            }
        }

    }
}
