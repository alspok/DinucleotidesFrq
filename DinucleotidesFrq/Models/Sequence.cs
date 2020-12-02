using System;

namespace DinucleotidesFrq.Models
{
    public class Sequence
    {
        public string Seq { get; set; } = "cacagatttgataggcagtgacagatggacagaaagatagagaaag";
        public int SeqLength { get; set; } = 0;
        public bool SeqMatch { get; set; } = true;
        public string TestSeq { get; set; } = "aaacagatcacccgctgagcgggttatctgtt";
        public string RandSeq { get; set; } = "tacttcgtgtgttgactctacggcgacaagcttagaggtagtttctctgcggtaaacacttcttggatattcgggcggtgggctagtgtcgccacaaaat";
    }
}
