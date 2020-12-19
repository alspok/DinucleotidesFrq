using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DinucleotidesFrq.Models;

namespace DinucleotidesFrq.Controllers
{
    public class TestController : Controller
    {
        public ActionResult Test()
        {
            TestModel testModel = new TestModel();

            return View (testModel);
        }
    }
}
