using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace BSynchro.RJP.Customer
{
    public class CustomerDto:FullAuditedEntityDto<Guid>
    {
        public string CustomerId { get;  set; }
        public string Name { get;  set; }
        public string Surname { get;  set; }
        public double Balance { get; set; }
        public List<AccountDto> Accounts { get; set; }


    }
}
