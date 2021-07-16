using DW.Billing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.CodeAnalysis;

namespace DW.Billing.ORM.EntityMappings
{
    [ExcludeFromCodeCoverage]
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("TBL_PRODUCTO");

            builder.Property(p => p.ProductID)
                .HasColumnName("ID_PRODUCTO")
                .IsRequired();

            builder.Property(p => p.Description)
                .HasColumnName("DESCRIPCION")
                .IsRequired();

            builder.Property(p => p.Price)
                .HasColumnName("PRECIO")                
                .IsRequired();

            builder.Property(p => p.Stock)
                .HasColumnName("STOCK")
                .IsRequired();

            builder.Property(p => p.EntryDate)
                .HasColumnName("FECHA_INGRESO")
                .IsRequired();

            builder.HasKey(p => p.ProductID);
        }
    }
}
