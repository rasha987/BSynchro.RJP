using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace BSynchro.RJP.Customer
{
    public class CustomerManager: DomainService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerManager(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public CustomerManager()
        {

        }
        public async Task<double> GetBalance(Guid id)
        {
            var currentCustomer =(await _customerRepository.GetAsync(x => x.Id == id));
            return currentCustomer.Accounts.Sum(x=>x.InitialCredit);
        }
        public async Task<bool> IsExsitingCustomer(Guid id)
        {
            var currentCustomer = (await _customerRepository.GetAsync(x => x.Id == id));
            if (currentCustomer!= null) return true;
            return false;
        }
    }
}
