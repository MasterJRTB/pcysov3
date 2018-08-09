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
        public ICommand Limpiar { get; private set; }

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

                NombreTrabajador = string.Empty;
                TipoTrabajador = string.Empty;
                CtTrabajador = string.Empty;
                DepaTrabajador = string.Empty;
                PueTrabajador = string.Empty;
                HorTrabajador = string.Empty;
                TelofiTrabajador = string.Empty;
                ExttelTrabajador = string.Empty;
                EmailTrabajador = string.Empty;
                FaTrabajador = DateTime.Now;
                NssTrabajador = string.Empty;

                NjTrabajador = string.Empty;
                TjTrabajador = string.Empty;
                EtjTrabajador = string.Empty;
                EmjTrabajador = string.Empty;

                CalTrabajador = string.Empty;
                NeTrabajador = string.Empty;
                NiTrabajador = string.Empty;
                ColTrabajador = string.Empty;
                CpTrabajador = string.Empty;
                DmTrabajador = string.Empty;

                NceTrabajador = string.Empty;
                PareTrabajador = string.Empty;
                TceTrabajador = string.Empty;
                CelceTrabajador = string.Empty;


                NombreTrabajador = "";
                TipoTrabajador = "";
                CtTrabajador = "";
                DepaTrabajador = "";
                PueTrabajador = "";
                HorTrabajador = "";
                TelofiTrabajador = "";
                ExttelTrabajador = "";
                EmailTrabajador = "";
                FaTrabajador = DateTime.Now;
                NssTrabajador = "";

                NjTrabajador = "";
                TjTrabajador = "";
                EtjTrabajador = "";
                EmjTrabajador = "";

                CalTrabajador = "";
                NeTrabajador = "";
                NiTrabajador = "";
                ColTrabajador = "";
                CpTrabajador = "";
                DmTrabajador = "";

                NceTrabajador = "";
                PareTrabajador = "";
                TceTrabajador = "";
                CelceTrabajador = "";
            }
          );
        }
       
        

    #endregion
}
}
