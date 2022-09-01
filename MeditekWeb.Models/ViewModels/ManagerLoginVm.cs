using System;
using System.Collections.Generic;
using System.Text;

namespace MeditekWeb.Models.ViewModels
{
    public class ManagerLoginVm
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Remember { get; set; }
    }
}
