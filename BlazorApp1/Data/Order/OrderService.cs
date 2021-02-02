using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data.Order
{
    public class OrderService : IOrderService
    {
        //Database Connection
        private readonly SqlConnectionConfig _connectionConfig;

        public OrderService(SqlConnectionConfig connectionConfig)
        {
            _connectionConfig = connectionConfig;
        }

        //Method to create order made by user
        public async Task<bool> CreateOrder(int userID, int productID, long cardNumber)
        {
            using (var conn = new SqlConnection(_connectionConfig.Value))
            {
                DateTime orderDate = DateTime.Now;
                var parameters = new DynamicParameters();
                parameters.Add("userID", userID, DbType.Int32);
                parameters.Add("orderDate", orderDate, DbType.DateTime);
                parameters.Add("productID", productID, DbType.Int32);
                parameters.Add("cardNumber", cardNumber, DbType.Int64);

                string query = @"INSERT INTO Orders (userID, orderDate, productID, cardNumber) VALUES (@userID, @orderDate, @productID, @cardNumber)";
                await conn.ExecuteAsync(query, new { userID, orderDate, productID, cardNumber}, commandType: CommandType.Text);
            }
            return true;
        }

        //Method to list Order depending on user
        public async Task<List<dynamic>> GetOrdersByUser(int id)
        {
            using(var conn = new SqlConnection(_connectionConfig.Value))
            {
                List<dynamic> displayList = new List<dynamic>();
                conn.Open();
                string query = "SELECT Orders.orderID, Orders.orderDate, Product.productName, Orders.cardNumber FROM Orders INNER JOIN Product ON Orders.productID=Product.productID WHERE Orders.userID = '" + id + "'";

                SqlCommand comm = new SqlCommand(query, conn);
                
                using(SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dynamic dynObject = new ExpandoObject();
                        dynObject.orderID = (int)reader[0];
                        dynObject.orderDate = (DateTime)reader[1];
                        dynObject.productName = reader[2].ToString();
                        dynObject.cardNumber = (long)reader[3];
                        displayList.Add(dynObject);
                    }
                }
                conn.Close();
                return displayList;
            }
        }

        //Method to Delete Orders Made by user
        public async Task DeleteOrder(int id)
        {
            using(var conn = new SqlConnection(_connectionConfig.Value))
            {
                conn.Open();
                string query = "DELETE FROM Orders WHERE orderID = " + id;

                SqlCommand comm = new SqlCommand(query, conn);

                //ExecuteReader runs SQL Command
                comm.ExecuteReader();

                conn.Close();
            }
            //return true;
        }
        //Method to list all Orders made by all users to be displayed in admin page
        //public async Task<List<Order>> GetOrders()
        //{
        //    using (var conn = new SqlConnection(_connectionConfig.Value))
        //    {
        //        List<Order> orderList = new List<Order>();
        //        conn.Open();
        //        string query = "SELECT * FROM Orders";

        //        SqlCommand comm = new SqlCommand(query, conn);

        //        using(SqlDataReader reader = comm.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                Order o = new Order();
        //                o.orderID = reader[0];
        //            }
        //        }
        //    }
        //}
    }
}
