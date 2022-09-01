using MeditekWeb.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeditekWeb.DataAccess.Abstract
{
    public interface IManagerRepository:IRepository<Manager>
    {
        Manager LogIn(string userName , string Password);
    }
}
