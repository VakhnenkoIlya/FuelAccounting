using FuelAccounting.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelAccounting
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<DailyReport> DailyReports { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=PerfMonUtils.dll");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             modelBuilder.Entity<Car>().HasIndex(b => b.Id).IsUnique();
            modelBuilder.Entity<DailyReport>().HasOne<Car>(s => s.Car)
            .WithMany(g => g.Reports);
        }
    }
}
