using MeditekWeb.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeditekWeb.DataAccess.Context
{
    public class MeditekDataContext:DbContext
    {
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Event> Etkinlik { get; set; }
        public DbSet<Team> Teams { get; set; }

        public DbSet<Member> Members { get; set; }
        public DbSet<Unit> Birimler { get; set; }
        public DbSet<Contact> Contact { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=MeditekData;Trusted_Connection=True;");
            
        }

    }
}
