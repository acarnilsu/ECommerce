using AutoMapper;
using ECommerce.API.DTOs;
using ECommerce.BusinessLayer.Abstract;
using ECommerce.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ProductList()
        {
            var values=_productService.TGetAll().Take(12).ToList();
            var productDto = _mapper.Map<List<ProductListDto>>(values);
            return Ok(productDto);
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductAddDto productAddDto)
        {
            var products = _mapper.Map<Product>(productAddDto);
            products.Id = Guid.NewGuid().ToString();
            await _productService.TAddAsync(products);
            return NoContent();    //kayıt yaptığım için geriye bir şey dönmeme gerek yok
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(string id)
        {
            var values =await _productService.TGetByIdAsync(id);
            return Ok(values);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(ProductUpdateDto productUpdateDto)
        {
            var values =await _productService.TGetByIdAsync(productUpdateDto.Id);
            values.barcode = productUpdateDto.barcode;
            values.name= productUpdateDto.name;
            values.stock= productUpdateDto.stock;
            values.price= productUpdateDto.price;
            values.imageUrl1 = productUpdateDto.imageUrl1;
            _productService.TUpdate(values);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(string id)
        {
            var values = await _productService.TGetByIdAsync(id);
            _productService.TRemove(values);
            return NoContent();
        }
    }
}
