using DW.Billing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.CodeAnalysis;

namespace DW.Billing.ORM.EntityMappings
{
    [ExcludeFromCodeCoverage]
    public class CustomerMapping : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("TBL_CLIENTE");

            builder.Property(p => p.Document)
                .HasColumnName("DOCUMENTO")
                .IsRequired();

            builder.Property(p => p.DocumentType)
                .HasColumnName("COD_TIPO_DOCUMENTO")
                .IsRequired();

            builder.Property(p => p.Names)
                .HasColumnName("NOMBRES")                
                .IsRequired();

            builder.Property(p => p.LastNames)
                .HasColumnName("APELLIDOS")
                .IsRequired();

            builder.Property(p => p.Adress)
                .HasColumnName("DIRECCION")
                .IsRequired();

            builder.Property(p => p.Phone)
                .HasColumnName("TELEFONO")
                .IsRequired();

            builder.Property(p => p.Email)
                .HasColumnName("EMAIL")
                .IsRequired();

            builder.Property(p => p.Birthday)
                .HasColumnName("FECHA_NACIMIENTO")
                .IsRequired();

            builder.HasKey(p => p.Document);
        }
    }
}
