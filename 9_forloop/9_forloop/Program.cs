using System;

namespace _9_forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var a = 1; a <= 10; a++)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine(a);
                }
            }

            for (var b = 10; b >= 1; b--)
            {
                if (b % 2 == 0)
                {
                    Console.WriteLine(b);
                }
            }

            // Same
            var name = "Ronnapon";
            for (var c = 0; c < name.Length; c++)
            {
                Console.WriteLine(name[c]);
            }
        }
    }
}
