using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackWebApp.Models
{
    public class DeleteReminderContext: DbContext
    {
        
            public DeleteReminderContext(DbContextOptions<DeleteReminderContext> options) : base(options)
            {

            }
            public DbSet<DeleteReminderModel> deleteReminders { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<DeleteReminderModel>().ToTable("tblTickler");
            }
    }
}
