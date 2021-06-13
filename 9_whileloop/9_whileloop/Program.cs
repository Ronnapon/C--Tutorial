using System;

namespace _9_whileloop
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            while (i <= 10)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
                i++;
            }

            while (true)
            {
                Console.WriteLine("Type your name ");
                var input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                break;
            }
        }
    }
}
