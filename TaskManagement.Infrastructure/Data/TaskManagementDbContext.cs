using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagement.Core.Entities;

namespace TaskManagement.Infrastructure.Data
{
    public class TaskManagementDbContext : DbContext
    {
        public TaskManagementDbContext(DbContextOptions<TaskManagementDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>(ConfigureTask);
            modelBuilder.Entity<User>(ConfigureUser);
            modelBuilder.Entity<TaskHistory>(ConfigureTaskHistory);
        }

        //DB relationship: One Task to one User

        //DbSet<T> indicate tables
        public DbSet<Task> Tasks { get; set; }
        private void ConfigureTask(EntityTypeBuilder<Task> obj)
        {
            // rename table
            obj.ToTable("Tasks");
            // primary key
            obj.HasKey(t => t.Id);
            // string varchars
            obj.Property(t => t.Title).HasMaxLength(50);
            obj.Property(t => t.Description).HasMaxLength(500);
            obj.Property(t => t.Remarks).HasMaxLength(500);
            obj.HasOne(t => t.User).WithMany(u => u.PendingTasks);
        }

        // relationship: User to Task
        public DbSet<User> Users { get; set; }
        private void ConfigureUser(EntityTypeBuilder<User> obj)
        {
            obj.ToTable("Users");
            obj.HasKey(u => u.Id);
            obj.Property(u => u.Email).HasMaxLength(50);
            obj.Property(u => u.Password).HasMaxLength(20);
            obj.Property(u => u.Fullname).HasMaxLength(50);
        }

        public DbSet<TaskHistory> TasksHistories { get; set; }
        private void ConfigureTaskHistory(EntityTypeBuilder<TaskHistory> obj)
        {
            obj.ToTable("Tasks History");
            obj.HasKey(th => th.TaskId);
            obj.Property(th => th.Title).HasMaxLength(50);
            obj.Property(th => th.Description).HasMaxLength(500);
            obj.Property(th => th.Remarks).HasMaxLength(500);
            // set default value to current datetime
            obj.Property(th => th.Completed).HasDefaultValueSql("getdate()");
            obj.HasOne(th => th.User).WithMany(u => u.CompletedTasks);
        }

    }
}
