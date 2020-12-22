using System;
using DinucleotidesFrq.Models;
using System.Text.RegularExpressions;

namespace DinucleotidesFrq.Helpers
{
    public class Match
    {
        public void  MatchSeq(SequenceModels sequenceModels)
        {
            if (!Regex.IsMatch(sequenceModels.Seq.Seq, @"^[ACGTacgt]*$"))
                sequenceModels.Match.Match = false;
        }
    }
}
