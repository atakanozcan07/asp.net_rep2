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
    public class EventBs : IEventBs
    {
        IEventRepository _repo;
        public EventBs(IEventRepository repo)
        {
            _repo = repo;

        }
        public void Delete(Event entity)
        {
            
            _repo.Delete(entity);
        }

        public Event Get(Expression<Func<Event, bool>> filter)
        {
            
            return _repo.Get(filter);
        }

        public List<Event> GetAll(Expression<Func<Event, bool>> filter = null)
        {
            
            return _repo.GetAll(filter);
        }

        public Event GetByEventId(int id)
        {
            return _repo.GetByEventId(id);
        }

        public Event GetById(int id)
        {
            
            return _repo.GetById(id);
        }

        public int Insert(Event entity)
        {
            
            return _repo.Insert(entity);
        }

        public void Update(Event entity)
        {
            
            _repo.Update(entity);
        }
    }
}
