using System;

namespace _11_timespan
{
    class Program
    {
        static void Main(string[] args)
        {
            // createing
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("duration>>" + duration);

            // Properties
            Console.WriteLine("Minute: "+ timeSpan.Minutes);
            Console.WriteLine("Total Minute: "+ timeSpan.TotalMinutes);

            // Add
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example: " + timeSpan.Add(TimeSpan.FromMinutes(2)));

            // Tostring
            Console.WriteLine("ToString: " + timeSpan.ToString());

            // Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
