using MeditekWeb.DataAccess.Abstract;
using MeditekWeb.DataAccess.Context;
using MeditekWeb.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeditekWeb.DataAccess.Concrete
{
    public class TeamRepository : RepositoryBase<Team, MeditekDataContext>, ITeamRepository
    {
        public Team GetByTeamId(int id)
        {
            return Get(i => i.ID == id);
        }
    }
}
