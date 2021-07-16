using DW.Billing.Models;
using DW.Billing.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DW.Billing.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _services;
        public ProductController(IProductService services)
        {
            _services = services;
        }


        [HttpGet("AllProducts")]
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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
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

        [HttpGet("PriceByProduct")]
        public async Task<IActionResult> PriceByProduct()
        {
            return await Task.Run(() =>
            {
                try
                {
                    var result = _services.PricesByProduct();
                    return Ok(result);
                }
                catch (Exception)
                {
                    return Ok(500);
                }
            });
        } 

        [HttpPost("SaveProducts")]
        public async Task<IActionResult> Save([FromBody] List<Product> products)
        {
            return await Task.Run(() =>
            {
                try
                {
                    var result = _services.Insert(products);
                    return Ok(result);
                }
                catch (Exception)
                {
                    return Ok(500);
                }
            });
        }

        [HttpPost("SaveProduct")]
        public async Task<IActionResult> Save([FromBody] Product product)
        {
            return await Task.Run(() =>
            {
                try
                {
                    var result = _services.Insert(product);
                    return Ok(result);
                }
                catch (Exception)
                {
                    return Ok(500);
                }
            });
        }

        [HttpPost("UpdateProduct")]
        public async Task<IActionResult> Update([FromBody] Product product)
        {
            return await Task.Run(() =>
            {
                try
                {
                    var result = _services.Update(product);
                    return Ok(result);
                }
                catch (Exception)
                {
                    return Ok(500);
                }
            });
        }

        [HttpPost("UpdateProducts")]
        public async Task<IActionResult> Update([FromBody] List<Product> products)
        {
            return await Task.Run(() =>
            {
                try
                {
                    var result = _services.Update(products);
                    return Ok(result);
                }
                catch (Exception)
                {
                    return Ok(500);
                }
            });
        }

        [HttpPost("DeleteProducts")]
        public async Task<IActionResult> Delete([FromBody] List<Product> products)
        {
            return await Task.Run(() =>
            {
                try
                {
                    var result = _services.Delete(products);
                    return Ok(result);
                }
                catch (Exception)
                {
                    return Ok(500);
                }
            });
        }

        [HttpPost("DeleteProduct/{id}")]
        public async Task<IActionResult> Delete( int id)
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

    }
}
