using System.Collections.Generic;
using System.Web.Mvc;
using DinucleotidesFrq.Models;

namespace DinucleotidesFrq.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Sequence sequence = new Sequence
            {
                Seq = "agacagacagacagatagatgtc",
                SeqName = "SomeSeq",
            };

            sequence.SeqLength = sequence.Seq.Length;

            SeqMatch seqMatch = new SeqMatch
            {
                Match = true
            };

            List<TestSequence> testSequence = new List<TestSequence>
            {
                new TestSequence { Seq = "aaacagatcacccgctgagcgggttatctgtt", SeqName = "All dinucs" },
                new TestSequence { Seq = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",  SeqName = "Mono dinucs"},
                new TestSequence { Seq = "agcgggctagtgcgtgagcgggctagtgcgtg", SeqName = "Odd seq length" },
                new TestSequence { Seq = "agcgggctagtgcgtgcagcgggctagtgcgtg", SeqName = "Even seq length" }
            };

            FileSequence fileSequence = new FileSequence
            {
                Seq = string.Empty,
                SeqName = string.Empty,
                SeqFileName = string.Empty
            };

            List<string> fSeqs = new List<string>
            {
                "Esherichia coli",
                "Lactococcus lactis"
            };

            SequenceModels sequenceModels = new SequenceModels
            {
                Seq = sequence,
                Match = seqMatch,
                TestSeq = testSequence,
                FSeqs = fSeqs,
                FileSeq = fileSequence
            };

            return View(sequenceModels);
        }
    }
}
