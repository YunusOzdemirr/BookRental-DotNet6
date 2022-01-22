using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Entities.Dtos.CategoryDtos;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        //https://localhost:7202/api/categories/AddAsync
        //{
        //"Name":"Çocuk"
        //}
        ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("GetAllAsync")]
        public async Task<List<Category>> GetAllAsync()
        {
            return await _categoryService.GetAll();
        }
        [HttpGet("GetById")]
        public async Task<Category> GetById(int Id)
        {
            return await _categoryService.GetById(Id);
        }
        [HttpGet("GetByName")]
        public async Task<Category> GetByName(string Name)
        {
            return await _categoryService.GetByName(Name);
        }

        [HttpDelete("DeleteAsync")]
        public async Task<bool> Delete(int id)
        {
            return await _categoryService.Delete(id);
        }

        [HttpPost("AddAsync")]
        public async Task<Category> AddAsync(CategoryAddDto addDto)
        {
            return await _categoryService.AddAsync(addDto);
        }
        [HttpPost("UpdateAsync")]
        public async Task<Category> UpdateAsync(CategoryUpdateDto updateDto)
        {
            return await _categoryService.UpdateAsync(updateDto);
        }
    }
}