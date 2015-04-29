using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Dapper;

namespace AcumenCodeExercise.Models
{
    public class DapperOrdersProvider : IOrdersProvider
    {
        private readonly string _connectionString;

        public DapperOrdersProvider(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Order> GetOrders(string country)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var result = connection.Query<Order>(
                    DapperOrderSql.GetOrders,
                    new { Country = country });
                
                return result.ToList();
            }
        }

        public IEnumerable<OrderProductInfo> GetProductPositionInfo(int orderId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var result = connection.Query<OrderProductInfo>(
                    DapperOrderSql.GetOrderProductInfo,
                    new { OID = orderId });

                return result.ToList();
            }
        }



        public Order GetOrder(int orderId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var result = connection.Query<Order>(
                    DapperOrderSql.GetOrder,
                    new { OID = orderId });

                return result.First();
            }
        }
    }
}