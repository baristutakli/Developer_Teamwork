using AutoMapper;
using GenericRepositoryPattern.Models;
using GenericRepositoryPattern.Models.DTOs.CategoryDtos;
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
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryController(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var cat = _categoryRepository.GetAll();
            if (cat.Any())
            {
                return Ok(_mapper.Map<List<CategoryDto>>(cat));
            }
            return NoContent();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var prod = await _categoryRepository.GetById(id);
            if (prod is not null)
            {
                return Ok(_mapper.Map<CategoryDto>(prod));
            }
            return NoContent();
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CategoryCreateDto category)
        {
            var resp = await _categoryRepository.Create(_mapper.Map<Category>(category));
            if (resp > 0)
                return Ok("Ekleme işlemi başarılı");
            return BadRequest();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _categoryRepository.Delete(id);
            return Ok("Silme işlemi başarılı");
        }
        [HttpPut]
        public async Task<IActionResult> Update(int id, CategoryUpdateDto category)
        {
            await _categoryRepository.Update(id, _mapper.Map<Category>(category));
            return Ok("Güncelleme İşlemi Başarılı");
        }

    }
}
