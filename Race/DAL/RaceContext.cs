using Race.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Race.DAL
{
    public class RaceContext : DbContext
    {
        public RaceContext() : base("RaceContext")
        {

        }

        public DbSet<Team> Teams { get; set; }
    }
}