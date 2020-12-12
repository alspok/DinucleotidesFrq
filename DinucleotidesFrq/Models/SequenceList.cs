using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace DinucleotidesFrq.Models
{
    public class SeqNames
    {
        public string SelectName { get; set; }
        public List<string> seqNames = new List<string>
        {
            "Escherichia.coli.6000",
            "L.lactis",
            "S.some"
        };
    }

    public class SequenceName
    {
        public List<SelectListItem> SequenceNames { get; set; }
    }
}