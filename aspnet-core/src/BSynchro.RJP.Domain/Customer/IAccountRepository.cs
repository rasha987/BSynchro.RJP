using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace BSynchro.RJP.Customer
{
    public interface IAccountRepository:IRepository<Account,Guid>
    {
    }
}
