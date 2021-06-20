using System;
using System.Collections.Generic;

namespace _13_summarizingtext
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "test is going to be really really really really really really long long long";
            Console.WriteLine(StringUtility.SummarizeText(sentence, 25));
        }
    }
}
