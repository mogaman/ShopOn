using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp1.Data.CreditCard
{
    public interface ICreditCardService
    {
        Task<bool> CardInsert(CreditCard x);
        Task<List<CreditCard>> usersCard(int id);
    }
}