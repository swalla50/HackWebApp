using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackWebApp.Models
{
    public class GetAllRemindersContext: DbContext
    {
        public GetAllRemindersContext(DbContextOptions<GetAllRemindersContext> options) : base(options)
        {

        }
        public DbSet<GetAllRemindersModel> getAllReminderModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GetAllRemindersModel>().ToTable("vwAllReminders");
        }
    }
}
