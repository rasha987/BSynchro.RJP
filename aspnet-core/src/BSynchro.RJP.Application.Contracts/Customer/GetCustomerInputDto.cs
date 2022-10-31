using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace BSynchro.RJP.Customer
{
    public class GetCustomerInputDto: PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}
