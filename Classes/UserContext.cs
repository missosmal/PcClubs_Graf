using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PcClubs_Graf.Classes.Common;
using PcClubs_Graf.Models;

namespace PcClubs_Graf.Classes
{
    public class UserContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public UserContext() =>
            Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder oprionsBuilder) =>
            oprionsBuilder.UseMySql(Config.ConnectionConfig, Config.Version);
    }
}
