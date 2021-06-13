using System;

namespace _9_random_class
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------------------------
            var random = new Random();
            for (var e = 0; e < 10; e++)
            {
                Console.WriteLine((char)('a' + random.Next(1, 10)));
            }

            // asci
            Console.WriteLine((int)'a');
            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (var g = 0; g < passwordLength; g++)
            {
                buffer[g] = (char)('a' + random.Next(1, 10));
            }
            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}
