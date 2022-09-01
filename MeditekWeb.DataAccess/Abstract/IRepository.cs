using MeditekWeb.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MeditekWeb.DataAccess.Abstract
{
    public interface IRepository<TEntity> where  TEntity:BaseEntity,new()
    {
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        TEntity GetById(int id);
        int Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
