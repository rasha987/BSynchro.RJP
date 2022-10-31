using BSynchro.RJP.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace BSynchro.RJP.Data
{
    public class CustomerDataSeedContributor
        : IDataSeedContributor,
        ITransientDependency
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerDataSeedContributor(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if(!await _customerRepository.AnyAsync())
            {
                try
                {
                    var customer1 = Customer.Customer.Create("123456", "test user1", "test surname1");
                    var customer2 = Customer.Customer.Create("123457", "test user2", "test surname2");
                    await _customerRepository.InsertAsync(customer1);
                    await _customerRepository.InsertAsync(customer2);
                }
                catch (Exception ex)
                {
                    return;
                }

            }
        }
    }
}
