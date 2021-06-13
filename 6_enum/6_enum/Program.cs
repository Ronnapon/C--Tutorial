using System;

namespace _6_enum
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisterAirail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine(method);
            // 3
            Console.WriteLine((int)method);


            // Express
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            // Express
            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
        }
    }
}
