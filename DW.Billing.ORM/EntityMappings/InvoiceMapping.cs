using DW.Billing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.CodeAnalysis;

namespace DW.Billing.ORM.EntityMappings
{
    [ExcludeFromCodeCoverage]
    public class InvoiceMapping : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.ToTable("TBL_FACTURA");

            builder.Property(p => p.InvoiceNumber)
                .HasColumnName("NUM_FACTURA")
                .IsRequired();

            builder.Property(p => p.CustomerID)
                .HasColumnName("CODIGO_CLIENTE")
                .IsRequired();

            builder.Property(p => p.EmployeeName)
                .HasColumnName("NOMBRE_EMPLEADO")                
                .IsRequired();

            builder.Property(p => p.DateBilling)
                .HasColumnName("FECHA_FACTURACION")
                .IsRequired();

            builder.Property(p => p.InvoiceTotal)
                .HasColumnName("TOTAL_FACTURA")
                .IsRequired();

            builder.Property(p => p.IVA)
                .HasColumnName("IVA")
                .IsRequired();

            builder.HasKey(p => p.InvoiceNumber);
        }
    }
}

