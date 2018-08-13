

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
        private string epTrabajador;

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

        #region Propiedades
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
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(NombreTrabajador)));
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
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(TipoTrabajador)));
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
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(CtTrabajador)));
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
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(DepaTrabajador)));
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
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(PueTrabajador)));
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
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(HorTrabajador)));
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
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(TelofiTrabajador)));
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
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(ExttelTrabajador)));
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
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(EmailTrabajador)));
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
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(FaTrabajador)));
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
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(NssTrabajador)));
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
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(NjTrabajador)));
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
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(TjTrabajador)));
                }
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
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(EtjTrabajador)));
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
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(EmjTrabajador)));
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
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(CalTrabajador)));
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
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(NeTrabajador)));
                }
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
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(NiTrabajador)));
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
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(ColTrabajador)));
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
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(CpTrabajador)));
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
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(DmTrabajador)));
                }
            }
        }
        public string EpTrabajador
        {
            get
            {
                return epTrabajador;
            }
            set
            {
                if (epTrabajador != value)
                {
                    epTrabajador = value;
                    OnPropertyChanged("epTrabajador");
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(epTrabajador)));
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
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(NceTrabajador)));
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
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(PareTrabajador)));
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
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(TceTrabajador)));
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
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(CelceTrabajador)));
                }
            }
        }

        public string IsVisible { get; internal set; }
        #endregion
    }
}
