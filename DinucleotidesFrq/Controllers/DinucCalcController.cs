using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DinucleotidesFrq.Helpers;
using DinucleotidesFrq.Models;
using DinucleotidesFrq.DinucCalculation;

namespace DinucleotidesFrq.Controllers
{
    public class DinucCalcController : Controller
    {
        public ActionResult Calculation(MultipleModel multipleModel)
        {
            Match match = new Match();
            match.MatchSeq(multipleModel);
            if (multipleModel.Seq.SeqMatch)
            {
                DiCalc diCalc = new DiCalc();
                diCalc.Calc(multipleModel);
                multipleModel.Seq.SeqMatch = true;

                return View(multipleModel);
            }
            else
            {
                return View("~/Views/Home/Index.cshtml", multipleModel);
            }

            //DinucCalc dinucCalculation = new DinucCalc();
            //dinucCalculation.Calculation(multipleModel);

        }
    }
}
