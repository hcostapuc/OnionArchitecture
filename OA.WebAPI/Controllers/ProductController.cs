using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OA.Domain.Entities;
using OA.Service.Interfaces;

namespace OA.WebAPI.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        private readonly IProductDetailService productDetailService;
        public ProductController(IProductService productService, IProductDetailService productDetailsService)
        {
            this.productService = productService;
            this.productDetailService = productDetailService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var productList = await productService.GetAllAsync();

            return Ok(productList);
        }
    }
}