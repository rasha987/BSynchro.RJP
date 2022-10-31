using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BSynchro.RJP.Customer;
using Volo.Abp.Application.Dtos;

namespace BSynchro.RJP.Controllers.Customer
{
    public class RJPCustomerController:RJPController,ICustomerAppService
    {
        private readonly ICustomerAppService _customerAppService;
        public RJPCustomerController(ICustomerAppService customerAppService)
        {
            _customerAppService = customerAppService;
        }

        public Task AddAccountToCustomer(string customerId, double initialCredit)
        {
            return _customerAppService.AddAccountToCustomer(customerId, initialCredit);
        }

        public Task<CustomerDto> GetAsync(Guid id)
        {
            return _customerAppService.GetAsync(id);
        }

        public Task<PagedResultDto<CustomerListDto>> GetListAsync(GetCustomerInputDto input)
        {
            return _customerAppService.GetListAsync(input);
        }
    }
}
