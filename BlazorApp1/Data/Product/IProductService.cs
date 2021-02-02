using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public interface IProductService
    {
        Task<List<Product>> PublicProductList();
        Task<List<Product>> ProductList();
        Task<List<Product>> SearchProduct(string v);
        Task<bool> DeleteProduct(int id);
        Task EditProduct(Product p);
        Task AddProduct(Product p);
    }
}