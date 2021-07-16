
namespace DW.Billing.Models
{
    public class InvoiceDetail
    {
        public string InvoiceID { get; set; }
        public int ProductID { get; set; }
        public int Amount { get; set; }
        public decimal Total { get; set; }
    }
}
