using MeditekWeb.Business.Abstract;
using MeditekWeb.DataAccess.Abstract;
using MeditekWeb.DataAccess.Concrete;
using MeditekWeb.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MeditekWeb.Business.Concrete
{
    public class MemberBs : IMemberBs
    {
        IMemberRepository _repo;
        public MemberBs(IMemberRepository repo)
        {
            _repo = repo;

        }
        public void Delete(Member entity)
        {
            _repo.Delete(entity);
        }

        public Member Get(Expression<Func<Member, bool>> filter)
        {
            return _repo.Get(filter);
        }

        public List<Member> GetAll(Expression<Func<Member, bool>> filter = null)
        {
            return _repo.GetAll(filter);
        }

        public Member GetById(int id)
        {
            return _repo.GetById(id);
        }

        public Member GetByTeamId(int id)
        {
            return _repo.GetByTeamId(id);
        }

        public int Insert(Member entity)
        {
            return _repo.Insert(entity);
        }

        public void Update(Member entity)
        {
            _repo.Update(entity);
        }

    }
}
