using System;
using System.Collections.Generic;
using System.Linq;
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
            int seqLength = multipleModel.Seq.Seq.Length;

            Cseq = multipleModel.Seq.Seq + multipleModel.Seq.Seq.Substring(0, 2);
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

           int result = dinuc1st.Count(di => di.Contains("aa"));
            int result1 = dinuc2nd.Count(di => di.Contains("aa"));
        }
    }
}
