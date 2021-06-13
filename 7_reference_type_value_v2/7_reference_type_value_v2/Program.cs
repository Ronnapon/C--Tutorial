﻿
using System;

namespace _7_reference_type_value_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number);
            // Show 1

            var person = new Person() { age = 20 };
            MakeOld(person);
            Console.WriteLine(person.age);
            // Shpw 30

        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.age += 10;
        }
    }

    public class Person
    {
        public int age;
    }
}
