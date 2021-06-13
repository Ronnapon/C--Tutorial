using System;

namespace _5_string
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            String firstName = "Ronnapon";
            string lastName = "Prathombud";

            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            var names = new string[3] { "big1", "big2", "big3" };
            // Combine Array
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            // Path
            var text = "Hi Big\nLook into the following\\floder\\floder2";
            Console.WriteLine(text);

            var text1 = @"Hi Big
Look into the following\floder\floder2";
            Console.WriteLine(text1);

        }
    }
}
