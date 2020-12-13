using System;
using System.IO;
using DinucleotidesFrq.Models;

namespace DinucleotidesFrq.Helpers
{
    public class SequenceFile
    {
        public MultipleModel SeqFile(MultipleModel multipleModel)
        {
            string filePath = "Data/";
            string fileExt = ".fasta";
            string seqName = multipleModel.Names.SelectName;
            string seqLine = string.Empty;

            multipleModel.Seq.Seq = string.Empty;

            using (StreamReader stream = new StreamReader(filePath+seqName+fileExt))
            {
                while ((seqLine = stream.ReadLine()) != null)
                {
                    if (seqLine.Contains(">"))
                    {
                        continue;
                    }

                    multipleModel.Seq.Seq += seqLine.ToLower();
                }
            }

            multipleModel.Seq.SeqLength = multipleModel.Seq.Seq.Length;

            if (multipleModel.Seq.Seq.Length >= 400)
            {
                multipleModel.Seq.OutputSeq = multipleModel.Seq.Seq.Substring(0, 200) + "..." +
                    multipleModel.Seq.Seq.Substring(multipleModel.Seq.Seq.Length - 200);
            }
            else
            {
                multipleModel.Seq.OutputSeq = multipleModel.Seq.Seq;
            }

            return multipleModel;
        }
    }
}
