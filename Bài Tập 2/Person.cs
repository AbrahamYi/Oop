using System;

namespace Bài_Tập_2 // Ghi đè
{
    public class Person
    {
        public string Name { get; set; } // hỏi anh Trí

        public Person(string name)  // hỏi anh Trí
        {
            Name = name;
        }

        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }

        // Person()
        // {
        //     Name = String.Empty;
        // }
    }
}