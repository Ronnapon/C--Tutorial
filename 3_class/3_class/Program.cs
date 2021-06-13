using _3_class.Match;
using System;

namespace _3_class
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "Ronnapon";
            john.LastName = "Prathombud";
            john.Introduce();

            int a = 5;
            int b = 6;
            var calculate = new Calculator();
            var result = calculate.Add(a, b);
            Console.WriteLine(result);

        }
    }
}

// Ctr + Tab Change File
// Calculatore() Create Object
// Click Person ALT+Enter   (Move Person to New Class)