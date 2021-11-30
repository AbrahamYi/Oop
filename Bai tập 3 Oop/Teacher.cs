using System;

namespace Bai_tập_3_Oop
{
    public class Teacher: Person

    {
        public void Explain()
        {
            Console.WriteLine("I'm explaiining");
        }
        
        public void ShowAge()
        {
            Console.WriteLine("My age is {0} years old", age);
        }
    }
}