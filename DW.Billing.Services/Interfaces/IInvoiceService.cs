using DW.Billing.Common;
using DW.Billing.Models;
using System.Collections.Generic;


namespace DW.Billing.Services.Interfaces
{
    public interface IInvoiceService
    {
        ResponseServices<bool> Insert(List<Invoice> invoices);
        ResponseServices<bool> Insert(Invoice invoice);
        ResponseServices<bool> Delete(string id);
        ResponseServices<bool> Delete(List<Invoice> invoices);
        ResponseServices<bool> Update(Invoice invoice);
        ResponseServices<bool> Update(List<Invoice> invoices);
        ResponseServices<Invoice> Select(string id);
        ResponseServices<IEnumerable<Invoice>> Select();
    }
}
