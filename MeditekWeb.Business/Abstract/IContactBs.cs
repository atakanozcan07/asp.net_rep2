using MeditekWeb.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MeditekWeb.Business.Abstract
{
    public interface IContactBs
    {
        List<Contact> GetAll(Expression<Func<Contact, bool>> filter = null);
        Contact Get(Expression<Func<Contact, bool>> filter);
        Contact GetById(int id);
        int Insert(Contact entity);
        void Update(Contact entity);
        void Delete(Contact entity);
    }
}
