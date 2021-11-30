using System;

namespace Bai_tập_3_Oop
{
    public class Student : Person
    {
        public void study()
        {
            Console.WriteLine("I'm studying");
        }

        public void ShowAge()
        {
            Console.WriteLine("My age is {0} years old", age);
        }
    }
}