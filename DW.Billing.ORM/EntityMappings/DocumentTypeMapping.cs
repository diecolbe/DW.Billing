using DW.Billing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.CodeAnalysis;

namespace DW.Billing.ORM.EntityMappings
{
    [ExcludeFromCodeCoverage]
    class DocumentTypeMapping : IEntityTypeConfiguration<DocumentType>
    {
        public void Configure(EntityTypeBuilder<DocumentType> builder)
        {
            builder.ToTable("TBL_TIPODOCUMENTO");

            builder.Property(p => p.DocumentTypeID)
                .HasColumnName("ID_TIPO_DOCUMENTO")
                .IsRequired();
            builder.Property(p => p.Description)
                .HasColumnName("DESCRIPCION")
                .IsRequired();

            builder.HasKey(p => p.DocumentTypeID);
        }
    }
}
