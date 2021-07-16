using DW.Billing.Common;
using DW.Billing.Models;
using DW.Billing.Models.DTO;
using DW.Billing.ORM.BillingRepository.Interfaces;
using DW.Billing.ORM.UnitOfWork;
using DW.Billing.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace DW.Billing.Services.Services
{

    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductRepository _repository;

        public ProductService(IUnitOfWork unitOfWork, IProductRepository repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public ResponseServices<bool> Delete(int id)
        {
            var response = new ResponseServices<bool>();
            Product result = _unitOfWork.ProductRepository.FirstOrDefault(f => f.ProductID.Equals(id));

            if (result == null)
            {
                response.Message = $"El producto: {id} no existe.";
                response.Info = false;
                return response;
            }
            else
            {
                _unitOfWork.ProductRepository.Delete(result);
                _unitOfWork.Save();
                response.Message = $"Producto {id} eliminado satisfactoriamente.";
                response.Info = true;
            }
            return response;
        }

        public ResponseServices<bool> Delete(List<Product> products)
        {
            var response = new ResponseServices<bool>();

            if (products.Count == 0)
            {
                response.Message = $"No existen productos para eliminar.";
                response.Info = false;
                return response;
            }
            else
            {
                foreach (var product in products)
                {
                    _unitOfWork.ProductRepository.Delete(product);
                }

                _unitOfWork.Save();
                response.Message = $"Los productos fueron eliminados satisfactoriamente.";
                response.Info = true;
            }
            return response;
        }

        public ResponseServices<bool> Insert(List<Product> products)
        {
            var response = new ResponseServices<bool>();

            if (products.Count == 0)
            {
                response.Message = $"No existen productos para registrar.";
                response.Info = false;
                return response;
            }
            else
            {
                foreach (var product in products)
                {
                    Product result = _unitOfWork.ProductRepository.FirstOrDefault(f => f.ProductID.Equals(product.ProductID));
                    if (result == null)
                    {
                        _unitOfWork.ProductRepository.Insert(result);
                    }
                }
                _unitOfWork.Save();
                response.Message = $"Los productos fueron registrados satisfactoriamente.";
                response.Info = true;
            }
            return response;
        }

        public ResponseServices<bool> Insert(Product product)
        {
            var response = new ResponseServices<bool>();
            Product result = _unitOfWork.ProductRepository.FirstOrDefault(f => f.ProductID.Equals(product.ProductID));

            if (result != null)
            {
                response.Message = $"El producto: {product.Description} ya existe.";
                response.Info = false;
                return response;
            }
            else
            {
                _unitOfWork.ProductRepository.Insert(product);
                _unitOfWork.Save();
                response.Message = $"El producto {product.Description} fue registrado satisfactoriamente.";
                response.Info = true;
            }
            return response;
        }

        public ResponseServices<bool> Update(Product product)
        {
            var response = new ResponseServices<bool>();
            Product result = _unitOfWork.ProductRepository.FirstOrDefault(f => f.ProductID.Equals(product.ProductID));

            if (result == null)
            {
                response.Message = $"El producto {product.Description}, no existe";
                response.Info = false;
                return response;
            }
            else
            {
                _unitOfWork.ProductRepository.Update(result);
                _unitOfWork.Save();
                response.Message = $"El producto {result.Description} fue actualzado satisfactoriamente.";
                response.Info = true;
            }
            return response;
        }

        public ResponseServices<bool> Update(List<Product> products)
        {
            var response = new ResponseServices<bool>();

            if (products.Count == 0)
            {
                response.Message = $"No existen productos para actualizar.";
                response.Info = false;
                return response;
            }
            else
            {
                foreach (var product in products)
                {
                    _unitOfWork.ProductRepository.Update(product);
                }

                _unitOfWork.Save();
                response.Message = $"Los productos fueron actualizados satisfactoriamente.";
                response.Info = true;
            }
            return response;
        }

        public ResponseServices<Product> Select(int id)
        {
            var response = new ResponseServices<Product>();
            Product result = _unitOfWork.ProductRepository.FirstOrDefault(f => f.ProductID.Equals(id));

            if (result == null)
            {
                response.Message = $"El producto: {id} no existe.";
                response.Info = null;
                return response;
            }
            else
            {
                response.Info = result;
            }
            return response;
        }

        public ResponseServices<List<ProductDto>> Select()
        {
            var response = new ResponseServices<List<ProductDto>>();
            var result = _repository.GetAllProducts().Result;
            if (result.Count != 0)
            {
                response.Info = result;
            }
            return response;
        }

        public ResponseServices<List<TotalProductByYearDto>> TotalProductByYear(DateTime intial, DateTime final)
        {
            var response = new ResponseServices<List<TotalProductByYearDto>>();
            var result = _repository.TotalProductByYear(intial, final).Result;
            if (result.Count != 0)
            {
                response.Info = result;
            }
            return response;
        }

        public ResponseServices<List<PricesByProductDto>> PricesByProduct()
        {
            var response = new ResponseServices<List<PricesByProductDto>>();
            var result = _repository.PricesByProduct().Result;
            if (result.Count != 0)
            {
                response.Info = result;
            }
            return response;
        }

        public ResponseServices<List<ProductByStockMinimumDto>> ProductByStockMinimum()
        {
            var response = new ResponseServices<List<ProductByStockMinimumDto>>();
            var result = _repository.ProductByStockMinimum().Result;
            if (result.Count != 0)
            {
                response.Info = result;
            }
            return response;
        }

        public ResponseServices<List<CustomersPaymentsTo35YearsDto>> CustomersPaymentsTo35Years()
        {
            var response = new ResponseServices<List<CustomersPaymentsTo35YearsDto>>();
            var result = _repository.CustomersPaymentsTo35Years().Result;
            if (result.Count != 0)
            {
                response.Info = result;
            }
            return response;
        }
    }
}
