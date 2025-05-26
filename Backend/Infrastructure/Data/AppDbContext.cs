using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TaskModel> Tasks => Set<TaskModel>();

        public override Task<int> SaveChangesAsync(CancellationToken cancellation = default)
        {
            var entries = ChangeTracker.Entries<ModelBase>();

            foreach(var entry in entries)
            {
                if(entry.State == EntityState.Modified)
                    entry.Entity.UpdatedAt = DateTime.UtcNow;
            }

            return base.SaveChangesAsync(cancellation);
        }
    }
}
