using System;
namespace DinucleotidesFrq.Models
{

    public class SequenceModels
    {
        public TestSequenceModel TestSeq {get;set;}
        public RandomSequenceModel RandomSeq { get; set; }
        public SelectSequenceModel SelectSeq { get; set; }
        public GBSequenceModel GBSeq { get; set; }
    }

    public class TestSequenceModel
    {
        public string Seq { get; set; }
        public string SeqNames { get; set; }
        public int SeqLength { get; set; }
    }

    public class RandomSequenceModel
    {
        public string Seq { get; set; }
        public string SeqNames { get; set; }
        public int SeqLength { get; set; }
    }

    public class SelectSequenceModel
    {
        public string Seq { get; set; }
        public string SeqNames { get; set; }
        public int SeqLength { get; set; }
    }

    public class GBSequenceModel
    {
        public string Seq { get; set; }
        public string SeqNames { get; set; }
        public int SeqLength { get; set; }
    }
}
