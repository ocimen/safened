using AutoMapper;
using SafenedAPI.Domain;
using SafenedAPI.Service.Models;

namespace SafenedAPI.Service.Mappings
{
    public class MappingProfile : Profile
    {
        //private IMapper _mapper;

        public MappingProfile()
        {
            CreateMap<BankAccount, BankAccountModel>()

                .ForMember(dest => dest.BankName, opt => opt.MapFrom(src => src.Bank.Name))
                .ForMember(dest => dest.AccountOwner, opt => opt.MapFrom(src => $"{src.User.FirstName} {src.User.LastName}"))
                .ForMember(dest => dest.Balance, opt => opt.MapFrom(src => src.Balance));

            //var config = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<BankAccount, BankAccountModel>()

            //        .ForMember(dest => dest.BankName, opt => opt.MapFrom(src => src.Bank.Name))
            //        .ForMember(dest => dest.AccountOwner, opt => opt.MapFrom(src => $"{src.User.FirstName} {src.User.LastName}"))
            //        .ForMember(dest => dest.Balance, opt => opt.MapFrom(src => src.Balance));
            //});

            // _mapper = config.CreateMapper();
        }
    }
}
