using System;

namespace Inheritance_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is My Inheritance Test.\n");

            Book book1 = new Book();
            book1.SetAuthor("Smith");
            book1.SetTitle("A Great Book");

            System.Console.WriteLine(book1.GetBookInfo());

            PictureBook book2 = new PictureBook();
            book2.SetAuthor("Jones");
            book2.SetTitle("A Wonderful Picture Book");
            book2.SetIllustrator("Romão");

            System.Console.WriteLine(book2.GetBookInfo());
            System.Console.WriteLine(book2.GetPictureBookInfo());

            Book book3 = new Book("Edward", "Ahother Book");
            System.Console.WriteLine(book3.GetBookInfo());

            PictureBook book4 = new PictureBook();
            System.Console.WriteLine(book4.GetBookInfo());
        }
    }

}
