using MeditekWeb.DataAccess.Abstract;
using MeditekWeb.DataAccess.Context;
using MeditekWeb.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeditekWeb.DataAccess.Concrete
{
    public class MemberRepository : RepositoryBase<Member, MeditekDataContext>, IMemberRepository
    {
        public Member GetByTeamId(int id)
        {
            return Get(x => x.TEAM_ID == id);
        }
    }
}
