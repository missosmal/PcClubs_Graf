using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PcClubs_Graf.Classes.Common;
using PcClubs_Graf.Models;
using System.Text;

namespace PcClubs_Graf.Classes
{
    public class ClubsContext : DbContext
    {
        public DbSet<Clubs> Clubs { get; set; }
        public ClubsContext() =>
            Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder oprionsBuilder) =>
            oprionsBuilder.UseMySql(Config.ConnectionConfig, Config.Version);
    }
}
