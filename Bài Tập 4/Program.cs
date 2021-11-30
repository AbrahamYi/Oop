using System;

namespace Bài_Tập_4
{
    class Program
    {
        static void Main(string[] args)
        {
            PhotoBook A1 = new PhotoBook(); // không nhập mặc định là 16
            Console.WriteLine(A1.GetNumberPages());

            PhotoBook A2 = new PhotoBook(24);
            Console.WriteLine(A2.GetNumberPages()); // nếu điền số vào numpage thì sẽ in ra không trở lại về mặc định

            SuperPhotorBook A3 = new SuperPhotorBook();
            Console.WriteLine(A3.GetNumberPages());
        }
    }
}