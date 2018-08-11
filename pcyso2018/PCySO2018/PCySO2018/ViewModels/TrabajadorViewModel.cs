namespace PCySO2018.ViewModels
{
    using PCySO2018.Models;
    using System;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class TrabajadorViewModel : TrabajadorModel
    
    {
        
        public ICommand Agregar { get; private set; }
        public ICommand Actualizar { get; private set; }
        public ICommand Eliminar { get; private set; }
        public ICommand Limpiar { get; set; }
        

        #region Constructores
        public TrabajadorViewModel()
        {
            Agregar = new Command(() =>
            {
                TrabajadorModel trabajadorModel = new TrabajadorModel()
                {
                    NombreTrabajador = NombreTrabajador,
                    TipoTrabajador = TipoTrabajador,
                    CtTrabajador = CtTrabajador,
                    DepaTrabajador = DepaTrabajador,
                    PueTrabajador = PueTrabajador,
                    HorTrabajador = HorTrabajador,
                    TelofiTrabajador = TelofiTrabajador,
                    ExttelTrabajador = ExttelTrabajador,
                    EmailTrabajador = EmailTrabajador,
                    FaTrabajador = FaTrabajador,
                    NssTrabajador = NssTrabajador,

                    NjTrabajador = NjTrabajador,
                    TjTrabajador = TjTrabajador,
                    EtjTrabajador = EtjTrabajador,
                    EmjTrabajador = EmjTrabajador,

                    CalTrabajador = CalTrabajador,
                    NeTrabajador = NeTrabajador,
                    NiTrabajador = NiTrabajador,
                    ColTrabajador = ColTrabajador,
                    CpTrabajador = CpTrabajador,
                    DmTrabajador = DmTrabajador,
                    EpTrabajador = EpTrabajador,

                    NceTrabajador = NceTrabajador,
                    PareTrabajador = PareTrabajador,
                    TceTrabajador = TceTrabajador,
                    CelceTrabajador = CelceTrabajador
                };

                using (var contexto = new DataContext())
                {
                    contexto.InsertarTrabajador(trabajadorModel);
                }
            }
            );

            Actualizar = new Command(() =>
            {
                TrabajadorModel trabajadorModel = new TrabajadorModel()
                {
                    IdTrabajador = IdTrabajador,
                    NombreTrabajador = NombreTrabajador,
                    TipoTrabajador = TipoTrabajador,
                    CtTrabajador = CtTrabajador,
                    DepaTrabajador = DepaTrabajador,
                    PueTrabajador = PueTrabajador,
                    HorTrabajador = HorTrabajador,
                    TelofiTrabajador = TelofiTrabajador,
                    ExttelTrabajador = ExttelTrabajador,
                    EmailTrabajador = EmailTrabajador,
                    FaTrabajador = FaTrabajador,
                    NssTrabajador = NssTrabajador,

                    NjTrabajador = NjTrabajador,
                    TjTrabajador = TjTrabajador,
                    EtjTrabajador = EtjTrabajador,
                    EmjTrabajador = EmjTrabajador,

                    CalTrabajador = CalTrabajador,
                    NeTrabajador = NeTrabajador,
                    NiTrabajador = NiTrabajador,
                    ColTrabajador = ColTrabajador,
                    CpTrabajador = CpTrabajador,
                    DmTrabajador = DmTrabajador,
                    EpTrabajador = EpTrabajador,

                    NceTrabajador = NceTrabajador,
                    PareTrabajador = PareTrabajador,
                    TceTrabajador = TceTrabajador,
                    CelceTrabajador = CelceTrabajador
                };

                using (var contexto = new DataContext())
                {
                    contexto.ActualizarTrabajador(trabajadorModel);
                }
            }
            );

            Eliminar = new Command(() =>
            {
                TrabajadorModel trabajadorModel = new TrabajadorModel()
                {
                    IdTrabajador = IdTrabajador,
                    NombreTrabajador = NombreTrabajador,
                    TipoTrabajador = TipoTrabajador,
                    CtTrabajador = CtTrabajador,
                    DepaTrabajador = DepaTrabajador,
                    PueTrabajador = PueTrabajador,
                    HorTrabajador = HorTrabajador,
                    TelofiTrabajador = TelofiTrabajador,
                    ExttelTrabajador = ExttelTrabajador,
                    EmailTrabajador = EmailTrabajador,
                    FaTrabajador = FaTrabajador,
                    NssTrabajador = NssTrabajador,

                    NjTrabajador = NjTrabajador,
                    TjTrabajador = TjTrabajador,
                    EtjTrabajador = EtjTrabajador,
                    EmjTrabajador = EmjTrabajador,

                    CalTrabajador = CalTrabajador,
                    NeTrabajador = NeTrabajador,
                    NiTrabajador = NiTrabajador,
                    ColTrabajador = ColTrabajador,
                    CpTrabajador = CpTrabajador,
                    DmTrabajador = DmTrabajador,
                    EpTrabajador = EpTrabajador,

                    NceTrabajador = NceTrabajador,
                    PareTrabajador = PareTrabajador,
                    TceTrabajador = TceTrabajador,
                    CelceTrabajador = CelceTrabajador
                };

                using (var contexto = new DataContext())
                {
                    contexto.EliminarTrabajador(trabajadorModel);
                }
            }
           );

            Limpiar = new Command(() =>
            {

                this.NombreTrabajador = string.Empty;
                this.TipoTrabajador = string.Empty;
                this.CtTrabajador = string.Empty;
                this.DepaTrabajador = string.Empty;
                this.PueTrabajador = string.Empty;
                this.HorTrabajador = string.Empty;
                this.TelofiTrabajador = string.Empty;
                this.ExttelTrabajador = string.Empty;
                this.EmailTrabajador = string.Empty;
                this.FaTrabajador = DateTime.Now;
                this.NssTrabajador = string.Empty;

                this.NjTrabajador = string.Empty;
                this.TjTrabajador = string.Empty;
                this.EtjTrabajador = string.Empty;
                this.EmjTrabajador = string.Empty;

                this.CalTrabajador = string.Empty;
                this.NeTrabajador = string.Empty;
                this.NiTrabajador = string.Empty;
                this.ColTrabajador = string.Empty;
                this.CpTrabajador = string.Empty;
                this.DmTrabajador = string.Empty;
                this.EpTrabajador = string.Empty;

                this.NceTrabajador = string.Empty;
                this.PareTrabajador = string.Empty;
                this.TceTrabajador = string.Empty;
                this.CelceTrabajador = string.Empty;
            }
          );
        }

        



        #endregion
    }
}
