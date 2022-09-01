using MeditekWeb.Business.Abstract;
using MeditekWeb.DataAccess.Abstract;
using MeditekWeb.DataAccess.Concrete;
using MeditekWeb.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MeditekWeb.Business.Concrete
{
    public class TeamBs : ITeamBs
    {
        ITeamRepository _repo;
        public TeamBs(ITeamRepository repo)
        {
            _repo = repo;
        }
        public void Delete(Team entity)
        {
            _repo.Delete(entity);
        }

        public Team Get(Expression<Func<Team, bool>> filter)
        {
            return _repo.Get(filter);
        }

        public List<Team> GetAll(Expression<Func<Team, bool>> filter = null)
        {
            return _repo.GetAll(filter);
        }

        public Team GetById(int id)
        {
            return _repo.GetById(id);
        }

        public Team GetByTeamId(int id)
        {
            return _repo.GetByTeamId(id);
        }

        public int Insert(Team entity)
        {
            return _repo.Insert(entity);
        }

        public void Update(Team entity)
        {
            _repo.Update(entity);
        }
    }
}
