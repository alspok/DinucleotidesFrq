﻿using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace DinucleotidesFrq.Models
{

    public class SequenceModels
    {
        public Sequence Seq { get; set; }
        public List<TestSequence> TestSeq {get;set;}
        public TestSequence SelectedTestSeq { get; set; }
        public RandomSequence RandomSeq { get; set; }
        public FileSequence FileSeq { get; set; }
        public List<string> FSeqs { get; set; }
        public GBSequence GBSeq { get; set; }
        public OutputSequence OutputSeq { get; set; }
        public Dinucleotides Dinuc { get; set; }
        public SeqMatch Match{ get; set; }
    }

    public class SeqMatch
    {
        public bool Match { get; set; }
    }

    public class Sequence
    {
        public string Seq { get; set; }
        public string SeqName { get; set; }
        public int SeqLength { get; set; }
    }

    public class TestSequence
    {
        public string Seq { get; set; }
        public string SeqName { get; set; }
    }

    public class RandomSequence
    {
        public string Seq { get; set; }
        public string SeqName { get; set; }
    }

    public class FileSequence
    {
        public string Seq { get; set; }
        public string SeqName { get; set; }
        public string SeqFileName { get; set; }
    }

    public class FileSeq
    {
        public string SeqFileName { get; set; }
     }

    public class GBSequence
    {
        public string Seq { get; set; }
        public string SeqName { get; set; }
    }

    public class OutputSequence
    {
        public string OutSeq  { get; set;}
    }

    public class Dinucleotides
    {
        public class Dinucleo
        {
            public string Dinuc { get; set; } = string.Empty;
            public int Dinuc1stFrame { get; set; } = 0;
            public int Dinuc2ndFrame { get; set; } = 0;
            public double Dinuc1stFrameFrq { get; set; } = 0;
            public double Dinuc2ndFrameFrq { get; set; } = 0;
            public double DinucFrqDiff { get; set; } = 0;
        }

        public List<Dinucleo> Dinucs { get; set; } = new List<Dinucleo>
        {
            new Dinucleo { Dinuc = "aa" },
            new Dinucleo { Dinuc = "ac" },
            new Dinucleo { Dinuc = "ag" },
            new Dinucleo { Dinuc = "at" },

            new Dinucleo { Dinuc = "ca" },
            new Dinucleo { Dinuc = "cc" },
            new Dinucleo { Dinuc = "cg" },
            new Dinucleo { Dinuc = "ct" },

            new Dinucleo { Dinuc = "ga" },
            new Dinucleo { Dinuc = "gc" },
            new Dinucleo { Dinuc = "gg" },
            new Dinucleo { Dinuc = "gt" },

            new Dinucleo { Dinuc = "ta" },
            new Dinucleo { Dinuc = "tc" },
            new Dinucleo { Dinuc = "tg" },
            new Dinucleo { Dinuc = "tt" }
        };

        public double DinucDiffSum { get; set; }
    }
}
