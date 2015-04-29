using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;

namespace AcumenCodeExercise.Models
{
    public class DapperEmployeesProvider : IEmployeesProvider
    {
        private readonly string _connectionString;

        public DapperEmployeesProvider(string connectionString)
        {
            _connectionString = connectionString;
        }

    
        public IEnumerable<Employee> GetEmployees()
        {
 	         using (var connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();

                        var result = connection.Query<Employee>(
                            DapperEmployeeSql.GetEmployees);
                
                        return result.ToList();
                    }
        }
}
}