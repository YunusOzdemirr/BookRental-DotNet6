using AutoMapper;
using Entities.Concrete;
using Entities.Dtos.CategoryDtos;

namespace Services.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryAddDto>().ReverseMap();
            CreateMap<Category, CategoryUpdateDto>().ReverseMap();
        }
    }
}