using MeditekWeb.DataAccess.Abstract;
using MeditekWeb.DataAccess.Context;
using MeditekWeb.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeditekWeb.DataAccess.Concrete
{
    public class EventRepository : RepositoryBase<Event, MeditekDataContext>, IEventRepository
    {
        

        public Event GetByEventId(int id)
        {
            return Get(x => x.ID == id);
        }
      
    }
}
