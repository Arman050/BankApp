using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace BankApp.SQL
{
    public class DATABASEBank
    {
        private readonly string _connectionString;

        public DATABASEBank(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataTable ExecuteQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public void AddAccount(string accountNumber, string holderName, double creditLine)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Courant ([Number], [Name], Credit_Ligne) VALUES (@AccountNumber, @HolderName, @CreditLine)", connection))
                {
                    command.Parameters.AddWithValue("@AccountNumber", accountNumber);
                    command.Parameters.AddWithValue("@HolderName", holderName);
                    command.Parameters.AddWithValue("@CreditLine", creditLine);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}



