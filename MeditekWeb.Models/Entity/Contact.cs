using System;
using System.Collections.Generic;
using System.Text;

namespace MeditekWeb.Models.Entity
{
    public class Contact:BaseEntity
    {
        public string NAME { get; set; }
        public string MAIL { get; set; }
        public string MESSAGE { get; set; } 
    }
}
