
namespace PCySO2018.Infrastructure
{
    using PCySO2018.ViewModels;
    using System.ComponentModel;

    class InstanceLocator : Component
    {
        #region Propiedades
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion

        #region Constructores
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion


        //public InstanceLocator()
        //{
        //    InitializeComponent();
        //}

        //public InstanceLocator(IContainer container)
        //{
        //    container.Add(this);

        //    InitializeComponent();
        //}
    }
}
