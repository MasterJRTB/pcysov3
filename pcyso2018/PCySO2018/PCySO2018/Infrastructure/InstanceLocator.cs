using PCySO2018.ViewModels;
using System.ComponentModel;

namespace PCySO2018.Infrastructure
{
    public partial class InstanceLocator : Component
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


        /*public InstanceLocator()
        {
            //InitializeComponent();
        }

        public InstanceLocator(IContainer container)
        {
           // container.Add(this);

           // InitializeComponent();
        }*/
    }
}
