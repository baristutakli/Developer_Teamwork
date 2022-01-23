using AutoMapper;
using GenericRepositoryPattern.Models;
using GenericRepositoryPattern.Models.DTOs;
using GenericRepositoryPattern.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductController(IProductRepository productRepository,IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var prod = _productRepository.GetAllProductsWithCategory();
            if (prod.Any())
            {
                return Ok(_mapper.Map<List<ProductDto>>(prod));
            }
            return NoContent();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var prod = await _productRepository.GetByIdWithCategory(id);
            if (prod is not null)
            {
                return Ok(_mapper.Map<ProductDto>(prod));
            }
            return NoContent();
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProductCreateDto product)
        {
           var resp =await _productRepository.Create(_mapper.Map<Product>(product));
            if(resp>0)
                return Ok("Ekleme işlemi başarılı");
            return BadRequest();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _productRepository.Delete(id);
            return Ok("Silme işlemi başarılı");
        }
        [HttpPut]
        public async Task<IActionResult> Update(int id, ProductUpdateDto product)
        {
            await _productRepository.Update(id, _mapper.Map<Product>(product));
            return Ok("Güncelleme İşlemi Başarılı");
        }
    }
}
