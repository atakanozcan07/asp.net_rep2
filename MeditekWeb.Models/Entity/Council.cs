using System;
using System.Collections.Generic;
using System.Text;

namespace MeditekWeb.Models.Entity
{
    public class Council:BaseEntity
    {
        public Council()
        {
            Persons = new HashSet<Person>();
        }
        public string COUNCIL_NAME { get; set; }
        public ICollection<Person> Persons { get; set; }
    }
}
