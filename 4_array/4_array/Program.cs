using System;

namespace _4_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[3];
            var numbers = new int[3];
            numbers[0] = 1;
            // If not assign defult 0
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;
            // If not assign defult false
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] {"big1","big2","big3"};
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
        }
    }
}

// If not assign defult 0
