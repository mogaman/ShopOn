using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BlazorApp1.Data.CreditCard
{
    public class CreditCardService : ICreditCardService
    {
        //Database Connection
        private readonly SqlConnectionConfig _connectionConfig;

        public CreditCardService(SqlConnectionConfig connectionConfig)
        {
            _connectionConfig = connectionConfig;
        }

        //Method to Add CreditCard info to DB
        public async Task<bool> CardInsert(CreditCard x)
        {
            using (var conn = new SqlConnection(_connectionConfig.Value))
            {
                var parameters = new DynamicParameters();
                
                parameters.Add("userID", x.userID, DbType.Int32);
                parameters.Add("cardName", x.cardName, DbType.String);
                parameters.Add("cardNumber", x.cardNumber, DbType.Int64);
                parameters.Add("cardExpireMonth", x.cardExpireMonth, DbType.Int32);
                parameters.Add("cardExpireYear", x.cardExpireYear, DbType.Int32);
                parameters.Add("cardCVV", x.cardCVV, DbType.Int32);



                // Raw SQL method
                const string query = @"INSERT INTO CreditCard (userID, cardName, cardNumber, cardExpireMonth, cardExpireYear, cardCVV) VALUES (@userID, @cardName, @cardNumber, @cardExpireMonth, @cardExpireYear, @cardCVV)";
                await conn.ExecuteAsync(query, new { x.userID, x.cardName, x.cardNumber, x.cardExpireMonth, x.cardExpireYear, x.cardCVV }, commandType: CommandType.Text);

            }
            return true;
        }

        //Method to get users CreditCard Info
        public async Task<List<CreditCard>> usersCard(int id)
        {
            using(var conn = new SqlConnection(_connectionConfig.Value))
            {
                conn.Open();
                List<CreditCard> cardList = new List<CreditCard>();
                string query = @"SELECT * FROM CreditCard WHERE userID = '" + id + "'";
                SqlCommand comm = new SqlCommand(query, conn);

                using(SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CreditCard card = new CreditCard();
                        card.cardNumber = (long)reader[1];
                        card.cardName = reader[2].ToString();
                        card.cardExpireMonth = (int)reader[3];
                        card.cardExpireYear = (int)reader[4];
                        card.cardCVV = (int)reader[5];
                        cardList.Add(card);
                    }
                }
                conn.Close();
                return cardList;
            }
        }
    }
}
