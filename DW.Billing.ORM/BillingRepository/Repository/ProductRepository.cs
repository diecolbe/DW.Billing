using DW.Billing.Common;
using DW.Billing.Common.Resources;
using DW.Billing.Models.DTO;
using DW.Billing.ORM.BillingRepository.Interfaces;
using DW.Billing.ORM.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DW.Billing.ORM.BillingRepository.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ConnectionStrings _connection;

        public ProductRepository(ConnectionStrings connection)
        {
            _connection = connection;
        }

        public async Task<List<ProductDto>> GetAllProducts()
        {
            var query = Queries.GetAll;
            using (var manager = new DataBaseManager(_connection.ConnectionStringSQLServer))
            {
                var list = await manager.ExecuteQuerySelect<ProductDto>(query).ConfigureAwait(false);
                return list.ToList();
            }
        }

        public async Task<List<PricesByProductDto>> PricesByProduct()
        {
            var query = Queries.PricesByProduct;
            using (var manager = new DataBaseManager(_connection.ConnectionStringSQLServer))
            {
                var list = await manager.ExecuteQuerySelect<PricesByProductDto>(query).ConfigureAwait(false);
                return list.ToList();
            }
        }

        public async Task<List<ProductByStockMinimumDto>> ProductByStockMinimum()
        {
            var query = Queries.ProductByStockMinimum;
            using (var manager = new DataBaseManager(_connection.ConnectionStringSQLServer))
            {
                var list = await manager.ExecuteQuerySelect<ProductByStockMinimumDto>(query).ConfigureAwait(false);
                return list.ToList();
            }
        }

        public async Task<List<TotalProductByYearDto>> TotalProductByYear(DateTime intial, DateTime final)
        {
            var query = Queries.TotalProductByYear;
            using (var manager = new DataBaseManager(_connection.ConnectionStringSQLServer))
            {
                var filter = new
                {
                    intial,
                    final
                };
                var list = await manager.ExecuteQuerySelect<TotalProductByYearDto>(query, filter).ConfigureAwait(false);
                return list.ToList();
            }
        }

        public async Task<List<CustomersPaymentsTo35YearsDto>> CustomersPaymentsTo35Years()
        {
            var query = Queries.CustomersPaymentsTo35Years;
            using (var manager = new DataBaseManager(_connection.ConnectionStringSQLServer))
            {
                var list = await manager.ExecuteQuerySelect<CustomersPaymentsTo35YearsDto>(query).ConfigureAwait(false);
                return list.ToList();
            }
        }
    }
}
