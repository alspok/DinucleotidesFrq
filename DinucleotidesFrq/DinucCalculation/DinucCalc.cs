using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using DinucleotidesFrq.Models;

namespace DinucleotidesFrq.DinucCalculation
{
    public class DinucCalc
    {
        public void Calculation(MultipleModel multipleModel)
        {
            string cseq = multipleModel.Seq.Seq + multipleModel.Seq.Seq.Substring(0, 1);
            int dinucCount = 0;

            if (cseq.Length % 2 == 0)
            {
                dinucCount = cseq.Length / 2;
            }
            else
            {
                dinucCount = (cseq.Length - 1) / 2;
            }

            foreach (var item in multipleModel.Dinuc.dinucleotides)
            {
                List<int> index = new List<int>();
                int pos = -1;
                int count = 0;

                while ((pos = cseq.IndexOf(item.Dinuc, pos + 1, StringComparison.Ordinal)) != -1)
                {
                    index.Add(pos);
                    count++;
                }

                foreach (var item1 in index)
                {
                    if (item1 % 2 == 0)
                    {
                        item.Dinuc1stFrame++;
                    }
                    else
                    {
                        item.Dinuc2ndFrame++;
                    }
                }
                item.Dinuc1stFrameFrq = (double)decimal.Divide(item.Dinuc1stFrame, dinucCount);
                item.Dinuc2ndFrameFrq = (double)decimal.Divide(item.Dinuc2ndFrame, dinucCount);
                item.DinucFrqDiff = Math.Abs( item.Dinuc1stFrameFrq - item.Dinuc2ndFrameFrq);

                foreach (var item2 in multipleModel.Dinuc.dinucleotides)
                {
                    multipleModel.DinucFrqDiffSum += item2.DinucFrqDiff;
                }
            }
        }
    }
}
