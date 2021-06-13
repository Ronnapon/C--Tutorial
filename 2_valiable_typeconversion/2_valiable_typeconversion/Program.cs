using System;

namespace _2_valiable_typeconversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte b = 1;
            //int i = b;
            //Console.WriteLine(i);

            // convert int to byte
            int i = 1000;
            byte b = (byte) i;
            Console.WriteLine(b);

            // convert string to Number
            string number = "1234";
            int a = Convert.ToInt32(number);
            Console.WriteLine(i);

            // convert string to byte (cannot do it)
            try
            {
                string number1 = "1234";
                byte c = Convert.ToByte(number1);
                Console.WriteLine(c);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be convert to a byte");
            }


            // convert string to bool (can do it)
            try
            {
                string str = "true";
                bool d = Convert.ToBoolean(str);
                Console.WriteLine(d);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be convert to a byte");
            }
        }
    }
}


// CTR shift B  (Build)
