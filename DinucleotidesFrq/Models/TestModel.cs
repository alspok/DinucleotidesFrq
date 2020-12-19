using System;
using System.Collections.Generic;

namespace DinucleotidesFrq.Models
{
    public class TestModel
    {
        public class Sequence
        {
            public string Seq { get; set; }
            public int SeqLength { get; set; }
        }

        public List<Sequence> Sequences { get; set; } = new List<Sequence>
        {
            new Sequence{Seq = "aaaaaaaaaggt", SeqLength = 12 }
        };

        public class FileSequence
        {
            public string FileName;
            public string FileType;
        }

        public List<FileSequence> FileSequences { get; set; } = new List<FileSequence>
        {
            new FileSequence{ FileName = "SomeName", FileType = "SomeType" },
            new FileSequence{ FileName = "OtherName", FileType = "OtherType" }
        };

        public string SelectedFile { get; set; }
    }
}
