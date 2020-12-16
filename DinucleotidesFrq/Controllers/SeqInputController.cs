using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DinucleotidesFrq.Models;
using DinucleotidesFrq.Helpers;

namespace DinucleotidesFrq.Controllers
{
    public class SeqInputController : Controller
    {
        public ActionResult SeqIn(SequenceModels sequenceModels, string  choose)
        {
            switch(choose)
            {
                case "add-test":
                    sequenceModels.TestSeq.TSeq = sequenceModels.TestSeq.TSeq;
                    break;
                case "make-random":
                    RandomSeq randomSeq = new RandomSeq();
                    sequenceModels.Seq.Seq = randomSeq.RandSeq();
                    break;
                case "add-random":
                    sequenceModels.Seq.Seq = sequenceModels.RandomSeq.Seq;
                    break;
                case "add-from-list":
                    SequenceFile sequenceFile = new SequenceFile();
                    sequenceFile.SeqFile(sequenceModels);
                    break; 
            }

            return View ("~/Views/Home/Index.cshtml", sequenceModels);
        }
    }
}
