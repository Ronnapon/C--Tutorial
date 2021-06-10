using System;

namespace _1_valiable
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "ronnapon";
            bool isWorking = true;
            var aaa = "test";
            const float Pi = 3.14f;  // cannot define valiable

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
        }
    }
}

// control F5  Run
// Keyworkd "cw"  >>>> Console.WriteLine
// You can use "var" instead all datatype
// CTR X Delete Line