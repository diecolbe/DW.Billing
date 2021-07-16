using DW.Billing.Models;
using DW.Billing.ORM.Repository;
using System;

namespace DW.Billing.ORM.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        Repository<Customer> CustomerRepository { get; }
        Repository<DocumentType> DocumentTypeRepository { get; }
        Repository<Invoice> InvoiceRepository { get; }
        Repository<InvoiceDetail> InvoiceDetailRepository { get; }
        Repository<Product> ProductRepository { get; }

        void Dispose();
        int Save();
    }
}
