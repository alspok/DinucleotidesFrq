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
                SeqName = "SomeSeq"
            };

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

            List<FileSequence> fileSequence = new List<FileSequence>
            {
                new FileSequence { Seq = string.Empty, SeqName = "Escherichia coli" },
                new FileSequence { Seq = string.Empty, SeqName = "Lactococcus lactis" }
            };

            SequenceModels sequenceModels = new SequenceModels
            {
                Seq = sequence,
                Match = seqMatch,
                TestSeq = testSequence,
                FileSeq = fileSequence
            };

            return View(sequenceModels);
        }
    }
}
