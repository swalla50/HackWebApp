using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackWebApp.Models
{
    public class GetContactsContext: DbContext
    {
        public GetContactsContext(DbContextOptions<GetContactsContext> options) : base(options)
        {

        }
        public DbSet<GetContactsModel> getContactsModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GetContactsModel>().ToTable("tblContact");
        }
    }
}
