using AutoMapper;
using WebApiProject.AppDbContext;
using WebApiProject.Model;

namespace WebApiClient.Configurations
{
    public class MapperConfig :Profile
    {
        public MapperConfig()
        {
            CreateMap<Product,CreateProductDTO>().ReverseMap();
            CreateMap<Product, GetProductDTO>().ReverseMap();
            CreateMap<APIUser,APIUserDTO>().ReverseMap();
            CreateMap<Bookings, GetBookingDTO>().ReverseMap();

        }
    }
}
