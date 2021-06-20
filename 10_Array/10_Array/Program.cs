using System;

namespace _10_Array
{
    class Program
    {

        // C# Array name of method
        static void Main(string[] args)
        {
            var number = new[] { 1, 2, 3, 4, 5, 6 };

            // Length
            Console.WriteLine("Length " + number.Length);

            // IndexOf()
            var indexArray = Array.IndexOf(number, 1);
            Console.WriteLine(indexArray);

            // Clear()
            Array.Clear(number, 0, 2);


            Console.WriteLine("------------------");
            foreach(int result in number)
            {
                Console.WriteLine(result);
            }

            // Copy()
            Console.WriteLine("Copy------------------");
            var anouther = new int[3] { 5, 6, 1 };
            Array.Copy(number, anouther, 2);
            foreach (int result in anouther)
            {
                Console.WriteLine(result);
            }

            Console.WriteLine("Sort------------------");
            // Sort()
            Array.Sort(number);
            foreach (int result in number)
            {
                Console.WriteLine(result);
            }

            // Reverse
            Console.WriteLine("Reverse------------------");
            Array.Reverse(number);
            foreach (int result in number)
            {
                Console.WriteLine(result);
            }
        }
    }
}
