using System;
using System.Collections.Generic;

namespace _10_list
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 }); // If See IEnumable canuse array or list

            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Index of" + numbers.IndexOf(2));
            Console.WriteLine("LastIndex of" + numbers.LastIndexOf(7));
            Console.WriteLine("Count "+ numbers.Count);


            Console.WriteLine("Remove number 1");
            for (int i = 0; i < numbers.Count ; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Clear>>>>>");
            numbers.Clear();
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
