using System;
using System.IO;
using DinucleotidesFrq.Models;

namespace DinucleotidesFrq.Helpers
{
    public class SequenceFile
    {
        public SequenceModels SeqFile(SequenceModels sequenceModels)
        {
            string filePath = "Data/";
            string seqLine = string.Empty;

            sequenceModels.Seq.Seq = string.Empty;

            using (StreamReader stream = new StreamReader(filePath))
            {
                while ((seqLine = stream.ReadLine()) != null)
                {
                    if (seqLine.Contains(">"))
                    {
                        continue;
                    }

                    sequenceModels.Seq.Seq += seqLine.ToLower();
                }
            }

            sequenceModels.Seq.SeqLength = sequenceModels.Seq.Seq.Length;

            if (sequenceModels.Seq.Seq.Length >= 400)
            {
                sequenceModels.OutputSeq.OutSeq = sequenceModels.Seq.Seq.Substring(0, 200) + "..." +
                    sequenceModels.Seq.Seq.Substring(sequenceModels.Seq.Seq.Length - 200);
            }
            else
            {
                sequenceModels.OutputSeq.OutSeq = sequenceModels.Seq.Seq;
            }

            return sequenceModels;
        }
    }
}
