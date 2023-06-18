using CleanArchitecture.TaskManager.Domain.DomainObjects.Entities;
using CleanArchitecture.TaskManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CleanArchitecture.TaskManager.Infrasctructure.Persistance
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Domain.DomainObjects.Entities.Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
        public ApplicationContext(DbContextOptions options) : base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(ApplicationContext)));
            base.OnModelCreating(modelBuilder);
        }
    }
}
