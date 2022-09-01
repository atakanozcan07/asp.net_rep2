using MeditekWeb.Business.Abstract;
using MeditekWeb.DataAccess.Abstract;
using MeditekWeb.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MeditekWeb.Business.Concrete
{
    public class ContactBs : IContactBs
    {

        IContactRepository _repo;
        public ContactBs(IContactRepository repo)
        {
            _repo = repo;

        }

        public void Delete(Contact entity)
        {
            _repo.Delete(entity);
        }

        public Contact Get(Expression<Func<Contact, bool>> filter)
        {
            return _repo.Get(filter);
        }

        public List<Contact> GetAll(Expression<Func<Contact, bool>> filter = null)
        {
            return _repo.GetAll(filter);
        }

        public Contact GetById(int id)
        {
            return _repo.GetById(id);
        }

        public int Insert(Contact entity)
        {
            return _repo.Insert(entity);
        }

        public void Update(Contact entity)
        {
            _repo.Update(entity);
        }
    }

}
