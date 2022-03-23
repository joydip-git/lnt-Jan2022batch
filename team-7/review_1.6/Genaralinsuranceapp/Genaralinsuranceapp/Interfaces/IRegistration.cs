using Genaralinsuranceapp.Repository;
using System.Collections.Generic;

namespace Genaralinsuranceapp.Interfaces
{
    public interface IRegistration
    {

        List<CustomerRegistration> GetALLCustomer();

        int AddCustomer(CustomerRegistration customer); 

        CustomerRegistration GetCustomerById (long CustomerId);

        
       
    }
}
