using MeditekWeb.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MeditekWeb.Business.Abstract
{
    public interface ITeamBs
    {
        List<Team> GetAll(Expression<Func<Team, bool>> filter = null);
        Team Get(Expression<Func<Team, bool>> filter);
        Team GetById(int id);
        int Insert(Team entity);
        void Update(Team entity);
        void Delete(Team entity);
        Team GetByTeamId(int id);
    }
}
