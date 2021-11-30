using System;
using System.Reflection.Metadata;

namespace Bài_tập_Oop
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 3;
            Person[] persons = new Person[total];

            for (int i = 0; i < total; i++)
            {
                persons[i] = new Person()
                {
                    Name = Console.ReadLine()
                };
            }

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(persons[i].ToString()); // vi so toStrinng
            }

            Console.ReadLine();
        }

    }
}