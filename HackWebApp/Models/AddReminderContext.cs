using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackWebApp.Models
{
    public class AddReminderContext: DbContext
    {
        public AddReminderContext(DbContextOptions<AddReminderContext> options) : base(options)
        {

        }
        public DbSet<AddReminderModel> addReminderModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddReminderModel>().ToTable("tblTickler");
        }
    }
}
