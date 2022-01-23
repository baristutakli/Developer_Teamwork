using AutoMapper;
using GenericRepositoryPattern.Models;
using GenericRepositoryPattern.Models.DTOs;
using GenericRepositoryPattern.Models.DTOs.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepositoryPattern.Services.Helpers
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(model => model.CategoryName, opts => opts.MapFrom(src => src.Category.Name))
                .ForMember(model => model.CreatedAt, opts => opts.MapFrom(src => String.Format("{0: MM.dd.yyyy HH:mm}", src.CreatedAt)))
                .ReverseMap();

            CreateMap<Product, ProductCreateDto>().ReverseMap();
            CreateMap<Product, ProductUpdateDto>().ReverseMap();


            CreateMap<Category, CategoryDto>()
                .ForMember(model => model.CreatedAt, opts => opts.MapFrom(src => String.Format("{0: MM.dd.yyyy HH:mm}", src.CreatedAt)))
                .ReverseMap();

            CreateMap<Category, CategoryUpdateDto>().ReverseMap();
            CreateMap<Category, CategoryCreateDto>().ReverseMap();

        }
    }
}
