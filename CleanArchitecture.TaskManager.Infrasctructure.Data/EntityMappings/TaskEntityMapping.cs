using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.TaskManager.Infrasctructure.Persistance.EntityMappings
{
    public class TaskEntityMapping : IEntityTypeConfiguration<Domain.DomainObjects.Entities.Task>
    {
        public void Configure(EntityTypeBuilder<Domain.DomainObjects.Entities.Task> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(200);
            builder.Property(x => x.Description).HasMaxLength(200);

            builder.Property(x => x.UpdatedAt).IsRequired(false);
            builder.Property(x => x.CreatedAt).IsRequired(false);
            builder.Property(x => x.DeletedAt).IsRequired(false);

            builder.Property(x => x.Priority).IsRequired();
            builder.Property(x => x.DueDate).IsRequired();

            builder.HasOne(x => x.Responsible);
            builder.HasMany(x => x.DependecyTaks);

        }
    }
}
