using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Dapper;

namespace AcumenCodeExercise.Models
{
    public class DapperProductsProvider : IProductsProvider
    {

        private readonly string _connectionString;

        public DapperProductsProvider(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Product> GetProducts()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var result = connection.Query<Product>(
                    DapperProductSql.GetProducts);

                return result.ToList();
            }
        }

        public void Add(Product p)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                connection.Execute(
                    DapperProductSql.Add,
                    new { pProductId = p.ProductID, 
                          pProductName = p.ProductName, 
                          pSupplierID = p.SupplierID,
                          pCategoryID = p.CategoryID,
                          pQuantityPerUnit = p.QuantityPerUnit,
                          pUnitPrice = p.UnitPrice, 
                          pUnitsInStock = p.UnitsInStock,
                          pUnitsOnOrder = p.UnitsOnOrder,
                          pReorderLevel = p.ReorderLevel,
                          pDiscontinued = p.Discontinued});
            }
        }
    }
}