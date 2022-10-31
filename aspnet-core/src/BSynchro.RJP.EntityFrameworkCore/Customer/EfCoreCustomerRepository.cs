using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BSynchro.RJP.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using System.Linq.Dynamic.Core;

namespace BSynchro.RJP.Customer
{
    internal class EfCoreCustomerRepository : EfCoreRepository<RJPDbContext, Customer, Guid>,
            ICustomerRepository
    {
        public EfCoreCustomerRepository(
            IDbContextProvider<RJPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
        public async Task<Customer> FindByCustomerIdAsync(string customerId)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.FirstOrDefaultAsync(customer => customer.CustomerId == customerId);
        }

        public async Task<List<Customer>> GetListAsync(
            int skipCount,
            int maxResultCount,
            string sorting,
            string filter = null)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet
                .WhereIf(
                    !filter.IsNullOrWhiteSpace(),
                    x => x.Name.Contains(filter)
                )
                .OrderBy(sorting)
                .Skip(skipCount)
                .Take(maxResultCount)
                .ToListAsync();
        }
    }
}
