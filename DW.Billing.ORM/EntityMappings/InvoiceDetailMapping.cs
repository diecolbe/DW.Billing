using DW.Billing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.CodeAnalysis;

namespace DW.Billing.ORM.EntityMappings
{
    [ExcludeFromCodeCoverage]
    public class InvoiceDetailMapping : IEntityTypeConfiguration<InvoiceDetail>
    {
        public void Configure(EntityTypeBuilder<InvoiceDetail> builder)
        {
            builder.ToTable("TBL_DETALLE_FACTURA");

            builder.Property(p => p.InvoiceID)
                .HasColumnName("COD_FACTURA")
                .IsRequired();

            builder.Property(p => p.ProductID)
                .HasColumnName("CODIGO_PRODUCTO")
                .IsRequired();

            builder.Property(p => p.Amount)
                .HasColumnName("CANTIDAD")                
                .IsRequired();

            builder.Property(p => p.Total)
                .HasColumnName("TOTAL")
                .IsRequired();

            builder.HasKey(p => new { p.InvoiceID, p.ProductID });
        }
    }
}
