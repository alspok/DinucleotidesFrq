using System;

namespace DinucleotidesFrq.Models
{
    public class Sequence
    {
        public string Seq { get; set; } = string.Empty;
        public int SeqLength { get; set; } = 0;
        public string TestSeq { get; set; } = "aaacagatcacccgctgagcgggttatctgtt";
        public string RandSeq { get; set; } = "tacttcgtgtgttgactctacggcgacaagcttagaggtagtttctctgcggtaaacacttcttggatattcgggcggtgggctagtgtcgccacaaaat";
    }
}
