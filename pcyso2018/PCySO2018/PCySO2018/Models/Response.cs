using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PCySO2018.Models
{
    public partial class Response : Component
    {
        public bool IsSuccess
        {
            get;
            set;
        }

        public string Message
        {
            get;
            set;
        }

        public object Result
        {
            get;
            set;
        }
    }
}
