using System;
using System.Linq;

namespace DinucleotidesFrq.Helpers
{
    public class RandomSeq
    {
        public string RandSeq()
        {
            string nucs = "acgt";
            int randSeqLength = 100;

            Random random = new Random();

            var randSeq = new string(Enumerable.Repeat(nucs, randSeqLength).Select(s => s[random.Next(s.Length)]).ToArray());

            return randSeq;
        }
    }
}
