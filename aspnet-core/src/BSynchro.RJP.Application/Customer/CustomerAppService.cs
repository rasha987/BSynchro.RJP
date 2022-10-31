using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;

namespace BSynchro.RJP.Customer
{
    public class CustomerAppService: RJPAppService, ICustomerAppService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerAppService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task AddAccountToCustomer(string customerId, double initialCredit)
        {
            var customer = await FindByCustomerIdAsync(customerId);
            if (customer == null)
                throw new UserFriendlyException("CustomerId not found!");
            if (initialCredit == 0)
                throw new UserFriendlyException("initial Credit amount should not be zero!");
            customer.AddAccount(initialCredit);
            await _customerRepository.UpdateAsync(customer,true);
        }

        private async Task<Customer> FindByCustomerIdAsync(string customerId)
        {
            var result=await _customerRepository.FindByCustomerIdAsync(customerId);
            return result;
        }

        public async Task<CustomerDto> GetAsync(Guid id)
        {
            var result = (await _customerRepository.WithDetailsAsync(x=>x.Accounts)).FirstOrDefault(x=>x.Id==id);
            return ObjectMapper.Map<Customer, CustomerDto>(result);
        }

        public async Task<PagedResultDto<CustomerListDto>> GetListAsync(GetCustomerInputDto input)
        {
            if (input.Sorting.IsNullOrWhiteSpace())
            {
                input.Sorting = nameof(Customer.Name);
            }

            var result = await _customerRepository.GetListAsync(
                input.SkipCount,
                input.MaxResultCount,
                input.Sorting,
                input.Filter
            );

            var totalCount = input.Filter == null
                ? await _customerRepository.CountAsync()
                : await _customerRepository.CountAsync(x => x.Name.Contains(input.Filter));

            return new PagedResultDto<CustomerListDto>(
                 totalCount,
                 ObjectMapper.Map<List<Customer>, List<CustomerListDto>>(result)
             );
        }
    }
}
