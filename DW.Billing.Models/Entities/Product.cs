using System;

namespace DW.Billing.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
