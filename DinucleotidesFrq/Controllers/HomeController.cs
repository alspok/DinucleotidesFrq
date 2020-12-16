using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using DinucleotidesFrq.Models;

namespace DinucleotidesFrq.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            SequenceModels sequenceModels = new SequenceModels();

            //var mvcName = typeof(Controller).Assembly.GetName();
            //var isMono = Type.GetType("Mono.Runtime") != null;

            //ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            //ViewData["Runtime"] = isMono ? "Mono" : ".NET";

            return View(sequenceModels);
        }
    }
}
