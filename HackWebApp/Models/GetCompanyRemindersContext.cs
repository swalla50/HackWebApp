using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackWebApp.Models
{
    public class GetCompanyRemindersContext: DbContext
    {
        public GetCompanyRemindersContext(DbContextOptions<GetCompanyRemindersContext> options) : base(options)
        {

        }
        public DbSet<GetCompanyRemindersModel> getCompanyReminderModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GetCompanyRemindersModel>().ToTable("vwCompanyReminders");
        }
    }
}
