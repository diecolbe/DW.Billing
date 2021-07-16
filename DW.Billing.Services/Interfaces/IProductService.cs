
using DW.Billing.Common;
using DW.Billing.Models;
using DW.Billing.Models.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DW.Billing.Services.Interfaces
{
    public interface IProductService
    {
        ResponseServices<bool> Insert(List<Product> products);
        ResponseServices<bool> Insert(Product product);
        ResponseServices<bool> Delete(int id);
        ResponseServices<bool> Delete(List<Product> products);
        ResponseServices<bool> Update(Product product);
        ResponseServices<bool> Update(List<Product> products);
        ResponseServices<Product> Select(int id);
        ResponseServices<List<ProductDto>> Select();
        ResponseServices<List<PricesByProductDto>> PricesByProduct();
        ResponseServices<List<ProductByStockMinimumDto>> ProductByStockMinimum();
        ResponseServices<List<TotalProductByYearDto>> TotalProductByYear(DateTime intial, DateTime final);
        ResponseServices<List<CustomersPaymentsTo35YearsDto>> CustomersPaymentsTo35Years();
    }
}
