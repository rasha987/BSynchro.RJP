using AutoMapper;

namespace BSynchro.RJP;

public class RJPApplicationAutoMapperProfile : Profile
{
    public RJPApplicationAutoMapperProfile()
    {
        CreateMap<Customer.Customer, Customer.CustomerDto>();
        CreateMap<Customer.Customer, Customer.CustomerListDto>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
