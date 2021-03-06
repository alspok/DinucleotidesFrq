﻿using System;
using System.Collections.Generic;
using System.Linq;
using DinucleotidesFrq.Models;

namespace DinucleotidesFrq.DinucCalculation
{
    public class DiCalc
    {
        public string Cseq { get; set; }

        public void Calc(SequenceModels sequenceModels)
        {
            List<string> dinuc1st = new List<string>();
            List<string> dinuc2nd = new List<string>();
            char[] nucArray;
            int seqLength = sequenceModels.Seq.SeqLength;

            Cseq = sequenceModels.Seq.Seq + sequenceModels.Seq.Seq.Substring(0, 2);
            nucArray = Cseq.ToCharArray();

            try
            {
                if (seqLength % 2 == 0)
                {
                    for (int i = 0; i < seqLength; i += 2)
                    {
                        dinuc1st.Add(nucArray[i].ToString() + nucArray[i + 1].ToString());
                        dinuc2nd.Add(nucArray[i + 1].ToString() + nucArray[i + 2].ToString());
                    }
                }
                else
                {
                    for (int i = 0; i < seqLength -1 ; i += 2)
                    {
                        dinuc1st.Add(nucArray[i].ToString() + nucArray[i + 1].ToString());
                        dinuc2nd.Add(nucArray[i + 1].ToString() + nucArray[i + 2].ToString());
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            foreach (var item in sequenceModels.Dinuc.Dinucs)
            {
                item.Dinuc1stFrame = dinuc1st.Count(di => di.Contains(item.Dinuc));
                item.Dinuc2ndFrame = dinuc2nd.Count(di => di.Contains(item.Dinuc));

                item.Dinuc1stFrameFrq = (double)decimal.Divide(item.Dinuc1stFrame, dinuc1st.Count);
                item.Dinuc2ndFrameFrq = (double)decimal.Divide(item.Dinuc2ndFrame, dinuc2nd.Count);

                item.DinucFrqDiff = Math.Abs(item.Dinuc1stFrameFrq - item.Dinuc2ndFrameFrq);

                sequenceModels.Dinuc.DinucDiffSum += item.DinucFrqDiff;
            }
        }
    }
}
