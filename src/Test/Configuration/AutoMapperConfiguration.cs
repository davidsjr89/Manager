using API.ViewModels;
using AutoMapper;
using Domain.Entities;
using Services.DTO;

namespace Test.Configuration
{
    public static class AutoMapperConfiguration
    {
        public static IMapper GetConfiguration()
        {
            var autoMapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDTO>()
                    .ReverseMap();

                cfg.CreateMap<CreateUserViewModel, UserDTO>()
                                    .ReverseMap();

                cfg.CreateMap<UpdateUserViewModel, UserDTO>()
                    .ReverseMap();
            });
            return autoMapperConfig.CreateMapper();
        }
    }
}