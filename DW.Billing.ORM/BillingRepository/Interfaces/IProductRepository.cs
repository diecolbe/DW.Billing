using DW.Billing.Models.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DW.Billing.ORM.BillingRepository.Interfaces
{
    public interface IProductRepository
    {
        Task<List<ProductDto>> GetAllProducts();
        Task<List<PricesByProductDto>> PricesByProduct();
        Task<List<ProductByStockMinimumDto>> ProductByStockMinimum();
        Task<List<CustomersPaymentsTo35YearsDto>> CustomersPaymentsTo35Years();
        Task<List<TotalProductByYearDto>> TotalProductByYear(DateTime intial, DateTime final);
        
        
    }
}
