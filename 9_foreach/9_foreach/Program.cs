using System;

namespace _9_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------------------
            // user with Array List
            var name = new string[3] { "big1", "big2", "big3" };
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            var number = new int[3] { 1, 2, 3 };
            foreach (int result in number)
            {
                Console.WriteLine(result);
            }

        }   //--------------------------------------------------
    }
}
