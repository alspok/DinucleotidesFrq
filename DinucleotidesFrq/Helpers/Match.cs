using System;
using System.Text.RegularExpressions;

namespace DinucleotidesFrq.Helpers
{
    public class Match
    {
        public bool MatchSeq(string seq)
        {
            return Regex.IsMatch(seq, @"^[a-zA-Z0-9]*$");
        }
    }
}
