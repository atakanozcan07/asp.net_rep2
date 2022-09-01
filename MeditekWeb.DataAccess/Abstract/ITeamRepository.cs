using MeditekWeb.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeditekWeb.DataAccess.Abstract
{
    public interface ITeamRepository:IRepository<Team>
    {
        Team GetByTeamId(int id);
    }
}
