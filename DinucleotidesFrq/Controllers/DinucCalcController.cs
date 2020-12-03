using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DinucleotidesFrq.Models;
using DinucleotidesFrq.DinucCalculation;

namespace DinucleotidesFrq.Controllers
{
    public class DinucCalcController : Controller
    {
        public ActionResult Calculation(MultipleModel multipleModel)
        {
            //DinucCalc dinucCalculation = new DinucCalc();
            //dinucCalculation.Calculation(multipleModel);
            DiCalc diCalc = new DiCalc();
            diCalc.Calc(multipleModel);

            return View (multipleModel);
        }
    }
}
