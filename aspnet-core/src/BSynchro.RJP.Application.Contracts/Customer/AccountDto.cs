using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace BSynchro.RJP.Customer
{
    public class AccountDto: FullAuditedEntityDto<Guid>
    {
        public double InitialCredit { get;  set; }
    }
}
