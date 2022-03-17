using Integracao.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Integracao.Data.Mappings
{
    public class FormaPagamentoMapping : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            // Primary Key
            builder.HasKey(f => f.Codigo);
            builder.Property(f => f.Codigo).ValueGeneratedOnAdd();

            // Property
            builder.Property(f => f.Id).ValueGeneratedOnAdd();
            builder.Property(f => f.Nome).HasColumnType("nvarchar(25)").IsRequired();
            builder.Property(f => f.IsDeleted).HasColumnType("bool").HasDefaultValue(false);
            builder.HasQueryFilter(f => !f.IsDeleted);

            // Index
            builder.HasIndex(f => new { f.Nome }).IsUnique();
        }
    }
}
