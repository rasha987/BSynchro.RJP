using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace BSynchro.RJP.Customer
{
    public class Customer:FullAuditedAggregateRoot<Guid>
    {
        public string CustomerId { get;private set; }
        public string Name { get;private set; }
        public string Surname { get;private set; }
        public ICollection<Account> Accounts { get; private set; }


        private Customer ()
        { }

        private Customer(string customerId, string name,string surname)
        {
            CustomerId = customerId;
            Name = name;
            Surname = surname;
            Accounts= new List<Account> ();
        }
        public static Customer Create(string customerId, string name, string surname)
        {
            return new Customer (customerId, name, surname);
        }

        public void AddAccount(double initialCredit)
        {
            if(initialCredit!= 0)
              Accounts.Add(Account.Create(initialCredit));
        }
    }
}
