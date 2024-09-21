using LiteThinkingProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LiteThinkingProject.Infraestructure.Data.Configurations
{
    public class TransaccionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.Property(t => t.Id)
                   .IsRequired();
        }
    }
}
