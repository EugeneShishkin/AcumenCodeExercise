using AcumenCodeExercise.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AcumenCodeExercise.Controllers
{
    public class EmploeesController : ApiController
    {
        private readonly IEmployeesProvider _employeesProvider;

        public EmploeesController()
        {
            _employeesProvider = new DapperEmployeesProvider(ConfigurationManager.ConnectionStrings["Sql"].ConnectionString);
        }
        
        [HttpGet]
        [Route("Employees")]
        public IEnumerable<Employee> Index()
        {
            return _employeesProvider.GetEmployees();
        }
    }
}
