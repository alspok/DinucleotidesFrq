using System;
using System.Collections.Generic;

namespace DinucleotidesFrq.Models
{
    public class Dinucleotides
    {
        public string Dinuc { get; set; } = string.Empty;
        public int Dinuc1stFrame { get; set; } = 0;
        public int Dinuc2ndFrame { get; set; } = 0;
        public double Dinuc1stFrameFrq { get; set; } = 0;
        public double Dinuc2ndFrameFrq { get; set; } = 0;
        public double DinucFrqDiff { get; set; } = 0;
    }

    public class DinucList
    {
        public List<Dinucleotides> dinucleotides = new List<Dinucleotides>()
        {
            new Dinucleotides{ Dinuc = "aa" },
            new Dinucleotides{ Dinuc = "ac" },
            new Dinucleotides{ Dinuc = "ag" },
            new Dinucleotides{ Dinuc = "at" },

            new Dinucleotides{ Dinuc = "ca" },
            new Dinucleotides{ Dinuc = "cc" },
            new Dinucleotides{ Dinuc = "cg" },
            new Dinucleotides{ Dinuc = "ct" },

            new Dinucleotides{ Dinuc = "ga" },
            new Dinucleotides{ Dinuc = "gc" },
            new Dinucleotides{ Dinuc = "gg" },
            new Dinucleotides{ Dinuc = "gt" },

            new Dinucleotides{ Dinuc = "ta" },
            new Dinucleotides{ Dinuc = "tc" },
            new Dinucleotides{ Dinuc = "tg" },
            new Dinucleotides{ Dinuc = "tt" }
        };
    }
}
