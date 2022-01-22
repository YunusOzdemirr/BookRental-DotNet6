using AutoMapper;
using Data.Entityframework.Context;
using Entities.Concrete;
using Entities.Dtos.CategoryDtos;
using Microsoft.EntityFrameworkCore;
using Services.Abstract;
using Shared.Entities.Concrete;
using Shared.Utilities.Exceptions;

namespace Services.Concrete
{
    public class CategoryManager : ICategoryService
    {
        BookRentalContext BookRentalContext;
        IMapper Mapper;
        public CategoryManager(BookRentalContext bookRentalContext, IMapper mapper)
        {
            BookRentalContext = bookRentalContext;
            Mapper = mapper;
        }

        public async Task<Category> AddAsync(CategoryAddDto categoryAddDto)
        {
            var isExistCategory = await BookRentalContext.Categories.SingleOrDefaultAsync(a => a.Name == categoryAddDto.Name);
            if (isExistCategory is not null)// category!=null
                throw new ExistArgumentException("Bu Kategori zaten mevcut", new Error());

            var category = Mapper.Map<Category>(categoryAddDto);
            await BookRentalContext.AddAsync(category);
            await BookRentalContext.SaveChangesAsync();
            return category;
        }

        public async Task<bool> Delete(int Id)
        {
            var isExistCategory = await BookRentalContext.Categories.SingleOrDefaultAsync(a => a.Id == Id);
            if (isExistCategory is null)// category!=null
                throw new ExistArgumentException("Böyle bir kategoryi mevcut değil", new Error());

            BookRentalContext.Remove(isExistCategory);
            await BookRentalContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<Category>> GetAll()
        {
            var categories = await BookRentalContext.Categories.ToListAsync();
            return categories;
        }

        public async Task<Category> GetById(int Id)
        {
            var isExistCategory = await BookRentalContext.Categories.SingleOrDefaultAsync(a => a.Id == Id);
            if (isExistCategory is null)// category!=null
                throw new ExistArgumentException("Böyle bir kategoryi mevcut değil", new Error());

            return isExistCategory;
        }

        public async Task<Category> GetByName(string Name)
        {
            var isExistCategory = await BookRentalContext.Categories.SingleOrDefaultAsync(a => a.Name == Name);
            if (isExistCategory is null)// category!=null
                throw new ExistArgumentException("Böyle bir kategoryi mevcut değil", new Error());

            return isExistCategory;
        }

        public async Task<Category> UpdateAsync(CategoryUpdateDto updateDto)
        {
            var isExistCategory = await BookRentalContext.Categories.SingleOrDefaultAsync(a => a.Id == updateDto.Id);
            if (isExistCategory is null)// category!=null
                throw new ExistArgumentException("Böyle bir kategoryi mevcut değil", new Error());

            var newCategory = Mapper.Map<CategoryUpdateDto, Category>(updateDto, isExistCategory);
            BookRentalContext.Update(newCategory);
            await BookRentalContext.SaveChangesAsync();
            return newCategory;
        }
    }
}