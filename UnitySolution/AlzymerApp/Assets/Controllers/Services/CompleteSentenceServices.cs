using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Controllers.Services
{
    public class CompleteSentenceServices
    {
        public static List<string> Sentences
        {
            get
            {
                List<string> lstSentences = new List<string>();
                lstSentences.Add(@"All's well that ends well.");
                lstSentences.Add(@"Work hard and dream big.");
                lstSentences.Add(@"Life's too short to wait.");
                lstSentences.Add(@"Lets make today ridiculously amazing.");
                lstSentences.Add(@"Not every person really lives.");
                lstSentences.Add(@"Smile and make others smile.");
                lstSentences.Add(@"Happiness lies deep within your heart.");
                return lstSentences;
            }
        }
    }
}
