﻿using System;
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
        public ActionResult SeqIn(MultipleModel multipleModel, string  choose)
        {
            switch(choose)
            {
                case "add-test":
                    multipleModel.Seq.Seq = multipleModel.Seq.TestSeq;
                    break;
                case "make-random":
                    RandomSeq randomSeq = new RandomSeq();
                    multipleModel.Seq.Seq = randomSeq.RandSeq();
                    break;
                case "add-random":
                    multipleModel.Seq.Seq = multipleModel.Seq.RandSeq;
                    break;
                case "add-from-list":
                    SequenceFile sequenceFile = new SequenceFile();
                    sequenceFile.SeqFile(multipleModel.Names.SelectName);
                    break; 
            }

            return View ("~/Views/Home/Index.cshtml", multipleModel);
        }
    }
}
