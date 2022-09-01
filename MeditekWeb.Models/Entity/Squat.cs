using System;
using System.Collections.Generic;
using System.Text;

namespace MeditekWeb.Models.Entity
{
    public class Squat
    {
        public Squat()
        {
            Members = new HashSet<Member>();
            
        }
        public string SQUAT_NAME { get; set; }
        public virtual ICollection<Member> Members { get; set; }
    }
}
