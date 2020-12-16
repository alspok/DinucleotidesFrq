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
        public ActionResult Calculation(SequenceModels sequenceModels)
        {
            Match match = new Match();
            match.MatchSeq(sequenceModels);
            if (sequenceModels.SeqMatch)
            {
                DiCalc diCalc = new DiCalc();
                diCalc.Calc(sequenceModels);
                sequenceModels.SeqMatch = true;

                return View(sequenceModels);
            }
            else
            {
                return View("~/Views/Home/Index.cshtml", sequenceModels);
            }

            //DinucCalc dinucCalculation = new DinucCalc();
            //dinucCalculation.Calculation(multipleModel);

        }
    }
}
