using HappyPeople.Models.Data;
using HappyPpl.Models.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HappyPeople.Services
{
    public class HappyDbContext : DbContext
    {
        public HappyDbContext()
            : base("DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<CountryData> CountryDatas { get; set; }

        public DbSet<IndexInfo> IndexInfos { get; set; }

        public DbSet<CountryVote> CountryVotes { get; set; }
    }
}