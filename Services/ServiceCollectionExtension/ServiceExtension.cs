using AutoMapper;
using Data.Entityframework.Context;
using Microsoft.Extensions.DependencyInjection;
using Services.Abstract;
using Services.Concrete;
using Services.Profiles;

namespace Services.ServiceCollectionExtension
{
    public static class ServiceExtension
    {
        public static void LoadMyServices(this IServiceCollection services)
        {
            services.AddSingleton<BookRentalContext>();
            services.AddAutoMapper(typeof(CategoryProfile));
            services.AddScoped<ICategoryService, CategoryManager>();
        }
    }
}