using System;
using System.Collections.Generic;

namespace DinucleotidesFrq.Models
{

    public class SequenceModels
    {
        public InputSequence InputSeq { get; set; }
        public TestSequence TestSeq {get;set;}
        public RandomSequence RandomSeq { get; set; }
        public SelectSequence SelectSeq { get; set; }
        public GBSequence GBSeq { get; set; }
    }

    public class InputSequence
    {
        public string Seq { get; set; }
        public string SeqName { get; set; }
        public int SeqLength { get; set; }
    }

    public class TestSequence
    {
        public class TestSeq
        {
            public string Seq { get; set; }
            public string SeqName { get; set; }
            public int SeqLength { get; set; }
        }

        public List<TestSeq> TSeq { get; set; } = new List<TestSeq>
        {
            new TestSeq { Seq = "aaacagatcacccgctgagcgggttatctgtt", SeqName = "some", SeqLength = 32 },
            new TestSeq { Seq = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", SeqName = "", SeqLength = 32 },
            new TestSeq { Seq = "agcgggctagtgcgtgagcgggctagtgcgtg", SeqName = "", SeqLength = 32},
            new TestSeq { Seq = "agcgggctagtgcgtgcagcgggctagtgcgtg", SeqName = "", SeqLength = 33}
        };
    }

    public class RandomSequence
    {
        public string Seq { get; set; }
        public string SeqName { get; set; }
        public int SeqLength { get; set; }
    }

    public class SelectSequence
    {
        public string Seq { get; set; }
        public List<string> SeqName { get; set; } = new List<string>
        {
            "Escherichia coli",
            "Lactococcus lactis",
            "Someone some"
        };
        public int SeqLength { get; set; }
    }

    public class GBSequence
    {
        public string Seq { get; set; }
        public string SeqName { get; set; }
        public int SeqLength { get; set; }
    }
}
