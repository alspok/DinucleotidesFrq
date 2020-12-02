using System;
using DinucleotidesFrq.Models;
using System.Text.RegularExpressions;

namespace DinucleotidesFrq.Helpers
{
    public class Match
    {
        public void  MatchSeq(MultipleModel multipleModel)
        {
            if (!Regex.IsMatch(multipleModel.Seq.Seq, @"^[ACGTacgt]*$"))
                multipleModel.Seq.SeqMatch = false;
        }
    }
}
