using DW.Billing.Models;
using DW.Billing.ORM.Context;
using DW.Billing.ORM.Repository;
using System;

namespace DW.Billing.ORM.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BillingContext _context;
        private bool disposed = false;

        public UnitOfWork(BillingContext context)
        {
            _context = context;
        }

        #region Attributes

        private Repository<Customer> customerRepository;
        private Repository<DocumentType> documentTypeRepository;
        private Repository<Invoice> invoiceRepository;
        private Repository<InvoiceDetail> invoiceDetailRepository;
        private Repository<Product> productRepository;

        #endregion

        #region Repositories

        public Repository<Customer> CustomerRepository
        {
            get
            {
                if (this.customerRepository == null)
                    this.customerRepository = new Repository<Customer>(_context);
                return customerRepository;
            }
        }

        public Repository<DocumentType> DocumentTypeRepository
        {
            get
            {
                if (documentTypeRepository == null)
                    documentTypeRepository = new Repository<DocumentType>(_context);
                return documentTypeRepository;
            }
        }

        public Repository<Invoice> InvoiceRepository
        {
            get
            {
                if (invoiceRepository == null)
                    invoiceRepository = new Repository<Invoice>(_context);
                return invoiceRepository;
            }
        }

        public Repository<InvoiceDetail> InvoiceDetailRepository
        {
            get
            {
                if (invoiceDetailRepository == null)
                    invoiceDetailRepository = new Repository<InvoiceDetail>(_context);
                return invoiceDetailRepository;
            }
        }

        public Repository<Product> ProductRepository
        {
            get
            {
                if (productRepository == null)
                    productRepository = new Repository<Product>(_context);
                return productRepository;
            }
        }

        #endregion

        #region Members
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed && disposing)
            {
                _context.Dispose();
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public int Save()
        {
            return _context.SaveChanges(); 
        }
        #endregion

    }
}
