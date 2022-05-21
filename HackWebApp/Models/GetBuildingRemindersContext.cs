using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackWebApp.Models
{
    public class GetBuildingRemindersContext: DbContext
    {
        public GetBuildingRemindersContext(DbContextOptions<GetBuildingRemindersContext> options) : base(options)
        {

        }
        public DbSet<GetBuildingRemindersModel> getBuildinReminderModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GetBuildingRemindersModel>().ToTable("vwBuildingReminders");
        }
    }
}
