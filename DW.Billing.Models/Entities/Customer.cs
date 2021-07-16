using System;
using System.Diagnostics.CodeAnalysis;

namespace DW.Billing.Models
{
    [ExcludeFromCodeCoverage]
    public class Customer
    {
        public string Document { get; set; }
        public int DocumentType { get; set; }
        public string Names { get; set; }
        public string LastNames { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
    }
}
