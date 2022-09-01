using System;
using System.Collections.Generic;
using System.Text;

namespace MeditekWeb.Models.Entity
{
    public class Event:BaseEntity
    {
        

        public string EVENT_NAME { get; set; }
        public string EVENT_TEXT { get; set; }
        public string EVENT_IMG { get; set; }
        
        public string EVENT_DESCRIPTION { get; set; }
        public DateTime? EVENT_DATETIME { get; set; }

    }
}
