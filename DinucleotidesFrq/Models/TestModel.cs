using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web.Mvc;

namespace DinucleotidesFrq.Models
{
    public class TestModel
    {
        public TestModel()
        {
            SeqList = new List<SelectList>();
            SeqFileList = new List<SelectListItem>();
        }

        public string Seq { get; set; } = "gagagacagatagtagcatgac";

        public List<SelectList> SeqList { get; set; }
        public List<SelectListItem> SeqFileList { get; set; }
    }
}
