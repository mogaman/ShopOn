using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class CustomerService : ICustomerService
    {
        //Database Connection
        private readonly SqlConnectionConfig _connectionConfig;

        public CustomerService(SqlConnectionConfig connectionConfig)
        {
            _connectionConfig = connectionConfig;
        }

        //Add (create) object table row (SQL Insert)
        public async Task<int> CustomerInsert(Customer x)
        {
            using (var conn = new SqlConnection(_connectionConfig.Value))
            {
                conn.Open();
                var parameters = new DynamicParameters();
                parameters.Add("userName", x.userName, DbType.String);
                parameters.Add("userPassword", x.userPassword, DbType.String);
                parameters.Add("userEmail", x.userEmail, DbType.String);

                // Raw SQL method
                const string query = @"INSERT INTO Customer (userName, userPassword, userEmail) VALUES (@userName, @userPassword, @userEmail)";
                await conn.ExecuteAsync(query, new { x.userName, x.userPassword, x.userEmail }, commandType: CommandType.Text);

                string endQuery = @"SELECT userID from Customer WHERE userEmail = '" + x.userEmail + "'";
                SqlCommand cmm = new SqlCommand(endQuery, conn);
                
                using(SqlDataReader reader = cmm.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return (int)reader[0];
                        
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
        
        //Method to log customer in
        public async Task<Customer> CustomerLogin(string email, string password)
        {
            using(var conn = new SqlConnection(_connectionConfig.Value))
            {
                conn.Open();
                Customer cust = new Customer();
                string query = @"SELECT * from Customer WHERE userEmail = '" + email + "' AND userPassword = '" + password + "'";

                SqlCommand cmm = new SqlCommand(query, conn);

                //int id = (int)param.Value;
                await conn.ExecuteAsync(query, commandType: CommandType.Text);

                //SqlDataReader checks if there's an existing 
                using(SqlDataReader reader = cmm.ExecuteReader())
                {
                    //reader.Read checks if there's a column that exists
                    if (reader.Read())
                    {
                        cust.userID = (int)reader[0];
                        cust.userName = reader[1].ToString();
                        cust.userPassword = reader[2].ToString();
                        cust.userEmail = reader[3].ToString();
                        return cust;
                    }
                    else
                    {
                        return cust;
                    }
                }
                conn.Close();
                
            }
        }

        //Method to show all Cutomers in Admin Page
        public async Task<List<Customer>> CustomerGet()
        {
            List<Customer> customerList = new List<Customer>();
            using (var conn = new SqlConnection(_connectionConfig.Value))
            {
                conn.Open();
                string query = @"SELECT * FROM Customer";
                SqlCommand comm = new SqlCommand(query, conn);
                using(SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Customer cust = new Customer();
                        cust.userID = (int)reader[0];
                        cust.userName = reader[1].ToString();
                        cust.userPassword = reader[2].ToString();
                        cust.userEmail = reader[3].ToString();

                        customerList.Add(cust);
                    }
                }
                conn.Close();
            }
            return customerList;
        }
        
        //Method to delete Customer in Admin Page
        public async Task DeleteCustomer(int id)
        {
            using(var conn = new SqlConnection(_connectionConfig.Value))
            {
                conn.Open();
                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "DELETE FROM Orders WHERE userID = " + id + "; DELETE FROM CreditCard WHERE userID = " + id + "DELETE FROM Customer WHERE userID = " + id + ";";

                comm.ExecuteReader();
                //List<string> queries = new List<string>();
                //queries.Add("DELETE FROM Orders WHERE userID = " + id);
                //queries.Add("DELETE FROM CreditCard WHERE userID = " + id);
                //queries.Add("DELETE FROM Customer WHERE userID = " + id);

                //foreach(string query in queries)
                //{
                //    SqlCommand comm = new SqlCommand(query, conn);
                //    comm.ExecuteReader();
                //}            

                conn.Close();
            }
        }

        //Method to edit Customer in Admin Page
        public async Task EditCustomer(Customer c)
        {
            using(var conn = new SqlConnection(_connectionConfig.Value))
            {
                conn.Open();
                string query = "UPDATE Product SET userName = '" + c.userName + "', userPassword = '" + c.userPassword + "', userEmail = '" + c.userEmail + "' WHERE userID = " + c.userID;

                SqlCommand comm = new SqlCommand(query, conn);
                comm.ExecuteReader();

                conn.Close();
            }
        }
    }
}
