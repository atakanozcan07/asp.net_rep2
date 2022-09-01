using MeditekWeb.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MeditekWeb.Business.Abstract
{
    public interface IEventBs
    {
        List<Event> GetAll(Expression<Func<Event, bool>> filter = null);
        Event Get(Expression<Func<Event, bool>> filter);
        Event GetById(int id);
        int Insert(Event entity);
        void Update(Event entity);
        void Delete(Event entity);
        Event GetByEventId(int id);
    }
}
