using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackWebApp.Models
{
    public class GetBuildingandHierarchyContext: DbContext
    {
        public GetBuildingandHierarchyContext(DbContextOptions<GetBuildingandHierarchyContext> options) : base(options)
        {

        }
        public DbSet<GetBuildingandHierarchyModel> getBuildingandHierarchyModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GetBuildingandHierarchyModel>(builder => { builder.HasNoKey(); builder.ToTable("vwBuildingandHierarchy"); });
        }
    }
}
