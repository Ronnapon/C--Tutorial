using System;

namespace _15_procedural_programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            var name = Console.ReadLine();
            var reverse = ReverseName(name);
            Console.WriteLine(reverse);
        }

        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            return new string(array);
        }
    }
}
