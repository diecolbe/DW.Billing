using System;
using System.Collections.Generic;

namespace DW.Billing.Models
{
    public class Invoice
    {
        public string InvoiceNumber { get; set; }
        public string CustomerID { get; set; }
        public string EmployeeName { get; set; }
        public DateTime DateBilling { get; set; }
        public decimal InvoiceTotal { get; set; }
        public decimal IVA { get; set; }
        public virtual List<InvoiceDetail> InvoiceDetail { get; set; }
    }
}
