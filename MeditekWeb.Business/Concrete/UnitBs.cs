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
    public class UnitBs : IUnitBs
    {
        IUnitRepository _repo;
        public UnitBs(IUnitRepository repo)
        {
            _repo = repo;

        }
        public void Delete(Unit entity)
        {
            _repo.Delete(entity);
        }

        public Unit Get(Expression<Func<Unit, bool>> filter)
        {
            return _repo.Get(filter);
        }

        public List<Unit> GetAll(Expression<Func<Unit, bool>> filter = null)
        {
            return _repo.GetAll(filter);
        }

        public Unit GetById(int id)
        {
            return _repo.GetById(id);
        }

        public int Insert(Unit entity)
        {
            return _repo.Insert(entity);
        }

        public void Update(Unit entity)
        {
            _repo.Update(entity);
        }
    }
}
