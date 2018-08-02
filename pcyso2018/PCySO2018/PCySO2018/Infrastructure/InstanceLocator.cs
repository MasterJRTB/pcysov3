﻿namespace PCySO2018.Infrastructure
{
    using PCySO2018.ViewModels;
    using System;
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


        public InstanceLocator(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
