using System.Web.Mvc;
using DinucleotidesFrq.Models;

namespace DinucleotidesFrq.Controllers
{
    public class TestController : Controller
    {
        public ActionResult Test()
        {
            TestModel testModel = new TestModel();

            //testModel.SeqList().Add(new SelectListItem { Text = "aaaaaaaa", Value = "1" });
            //testModel.SeqList().Add(new SelectListItem { Text = "cccccccc", Value = "2" });
            //testModel.SeqList().Add(new SelectListItem { Text = "gggggggg", Value = "3" });
            //testModel.SeqList().Add(new SelectListItem { Text = "ttttttttttttttt", Value = "4" });

            testModel.SeqFileList.Add(new SelectListItem { Text = "Physics", Value = "1" });
            testModel.SeqFileList.Add(new SelectListItem { Text = "Chemistry", Value = "2" });
            testModel.SeqFileList.Add(new SelectListItem { Text = "Mathematics", Value = "3" });

            return View(testModel);
        }
    }
}
