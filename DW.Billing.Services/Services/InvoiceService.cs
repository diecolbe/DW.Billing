using DW.Billing.Common;
using DW.Billing.Models;
using DW.Billing.ORM.UnitOfWork;
using DW.Billing.Services.Interfaces;
using System.Collections.Generic;

namespace DW.Billing.Services.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IUnitOfWork _unitOfWork;

        public InvoiceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ResponseServices<bool> Delete(string id)
        {
            var response = new ResponseServices<bool>();
            Product result = _unitOfWork.ProductRepository.FirstOrDefault(f => f.ProductID.Equals(id));

            if (result == null)
            {
                response.Message = $"La factura: {id} no existe.";
                response.Info = false;
                return response;
            }
            else
            {
                _unitOfWork.InvoiceDetailRepository.Delete(result);
                _unitOfWork.Save();
                response.Message = $"La factura: {id} ha sido eliminada satisfactoriamente.";
                response.Info = true;
            }
            return response;
        }

        public ResponseServices<bool> Delete(List<Invoice> invoices)
        {
            var response = new ResponseServices<bool>();

            if (invoices.Count == 0)
            {
                response.Message = $"No existen facturas para eliminar.";
                response.Info = false;
                return response;
            }
            else
            {
                foreach (var invoice in invoices)
                {
                    _unitOfWork.InvoiceDetailRepository.Delete(invoice);
                }

                _unitOfWork.Save();
                response.Message = $"Las facturas fueron eliminados satisfactoriamente.";
                response.Info = true;
            }
            return response;
        }

        public ResponseServices<bool> Insert(List<Invoice> invoices)
        {
            var response = new ResponseServices<bool>();

            if (invoices.Count == 0)
            {
                response.Message = $"No existen facturas para registrar.";
                response.Info = false;
                return response;
            }
            else
            {
                foreach (var invoice in invoices)
                {
                    Invoice result = _unitOfWork.InvoiceRepository.FirstOrDefault(f => f.InvoiceNumber.Equals(invoice.InvoiceNumber));
                    if (result == null)
                    {
                        _unitOfWork.InvoiceRepository.Insert(result);
                    }
                }
                _unitOfWork.Save();
                response.Message = $"Las facturas fueron registradas satisfactoriamente.";
                response.Info = true;
            }
            return response;
        }

        public ResponseServices<bool> Insert(Invoice invoice)
        {
            var response = new ResponseServices<bool>();
            Invoice result = _unitOfWork.InvoiceRepository.FirstOrDefault(f => f.InvoiceNumber.Equals(invoice.InvoiceNumber));

            if (result != null)
            {
                response.Message = $"La factura: {invoice.InvoiceNumber} ya existe.";
                response.Info = false;
                return response;
            }
            else
            {
                _unitOfWork.InvoiceRepository.Insert(invoice);
                foreach (var detail in invoice.InvoiceDetail)
                {
                    var product = _unitOfWork.ProductRepository.FirstOrDefault(f => f.ProductID == detail.ProductID);
                    if (product != null)
                    {
                        //Se descuenta del inventario
                        product.Stock = product.Stock - detail.Amount;
                        _unitOfWork.ProductRepository.Update(product);
                    }
                }
                _unitOfWork.Save();
                response.Message = $"La factura {invoice.InvoiceNumber} fue registrada satisfactoriamente.";
                response.Info = true;
            }
            return response;
        }

        public ResponseServices<Invoice> Select(string id)
        {
            var response = new ResponseServices<Invoice>();
            Invoice result = _unitOfWork.InvoiceRepository.FirstOrDefault(f => f.InvoiceNumber.Equals(id));

            if (result == null)
            {
                response.Message = $"La factura: {id} no existe.";
                response.Info = null;
                return response;
            }
            else
            {
                response.Info = result;
            }
            return response;
        }

        public ResponseServices<IEnumerable<Invoice>> Select()
        {
            var response = new ResponseServices<IEnumerable<Invoice>>();
            response.Info = _unitOfWork.InvoiceRepository.GetAll();
            return response;
        }

        public ResponseServices<bool> Update(Invoice invoice)
        {
            var response = new ResponseServices<bool>();
            Invoice result = _unitOfWork.InvoiceRepository.FirstOrDefault(f => f.InvoiceNumber.Equals(invoice.InvoiceNumber));

            if (result == null)
            {
                response.Message = $"La factura: {invoice.InvoiceNumber}, no existe";
                response.Info = false;
                return response;
            }
            else
            {
                _unitOfWork.InvoiceRepository.Update(result);
                _unitOfWork.Save();
                response.Message = $"La factura {result.InvoiceNumber} fue actualzada satisfactoriamente.";
                response.Info = true;
            }
            return response;
        }

        public ResponseServices<bool> Update(List<Invoice> invoices)
        {
            var response = new ResponseServices<bool>();

            if (invoices.Count == 0)
            {
                response.Message = $"No existen facturas para actualizar.";
                response.Info = false;
                return response;
            }
            else
            {
                foreach (var invoice in invoices)
                {
                    _unitOfWork.InvoiceRepository.Update(invoice);
                }

                _unitOfWork.Save();
                response.Message = $"Las facturas fueron actualizadas satisfactoriamente.";
                response.Info = true;
            }
            return response;
        }
    }
}
