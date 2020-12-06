﻿using System;
namespace DinucleotidesFrq.Models
{
    public class MultipleModel
    {
        public Sequence Seq { get; set; } = new Sequence();
        public DinucList Dinuc { get; set; } = new DinucList();
        public double DinucFrqDiffSum { get; set; } = 0;
        public SequenceName SeqNames {get;set;} = new SequenceName();
    }
}
