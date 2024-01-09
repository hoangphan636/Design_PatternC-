using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Request__Delegates_MiddleWare_1_
{
    public class CreditLimitCalculator(
     CustomerCreditServiceClient customerCreditServiceClient)
    {
        public (bool HasCreditLimit, decimal? CreditLimit) Calculate(
            Customer customer,
            Company company)
        {
            return company.Type switch
            {
                CompanyType.VeryImportantClient => (false, null),
                CompanyType.ImportantClient => (true, GetCreditLimit(customer) * 2),
                _ => (true, GetCreditLimit(customer))
            };
        }

        private decimal GetCreditLimit(Customer customer)
        {
            return customerCreditServiceClient.GetCreditLimit(
                customer.FirstName,
                customer.LastName,
                customer.DateOfBirth);
        }
    }
}
