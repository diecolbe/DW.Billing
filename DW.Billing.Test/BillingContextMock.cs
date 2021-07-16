using DW.Billing.Models;
using DW.Billing.ORM.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DW.Billing.Test
{
    public class BillingContextMock
    {
        private static BillingContext context;

        public static BillingContext Seed()
        {
            var options = new DbContextOptionsBuilder<BillingContext>()
                .EnableSensitiveDataLogging()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            context = new BillingContext(options);

            //Customers
            SetDataCustomer();
            //Document Type
            SetDataDocumentType();
            //Invoice
            SetDataInvoice();
            //Products
            SetDataProduct();

            return context;

        }
        private static void SetDataCustomer()
        {
            context.Customer.AddRange(
                new Customer
                {
                    Document = "123456",
                    DocumentType = 1,
                    Names = "Pedro",
                    LastNames = "perez gomez",
                    Adress = "Calle 1 casa # 1",
                    Phone = "310123456",
                    Email = "pedro@prueba.com",
                    Birthday = new DateTime(1984 - 03 - 01)

                },
                new Customer
                {
                    Document = "123423",
                    DocumentType = 1,
                    Names = "Diana",
                    LastNames = "vargas londoño",
                    Adress = "Calle 4 casa # 4",
                    Phone = "310123423",
                    Email = "Diana@prueba.com",
                    Birthday = new DateTime(2000 - 09 - 23)
                },
                new Customer
                {
                    Document = "123460",
                    DocumentType = 1,
                    Names = "Juan",
                    LastNames = "gonzalez rivera",
                    Adress = "Calle 2 casa # 2",
                    Phone = "310123460",
                    Email = "Juan@prueba.com",
                    Birthday = new DateTime(1990 - 05 - 20)
                },
                new Customer
                {
                    Document = "123471",
                    DocumentType = 5,
                    Names = "Daniela",
                    LastNames = "ortegon londoño",
                    Adress = "Calle 5 casa # 5",
                    Phone = "310123471",
                    Email = "Daniela@prueba.com",
                    Birthday = new DateTime(1989 - 08 - 10)
                },
                 new Customer
                 {
                     Document = "123489",
                     DocumentType = 1,
                     Names = "Angela",
                     LastNames = "lopez martinez",
                     Adress = "Calle 3 casa # 3",
                     Phone = "310123489",
                     Email = "Angela@prueba.com",
                     Birthday = new DateTime(1989 - 06 - 23)
                 }
            );
        }

        private static void SetDataDocumentType()
        {
            context.DocumentType.AddRange(
                new DocumentType()
                {
                    DocumentTypeID = 1,
                    Description = "Cédula de ciudadanía"
                },
                new DocumentType()
                {
                    DocumentTypeID = 2,
                    Description = "Cédula de extranjería"
                },
                new DocumentType()
                {
                    DocumentTypeID = 3,
                    Description = "Tarjeta de extranjería"
                },
                new DocumentType()
                {
                    DocumentTypeID = 4,
                    Description = "Tarjeta de identidad"
                },
                new DocumentType()
                {
                    DocumentTypeID = 5,
                    Description = "Pasaporte "
                }
                );
        }

        private static void SetDataInvoice()
        {
            context.Invoice.AddRange(
                new Invoice()
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
                }
                );

        }
        private static void SetDataProduct()
        {
            context.Product.AddRange(
                new Product()
                {
                    ProductID = 10,
                    Description = "Producto B",
                    Price = 200,
                    Stock = 10,
                    EntryDate = new DateTime(2021 - 07 - 15)
                },
                new Product()
                {
                    ProductID = 11,
                    Description = "Producto C",
                    Price = 300,
                    Stock = 7,
                    EntryDate = new DateTime(2021 - 07 - 15)
                },
                new Product()
                {
                    ProductID = 12,
                    Description = "Producto D",
                    Price = 400,
                    Stock = 10,
                    EntryDate = new DateTime(2021 - 07 - 15)
                },
                new Product()
                {
                    ProductID = 13,
                    Description = "Producto C",
                    Price = 100,
                    Stock = 20,
                    EntryDate = new DateTime(2021 - 07 - 15)
                },
                new Product()
                {
                    ProductID = 14,
                    Description = "Producto F",
                    Price = 250,
                    Stock = 5,
                    EntryDate = new DateTime(2021 - 07 - 15)
                },
                new Product()
                {
                    ProductID = 15,
                    Description = "Producto G",
                    Price = 500,
                    Stock = 9,
                    EntryDate = new DateTime(2021 - 07 - 15)
                },
                new Product()
                {
                    ProductID = 16,
                    Description = "Producto H",
                    Price = 150,
                    Stock = 6,
                    EntryDate = new DateTime(2021 - 07 - 15)
                },
                new Product()
                {
                    ProductID = 17,
                    Description = "Producto AB",
                    Price = 150,
                    Stock = 3,
                    EntryDate = new DateTime(2021 - 07 - 15)
                }
                );

        }
    }
}
