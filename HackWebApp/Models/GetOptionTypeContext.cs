using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackWebApp.Models
{
    public class GetOptionTypeContext :DbContext
    {
        public GetOptionTypeContext(DbContextOptions<GetOptionTypeContext> options) : base(options)
        {

        }
        public DbSet<GetOptionTypeModel> getOptionTypeModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GetOptionTypeModel>().ToTable("tblTicklerType");
        }
    }
}
