﻿using System;
namespace DinucleotidesFrq.Models
{
    public class MultipleModel
    {
        public Sequence Seq { get; set; } = new Sequence();
        public DinucList Dinuc { get; set; } = new DinucList();
    }
}