using CleanArchitecture.TaskManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.TaskManager.Infrasctructure.Persistance.EntityMappings
{
    public class UserEntityMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(200);
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Role).IsRequired();

            builder.Property(x => x.Password).IsRequired();
            builder.Property(x => x.DeletedAt).IsRequired(false);
            builder.Property(x => x.CreatedAt).IsRequired(true);
            builder.Property(x => x.UpdatedAt).IsRequired(false);
        }
    }
}
