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
            MultipleModel multipleModel = new MultipleModel();

            //var mvcName = typeof(Controller).Assembly.GetName();
            //var isMono = Type.GetType("Mono.Runtime") != null;

            //ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            //ViewData["Runtime"] = isMono ? "Mono" : ".NET";

            return View(multipleModel);
        }
    }
}

/*
<tbody>
                        <tr>
                            <td>1st frame</td>
                                @foreach(var item in Model.Dinuc.dinucleotides)
{< td > @item.Dunuc1stFrameFrq </ td >}
                        </tr>
                        <tr>
                            <td>2nd frame</td>
                                @foreach(var item in Model.Dinuc.dinucleotides)
{< td > @item.Dunuc2ndFrameFrq </ td >}
                        </tr>
                        <tr>
                            <td>Dinuc diff</td>
                                @foreach(var item in Model.Dinuc.dinucleotides)
{< td > @item.DunucFrqDiff </ td >}
                        </tr>
                        
                    </tbody>
*/