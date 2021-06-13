using System;

namespace _3_class
{
    // Calss Person
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
}


// Click Person   ALT+Enter   (Move Person to New Class)