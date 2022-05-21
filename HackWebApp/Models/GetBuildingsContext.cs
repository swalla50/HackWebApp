using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackWebApp.Models
{
    public class GetBuildingsContext: DbContext
    {
        public GetBuildingsContext(DbContextOptions<GetBuildingsContext> options) : base(options)
        {

        }
        public DbSet<GetBuildingsModel> getBuildingsModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GetBuildingsModel>().ToTable("tblBuilding");
        }
    }
}
