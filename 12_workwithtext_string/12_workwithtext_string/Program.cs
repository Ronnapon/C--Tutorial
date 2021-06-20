using System;

namespace _12_workwithtext_string
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Ronnapon Prathombud ";

            // trim
            Console.WriteLine("Trim : '{0}'", fullName.Trim());

            // Upper
            Console.WriteLine("Upper : '{0}'", fullName.Trim().ToUpper());

            // Field
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(1, index);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            // Split
            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + fullName[0]);
            Console.WriteLine("LastName: " + fullName[1]);

            // replace
            fullName.Replace("Ron", "RonRon");
            fullName.Replace("o", "O");

            if (String.IsNullOrEmpty(fullName))
                Console.WriteLine("Invalid");
            else
                Console.WriteLine("Not Null");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine( price.ToString("C"));
        }
    }
}
