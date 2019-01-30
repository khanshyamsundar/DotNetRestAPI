using DotNetRestAPI.Dtos;
using DotNetRestAPI.Models;
using AutoMapper;

namespace DotNetRestAPI.Helpers
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AddSupplierDto, Suppliers>(); 
            CreateMap<EditSupplierDto, Suppliers>(); 
            CreateMap<Suppliers, SupplierResponseDto>(); 
        }
    }
}