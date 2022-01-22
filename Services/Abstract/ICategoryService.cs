using Entities.Concrete;
using Entities.Dtos.CategoryDtos;

namespace Services.Abstract
{
    public interface ICategoryService
    {
        Task<Category> AddAsync(CategoryAddDto categoryAddDto);
        Task<Category> UpdateAsync(CategoryUpdateDto updateDto);
        Task<List<Category>> GetAll();
        Task<Category> GetById(int Id);
        Task<Category> GetByName(string Name);
        Task<bool> Delete(int Id);
    }
}