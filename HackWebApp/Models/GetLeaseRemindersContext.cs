using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackWebApp.Models
{
    public class GetLeaseRemindersContext: DbContext
    {
        public GetLeaseRemindersContext(DbContextOptions<GetLeaseRemindersContext> options) : base(options)
        {

        }
        public DbSet<GetLeaseRemindersModel> getLeaseRemindersModel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GetLeaseRemindersModel>().ToTable("vwLeaseReminders");
        }
    }
}
