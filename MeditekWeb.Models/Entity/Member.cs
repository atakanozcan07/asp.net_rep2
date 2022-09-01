using System;
using System.Collections.Generic;
using System.Text;

namespace MeditekWeb.Models.Entity
{
    public class Member:BaseEntity
    {
        public Member()
        {
            Teams = new HashSet<Team>();
        }
        public string MEMBER_NAME { get; set; }
        public string MEMBER_SURNAME { get; set; }
        public string MEMBER_IMG { get; set; }

        public string MEMBER_ASSIGNMENT { get; set; }
        public string MEMBER_MAIL { get; set; }
        public string MEMBER_LINKEDIN { get; set; }
        public int? TEAM_ID { get; set; }
        public virtual ICollection<Team> Teams { get; set; }


    }
}
