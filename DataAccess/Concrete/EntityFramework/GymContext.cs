using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class GymContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;
                        Database=GymManagementDb;Trusted_Connection=true");
        }

        public DbSet<Gym> Gyms { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<WorkingHour> WorkingHours { get; set; }
        public DbSet<GymTime> GymTimes { get; set; }
        public DbSet<MembershipInfo> MembershipInfos { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}
