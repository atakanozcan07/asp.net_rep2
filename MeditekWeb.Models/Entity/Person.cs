using System;
using System.Collections.Generic;
using System.Text;

namespace MeditekWeb.Models.Entity
{
    public class Person:BaseEntity
    {
        public string PERSON_NAME { get; set; }
        public string PERSON_SURNAME { get; set; }
        public string PERSON_IMG { get; set; }
        public int COUNCIL_ID { get; set; }

        public Council Councils { get; set; }
    }
}
