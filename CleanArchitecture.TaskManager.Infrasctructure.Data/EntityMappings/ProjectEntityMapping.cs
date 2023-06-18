using CleanArchitecture.TaskManager.Domain.DomainObjects.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.TaskManager.Infrasctructure.Persistance.EntityMappings
{
    public class ProjectEntityMapping : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(200);
            builder.Property(x => x.Title).HasMaxLength(200);
            builder.Property(x => x.UpdatedAt).IsRequired(false);
            builder.Property(x => x.ToConcludedAt).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.DeletedAt).IsRequired(false);
            builder.Property(x => x.Description).HasMaxLength(400);

            //relations

            builder.HasMany(x => x.Tasks);
            builder.HasMany(x => x.Members);

        }
    }
}
