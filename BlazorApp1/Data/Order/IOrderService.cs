using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp1.Data.Order
{
    public interface IOrderService
    {
        Task<bool> CreateOrder(int userID, int productID, long cardNumber);
        Task<List<dynamic>> GetOrdersByUser(int id);
        Task DeleteOrder(int id);
    }
}