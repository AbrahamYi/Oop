using System;

namespace Bai_tập_3_Oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Person myPerson = new Person(); //he
            myPerson.Greet();
            Console.WriteLine();

            Student myStudent = new Student(); //she
            myStudent.SetAge(21);
            myStudent.Greet();
            myStudent.ShowAge();
            Console.WriteLine();
            
            Teacher myTeacher = new Teacher(); //Teacher
            myTeacher.SetAge(30000);
            myTeacher.ShowAge();
            myTeacher.Greet();
            myTeacher.Explain();
            Console.WriteLine();
        }
    }
}