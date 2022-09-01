using MeditekWeb.DataAccess.Abstract;
using MeditekWeb.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MeditekWeb.Business.Abstract
{
    public interface IMemberBs:IMemberRepository
    {
        List<Member> GetAll(Expression<Func<Member, bool>> filter = null);
        Member Get(Expression<Func<Member, bool>> filter);
        Member GetById(int id);
        int Insert(Member entity);
        void Update(Member entity);
        void Delete(Member entity);
        Member GetByTeamId(int id);
    }
}
