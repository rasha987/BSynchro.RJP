using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace BSynchro.RJP.Customer
{
    public class Account:FullAuditedAggregateRoot<Guid>
    {
        public double InitialCredit { get;private set; }
        public Guid CustomerId { get; private set; }
        public virtual Customer Customer { get; private set; }

        private Account()
        {
        }
        private Account (double initialCredit)
        {
            InitialCredit = initialCredit;
        }
        public static Account Create (double InitialCredit)
        {
            return new Account(InitialCredit);
        }
    }
}
