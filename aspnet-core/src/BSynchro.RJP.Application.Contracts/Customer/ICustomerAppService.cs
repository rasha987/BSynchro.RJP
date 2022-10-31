using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Content;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using System.Threading.Tasks;

namespace BSynchro.RJP.Customer
{
    public interface ICustomerAppService: IApplicationService
    {
        Task<PagedResultDto<CustomerListDto>> GetListAsync(GetCustomerInputDto input);
        Task<CustomerDto> GetAsync(Guid id);
        Task AddAccountToCustomer(string customerId, double initialCredit);
    }
}
