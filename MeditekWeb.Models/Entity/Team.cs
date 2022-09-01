using System;
using System.Collections.Generic;
using System.Text;

namespace MeditekWeb.Models.Entity
{
    public class Team:BaseEntity
    {
        public Team()
        {
            Members = new HashSet<Member>();
        }
        public  string TEAM_NAME { get; set; }
        public virtual ICollection<Member> Members { get; set; }

    }
}
