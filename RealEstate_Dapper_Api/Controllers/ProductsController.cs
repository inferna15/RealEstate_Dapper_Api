﻿using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.ProductRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            return Ok(await _productRepository.GetAllProductAsync());
        }

        [HttpGet("ProductListWithCategory")]
        public async Task<IActionResult> ProductListWithCategory()
        {
            return Ok(await _productRepository.GetAllProductWithCatagoryAsync());
        }
    }
}
