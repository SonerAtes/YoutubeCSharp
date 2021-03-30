using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Adepters
{
    class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikDogrula(Convert.ToInt64(customer.NationalityId),customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);
        }
    }
}
