using System;
using System.IO;
using DinucleotidesFrq.Models;

namespace DinucleotidesFrq.Helpers
{
    public class SequenceFile
    {
        public void SeqFile(string seqName, MultipleModel multipleModel)
        {
            string filePath = "/ home / alvydas / Projects / DinucleotidesFrq / DinucleotidesFrq / Data";
            string fileExt = ".fasta";
            string seqLine = string.Empty;

            using (StreamReader stream = new StreamReader(filePath+seqName+fileExt))
            {
                while ((seqLine = stream.ReadLine()) != null)
                {
                    if (seqLine.Contains(">")) continue;
                    multipleModel.Seq.Seq += seqLine;
                }
            }
        }
    }
}
