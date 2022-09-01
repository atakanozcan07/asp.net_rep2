using MeditekWeb.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MeditekWeb.Business.Abstract
{
    public interface IUnitBs
    {
        List<Unit> GetAll(Expression<Func<Unit, bool>> filter = null);
        Unit Get(Expression<Func<Unit, bool>> filter);
        Unit GetById(int id);
        int Insert(Unit entity);
        void Update(Unit entity);
        void Delete(Unit entity);
    }
}
