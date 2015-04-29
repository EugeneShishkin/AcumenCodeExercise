using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcumenCodeExercise.Models;
using System.Configuration;

namespace AcumenCodeExercise.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrdersProvider _ordersProvider;

        public OrdersController()
        {
            _ordersProvider = new DapperOrdersProvider(ConfigurationManager.ConnectionStrings["Sql"].ConnectionString);
        }

        // GET: Orders
        public ActionResult Index()
        {
            var model = _ordersProvider.GetOrders("USA");

            return View(model);
        }

        // GET: Orders/Details/5
        public ActionResult Details(int id)
        {
            var order = _ordersProvider.GetOrder(id);
            var orderContent =  _ordersProvider.GetProductPositionInfo(id);

            ViewBag.Content = orderContent;
            return View(order);
        }

    }
}
