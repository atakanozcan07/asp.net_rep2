using MeditekWeb.DataAccess.Abstract;
using MeditekWeb.DataAccess.Context;
using MeditekWeb.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeditekWeb.DataAccess.Concrete
{
    public class ManagerRepository : RepositoryBase<Manager, MeditekDataContext>, IManagerRepository
    {
        public Manager LogIn(string userName, string Password)
        {
            return Get(x => x.MANAGER_NAME == userName && x.MANAGER_PASSWORD == Password);
        }
    }
}
