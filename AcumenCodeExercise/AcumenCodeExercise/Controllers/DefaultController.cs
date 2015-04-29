using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace AcumenCodeExercise.Controllers
{
    public class DefaultController : ApiController
    {
        public String Get()
        {
            return string.Empty;
        }

        public ActionResult Post()
        {
            throw new NotImplementedException();
        }
    }
}
