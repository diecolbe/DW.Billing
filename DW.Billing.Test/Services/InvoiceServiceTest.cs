using DW.Billing.Common;
using DW.Billing.Models;
using DW.Billing.ORM.Context;
using DW.Billing.ORM.Repository;
using DW.Billing.ORM.UnitOfWork;
using DW.Billing.Services.Interfaces;
using DW.Billing.Services.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DW.Billing.Test.Services
{
    [TestClass()]
    [ExcludeFromCodeCoverage]
    public class InvoiceServiceTest
    {
        private readonly BillingContext _context;
        private IUnitOfWork _unitOfWork;
        private Mock<IInvoiceService> _invoiceServiceMock;
        private Mock<IRepository<Invoice>> _invoiceMock;
        private IInvoiceService _invoiceService;

        public InvoiceServiceTest()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddScoped<IInvoiceService, InvoiceService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            _context = BillingContextMock.Seed();
        }
        [TestInitialize]
        public void Init()
        {
            _invoiceServiceMock = new Mock<IInvoiceService>();
            _unitOfWork = new UnitOfWork(_context);
            _invoiceMock = new Mock<IRepository<Invoice>>() { CallBase = true };
            _invoiceService = new InvoiceService(_unitOfWork);
        }

        [TestMethod()]
        public void InsertTest()
        {
            Invoice invoice = new Invoice()
            {
                InvoiceNumber = "0002",
                CustomerID = "123460",
                EmployeeName = "Leonado",
                DateBilling = new DateTime(2021 - 07 - 16),
                InvoiceTotal = 450,
                IVA = 16,
                InvoiceDetail = new List<InvoiceDetail>()
                    {
                        new InvoiceDetail()
                        {
                            InvoiceID="0001",
                            ProductID=13,
                            Amount=2,
                            Total=200
                        },
                         new InvoiceDetail()
                        {
                            InvoiceID="0001",
                            ProductID=15,
                            Amount=3,
                            Total=1500
                        },
                          new InvoiceDetail()
                        {
                            InvoiceID="0001",
                            ProductID=12,
                            Amount=2,
                            Total=800
                        }
                    }
            };

            ResponseServices<bool> result = _invoiceService.Insert(invoice);
            Assert.IsTrue(result.Info);
        }

        [TestMethod()]
        public void InsertFalseTest()
        {
            Invoice invoice = new Invoice()
            {
                InvoiceNumber = "0001",
                CustomerID = "123423",
                EmployeeName = "Juliana",
                DateBilling = new DateTime(2021 - 07 - 16),
                InvoiceTotal = 450,
                IVA = 16,
                InvoiceDetail = new List<InvoiceDetail>()
                    {
                        new InvoiceDetail()
                        {
                            InvoiceID="0001",
                            ProductID=11,
                            Amount=3,
                            Total=900
                        },
                         new InvoiceDetail()
                        {
                            InvoiceID="0001",
                            ProductID=14,
                            Amount=3,
                            Total=750
                        },
                          new InvoiceDetail()
                        {
                            InvoiceID="0001",
                            ProductID=17,
                            Amount=3,
                            Total=2100
                        }
                    }
            };

            ResponseServices<bool> result = _invoiceService.Insert(invoice);
            Assert.IsTrue(result.Info);
        }
    }
}
