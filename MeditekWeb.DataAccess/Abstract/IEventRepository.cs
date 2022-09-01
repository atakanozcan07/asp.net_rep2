using MeditekWeb.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeditekWeb.DataAccess.Abstract
{
    public interface IEventRepository:IRepository<Event>
    {
        Event GetByEventId(int id);
        
       

        
        
    }
}
