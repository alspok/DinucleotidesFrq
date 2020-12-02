using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DinucleotidesFrq.Models;

namespace DinucleotidesFrq.Controllers
{
    public class DinucCalcController : Controller
    {
        public ActionResult Calculation(MultipleModel multipleModel)
        {
            return View (multipleModel);
        }
    }
}
