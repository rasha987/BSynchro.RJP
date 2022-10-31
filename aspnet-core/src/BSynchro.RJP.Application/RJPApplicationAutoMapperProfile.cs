using AutoMapper;
using System.Linq;
namespace BSynchro.RJP;

public class RJPApplicationAutoMapperProfile : Profile
{
    public RJPApplicationAutoMapperProfile()
    {
        CreateMap<Customer.Customer, Customer.CustomerDto>().ForMember(x=>x.Balance,option=>
        option.MapFrom(src=>src.Accounts.Sum(x=>x.InitialCredit))
            );
        CreateMap<Customer.Customer, Customer.CustomerListDto>().ForMember(x => x.Balance, option =>
           option.MapFrom(src => src.Accounts.Sum(x => x.InitialCredit))
            ); ;
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
