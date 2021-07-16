using DW.Billing.Models;
using DW.Billing.ORM.EntityMappings;
using Microsoft.EntityFrameworkCore;

namespace DW.Billing.ORM.Context
{
    public class BillingContext : DbContext
    {
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetail { get; set; }
        public virtual DbSet<DocumentType> DocumentType { get; set; }
        public virtual DbSet<Product> Product { get; set; }

        public BillingContext(DbContextOptions<BillingContext> dbContextOptions) 
            : base(dbContextOptions)
        {

        }       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerMapping());
            modelBuilder.ApplyConfiguration(new InvoiceMapping());
            modelBuilder.ApplyConfiguration(new InvoiceDetailMapping());
            modelBuilder.ApplyConfiguration(new DocumentTypeMapping());
            modelBuilder.ApplyConfiguration(new ProductMapping());
        }
    }
}
