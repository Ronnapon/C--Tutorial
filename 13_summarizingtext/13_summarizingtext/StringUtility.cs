using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_summarizingtext
{
    class StringUtility
    {
        public static string SummarizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
            {
                return text;
            }
            else
            {
                //sentence.Substring(0, maxLength);
                var words = text.Split(' ');
                var totalCharacers = 0;
                var summaryWrods = new List<string>();

                foreach (var word in words)
                {
                    summaryWrods.Add(word);
                    totalCharacers += word.Length + 1;
                    if (totalCharacers > maxLength)
                        break;
                }
                var summary = String.Join(" ", summaryWrods) + "......";
                return summary;
            }
        }
    }
}
