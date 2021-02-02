using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public interface ICustomerService
    {
        Task<int> CustomerInsert(Customer x);
        Task<Customer> CustomerLogin(string email, string password);
        Task<List<Customer>> CustomerGet();
        Task DeleteCustomer(int id);
        Task EditCustomer(Customer c);
    }
}