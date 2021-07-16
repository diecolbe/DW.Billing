using DW.Billing.Models;
using DW.Billing.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DW.Billing.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class InvoiceController : Controller
    {
        private readonly IInvoiceService _services;
        public InvoiceController(IInvoiceService services)
        {
            _services = services;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return await Task.Run(() =>
            {
                try
                {
                    var result = _services.Select(id);
                    return Ok(result);
                }
                catch (Exception)
                {
                    return Ok(500);
                }
            });
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return await Task.Run(() =>
            {
                try
                {
                    var result = _services.Select();
                    return Ok(result);
                }
                catch (Exception)
                {
                    return Ok(500);
                }
            });
        }

        [HttpPost("SaveInvoice")]
        public async Task<IActionResult> Save([FromBody] Invoice invoice)
        {
            return await Task.Run(() =>
            {
                try
                {
                    var result = _services.Insert(invoice);
                    return Ok(result);
                }
                catch (Exception)
                {
                    return Ok(500);
                }
            });
        }

        [HttpPost("DeleteInvoice/{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            return await Task.Run(() =>
            {
                try
                {
                    var result = _services.Delete(id);
                    return Ok(result);
                }
                catch (Exception)
                {
                    return Ok(500);
                }
            });
        }

        [HttpPost("UpdateInvoice/{id}")]
        public async Task<IActionResult> Update([FromBody] Invoice invoice)
        {
            return await Task.Run(() =>
            {
                try
                {
                    var result = _services.Update(invoice);
                    return Ok(result);
                }
                catch (Exception)
                {
                    return Ok(500);
                }
            });
        }
    }
}
