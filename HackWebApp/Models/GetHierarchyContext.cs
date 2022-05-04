using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackWebApp.Models
{
    public class GetHierarchyContext :DbContext
    {
        public GetHierarchyContext(DbContextOptions<GetHierarchyContext> options) : base(options)
        {

        }
        public DbSet<GetHierarchyModel> getHierarchyModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GetHierarchyModel>().ToTable("vwCompanyHierarchy");
        }
    }
}
