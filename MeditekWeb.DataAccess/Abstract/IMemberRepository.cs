using MeditekWeb.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeditekWeb.DataAccess.Abstract
{
    public interface IMemberRepository:IRepository<Member>
    {
        Member GetByTeamId(int id);

    }
}
