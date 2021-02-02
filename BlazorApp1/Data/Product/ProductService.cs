using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class ProductService : IProductService
    {
        //Database Connection
        private readonly SqlConnectionConfig _connectionConfig;

        public ProductService(SqlConnectionConfig connectionConfig)
        {
            _connectionConfig = connectionConfig;
        }

        //Method to get List of all Products and place into List of Products
        public async Task<List<Product>> PublicProductList()
        {
            using (var conn = new SqlConnection(_connectionConfig.Value))
            {
                conn.Open();
                List<Product> productList = new List<Product>();
                string query = @"SELECT * from Product WHERE productQuantity > 0";
                SqlCommand comm = new SqlCommand(query, conn);

                using(SqlDataReader reader = comm.ExecuteReader())
                {
                    //reader.Read checks for any columns
                    while (reader.Read())
                    {
                        Product prod = new Product();
                        prod.productID = (int)reader[0];
                        prod.productName = reader[1].ToString();
                        prod.productDescription = reader[2].ToString();
                        prod.productPrice = (decimal)reader[3];
                        prod.productQuantity = (int)reader[4];

                        productList.Add(prod);
                    }
                }
                conn.Close();
                return productList;
            }
        }

        //Method to get List of all Products
        public async Task<List<Product>> ProductList()
        {
            using (var conn = new SqlConnection(_connectionConfig.Value))
            {
                conn.Open();
                List<Product> productList = new List<Product>();
                string query = @"SELECT * from Product";
                SqlCommand comm = new SqlCommand(query, conn);

                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    //reader.Read checks for any columns
                    while (reader.Read())
                    {
                        Product prod = new Product();
                        prod.productID = (int)reader[0];
                        prod.productName = reader[1].ToString();
                        prod.productDescription = reader[2].ToString();
                        prod.productPrice = (decimal)reader[3];
                        prod.productQuantity = (int)reader[4];

                        productList.Add(prod);
                    }
                }
                conn.Close();
                return productList;
            }
        }

        //Method for user to search product based on name
        public async Task<List<Product>> SearchProduct(string v)
        {
            using(var conn = new SqlConnection(_connectionConfig.Value))
            {
                conn.Open();
                List<Product> productList = new List<Product>();
                string query = "SELECT * FROM Product WHERE productName='" + v + "'";
                SqlCommand comm = new SqlCommand(query, conn);

                using(SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product prod = new Product();
                        prod.productID = (int)reader[0];
                        prod.productName = reader[1].ToString();
                        prod.productDescription = reader[2].ToString();
                        prod.productPrice = (decimal)reader[3];
                        prod.productQuantity = (int)reader[4];

                        productList.Add(prod);
                    }
                }
                conn.Close();
                return productList;
            }
        }

        //Method for admin to delete product
        public async Task<bool> DeleteProduct(int id)
        {
            using(var conn = new SqlConnection(_connectionConfig.Value))
            {
                conn.Open();
                string query = "DELETE FROM Product WHERE productID = '" + id + "'";

                SqlCommand comm = new SqlCommand(query, conn);
                comm.ExecuteReader();

                conn.Close();
            }
            return true;
        }

        //Method for admin to edit Product
        public async Task EditProduct(Product p)
        {
            using(var conn = new SqlConnection(_connectionConfig.Value))
            {
                conn.Open();
                string query = "UPDATE Product SET productName = '" + p.productName + "', productDescription = '" + p.productDescription + "', productPrice = '" + p.productPrice + "', productQuantity = '" + p.productQuantity + "' WHERE productID = " + p.productID;

                SqlCommand comm = new SqlCommand(query, conn);
                comm.ExecuteReader();

                conn.Close();
            }
        }

        //Method for admin to add Products
        public async Task AddProduct(Product p)
        {
            using(var conn = new SqlConnection(_connectionConfig.Value))
            {
                conn.Open();
                string query = "INSERT INTO Product(productName, productDescription, productPrice, productQuantity) VALUES('" + p.productName + "', '" + p.productDescription + "', " + p.productPrice + ", " + p.productQuantity + ");";

                await conn.ExecuteAsync(query, new { p.productName, p.productDescription, p.productPrice, p.productQuantity }, commandType: CommandType.Text);
            }
        }
    }
}
