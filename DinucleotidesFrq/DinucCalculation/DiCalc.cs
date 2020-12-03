using System;
using System.Collections.Generic;
using DinucleotidesFrq.Models;

namespace DinucleotidesFrq.DinucCalculation
{
    public class DiCalc
    {
        public string Cseq { get; set; }

        public void Calc(MultipleModel multipleModel)
        {
            List<string> dinuc1st = new List<string>();
            List<string> dinuc2nd = new List<string>();
            char[] nucArray;
            int calcLenght = 0;

            Cseq = multipleModel.Seq.Seq + multipleModel.Seq.Seq.Substring(0, 1);
            nucArray = Cseq.ToCharArray();

            if (nucArray.Length % 2 == 0)
            {
                calcLenght = nucArray.Length - 1;
            }
            else
            {
                calcLenght = nucArray.Length - 3;
            }


            for (int i = 0; i < calcLenght; i += 2)
            {
                dinuc1st.Add ( nucArray[i].ToString() + nucArray[i + 1].ToString());
                dinuc2nd.Add(nucArray[i+1].ToString() + nucArray[i + 2].ToString());
            }


        }
    }
}
