using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ck283615_MIS4200.Models;
using System.Data.Entity;

namespace ck283615_MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base ("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context,
                ck283615_MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}